using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

using Tanji.Pages;
using Tanji.Components;
using Tanji.Pages.About;
using Tanji.Applications;
using Tanji.Pages.Toolbox;
using Tanji.Pages.Injection;
using Tanji.Pages.Extensions;
using Tanji.Pages.Connection;

using Sulakore.Communication;

namespace Tanji
{
    public partial class MainFrm : TanjiForm, IDataManager
    {
        private readonly List<ITanjiService> _services;
        private readonly EventHandler _connected, _disconnected;
        private readonly List<IDataHandler> _dataHandlers, _toRemoveList;

        public HConnection Connection { get; }

        public AboutPage AboutPg { get; }
        public ToolboxPage ToolboxPg { get; }
        public InjectionPage InjectionPg { get; }
        public ExtensionsPage ExtensionsPg { get; }
        public ConnectionPage ConnectionPg { get; }

        public PacketLoggerFrm PacketLoggerUI { get; }

        public MainFrm()
        {
            InitializeComponent();

            _connected = Connected;
            _disconnected = Disconnected;
            _services = new List<ITanjiService>();
            _toRemoveList = new List<IDataHandler>();
            _dataHandlers = new List<IDataHandler>();

            Connection = new HConnection();
            Connection.Connected += Connected;
            Connection.Disconnected += Disconnected;
            Connection.DataOutgoing += DataOutgoing;
            Connection.DataIncoming += DataIncoming;

            AboutPg = new AboutPage(this, AboutTab);
            ToolboxPg = new ToolboxPage(this, ToolboxTab);
            InjectionPg = new InjectionPage(this, InjectionTab);
            ExtensionsPg = new ExtensionsPage(this, ExtensionsTab);
            ConnectionPg = new ConnectionPage(this, ConnectionTab);

            PacketLoggerUI = new PacketLoggerFrm(this);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            ConnectionPg.CreateTrustedRootCertificate();
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

        private void Connected(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(_connected, sender, e);
                return;
            }

            AttachServices();
            AttachDataHandlers();

            Text = $"Tanji ~ Connected[{Connection.Host}:{Connection.Port}]";
            TopMost = PacketLoggerUI.TopMost;

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

            HaltServices();
            ConnectionPg.Game = null;
            ConnectionPg.GameData = null;

            TopMost = true;
            Text = "Tanji ~ Disconnected";

            PacketLoggerUI.Close();
            PacketLoggerUI.Hide();
        }

        private void DataOutgoing(object sender, DataInterceptedEventArgs e)
        {
            ProcessRemoveQueue();
            foreach (IDataHandler dataHandler in _dataHandlers)
            {
                if (dataHandler.IsHandlingOutgoing)
                    dataHandler.HandleOutgoing(e);
            }
        }
        private void DataIncoming(object sender, DataInterceptedEventArgs e)
        {
            ProcessRemoveQueue();
            foreach (IDataHandler dataHandler in _dataHandlers)
            {
                if (dataHandler.IsHandlingIncoming)
                    dataHandler.HandleIncoming(e);
            }
        }

        public void HaltServices()
        {
            foreach (ITanjiService service in _services)
                service.Halt();
        }
        public void AttachServices()
        {
            _services.Clear();

            _services.Add(InjectionPg.FiltersPg);
            _services.Add(InjectionPg.SchedulerPg);
        }
        public void AttachDataHandlers()
        {
            _toRemoveList.Clear();
            _dataHandlers.Clear();

            _dataHandlers.Add(ExtensionsPg);
            _dataHandlers.Add(InjectionPg.FiltersPg);
            _dataHandlers.Add(ConnectionPg.HandshakeMngr);
            _dataHandlers.Add(PacketLoggerUI);
        }

        public void AddDataHandler(IDataHandler dataHandler)
        {
            lock (_dataHandlers)
            {
                if (!_dataHandlers.Contains(dataHandler))
                    _dataHandlers.Add(dataHandler);
            }
        }
        public void RemoveDataHandler(IDataHandler dataHandler)
        {
            lock (_dataHandlers)
            {
                if (_dataHandlers.Contains(dataHandler) &&
                    !_toRemoveList.Contains(dataHandler))
                {
                    _toRemoveList.Add(dataHandler);
                }
            }
        }

        private void ProcessRemoveQueue()
        {
            if (_toRemoveList.Count < 1) return;
            lock (_dataHandlers)
            {
                foreach (IDataHandler dataHandler in _toRemoveList)
                {
                    if (_dataHandlers.Contains(dataHandler))
                        _dataHandlers.Remove(dataHandler);
                }
                _toRemoveList.Clear();
            }
        }
    }
}