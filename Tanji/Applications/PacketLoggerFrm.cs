using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Tanji.Pages;
using Tanji.Utilities;
using Tanji.Components;
using Tanji.Applications.Dialogs;

using Sulakore.Protocol;
using Sulakore.Communication;

using FlashInspect.ActionScript;

namespace Tanji.Applications
{
    public partial class PacketLoggerFrm : TanjiForm, IDataHandler
    {
        private Task _readQueueTask;
        private FindHeaderDialog _currentFindHeaderUI;

        private readonly Action _refreshLog;
        private readonly object _pushToQueueLock;
        private readonly Action<string, Color> _writeHighlight;
        private readonly List<ushort> _invalidParsers, _invalidStructures;

        public MainFrm MainUI { get; }
        public Queue<DataInterceptedEventArgs> Intercepted { get; }

        public Color SpecialHighlight { get; set; } = Color.DarkGray;
        public Color IncomingHighlight { get; set; } = Color.FromArgb(178, 34, 34);
        public Color OutgoingHighlight { get; set; } = Color.FromArgb(0, 102, 204);
        public Color StructureHighlight { get; set; } = Color.FromArgb(0, 204, 136);

        public bool IsHalted { get; private set; }
        public bool IsHandlingOutgoing { get; private set; } = true;
        public bool IsHandlingIncoming { get; private set; } = true;

        public bool DisplayHash { get; private set; }
        public bool DisplayTimestamp { get; private set; }
        public bool DisplayBlocked { get; private set; } = true;
        public bool DisplayReplaced { get; private set; } = true;
        public bool DisplayStructure { get; private set; } = true;
        public bool DisplayClassName { get; private set; } = true;
        public bool DisplayParserName { get; private set; } = true;

        public PacketLoggerFrm(MainFrm mainUI)
        {
            InitializeComponent();

            _refreshLog = RefreshLog;
            _writeHighlight = WriteHighlight;

            _pushToQueueLock = new object();
            _invalidParsers = new List<ushort>();
            _invalidStructures = new List<ushort>();

            MainUI = mainUI;
            Intercepted = new Queue<DataInterceptedEventArgs>();
        }

