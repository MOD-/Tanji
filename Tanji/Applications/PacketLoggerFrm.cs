using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Sulakore.Protocol;
using Sulakore.Communication;

namespace Tanji.Applications
{
    public partial class PacketLoggerFrm : Form
    {
        private Task _readQueueTask;

        private readonly WriteHighlightCallback _writeHighlight;
        private delegate void WriteHighlightCallback(string value, Color highlight);

        private readonly WriteCallback _write;
        private delegate void WriteCallback(InterceptedEventArgs e);

        public MainFrm MainUI { get; }
        public bool IsHalted { get; private set; }
        public Queue<InterceptedEventArgs> Intercepted { get; }

        public Color BlockHighlight { get; set; } = Color.FromArgb(105, 105, 105);
        public Color ReplaceHighlight { get; set; } = Color.FromArgb(0, 139, 139);
        public Color IncomingHighlight { get; set; } = Color.FromArgb(178, 34, 34);
        public Color OutgoingHighlight { get; set; } = Color.FromArgb(0, 102, 204);
        public Color PacketStructHighlight { get; set; } = Color.FromArgb(0, 204, 136);

        public bool ViewOutgoing { get; private set; } = true;
        public bool ViewIncoming { get; private set; } = true;

        public bool DisplayBlocked { get; private set; } = true;
        public bool DisplayReplaced { get; private set; } = true;
        public bool DisplaySplitter { get; private set; } = true;
        public bool DisplayPacketStructure { get; private set; } = false;

        public PacketLoggerFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;

            _write = Write;
            _writeHighlight = WriteHighlight;
            Intercepted = new Queue<InterceptedEventArgs>();

            MainUI.Connection.DataIncoming += DataIncoming;
            MainUI.Connection.DataOutgoing += DataOutgoing;
        }

