/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

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
        private bool _isReadingQueue;

        private readonly WriteHighlightCallback _writeHighlight;
        private delegate void WriteHighlightCallback(string value, Color highlight);

        private readonly WriteCallback _write;
        private delegate void WriteCallback(InterceptedEventArgs e);

        public MainFrm MainUI { get; }
        public bool IsLoaded { get; private set; }
        public bool IsHalted { get; private set; }
        public Queue<InterceptedEventArgs> Intercepted { get; }

        public Color BlockHighlight { get; set; } = Color.DimGray;
        public Color ReplaceHighlight { get; set; } = Color.DarkCyan;
        public Color IncomingHighlight { get; set; } = Color.Firebrick;
        public Color OutgoingHighlight { get; set; } = SystemColors.HotTrack;
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

        protected override void OnActivated(EventArgs e)
        {
            IsLoaded = true;
            if (IsHalted) IsHalted = false;
            base.OnActivated(e);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Intercepted.Clear();

            IsLoaded = false;
            e.Cancel = IsHalted = true;
            WindowState = FormWindowState.Minimized;

            LoggerTxt.Clear();
            base.OnFormClosing(e);
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
        private void SaveLogBtn_Click(object sender, EventArgs e)
        {
            // TODO: This.
        }
        private void EmptyLogBtn_Click(object sender, EventArgs e)
        {
            LoggerTxt.Clear();
        }

        private void DataIncoming(object sender, InterceptedEventArgs e)
        {
            if (!IsHalted && ViewIncoming)
                PushToQueue(sender, e);
        }
        private void DataOutgoing(object sender, InterceptedEventArgs e)
        {
            if (!IsHalted && ViewOutgoing)
                PushToQueue(sender, e);
        }

        private void RunDisplayQueueLoop()
        {
            if (!_isReadingQueue && Monitor.TryEnter(Intercepted))
            {
                _isReadingQueue = true;
                try
                {
                    while (Intercepted.Count > 0)
                    {
                        InterceptedEventArgs e = Intercepted.Dequeue();
                        bool toServer = (e.Packet.Destination == HDestination.Server);

                        if (toServer && !ViewOutgoing) continue;
                        if (!toServer && !ViewIncoming) continue;
                        if (e.IsBlocked && !DisplayBlocked) continue;

                        while (!IsLoaded) Thread.Sleep(100);
                        Write(e);
                    }
                }
                finally
                {
                    Monitor.Exit(Intercepted);
                    _isReadingQueue = false;
                }
            }
            else return;
        }
        private void PushToQueue(object sender, InterceptedEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized ||
                e.IsBlocked && !DisplayBlocked)
            {
                return;
            }

            Intercepted.Enqueue(e);
            if (!_isReadingQueue)
            {
                _readQueueTask = Task.Factory.StartNew(
                    RunDisplayQueueLoop, TaskCreationOptions.LongRunning);
            }
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
                    string[] structure = MainUI.OutStructs[e.Packet.Header];
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
                                WriteHighlight(packetInfo, PacketStructHighlight);

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