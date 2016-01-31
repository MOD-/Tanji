using System;
using System.Diagnostics;

using Tanji.Components;
using Tanji.Pages.About;
using Tanji.Applications;
using Tanji.Pages.Toolbox;
using Tanji.Pages.Injection;
using Tanji.Pages.Extensions;
using Tanji.Pages.Connection;

namespace Tanji
{
    public partial class MainFrm : TanjiForm
    {
        public AboutPage AboutPg { get; }
        public ToolboxPage ToolboxPg { get; }
        public InjectionPage InjectionPg { get; }
        public ConnectionPage ConnectionPg { get; }
        public ExtensionsPage ExtensionsPg { get; }

        public PacketLoggerFrm PacketLoggerUI { get; }

        public MainFrm()
        {
            InitializeComponent();

            AboutPg = new AboutPage(this, AboutTab);
            ToolboxPg = new ToolboxPage(this, ToolboxTab);
            InjectionPg = new InjectionPage(this, InjectionTab);
            ConnectionPg = new ConnectionPage(this, ConnectionTab);
            ExtensionsPg = new ExtensionsPage(this, ExtensionsTab);
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
    }
}