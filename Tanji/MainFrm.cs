/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using FlashInspect;

using Tanji.Dialogs;
using Tanji.Managers;
using Tanji.Applications;

using Sulakore.Habbo.Web;
using Sulakore.Communication;

namespace Tanji
{
    public partial class MainFrm : Form
    {
        public bool IsRetro { get; set; }
        public bool IsDebugging { get; } = false;
        
        public IDictionary<ushort, string[]> OutStructs { get; }

        public HGameData GameData { get; set; }
        public ShockwaveFlash Game { get; set; }

        public HConnection Connection { get; }
        public EncoderManager EncoderMngr { get; }
        public HandshakeManager HandshakeMngr { get; }
        public ExtensionManager ExtensionMngr { get; }
        public InjectionManager InjectionMngr { get; }

        public UpdateFrm UpdateUI { get; }
        public ConnectFrm ConnectUI { get; }
        public PacketLoggerFrm PacketLoggerUI { get; }

        public MainFrm()
        {
            InitializeComponent();

            OutStructs = new Dictionary<ushort, string[]>();

            Connection = new HConnection();
            UpdateUI = new UpdateFrm(this);
            ConnectUI = new ConnectFrm(this);

            if (!IsDebugging)
            {
                Load += MainFrm_Load;
                Shown += MainFrm_Shown;

                Connection.Connected += Connected;
                Connection.Disconnected += Disconnected;
            }

            // Data Priority - #1 | Notify Extensions
            ExtensionMngr = new ExtensionManager(this);
            // Data Priority - #2 | Process Handshake
            HandshakeMngr = new HandshakeManager(this);
            // Data Priority - #3 | Display Data
            PacketLoggerUI = new PacketLoggerFrm(this);

            EncoderMngr = new EncoderManager(this);
            InjectionMngr = new InjectionManager(this);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            PromptConnect();

            if (!Connection.IsConnected) Close();
            else Text = $"Tanji ~ Connected[{Connection.Host}:{Connection.Port}]";
        }
        private void MainFrm_Shown(object sender, EventArgs e)
        {
            if (!PacketLoggerUI.IsLoaded)
                PacketLoggerUI.Show();
        }

        private void PromptConnect()
        {
            ConnectUI.ShowDialog();
        }
        private void Connected(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(ConnectUI.Close));
        }

        private void Disconnected(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(Close));
        }

        private void TanjiInfoTxt_Click(object sender, EventArgs e)
        {
            TanjiVersionTxt.LinkVisited = true;
            Process.Start("https://GitHub.com/ArachisH/Tanji");
        }
        private void TanjiVersionTxt_Click(object sender, EventArgs e)
        {
            //TanjiVersionTxt.LinkVisited = true;

            string htmlUrl = UpdateUI.TanjiReleases?[0].HtmlUrl;
            if (!string.IsNullOrWhiteSpace(htmlUrl))
                Process.Start(htmlUrl);
        }
    }
}