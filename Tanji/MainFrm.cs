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
        public ExtensionsPage ExtensionsPg { get; }
        public ConnectionPage ConnectionPg { get; }

        public PacketLoggerFrm PacketLoggerUI { get; }

        public MainFrm()
        {
            InitializeComponent();

            // Initialize this first, since it carries the important HConnection instance
            // that many other pages will need for hooking onto the data interception events.
            ConnectionPg = new ConnectionPage(this, ConnectionTab);
            
            // Everything here should be initialized by their data priority from least to greatest.
            ExtensionsPg = new ExtensionsPage(this, ExtensionsTab);
            InjectionPg = new InjectionPage(this, InjectionTab);
            ToolboxPg = new ToolboxPage(this, ToolboxTab);
            AboutPg = new AboutPage(this, AboutTab);

            // This instance/form currently has top priority,
            // since we want to display the final true intentions
            // of a packet whether is was replaced/blocked.
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
    }
}