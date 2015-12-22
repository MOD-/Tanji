using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanji.Managers
{
    public class AboutManager
    {
        public MainFrm MainUI { get; }

        public AboutManager(MainFrm main, TabPage aboutTab)
        {
            MainUI = main;

            aboutTab.Controls["ATTanjiBtn"].Click += ATTanjiBtn_Click;
            aboutTab.Controls["ATIconLogoBtn"].Click += ATIconLogoBtn_Click;
            aboutTab.Controls["ATMakeCertBtn"].Click += ATMakeCertBtn_Click;
            aboutTab.Controls["ATSulakoreBtn"].Click += ATSulakoreBtn_Click;

            aboutTab.Controls["ATDarkboxBtn"].Click += ATDarkboxBtn_Click;
            aboutTab.Controls["ATRagezoneBtn"].Click += ATRagezoneBtn_Click;
            aboutTab.Controls["ATDonationsBtn"].Click += ATDonationsBtn_Click;

            aboutTab.Controls["ATGitHubBtn"].Click += ATGitHubBtn_Click;
            aboutTab.Controls["ATTwitterBtn"].Click += ATTwitterBtn_Click;
            aboutTab.Controls["ATReleasesBtn"].Click += ATReleasesBtn_Click;

            aboutTab.Controls["ATVersionLbl"].Text =
                ("v" + MainUI.UpdateUI.LocalVersion);

            MainUI.UpdateUI.CheckForUpdatesAsync().ContinueWith(
                UpdateCheckFinished, aboutTab, TaskScheduler.FromCurrentSynchronizationContext());
        }
        
        private void UpdateCheckFinished(Task<bool> updateCheckTask, object tab)
        {
            var aboutTab = (TabPage)tab;

            aboutTab.Controls["ATDownloadsLbl"].Text =
                ("Downloads: " + (MainUI.UpdateUI.CurrentRelease?.Assets[0].DownloadCount ?? 0));

            aboutTab.Controls["ATReleasesBtn"].Text =
                ("Release(s): " + (MainUI.UpdateUI?.TanjiReleases?.Count ?? 0));
        }

        private void ATGitHubBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH");
        }
        private void ATTwitterBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://Twitter.com/ArachisH");
        }

        private void ATDarkboxBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.Darkbox.nl/board/index.php");
        }
        private void ATRagezoneBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://Forum.RaGEZONE.com/f282/");
        }
        private void ATReleasesBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Tanji/releases");
        }
        private void ATDonationsBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://Pledgie.com/campaigns/30163");
        }

        private void ATTanjiBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Tanji");
        }
        private void ATIconLogoBtn_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.iconarchive.com/show/fs-icons-by-franksouza183/Apps-clementine-icon.html");
        }
        private void ATMakeCertBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://msdn.microsoft.com/en-us/library/bfsktky3(v=vs.110).aspx");
        }
        private void ATSulakoreBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Sulakore");
        }
    }
}