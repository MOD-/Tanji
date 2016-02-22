using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Tanji.Pages;
using Tanji.Components;

using Sulakore.Protocol;
using Sulakore.Communication;
using Sulakore.Disassembler.ActionScript;

namespace Tanji.Applications
{
    public partial class PacketLoggerFrm : TanjiForm, IDataHandler
    {
        private Task _readQueueTask;

        private readonly Action _refreshLog;
        private readonly Action<string, Color> _writeHighlight;
        private readonly IDictionary<HDestination, IList<ushort>> _invalidStructures;

        public MainFrm MainUI { get; }
        public Queue<InterceptedEventArgs> Intercepted { get; }

        public Color BlockHighlight { get; set; } = Color.DarkGray;
        public Color ReplaceHighlight { get; set; } = Color.DarkCyan;
        public Color IncomingHighlight { get; set; } = Color.FromArgb(178, 34, 34);
        public Color OutgoingHighlight { get; set; } = Color.FromArgb(0, 102, 204);
        public Color PacketStructHighlight { get; set; } = Color.FromArgb(0, 204, 136);

        public bool IsHalted { get; private set; } = false;
        public bool IsHandlingOutgoing { get; private set; } = true;
        public bool IsHandlingIncoming { get; private set; } = true;

        public bool DisplayBlocked { get; private set; } = true;
        public bool DisplayReplaced { get; private set; } = true;
        public bool DisplayStructures { get; private set; } = true;

        public PacketLoggerFrm(MainFrm mainUI)
        {
            InitializeComponent();

            _refreshLog = RefreshLog;
            _writeHighlight = WriteHighlight;

            _invalidStructures = new Dictionary<HDestination, IList<ushort>>(2);
            _invalidStructures[HDestination.Client] = new List<ushort>();
            _invalidStructures[HDestination.Server] = new List<ushort>();

            MainUI = mainUI;
            Intercepted = new Queue<InterceptedEventArgs>();
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
                    CaptureIncomingLbl.Text = ("Capture Incoming: " + isChecked);
                    IsHandlingIncoming = isChecked;
                    break;
                }
                case nameof(ViewOutgoingBtn):
                {
                    CaptureOutgoingLbl.Text = ("Capture Outgoing: " + isChecked);
                    IsHandlingOutgoing = isChecked;
                    break;
                }
                case nameof(DisplayStructuresBtn):
                {
                    DisplayStructures = isChecked;
                    break;
                }
                case nameof(BlockedBtn):
                {
                    DisplayBlocked = isChecked;
                    break;
                }
                case nameof(ReplacedBtn):
                {
                    DisplayReplaced = isChecked;
                    break;
                }
                case nameof(AlwaysOnTopBtn):
                {
                    TopMost = isChecked;

                    Text = "Tanji ~ Packet Logger" +
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

        public void HandleOutgoing(InterceptedEventArgs e)
        {
            if (!IsHalted)
                PushToQueue(e);
        }
        public void HandleIncoming(InterceptedEventArgs e)
        {
            if (!IsHalted)
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
                        if (args.WasReplaced && !DisplayReplaced) continue;
                        if (toServer && !IsHandlingOutgoing) continue;
                        if (!toServer && !IsHandlingIncoming) continue;

                        string packetLog = ExtractPacketLog(args.Replacement, toServer);
                        Color packetLogHighlight = (toServer ? OutgoingHighlight : IncomingHighlight);

                        if (args.IsBlocked) WriteHighlight("Blocked ", BlockHighlight);
                        else if (args.WasReplaced) WriteHighlight("Replaced ", ReplaceHighlight);

                        WriteHighlight(packetLog + "\r\n", packetLogHighlight);
                        if (DisplayStructures)
                        {
                            string structureLog = ExtractStructureLog(args.Replacement, toServer);

                            if (!string.IsNullOrWhiteSpace(structureLog))
                                WriteHighlight(structureLog + "\r\n", PacketStructHighlight);
                        }

                        HMessage[] executions = args.GetExecutions();
                        if (executions.Length > 0)
                        {
                            WriteHighlight("\r\n", BackColor);
                            for (int i = 0; i < executions.Length; i++)
                            {
                                HMessage packet = executions[i];
                                WriteHighlight(ExtractPacketLog(packet, toServer) + "\r\n", packetLogHighlight);
                            }
                        }

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
                MainUI.ConnectionPg.Game.OutgoingTypes : MainUI.ConnectionPg.Game.IncomingTypes)[packet.Header].Instance;

            string arrow = (toServer ? "->" : "<-");
            string type = (toServer ? "Outgoing" : "Incoming");
            return $"{type}({packet.Header}, {packet.Length}, {messageInstance.Type.ObjName}) {arrow} {packet}";
        }
        public string ExtractStructureLog(HMessage packet, bool toServer)
        {
            if (!toServer || _invalidStructures[packet.Destination]
                .Contains(packet.Header))
            {
                return string.Empty;
            }

            ASInstance messageInstance = (toServer ?
                MainUI.ConnectionPg.Game.OutgoingTypes : MainUI.ConnectionPg.Game.IncomingTypes)[packet.Header].Instance;

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