        private void Item_Checked(object sender, EventArgs e)
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
                case nameof(DisplayStructureBtn):
                {
                    DisplayStructure = isChecked;
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
                case nameof(HashBtn):
                {
                    DisplayHash = isChecked;
                    break;
                }
                case nameof(TimestampBtn):
                {
                    DisplayTimestamp = isChecked;
                    break;
                }
                case nameof(ClassNameBtn):
                {
                    DisplayClassName = isChecked;
                    break;
                }
                case nameof(ParserName):
                {
                    DisplayParserName = isChecked;
                    break;
                }
                case nameof(AlwaysOnTopBtn):
                {
                    TopMost = isChecked;
                    MainUI.TopMost = isChecked;

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
        private void FindHeaderBtn_Click(object sender, EventArgs e)
        {
            if (_currentFindHeaderUI != null &&
                !_currentFindHeaderUI.IsDisposed)
            {
                _currentFindHeaderUI.BringToFront();
            }
            else
            {
                _currentFindHeaderUI =
                    new FindHeaderDialog(MainUI.ConnectionPg.Game);

                _currentFindHeaderUI.Show(this);
            }

            string selectedText = LoggerTxt.SelectedText;
            if (!string.IsNullOrWhiteSpace(selectedText))
                _currentFindHeaderUI.Find(selectedText);
        }

        public void HandleOutgoing(DataInterceptedEventArgs e) => PushToQueue(e);
        public void HandleIncoming(DataInterceptedEventArgs e) => PushToQueue(e);

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
        public void WriteStructureLog(HMessage packet, ASClass messageClass)
        {
            if (_invalidStructures.Contains(packet.Header))
                return;

            int position = 0;
            string structureLog = $"{{l}}{{u:{packet.Header}}}";
            ASMethod msgCtor = messageClass.Instance.Constructor;
            foreach (ASParameter parameter in msgCtor.Parameters)
            {
                switch (parameter.Type.Name.ToLower())
                {
                    case "string":
                    if (!packet.CanReadString(position)) continue;
                    structureLog += ($"{{s:{packet.ReadString(ref position)}}}");
                    break;

                    case "boolean":
                    if (packet.ReadableAt(position) < 1) continue;
                    structureLog += ($"{{b:{packet.ReadBoolean(ref position)}}}");
                    break;

                    case "int":
                    if (packet.ReadableAt(position) < 4) continue;
                    structureLog += ($"{{i:{packet.ReadInteger(ref position)}}}");
                    break;
                }
            }
            if (packet.ReadableAt(position) == 0)
            {
                WriteHighlight(structureLog + "\r\n", StructureHighlight);
            }
            else _invalidStructures.Add(packet.Header);
        }
        public void WritePacketLog(DataInterceptedEventArgs args, bool isOutgoing)
        {
            HMessage pkt = args.Packet;
            HGame game = MainUI.ConnectionPg.Game;

            ReadOnlyDictionary<ushort, ASClass> msgClasses = (isOutgoing ?
                game.OutgoingMessages : game.IncomingMessages);

            ASClass msgClass = null;
            msgClasses.TryGetValue(pkt.Header, out msgClass);

            Color highlight = (isOutgoing ?
                OutgoingHighlight : IncomingHighlight);

            if (DisplayTimestamp)
                WriteHighlight($"[{DateTime.Now.ToLongTimeString()}]\r\n", SpecialHighlight);

            if (DisplayHash)
            {
                string hash = game.GetMessageHash(msgClass);
                WriteHighlight($"[{hash}]\r\n", SpecialHighlight);
            }

            WriteHighlight((isOutgoing ?
                "Outgoing" : "Incoming"), highlight);

            if (args.IsBlocked && DisplayBlocked)
            {
                WriteHighlight("[Blocked]", SpecialHighlight);
            }
            else if (!args.IsOriginal)
            {
                WriteHighlight("[Replaced]", SpecialHighlight);
            }

            string arrow = (isOutgoing ? "->" : "<-");
            WriteHighlight($"({pkt.Header}, {pkt.Length}", highlight);

            if (DisplayClassName && msgClass != null)
            {
                WriteHighlight(", ", highlight);
                WriteHighlight((msgClass?.Instance.Name.Name) ?? "???", SpecialHighlight);
            }
            if (!isOutgoing && DisplayParserName &&
                msgClass != null && !_invalidParsers.Contains(pkt.Header))
            {
                ASClass parserClass = game
                    .GetIncomingMessageParser(msgClass);

                if (parserClass != null)
                {
                    WriteHighlight($", ", highlight);
                    WriteHighlight(parserClass.Instance.Name.Name, SpecialHighlight);
                }
                else _invalidParsers.Add(pkt.Header);
            }
            WriteHighlight($") {arrow} {pkt}\r\n", highlight);

            if (DisplayStructure && isOutgoing)
                WriteStructureLog(pkt, msgClass);
        }

        private void LogMessageQueue()
        {
            if (Intercepted.Count > 0 &&
                (_readQueueTask?.IsCompleted ?? true))
            {
                _readQueueTask = Task.Factory
                    .StartNew(MessageQueueLogger);
            }
        }
        private void MessageQueueLogger()
        {
            bool wasLockTaken = false;
            try
            {
                Monitor.TryEnter(Intercepted, ref wasLockTaken);
                if (!wasLockTaken) return;

                while (Intercepted.Count > 0)
                {
                    DataInterceptedEventArgs args = Intercepted.Dequeue();
                    bool isOutgoing = (args.Packet.Destination == HDestination.Server);
                    if (!IsLoggingAuthorized(args, isOutgoing)) continue;

                    WritePacketLog(args, isOutgoing);
                    WriteHighlight("--------------------\r\n", SpecialHighlight);
                    RefreshLog();
                }
            }
            finally
            {
                if (wasLockTaken)
                {
                    Monitor.Exit(Intercepted);
                    Application.DoEvents();
                }
            }
        }
        private void PushToQueue(DataInterceptedEventArgs e)
        {
            if (IsHalted) return;
            lock (_pushToQueueLock)
            {
                Intercepted.Enqueue(e);
                LogMessageQueue();
            }
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
        private bool IsLoggingAuthorized(DataInterceptedEventArgs args, bool isOutgoing)
        {
            if (!DisplayBlocked && args.IsBlocked) return false;
            if (!DisplayReplaced && !args.IsOriginal) return false;

            if (!IsHandlingOutgoing && isOutgoing) return false;
            if (!IsHandlingIncoming && !isOutgoing) return false;

            return true;
        }

        protected override void OnActivated(EventArgs e)
        {
            if (IsHalted)
            {
                IsHalted = false;
                IsHandlingOutgoing = ViewOutgoingBtn.Checked;
                IsHandlingIncoming = ViewIncomingBtn.Checked;
                LoggerTxt.Clear();
            }
            LogMessageQueue();
            base.OnActivated(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = IsHalted = true;
            Intercepted.Clear();

            IsHandlingOutgoing =
                IsHandlingIncoming = false;

            LoggerTxt.Clear();
            WindowState = FormWindowState.Minimized;

            base.OnFormClosing(e);
        }
    }
}