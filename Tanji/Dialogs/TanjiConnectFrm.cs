/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    .NET library for creating Habbo Hotel related desktop applications.
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
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using Sulakore;
using Sulakore.Habbo.Web;
using Sulakore.Protocol.Encryption;

using Eavesdrop;

using FlashInspect;

namespace Tanji.Dialogs
{
    public partial class TanjiConnectFrm : Form
    {
        public MainFrm Main { get; private set; }
        public bool IsConnecting { get; private set; }

        public TanjiConnectFrm(MainFrm main)
        {
            InitializeComponent();
            Main = main;

            if (!Directory.Exists("Modified Clients"))
                Directory.CreateDirectory("Modified Clients");

            CreateTrustedRootCertificate();
            Eavesdropper.IsSslSupported = true;
            Eavesdropper.EavesdropperResponse += EavesdropperResponse;
        }

        private void ModeChanged(object sender, EventArgs e)
        {
            GameHostTxt.Enabled =
                GamePortTxt.Enabled = ModePnl.IsManual;

            Text = string.Format("Tanji ~ Connection Setup [{0}]",
                ModePnl.IsManual ? "Manual" : "Automatic");
        }
        private async void ConnectBtn_Click(object sender, EventArgs e)
        {
            IsConnecting = !IsConnecting;
            ModePnl.Enabled = !ModePnl.Enabled;

            if (IsConnecting)
            {
                ConnectBtn.Text = "Cancel";
                if (!ModePnl.IsManual || Main.Game != null)
                    Eavesdropper.Initiate(8080);

                if (ModePnl.IsManual)
                {
                    StatusTxt.SetDotAnimation(Eavesdropper.IsRunning ?
                        "Overriding Client" : "Intercepting Connection");

                    // TODO: Verify if the custom host/port pair is valid.
                    await Main.Connection.ConnectAsync("", 0);
                    // TODO: Close the connection setup, don't forget to reset some stuff too.
                }
                else StatusTxt.SetDotAnimation("Extracting Host/Port");
            }
            else
            {
                ConnectBtn.Text = "Connect";
                StatusTxt.StopDotAnimation("Standing By...");
            }
        }
        private async void EavesdropperResponse(object sender, EavesdropperResponseEventArgs e)
        {
            if (e.Response.ContentLength < 1) return;
            if (e.Response.ContentType == "application/x-shockwave-flash")
            {
                // TODO: Replace the client here, also replace keys if it needs to be done.
                Eavesdropper.Terminate(); // No more http(s) interception is necessary.
            }
            else
            {
                string responseBody = Encoding.UTF8.GetString(e.Payload);
                if (responseBody.Contains("connection.info.host"))
                {
                    Main.IsRetro = (SKore.ToHotel(
                        e.Response.ResponseUri.Host) == HHotel.Unknown);

                    Main.GameData = new HGameData(responseBody);

                    // Should we even await this?
                    await LoadModdedClientAsync()
                        .ConfigureAwait(false);

                    // TODO: Modify flash client url to produce a non-cached version.
                    // blah blah blah
                }
            }
        }

        private void CreateTrustedRootCertificate()
        {
            while (!Eavesdropper.CreateTrustedRootCertificate())
            {
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to decrypt HTTPS traffic.\r\n\r\nShutting Down...",
                    "Tanji ~ Alert!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Cancel)
                    Environment.Exit(0);
            }
        }
        private async Task LoadModdedClientAsync()
        {
            string possibleClientPath = Path.Combine("Modified Clients",
               Main.GameData.FlashClientBuild + ".swf");

            if (File.Exists(possibleClientPath))
            {
                bool verifySuccess = await VerifyGameClientAsync(
                    possibleClientPath).ConfigureAwait(false);

                if (!verifySuccess)
                    File.Delete(possibleClientPath);
            }

            StatusTxt.SetDotAnimation(Main.GameData == null ?
                "Intercepting Client" : "Overriding Client");
        }
        private async Task<bool> VerifyGameClientAsync(string path)
        {
            try
            {
                Main.Game = new ShockwaveFlash(path);
                if (Main.Game.IsCompressed)
                {
                    StatusTxt.SetDotAnimation("Decompressing Client");
                    if (await Main.Game
                        .DecompressAsync().ConfigureAwait(false))
                    {
                        StatusTxt.SetDotAnimation("Extracting Tags");
                        Main.Game.ExtractTags();
                    }
                }
                return !Main.Game.IsCompressed;
            }
            catch
            {
                Main.Game = null;
                return false;
            }
        }

        private async void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;
            if (ChooseClientDlg.ShowDialog() != DialogResult.OK) return;

            bool verifySuccess =
                await VerifyGameClientAsync(ChooseClientDlg.FileName);

            StatusTxt.StopDotAnimation("Standing By...");
            if (!verifySuccess)
            {
                MessageBox.Show("Unable to dissassemble the flash file.",
                    "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CustomClientTxt.Text = verifySuccess ?
                Main.Game.Location : string.Empty;
        }
    }
}