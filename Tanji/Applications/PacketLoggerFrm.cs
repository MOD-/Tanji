using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Sulakore.Protocol;
using Sulakore.Communication;

using FlashInspect.ActionScript;

namespace Tanji.Applications
{
    public partial class PacketLoggerFrm : Form
    {
        private Task _readQueueTask;
        private readonly IDictionary<HDestination, IList<ushort>> _invalidStructures;

        private readonly RefreshLogCallback _refreshLog;
        private delegate void RefreshLogCallback();

        private readonly WriteHighlightCallback _writeHighlight;
        private delegate void WriteHighlightCallback(string value, Color highlight);

        public MainFrm MainUI { get; }
        public bool IsHalted { get; private set; }
        public Queue<InterceptedEventArgs> Intercepted { get; }

        public Color BlockHighlight { get; set; } = Color.DarkGray;
        public Color ReplaceHighlight { get; set; } = Color.DarkCyan;
        public Color IncomingHighlight { get; set; } = Color.FromArgb(178, 34, 34);
        public Color OutgoingHighlight { get; set; } = Color.FromArgb(0, 102, 204);
        public Color PacketStructHighlight { get; set; } = Color.FromArgb(0, 204, 136);

        public bool ViewOutgoing { get; private set; } = true;
        public bool ViewIncoming { get; private set; } = true;

        public bool DisplayBlocked { get; private set; } = true;
        public bool DisplayReplaced { get; private set; } = true;
        public bool DisplaySplitter { get; private set; } = true;
        public bool DisplayStructures { get; private set; } = true;

        public PacketLoggerFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;

            Intercepted = new Queue<InterceptedEventArgs>();

            _refreshLog = RefreshLog;
            _writeHighlight = WriteHighlight;

            _invalidStructures = new Dictionary<HDestination, IList<ushort>>(2);
            _invalidStructures[HDestination.Client] = new List<ushort>();
            _invalidStructures[HDestination.Server] = new List<ushort>();

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

                case nameof(DisplayStructuresBtn):
                DisplayStructures = isChecked;
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
                {
                    TopMost = isChecked;

                    Text = "Tanji ~ PacketLogger" +
                        (TopMost ? " | TopMost" : string.Empty);

                    break;
                }
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

        private void RefreshLog()
        {
            if (InvokeRequired) Invoke(_refreshLog);
            else
            {
                LoggerTxt.SelectionStart = LoggerTxt.TextLength;
                LoggerTxt.ScrollToCaret();
            }
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
                        if (args.IsBlocked || args.WasReplaced) WriteHighlight("| ", Color.White);

                        WriteHighlight(packetLog + "\r\n", packetLogHighlight);
                        if (DisplayStructures)
                        {
                            string structureLog = ExtractStructureLog(args.Replacement, toServer);

                            if (!string.IsNullOrWhiteSpace(structureLog))
                                WriteHighlight(structureLog + "\r\n", PacketStructHighlight);
                        }

                        if (args.Executions.Count > 0)
                        {
                            WriteHighlight("\r\n", BackColor);
                            for (int i = 0; i < args.Executions.Count; i++)
                            {
                                HMessage packet = args.Executions[i];
                                WriteHighlight(ExtractPacketLog(packet, toServer) + "\r\n", packetLogHighlight);
                            }
                        }

                        if (DisplaySplitter)
                            WriteHighlight("--------------------\r\n", packetLogHighlight);

                        RefreshLog();
                    }
                }
                finally
                {
                    Monitor.Exit(Intercepted);
                    Application.DoEvents();
                }
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
        public string ExtractPacketLog(HMessage packet, bool toServer)
        {
            ASInstance messageInstance = (toServer ?
                MainUI.Game.OutgoingTypes : MainUI.Game.IncomingTypes)[packet.Header];

            string arrow = (toServer ? "->" : "<-");
            string type = (toServer ? "Outgoing" : "Incoming");
            return $"{type}({packet.Header}, {packet.Length}, {messageInstance.Name.ObjName}) {arrow} {packet}";
        }
        public string ExtractStructureLog(HMessage packet, bool toServer)
        {
            // Incoming structure support MAY come, when it does remove 'toServer' condition.
            if (!toServer || _invalidStructures[packet.Destination]
                .Contains(packet.Header))
            {
                return string.Empty;
            }

            ASInstance messageInstance = (toServer ?
                MainUI.Game.OutgoingTypes : MainUI.Game.IncomingTypes)[packet.Header];

            string arguments = $"{{l}}{{u:{packet.Header}}}";
            ASMethod messageCtor = messageInstance.Constructor;
            foreach (ASParameter param in messageCtor.Parameters)
            {
                try
                {
                    arguments += "{";
                    switch (param.Type.ObjName.ToLower())
                    {
                        default:
                        return string.Empty;

                        case "string":
                        arguments += "s:" + packet.ReadString();
                        break;

                        case "int":
                        arguments += "i:" + packet.ReadInteger();
                        break;

                        case "boolean":
                        arguments += "b:" + packet.ReadBoolean();
                        break;
                    }
                    arguments += "}";
                }
                catch
                {
                    _invalidStructures[packet.Destination]
                        .Add(packet.Header);
                }
            }

            if (packet.Readable != 0)
                arguments = string.Empty;

            packet.Position = 0;
            return arguments;
        }
    }
}