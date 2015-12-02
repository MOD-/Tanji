using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Eavesdrop;

using Tanji.Managers;

using Sulakore;
using Sulakore.Habbo;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using FlashInspect.Tags;
using FlashInspect.ActionScript;

namespace Tanji.Dialogs
{
    public partial class ConnectFrm : Form
    {
        private readonly Regex _ipMatcher;
        private readonly List<ushort> _possiblePorts;

        public MainFrm MainUI { get; }
        public AboutManager AboutMngr { get; }
        public ConnectionManager ConnectionMngr { get; }

        public ConnectFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;

            ConnectionMngr = new ConnectionManager(this);
            AboutMngr = new AboutManager(main, AboutTab);

            _possiblePorts = new List<ushort>();
            _ipMatcher = new Regex("^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$");

            if (!Directory.Exists("Modified Clients"))
                Directory.CreateDirectory("Modified Clients");

            CreateTrustedRootCertificate();
            Eavesdropper.IsSslSupported = true;
        }

        private async void ConnectFrm_Shown(object sender, EventArgs e)
        {
            CTBrowseBtn.Enabled = ConnectBtn.Enabled = false;
            StatusTxt.SetDotAnimation("Checking for Updates...");

            try
            {
                if (await MainUI.UpdateUI.CheckForUpdatesAsync())
                {
                    StatusTxt.StopDotAnimation("Update Found!");
                    MainUI.UpdateUI.ShowDialog();
                }
            }
            catch { /* Update check failed. */ }
            finally
            {
                CTBrowseBtn.Enabled = ConnectBtn.Enabled = true;
                StatusTxt.StopDotAnimation("Standing By...");
            }
        }
        private void ConnectFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoConnectCleanup();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (!Eavesdropper.IsRunning)
            {
                ConnectBtn.Text = "Cancel";
                DoAutomaticConnect();
            }
            else DoCancelConnect();
        }
        private async void BrowseBtn_Click(object sender, EventArgs e)
        {
            ChooseClientDlg.FileName = ChooseClientDlg.SafeFileName;
            if (ChooseClientDlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                if (!(await VerifyGameClientAsync(ChooseClientDlg.FileName)))
                {
                    MessageBox.Show("Unable to disassemble the Shockwave Flash(.swf) file.",
                        "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally { StatusTxt.StopDotAnimation("Standing By..."); }

            CTCustomClientTxt.Text =
                (MainUI.Game?.Location ?? string.Empty);
        }

        private void InjectClient(object sender, EavesdropperRequestEventArgs e)
        {
            // This is here to speed-up the loading process of the client,
            // instead of having it to re-download the client everytime.
            if (e.Request.RequestUri.OriginalString.Contains(".swf?Tanji-"))
            {
                Eavesdropper.EavesdropperRequest -= InjectClient;
                e.Request = WebRequest.Create(new Uri(MainUI.Game.Location));
                Eavesdropper.EavesdropperResponse += ReplaceClient;
            }
        }
        private void ReplaceClient(object sender, EavesdropperResponseEventArgs e)
        {
            if ((e.Payload.Length > 3000000 && e.Response.ContentType == "application/x-shockwave-flash") ||
                File.Exists(e.Response.ResponseUri.LocalPath))
            {
                string[] ports = MainUI.GameData.Port.Split(',');
                foreach (string port in ports) TryAddPort(port);

                if (MainUI.Game == null)
                {
                    VerifyGameClientAsync(new HFlash(e.Payload)).Wait();
                    if (MainUI.Game != null)
                    {
                        if (MainUI.IsRetro)
                        {
                            IEnumerable<DoABCTag> abcTags =
                                MainUI.Game.Tags.OfType<DoABCTag>();

                            // Find(if any) hard-coded IP addresses.
                            // Overwrite the "connection.info.host" variable with "tanji.connection.info.host".
                            HandleConstants(abcTags);
                        }

                        MainUI.Game.RemoveLocalUseRestrictions();
                        MainUI.Game.ReplaceRSA(HandshakeManager.FAKE_EXPONENT, HandshakeManager.FAKE_MODULUS);

                        StatusTxt.SetDotAnimation("Reconstructing");
                        MainUI.Game.Reconstruct();

                        // TODO: Cache retro clients with a file hash as their identifier.
                        if (!MainUI.IsRetro)
                        {
                            File.WriteAllBytes(Path.Combine("Modified Clients",
                                MainUI.GameData.MovieName + ".swf"), MainUI.Game.ToArray());
                        }
                    }
                }

                e.Payload = MainUI.Game.ToArray();
                Eavesdropper.EavesdropperResponse -= ReplaceClient;
                Eavesdropper.Terminate();

                // Apply custom connection parameters(if any).
                _possiblePorts.AddRange(ConnectionMngr.GamePorts);
                if (!string.IsNullOrWhiteSpace(ConnectionMngr.GameHost))
                    MainUI.GameData.Host = ConnectionMngr.GameHost;

                Task connectTask = MainUI.Connection.ConnectAsync(
                    MainUI.GameData.Host, _possiblePorts.ToArray());

                StatusTxt.SetDotAnimation("Intercepting Connection({0})",
                    MainUI.GameData.Port.Replace(",", ", "));
            }
        }
        private void ExtractHostPort(object sender, EavesdropperResponseEventArgs e)
        {
            string responseBody = Encoding.UTF8.GetString(e.Payload);
            if (MainUI.GameData == null && responseBody.Contains("info.host"))
            {
                Eavesdropper.EavesdropperResponse -= ExtractHostPort;

                MainUI.GameData = new HGameData(responseBody);
                MainUI.ExtensionMngr.GameData = MainUI.GameData;
                MainUI.ExtensionMngr.Hotel = SKore.ToHotel(MainUI.GameData.Host);
                MainUI.IsRetro = (MainUI.ExtensionMngr.Hotel == HHotel.Unknown);

                if (!MainUI.IsRetro && e.Response.ResponseUri.Segments.Length > 2)
                    MainUI.GameData.UniqueId = e.Response.ResponseUri.Segments[2].TrimEnd('/');

                string ticks = DateTime.Now.Ticks.ToString();
                if (responseBody.Contains("embedSWF("))
                {
                    // Force a non-cached client to be returned.
                    string child = responseBody.GetChild("embedSWF(", ',');
                    responseBody = responseBody.Replace($"embedSWF({child}",
                        $"embedSWF({child} + \"?Tanji-{ticks}\"");
                }
                else
                {
                    // Force all swf objects to return a non-cached version.
                    responseBody = responseBody.Replace(
                        ".swf", ".swf?Tanji-" + ticks);
                }
                if (MainUI.IsRetro)
                {
                    // TODO: Possibly randomize the variable name?
                    // Add custom variable that will replace "connection.info.host" in the client.
                    responseBody = responseBody.Replace("\"connection.info.host",
                        "\"tanji.connection.info.host\" : \"127.0.0.1\", \r\n\"connection.info.host");
                }
                else if (MainUI.Game == null) TryLoadModdedClient();
                e.Payload = Encoding.UTF8.GetBytes(responseBody);

                if (MainUI.Game != null) Eavesdropper.EavesdropperRequest += InjectClient;
                else Eavesdropper.EavesdropperResponse += ReplaceClient;

                StatusTxt.SetDotAnimation((MainUI.Game == null ?
                    "Intercepting" : "Injecting") + " Client");
            }
        }

        private bool TryAddPort(string port)
        {
            ushort possiblePort = 0;
            if (ushort.TryParse(port, out possiblePort))
            {
                if (possiblePort < 1024) return false;
                if (!_possiblePorts.Contains(possiblePort))
                {
                    _possiblePorts.Add(possiblePort);
                    return true;
                }
            }
            return false;
        }
        private void HandleConstants(IEnumerable<DoABCTag> abcTags)
        {
            foreach (DoABCTag abcTag in abcTags)
            {
                if (abcTag.Name != "frame2") continue;

                ABCFile abc = abcTag.ABC;
                ASConstants constants = abc.Constants;
                for (int i = 1; i < constants.Strings.Count; i++)
                {
                    string cString = constants.Strings[i];
                    switch (cString)
                    {
                        case "connection.info.host":
                        {
                            constants.Strings[i] = "tanji.connection.info.host";
                            break;
                        }
                        default:
                        {
                            if (cString.Length < 3) continue;
                            if (cString.Length < 6 && TryAddPort(cString)) continue;

                            // TODO: Check 'SocketConnection.init' if a host/port has been hard-coded to override the external params.
                            if (cString.Length <= 15 &&
                                _ipMatcher.Match(cString).Success)
                            {
                                MainUI.GameData.Host = cString;
                                constants.Strings[i] = "127.0.0.1";
                            }
                            break;
                        }
                    }
                }
                break;
            }
        }

        private void DoCancelConnect()
        {
            DoConnectCleanup();
            MainUI.Connection.Disconnect();

            _possiblePorts.Clear();

            MainUI.Game = null;
            MainUI.GameData = null;
        }
        private void DoConnectCleanup()
        {
            Eavesdropper.Terminate();
            HConnection.RestoreHosts();

            Eavesdropper.EavesdropperRequest -= InjectClient;
            Eavesdropper.EavesdropperResponse -= ReplaceClient;
            Eavesdropper.EavesdropperResponse -= ExtractHostPort;

            ConnectBtn.Text = "Connect";
            StatusTxt.StopDotAnimation("Standing By...");
        }
        private void DoAutomaticConnect()
        {
            Eavesdropper.EavesdropperResponse += ExtractHostPort;
            Eavesdropper.Initiate(ConnectionMngr.ProxyPort);

            StatusTxt.SetDotAnimation("Extracting Host/Port");
        }

        private bool TryLoadModdedClient()
        {
            string possibleClientPath = Path.Combine("Modified Clients",
                MainUI.GameData.MovieName + ".swf");

            return VerifyGameClientAsync(possibleClientPath).Result;
        }
        private void CreateTrustedRootCertificate()
        {
            while (!Eavesdropper.Certificates.CreateTrustedRootCertificate())
            {
                BringToFront();
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to intercept HTTPS traffic.\r\n\r\nWould you like to retry the process?",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result != DialogResult.Yes)
                {
                    Close();
                    break;
                }
            }
        }

        private async Task<bool> VerifyGameClientAsync(string path)
        {
            if (!File.Exists(path)) return false;

            return await VerifyGameClientAsync(
                new HFlash(path)).ConfigureAwait(false);
        }
        private async Task<bool> VerifyGameClientAsync(HFlash game)
        {
            if (game.IsCompressed)
            {
                StatusTxt.SetDotAnimation("Decompressing");

                await Task.Factory.StartNew(
                    game.Decompress).ConfigureAwait(false);
            }

            if (!game.IsCompressed)
            {
                MainUI.Game = game;

                StatusTxt.SetDotAnimation("Disassembling");
                MainUI.Game.ReadTags();
            }

            return MainUI.Game != null;
        }

        private void CTDestroyCertificatesBtn_Click(object sender, EventArgs e)
        {
            Eavesdropper.Certificates.DestroySignedCertificates();
            CreateTrustedRootCertificate();
        }
        private void CTExportRootCertificateAuthorityBtn_Click(object sender, EventArgs e)
        {
            string name = "EavesdropRoot";

            bool exportSuccess = Eavesdropper.Certificates
                .ExportTrustedRootCertificate(name + ".cer");

            string message = (exportSuccess
                ? $"Successfully exported {name} to:\r\n{Path.GetFullPath(name + ".cer")}"
                : $"Failed to export {name} certificate authority.");

            MessageBox.Show(message,
                "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}