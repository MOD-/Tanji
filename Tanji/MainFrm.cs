using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using Tanji.Components;
using Tanji.Pages.About;
using Tanji.Applications;
using Tanji.Manipulators;
using Tanji.Pages.Modules;
using Tanji.Pages.Toolbox;
using Tanji.Pages.Injection;
using Tanji.Pages.Connection;

using Sulakore.Habbo;
using Sulakore.Protocol;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using Eavesdrop;

using Tangine.Habbo;

namespace Tanji
{
    public partial class MainFrm : TanjiForm
    {
        private readonly List<IHaltable> _haltables;
        private readonly List<IReceiver> _receivers;
        private readonly EventHandler _connected, _disconnected;

        public HGame Game { get; set; }
        public HHotel Hotel { get; set; }
        public HGameData GameData { get; set; }
        public HConnection Connection { get; set; }

        public AboutPage AboutPg { get; }
        public ModulesPage ModulesPg { get; }
        public ToolboxPage ToolboxPg { get; }
        public InjectionPage InjectionPg { get; }
        public ConnectionPage ConnectionPg { get; }

        public PacketLoggerFrm PacketLoggerUI { get; }

        public MainFrm()
        {
            InitializeComponent();

            _connected = Connected;
            _disconnected = Disconnected;
            _haltables = new List<IHaltable>();
            _receivers = new List<IReceiver>();

            GameData = new HGameData();
            Connection = new HConnection();
            Connection.Connected += Connected;
            Connection.Disconnected += Disconnected;
            Connection.DataOutgoing += DataOutgoing;
            Connection.DataIncoming += DataIncoming;

            ConnectionPg = new ConnectionPage(this, ConnectionTab);
            InjectionPg = new InjectionPage(this, InjectionTab);
            ToolboxPg = new ToolboxPage(this, ToolboxTab);
            ModulesPg = new ModulesPage(this, ModulesTab);
            AboutPg = new AboutPage(this, AboutTab);

            PacketLoggerUI = new PacketLoggerFrm(this);

            _haltables.Add(ModulesPg);
            _haltables.Add(PacketLoggerUI);
            _haltables.Add(InjectionPg.FiltersPg);
            _haltables.Add(InjectionPg.SchedulerPg);

            _receivers.Add(ModulesPg);
            _receivers.Add(InjectionPg.FiltersPg);
            _receivers.Add(ConnectionPg.HandshakeMngr);
            _receivers.Add(PacketLoggerUI);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Eavesdropper.Terminate();
            ConnectionPg.CreateTrustedRootCertificate();
        }
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Eavesdropper.Terminate();
        }

        private void TanjiInfoTxt_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Tanji");
        }
        private void TanjiVersionTxt_Click(object sender, EventArgs e)
        {
            if (AboutPg.TanjiRepo.LatestRelease != null)
                Process.Start(AboutPg.TanjiRepo.LatestRelease.HtmlUrl);
        }

        private void Halt()
        {
            _haltables.ForEach(h => h.Halt());
        }
        private void HandleData(DataInterceptedEventArgs e)
        {
            bool isOutgoing = (e.Packet.Destination == HDestination.Server);
            foreach (IReceiver receiver in _receivers)
            {
                if (!receiver.IsReceiving) continue;

                if (isOutgoing) receiver.HandleOutgoing(e);
                else receiver.HandleIncoming(e);
            }
        }

        private void Connected(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(_connected, sender, e);
                return;
            }

            ConnectionPg.HandshakeMngr.RestartHandshake();
            Text = $"Tanji ~ Connected[{Connection.Host}:{Connection.Port}]";
            TopMost = PacketLoggerUI.TopMost;

            PacketLoggerUI.RevisionTxt.Text =
                ("Revision: " + Game.GetClientRevision());

            PacketLoggerUI.Show();
            PacketLoggerUI.WindowState = FormWindowState.Normal;

            BringToFront();
        }
        private void Disconnected(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(_disconnected, sender, e);
                return;
            }

            Halt();
            Game.Dispose();
            Game = null;

            TopMost = true;
            Text = "Tanji ~ Disconnected";
        }

        private void DataOutgoing(object sender, DataInterceptedEventArgs e) => HandleData(e);
        private void DataIncoming(object sender, DataInterceptedEventArgs e) => HandleData(e);
    }
}