using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.GitHub;

namespace Tanji.Pages.About
{
    public class AboutPage : TanjiPage
    {
        public GitRepository TanjiRepo { get; }

        public Version LocalVersion { get; }
        public Version LatestVersion { get; private set; }

        public AboutPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            LocalVersion = new Version(Application.ProductVersion);
            UI.TanjiVersionTxt.Text = ("v" + LocalVersion);

            TanjiRepo = new GitRepository("ArachisH", "Tanji");
            
            TanjiRepo.GetLatestReleaseAsync().ContinueWith(
                LatestReleaseGrabbed, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void LatestReleaseGrabbed(Task<GitRelease> getLatestReleaseTask)
        {
            LatestVersion = new Version(TanjiRepo
                .LatestRelease.TagName.Substring(1));

            UI.TanjiVersionTxt.IsLink = true;
            IsNotifying = (LatestVersion > LocalVersion);
        }
    }
}