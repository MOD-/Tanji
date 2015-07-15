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
using Sulakore.Communication;

using Eavesdrop;

using FlashInspect;

namespace Tanji.Dialogs
{
    public partial class TanjiConnectFrm : Form
    {
        private readonly TaskScheduler _uiContext;

        public bool IsManual
        {
            get { return ModePnl.IsManual; }
        }
        protected MainFrm Main { get; private set; }
        public bool IsConnecting { get; private set; }

        public TanjiConnectFrm(MainFrm main)
        {
            InitializeComponent();
            Main = main;

            _uiContext =
                TaskScheduler.FromCurrentSynchronizationContext();

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

            BrowseBtn.Enabled = !ModePnl.IsManual;

            Text = string.Format("Tanji ~ Connection Setup [{0}]",
                ModePnl.IsManual ? "Manual" : "Automatic");
        }
        private async void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;
            if (ChooseClientDlg.ShowDialog() != DialogResult.OK) return;

            bool verifySuccess = await VerifyGameClientAsync(
                ChooseClientDlg.FileName);

            StatusTxt.StopDotAnimation("Standing By...");
            if (!verifySuccess)
            {
                MessageBox.Show("Unable to dissassemble the Shockwave Flash(.swf) file.",
                    "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CustomClientTxt.Text = verifySuccess ?
                Main.Game.Location : string.Empty;
        }
        private async void ConnectBtn_Click(object sender, EventArgs e)
        {
            IsConnecting = !IsConnecting;
            if (IsConnecting)
            {
                ModePnl.Enabled = GameHostTxt.Enabled =
                    GamePortTxt.Enabled = false;

                ConnectBtn.Text = "Cancel";
                if (ModePnl.IsManual)
                {
                    if (!(await OnManualConnectAsync()))
                    {
                        ResetInterface();
                        MessageBox.Show("Something went wrong when attempting to intercept the connection.",
                            "Tanji ~ Error!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else Close();
                }
                else OnAutomaticConnect();
            }
            else OnCancelConnect();
        }
        private void EavesdropperResponse(object sender, EavesdropperResponseEventArgs e)
        {
            if (e.Response.ContentType == "application/x-shockwave-flash" && e.Payload.Length > 3000000)
            {
                Eavesdropper.Terminate();
                StatusTxt.SetDotAnimation("Intercepting Connection");

                Main.Connection.ConnectAsync(Main.GameData.Host, Main.GameData.Port)
                    .ContinueWith(t => Close(), _uiContext);
            }
            else
            {
                string responseBody = Encoding.UTF8.GetString(e.Payload);
                if (responseBody.Contains("connection.info.host"))
                {
                    Main.GameData = new HGameData(responseBody);
                    Main.Contractor.Hotel = SKore.ToHotel(Main.GameData.Host);
                    Main.IsRetro = (Main.Contractor.Hotel == HHotel.Unknown);

                    /* We do this check first since future builds may support 
                     * caching of modded retro clients, when that happens, we 
                     * simply remove the '!Main.IsRetro' condition. */
                    if (Main.Game == null && !Main.IsRetro)
                        LoadModdedClientAsync().Wait();

                    /* Modded retro client caching is not supported yet, so let's 
                     * terminate the proxy, and begin intercepting the connection. */
                    if (Main.Game == null && Main.IsRetro)
                    {
                        Eavesdropper.Terminate();
                        StatusTxt.SetDotAnimation("Intercepting Connection");

                        Main.Connection.ConnectAsync(Main.GameData.Host, Main.GameData.Port)
                            .ContinueWith(t => Close(), _uiContext);
                    }
                    else
                    {
                        StatusTxt.SetDotAnimation((Main.GameData == null ?
                            "Intercepting" : "Replacing") + " Client");
                    }

                    responseBody = responseBody.Replace(".swf", ".swf?" + DateTime.Now.Millisecond);
                    e.Payload = Encoding.UTF8.GetBytes(responseBody);
                }
            }
        }

        protected virtual void OnCancelConnect()
        {
            ResetInterface();
            Eavesdropper.Terminate();
            Main.Connection.Disconnect();
        }
        protected virtual void OnAutomaticConnect()
        {
            Eavesdropper.Initiate(8080);
            StatusTxt.SetDotAnimation("Extracting Host/Port");
        }
        protected virtual async Task<bool> OnManualConnectAsync()
        {
            StatusTxt.SetDotAnimation("Intercepting Connection");

            await Main.Connection.ConnectAsync(
                GameHostTxt.Text, int.Parse(GamePortTxt.Text));

            return Main.Connection.IsConnected;
        }

        private void ResetInterface()
        {
            IsConnecting = false;
            ConnectBtn.Text = "Connect";
            StatusTxt.StopDotAnimation("Standing By...");
            ModePnl.Enabled = GameHostTxt.Enabled = GamePortTxt.Enabled = true;
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
        private async Task<bool> LoadModdedClientAsync()
        {
            string possibleClientPath = Path.Combine("Modified Clients",
               Main.GameData.FlashClientBuild + ".swf");

            bool loadSuccess = false;
            if (File.Exists(possibleClientPath))
            {
                loadSuccess = await VerifyGameClientAsync(
                    possibleClientPath).ConfigureAwait(false);

                if (!loadSuccess)
                    File.Delete(possibleClientPath);
            }
            return loadSuccess;
        }
        private async Task<bool> VerifyGameClientAsync(string path)
        {
            try
            {
                Main.Game = new ShockwaveFlash(path);
                if (Main.Game.IsCompressed)
                {
                    StatusTxt.SetDotAnimation("Decompressing Client");
                    if (await Main.Game.DecompressAsync()
                        .ConfigureAwait(false))
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

        private void TanjiConnectFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ResetInterface();
                Eavesdropper.Terminate();
                HConnection.RestoreHosts();
            }
            finally
            {
                if (!Main.Connection.IsConnected)
                    Environment.Exit(0);
            }
        }
    }
}