        protected override void OnLoad(EventArgs e)
        {
            _readQueueTask = Task.Factory.StartNew(
                RunDisplayQueueLoop, TaskCreationOptions.LongRunning);

            base.OnLoad(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            IsHalted = false;
            base.OnActivated(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = IsHalted = true;
            Intercepted.Clear();

            LoggerTxt.Clear();
            base.OnFormClosing(e);

            WindowState = FormWindowState.Minimized;
        }

        private void ItemChecked(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            bool isChecked = item.Checked;

            switch (item.Name)
            {
                case nameof(ViewIncomingBtn):
                {
                    CaptureIncomingLbl.Text = "Capture Incoming: " + isChecked;
                    ViewIncoming = isChecked;
                    break;
                }
                case nameof(ViewOutgoingBtn):
                {
                    CaptureOutgoingLbl.Text = "Capture Outgoing: " + isChecked;
                    ViewOutgoing = isChecked;
                    break;
                }

                case nameof(DisplayPacketStructureBtn):
                DisplayPacketStructure = isChecked;
                break;

                case nameof(BlockedBtn):
                DisplayBlocked = isChecked;
                break;

                case nameof(ReplacedBtn):
                DisplayReplaced = isChecked;
                break;

                case nameof(DisplaySplitterBtn):
                DisplaySplitter = isChecked;
                break;

                case nameof(AlwaysOnTopBtn):
                TopMost = isChecked;
                break;
            }
        }
        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoggerTxt.SelectedText))
                Clipboard.SetText(LoggerTxt.SelectedText);
        }
        private void EmptyLogBtn_Click(object sender, EventArgs e)
        {
            LoggerTxt.Clear();
        }

        private void DataIncoming(object sender, InterceptedEventArgs e)
        {
            if (!IsHalted && ViewIncoming)
                PushToQueue(e);
        }
        private void DataOutgoing(object sender, InterceptedEventArgs e)
        {
            if (!IsHalted && ViewOutgoing)
                PushToQueue(e);
        }

        private void RunDisplayQueueLoop()
        {
            if (Monitor.TryEnter(Intercepted))
            {
                try
                {
                    while (Intercepted.Count > 0)
                    {
                        InterceptedEventArgs args = Intercepted.Dequeue();
                        bool toServer = (args.Packet.Destination == HDestination.Server);

                        if (args.IsBlocked && !DisplayBlocked) continue;
                        if (toServer && !ViewOutgoing) continue;
                        if (!toServer && !ViewIncoming) continue;

                        string packetLog = ExtractPacketLog(args.Replacement, toServer);
                        Color packetLogHighlight = (toServer ? OutgoingHighlight : IncomingHighlight);

                        if (args.IsBlocked) WriteHighlight("Blocked ", BlockHighlight);
                        else if (args.WasReplaced) WriteHighlight("Replaced ", ReplaceHighlight);

                        WriteHighlight(packetLog + "\r\n", packetLogHighlight);

                        if (DisplaySplitter)
                            WriteHighlight("--------------------\r\n", packetLogHighlight);
                    }
                }
                finally { Monitor.Exit(Intercepted); }
            }
        }
        private void PushToQueue(InterceptedEventArgs e)
        {
            Intercepted.Enqueue(e);
            if (_readQueueTask != null && _readQueueTask.IsCompleted)
            {
                _readQueueTask = Task.Factory.StartNew(
                    RunDisplayQueueLoop, TaskCreationOptions.LongRunning);
            }
        }

        public string ExtractPacketLog(HMessage packet, bool toServer)
        {
            string arrow = (toServer ? "->" : "<-");
            string type = (toServer ? "Outgoing" : "Incoming");
            return $"{type}({packet.Header}, {packet.Length}) {arrow} {packet}";
        }
        public string ExtractStructureLog(HMessage packet, bool toServer)
        {
            return string.Empty;
        }

        public void Write(InterceptedEventArgs e)
        {
            if (InvokeRequired) Invoke(_write, e);
            else
            {
                bool toServer = (e.Packet.Destination == HDestination.Server);

                string directionArrow = (toServer ? "->" : "<-");
                string packetType = (toServer ? "Outgoing" : "Incoming");
                string dataLog = $"{packetType}({e.Replacement.Header}, {e.Replacement.Length}) {directionArrow} {e.Replacement}";

                Color highlight = toServer ?
                    OutgoingHighlight : IncomingHighlight;

                if (e.IsBlocked) WriteHighlight("Blocked | ", BlockHighlight);
                else if (e.WasReplaced) WriteHighlight("Replaced | ", ReplaceHighlight);
                WriteHighlight(dataLog, highlight);

                if (toServer && DisplayPacketStructure)
                {
                    Tuple<string, string[]> outgoingItems = MainUI.OutStructs[e.Packet.Header];
                    string[] structure = outgoingItems.Item2;

                    if (!structure.Contains("array"))
                    {
                        e.Packet.Position = 0;
                        string packetInfo = $"\r\n{{l}}{{u:{e.Packet.Header}}}";
                        try
                        {
                            foreach (string valueType in structure)
                            {
                                if (string.IsNullOrWhiteSpace(packetInfo)) break;
                                packetInfo += "{" + valueType[0] + ":";

                                switch (valueType)
                                {
                                    case "int":
                                    packetInfo += e.Packet.ReadInteger();
                                    break;

                                    case "string":
                                    packetInfo += e.Packet.ReadString();
                                    break;

                                    case "boolean":
                                    packetInfo += e.Packet.ReadBoolean().ToString();
                                    break;

                                    default:
                                    packetInfo = string.Empty;
                                    break;
                                }

                                if (!string.IsNullOrWhiteSpace(packetInfo))
                                    packetInfo += "}";
                            }
                        }
                        catch { packetInfo = "\r\nDeconstruction Failed."; }
                        finally
                        {
                            if (!string.IsNullOrWhiteSpace(packetInfo))
                                WriteHighlight(packetInfo + " | " + outgoingItems.Item1, PacketStructHighlight);

                            e.Packet.Position = 0;
                        }
                    }
                }

                string splitter = (DisplaySplitter ? "\r\n--------------------\r\n" : "\r\n");
                WriteHighlight(splitter, highlight);

                LoggerTxt.SelectionStart = LoggerTxt.TextLength;
                LoggerTxt.ScrollToCaret();
                Application.DoEvents();
            }
        }
        public void WriteHighlight(string value, Color highlight)
        {
            if (InvokeRequired) Invoke(_writeHighlight, value, highlight);
            else
            {
                LoggerTxt.SelectionStart = LoggerTxt.TextLength;
                LoggerTxt.SelectionLength = 0;
                LoggerTxt.SelectionColor = highlight;
                LoggerTxt.AppendText(value);
            }
        }
    }
}