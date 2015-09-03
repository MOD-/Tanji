/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    Habbo Hotel Packet(Logger/Manipulator)
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Utilities;
using System.IO.Compression;
using System.IO;

namespace Tanji.Dialogs
{
    public partial class UpdateFrm : Form
    {
        private readonly Task<bool> _checkForUpdatesTask;

        public MainFrm MainUI { get; }
        public Version LocalVersion { get; }

        public GitAsset SelectedAsset
        {
            get { return SelectedRelease.Assets[0]; }
        }
        public GitRelease SelectedRelease
        {
            get { return TanjiReleases[ReleasesTxt.SelectedIndex]; }
        }

        public bool IsDownloading { get; private set; }
        public string DownloadUrl { get; private set; }
        public string ReleaseNotesUrl { get; private set; }

        public Version LatestVersion { get; private set; }
        public GitRelease LatestRelease { get; private set; }
        public GitReleases TanjiReleases { get; private set; }

        public UpdateFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;

            LocalVersion = new Version(Application.ProductVersion);
            MainUI.TanjiVersionTxt.Text = "v" + LocalVersion;

            if (!main.IsDebugging)
                _checkForUpdatesTask = CheckForUpdatesAsync();
        }

        private void UpdateFrm_Load(object sender, EventArgs e)
        {
            ReleasesTxt.DataSource = TanjiReleases;
        }
        private async void DownloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IsDownloading = true;
                Cursor = Cursors.WaitCursor;

                DownloadBtn.Enabled =
                    ReleasesTxt.Enabled = false;

                using (var webClient = new WebClient())
                {
                    webClient.Proxy = null;
                    StatusLbl.SetDotAnimation("Downloading");
                    byte[] tanjiZip = await webClient.DownloadDataTaskAsync(DownloadUrl);

                    BringToFront();
                    StatusLbl.StopDotAnimation("Extracting...");
                    if (TanjiDirectoryDlg.ShowDialog() != DialogResult.OK)
                    {
                        StatusLbl.StopDotAnimation("Standing By...");
                        return;
                    }

                    using (var tanjiStream = new MemoryStream(tanjiZip))
                    using (var tanjiArchive = new ZipArchive(tanjiStream))
                    {
                        foreach (var tanjiFile in tanjiArchive.Entries)
                        {
                            StatusLbl.SetDotAnimation("Extracting {0}", tanjiFile.Name);

                            string saveAs = Path.Combine(TanjiDirectoryDlg.SelectedPath, tanjiFile.Name);
                            tanjiFile.ExtractToFile(saveAs, true);
                        }
                    }
                }
            }
            finally
            {
                IsDownloading = false;
                Cursor = Cursors.Default;

                DownloadBtn.Enabled =
                    ReleasesTxt.Enabled = true;

                StatusLbl.StopDotAnimation("Standing By...");
            }
        }
        private void UpdateFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = IsDownloading;
        }
        private void ReleasesTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReleaseNotesUrl = SelectedRelease.HtmlUrl;
            DownloadUrl = SelectedAsset.BrowserDownloadUrl;

            DownloadBtn.Text = $"Download ({SelectedAsset.Size / 1024} KB)";
        }
        private void ReleaseNotesLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ReleaseNotesUrl);
        }

        public async Task<bool> CheckForUpdatesAsync()
        {
            if (_checkForUpdatesTask != null)
                return await _checkForUpdatesTask.ConfigureAwait(false);

            TanjiReleases = await GitReleases.CreateAsync(
                "ArachisH", "Tanji").ConfigureAwait(false);

            if (TanjiReleases.Count < 1) return false;

            LatestRelease = TanjiReleases[0];
            LatestVersion = new Version(LatestRelease.TagName.Substring(1));

            return LocalVersion < LatestVersion;
        }
    }
}