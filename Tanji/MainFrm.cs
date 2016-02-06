using System;
using System.Diagnostics;
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
        private readonly IList<IDataHandler> _dataHandlers;

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

            Connection = new HConnection();
            Connection.DataOutgoing += DataOutgoing;
            Connection.DataIncoming += DataIncoming;

            PacketLoggerUI = new PacketLoggerFrm(this);

            AboutPg = new AboutPage(this, AboutTab);
            ToolboxPg = new ToolboxPage(this, ToolboxTab);
            InjectionPg = new InjectionPage(this, InjectionTab);
            ExtensionsPg = new ExtensionsPage(this, ExtensionsTab);
            ConnectionPg = new ConnectionPage(this, ConnectionTab);

            _dataHandlers = new List<IDataHandler>();
            _dataHandlers.Add(ConnectionPg.HandshakeMngr);
            _dataHandlers.Add(PacketLoggerUI); // Final say on what to do with data.
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

        public void AddDataHandler(IDataHandler dataHandler)
        {
            if (!_dataHandlers.Contains(dataHandler))
                _dataHandlers.Add(dataHandler);
        }
        public void RemoveDataHandler(IDataHandler dataHandler)
        {
            if (_dataHandlers.Contains(dataHandler))
                _dataHandlers.Remove(dataHandler);
        }

        private void DataOutgoing(object sender, InterceptedEventArgs e)
        {
            foreach (IDataHandler dataHandler in _dataHandlers)
            {
                if (dataHandler.IsHandlingOutgoing)
                    dataHandler.HandleOutgoing(e);
            }
        }
        private void DataIncoming(object sender, InterceptedEventArgs e)
        {
            foreach (IDataHandler dataHandler in _dataHandlers)
            {
                if (dataHandler.IsHandlingIncoming)
                    dataHandler.HandleIncoming(e);
            }
        }
    }
}