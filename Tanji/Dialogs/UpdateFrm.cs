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
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Utilities;
using System.Diagnostics;

namespace Tanji.Dialogs
{
    public partial class UpdateFrm : Form
    {
        public MainFrm MainUI { get; }
        public Version LocalVersion { get; }

        private GitReleases Releases { get; set; }

        public UpdateFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;

            LocalVersion = new Version(Application.ProductVersion);
            MainUI.TanjiVersionTxt.Text = "v" + LocalVersion;
        }

        public async Task<bool> CheckForUpdatesAsync()
        {
            var releases = Releases ?? (Releases = await GitReleases
                .CreateAsync("ArachisH", "Tanji").ConfigureAwait(false));

            if (releases.Count < 1) return false;
            var remoteVer = new Version(releases[0].TagName.Substring(1));

            if (LocalVersion < remoteVer)
            {
                var renderedBody = await GitReleases.RenderBodyToHTML(releases[0]);
                GitBody.DocumentText = renderedBody;
            }

            return LocalVersion < remoteVer;
        }

        private void MoreInformationBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://GitHub.com/ArachisH/Tanji/releases");
        }
    }
}