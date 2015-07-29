using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Utilities;

namespace Tanji.Dialogs
{
    public partial class UpdateFrm : Form
    {
        public MainFrm MainUI { get; }
        private GitReleases Releases { get; set; }

        public UpdateFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;
        }

        public async Task<bool> CheckForUpdatesAsync()
        {
            var releases = Releases ?? (Releases = await GitReleases
                .CreateAsync("ArachisH", "Tanji").ConfigureAwait(false));

            if (releases.Count < 1) return false;
            var remoteVer = new Version(releases[0].TagName);
            var localVer = new Version(Application.ProductVersion);

            if (localVer < remoteVer)
            {
                var renderedBody = await GitReleases.RenderBodyToHTML(releases[0]);
                GitBody.DocumentText = renderedBody;
            }

            return localVer < remoteVer;
        }
    }
}