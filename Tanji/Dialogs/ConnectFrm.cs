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
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Tanji.Managers;

using Sulakore;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using Eavesdrop;

using FlashInspect;
using FlashInspect.Tags;
using FlashInspect.Bytecode.DataTypes;
using System.Diagnostics;

namespace Tanji.Dialogs
{
    public partial class ConnectFrm : Form
    {
        private readonly Regex _ipMatcher;
        private readonly IList<ushort> _possiblePorts;

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
            _ipMatcher = new Regex(
                "^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$");

            if (!Directory.Exists("Modified Clients"))
                Directory.CreateDirectory("Modified Clients");

            CreateTrustedRootCertificate();
            Eavesdropper.IsSslSupported = true;
        }

        private async void ConnectFrm_Shown(object sender, EventArgs e)
        {
            CTBrowseBtn.Enabled =
                ConnectBtn.Enabled = false;
            StatusTxt.SetDotAnimation("Checking for updates");

            try
            {
                if (await MainUI.UpdateUI.CheckForUpdatesAsync())
                {
                    WindowState = FormWindowState.Minimized;
                    StatusTxt.StopDotAnimation("Update Found!");
                    MainUI.UpdateUI.ShowDialog();
                }
            }
            catch { /* Update check failed. */ }
            finally
            {
                CTBrowseBtn.Enabled =
                    ConnectBtn.Enabled = true;

                StatusTxt.StopDotAnimation("Standing By...");
                WindowState = FormWindowState.Normal;
            }
        }
        private void ConnectFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DoConnectCleanup();
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
                MessageBox.Show("Unable to disassemble the Shockwave Flash(.swf) file.",
                    "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CTCustomClientTxt.Text = verifySuccess ?
                MainUI.Game.Location : string.Empty;
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

        private void InjectClient(object sender, EavesdropperRequestEventArgs e)
        {
            if (e.Request.RequestUri.OriginalString.Contains(".swf?Tanji-"))
            {
                Eavesdropper.EavesdropperRequest -= InjectClient;
                e.Request = WebRequest.Create(new Uri(MainUI.Game.Location));
            }
        }
        private void ReplaceClient(object sender, EavesdropperResponseEventArgs e)
        {
            bool isLocal = false;
            if (e.Payload.Length > 3000000 &&
                e.Response.ContentType == "application/x-shockwave-flash" ||
                (isLocal = File.Exists(e.Response.ResponseUri.LocalPath)))
            {
                string[] ports = MainUI.GameData.Port.Split(',');
                if (MainUI.Game == null)
                {
                    bool verifySuccess = VerifyGameClientAsync(
                        new ShockwaveFlash(e.Payload)).Result;

                    if (verifySuccess)
                    {
                        StatusTxt.SetDotAnimation("Extracting Tags");
                        var flashTags = MainUI.Game.ExtractTags();

                        IEnumerable<FlashTag> tags = null;
                        if (MainUI.IsRetro)
                        {
                            tags = flashTags.OfType<DoABCTag>();
                            foreach (string port in ports)
                            {
                                ushort possiblePort = 0;
                                if (ushort.TryParse(port, out possiblePort) &&
                                    !_possiblePorts.Contains(possiblePort))
                                {
                                    _possiblePorts.Add(possiblePort);
                                }
                            }
                        }
                        else tags = flashTags.OfType<DefineBinaryDataTag>();

                        ModifyTags(tags);
                        StatusTxt.SetDotAnimation("Rebuilding Client");
                        MainUI.Game.Rebuild();
                    }

                    if (!MainUI.IsRetro)
                    {
                        MainUI.Game.Save(Path.Combine("Modified Clients",
                            MainUI.GameData.MovieName + ".swf"));
                    }
                }

                e.Payload = MainUI.Game.Data;
                MainUI.GameData.Port = ports[0];

                if (!MainUI.IsRetro)
                    _possiblePorts.Add(ushort.Parse(MainUI.GameData.Port));

                Eavesdropper.EavesdropperResponse -= ReplaceClient;
                Eavesdropper.Terminate();

                Task connectTask = MainUI.Connection
                    .ConnectAsync(MainUI.GameData.Host, _possiblePorts.ToArray());

                StatusTxt.SetDotAnimation(
                    "Intercepting Connection({0})", MainUI.GameData.Port);
            }
        }
        private void ExtractHostPort(object sender, EavesdropperResponseEventArgs e)
        {
            string responseBody = Encoding.UTF8.GetString(e.Payload);
            if (MainUI.GameData == null && responseBody.Contains("info.host"))
            {
                MainUI.GameData = new HGameData(responseBody);
                MainUI.ExtensionMngr.GameData = MainUI.GameData;
                MainUI.ExtensionMngr.Hotel = SKore.ToHotel(MainUI.GameData.Host);
                MainUI.IsRetro = (MainUI.ExtensionMngr.Hotel == HHotel.Unknown);

                bool isSourceReadable = false;
                if (MainUI.IsRetro)
                {
                    MainUI.GameData["tanji.connection.info.host"] = "127.0.0.1";
                    MainUI.GameData["tanji.client.starting"] = "Peeling Tangerines...";

                    if (!string.IsNullOrWhiteSpace(MainUI.GameData.MovieUrl) &&
                        !string.IsNullOrWhiteSpace(MainUI.GameData.BaseUrl))
                    {
                        isSourceReadable = true;
                        MainUI.GameData.MovieUrl += "?" + DateTime.Now.Ticks;
                    }
                    else
                    {
                        responseBody = responseBody.Replace(MainUI.GameData.Host,
                            (MainUI.GameData.Host + "\", \"tanji.connection.info.host\":\"127.0.0.1\", \"tanji.client.starting\":\"Peeling Tangerines..."));
                    }
                }

                if (!MainUI.IsRetro && MainUI.Game == null)
                    TryLoadModdedClientAsync().Wait();

                StatusTxt.SetDotAnimation((MainUI.Game == null ?
                    "Intercepting" : "Injecting") + " Client");

                if (responseBody.Contains("embedSWF("))
                {
                    string child = responseBody.GetChild("embedSWF(", ',');

                    responseBody = responseBody.Replace($"embedSWF({child}",
                        $"embedSWF({child} + \"?Tanji-{DateTime.Now.Ticks}\"");
                }


                Eavesdropper.EavesdropperResponse -= ExtractHostPort;
                Eavesdropper.EavesdropperResponse += ReplaceClient;

                if (!MainUI.IsRetro && MainUI.Game != null)
                    Eavesdropper.EavesdropperRequest += InjectClient;

                e.Payload = Encoding.UTF8.GetBytes(
                    MainUI.IsRetro && isSourceReadable ?
                    MainUI.GameData.ToString() : responseBody);
            }
        }

        private string ReplaceConstant(string constant)
        {
            bool modulusFound = false,
                exponentFound = false;

            switch (constant)
            {
                case "10001":
                {
                    exponentFound = true;
                    MainUI.HandshakeMngr.RealExponent = 10001;
                    constant = HandshakeManager.FAKE_EXPONENT.ToString();
                    break;
                }
                case "localhost":
                {
                    constant = "tsohlacol";
                    break;
                }
                case "client.starting":
                {
                    if (MainUI.GameData.ContainsKey("tanji.client.starting"))
                        constant = "tanji.client.starting";

                    break;
                }
                case "connection.info.host":
                {
                    if (MainUI.GameData.ContainsKey("tanji.connection.info.host"))
                        constant = "tanji.connection.info.host";

                    break;
                }

                default:
                {
                    if (constant.Length == 256)
                    {
                        modulusFound = true;
                        if (string.IsNullOrWhiteSpace(MainUI.HandshakeMngr.RealModulus))
                        {
                            MainUI.HandshakeMngr.RealModulus = constant;
                            constant = HandshakeManager.FAKE_MODULUS;
                        }
                    }
                    else if (constant.Length <= 15 &&
                        _ipMatcher.Match(constant).Success)
                    {
                        MainUI.GameData.Host = constant;
                        constant = "127.0.0.1";
                    }
                    break;
                }
            }

            if (MainUI.HandshakeMngr.RealExponent == 0 &&
                !exponentFound && modulusFound)
            {
                MainUI.HandshakeMngr.RealExponent = 3;
            }
            return constant;
        }
        private void ExtractRsaKeys(string base64RsaKeys)
        {
            byte[] rsaKeyData = Convert.FromBase64String(base64RsaKeys);
            string mergedRsaKeys = Encoding.UTF8.GetString(rsaKeyData);

            int modLength = mergedRsaKeys[0];
            string modulus = mergedRsaKeys.Substring(1, modLength);

            mergedRsaKeys = mergedRsaKeys.Substring(modLength);
            int exponent = int.Parse(mergedRsaKeys.Substring(2));

            if (string.IsNullOrWhiteSpace(MainUI.HandshakeMngr.RealModulus))
                MainUI.HandshakeMngr.RealModulus = modulus;

            if (MainUI.HandshakeMngr.RealExponent == 0)
                MainUI.HandshakeMngr.RealExponent = exponent;
        }
        private string EncodeRsaKeys(int exponent, string modulus)
        {
            string mergedKeys = string.Format("{0}{1} {2}",
                (char)modulus.Length, modulus, exponent);

            byte[] data = Encoding.UTF8.GetBytes(mergedKeys);
            return Convert.ToBase64String(data);
        }

        private void ModifyAbc(DoABCTag abcTag)
        {
            CPoolInfo constants = abcTag.ABCData.ConstantPool;
            StatusTxt.SetDotAnimation("Squeezing ({0})", abcTag.Name);

            for (int i = 1; i < constants.Strings.Length; i++)
            {
                string constant = constants.Strings[i];
                if (constant.Length > 256 || constant.Length < 2) continue;

                if (constant.Length > 2 && constant.Length < 6)
                {
                    ushort possiblePort = 0;
                    if (ushort.TryParse(constant, out possiblePort))
                    {
                        if (!_possiblePorts.Contains(possiblePort))
                            _possiblePorts.Add(possiblePort);

                        if (constant != "10001") continue;
                    }
                }

                constants.Strings[i] =
                    ReplaceConstant(constant);
            }
        }
        private void ModifyTags(IEnumerable<FlashTag> tags)
        {
            foreach (FlashTag tag in tags)
            {
                switch (tag.TagType)
                {
                    case FlashTagType.DefineBinaryData:
                    {
                        ModifyBin((DefineBinaryDataTag)tag);
                        break;
                    }

                    case FlashTagType.DoABC:
                    case FlashTagType.DoABC2:
                    {
                        ModifyAbc((DoABCTag)tag);
                        break;
                    }
                }
            }
        }
        private void ModifyBin(DefineBinaryDataTag binaryTag)
        {
            string binaryDataBody = Encoding.UTF8
                .GetString(binaryTag.BinaryData);

            if (binaryDataBody.Contains("habbo_login_dialog"))
            {
                string realRsaKeys = binaryDataBody
                    .GetChild("name=\"dummy_field\" caption=\"", '"');

                if (string.IsNullOrWhiteSpace(realRsaKeys)) return;
                ExtractRsaKeys(realRsaKeys);

                string fakeRsaKeys = EncodeRsaKeys(
                    HandshakeManager.FAKE_EXPONENT, HandshakeManager.FAKE_MODULUS);

                binaryTag.BinaryData = Encoding.UTF8.GetBytes(
                    binaryDataBody.Replace(realRsaKeys, fakeRsaKeys));
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
            Eavesdropper.EavesdropperRequest -= InjectClient;
            Eavesdropper.EavesdropperResponse -= ReplaceClient;
            Eavesdropper.EavesdropperResponse -= ExtractHostPort;

            ConnectBtn.Text = "Connect";
            StatusTxt.StopDotAnimation("Standing By...");

            HConnection.RestoreHosts();
        }
        private void DoAutomaticConnect()
        {
            Eavesdropper.EavesdropperResponse += ExtractHostPort;
            Eavesdropper.Initiate(8080);

            StatusTxt.SetDotAnimation("Extracting Host/Port");
        }

        private void CreateTrustedRootCertificate()
        {
            while (!Eavesdropper.CertificateMngr.CreateTrustedRootCertificate())
            {
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to intercept HTTPS traffic.\r\n\r\nWould you like to retry the process?",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.No)
                {
                    Close();
                    return;
                }
            }
            Eavesdropper.CertificateMngr.ExportTrustedRootCertificate("EavesdropRoot.cer");
        }
        private async Task<bool> TryLoadModdedClientAsync()
        {
            string possibleClientPath = Path.Combine("Modified Clients",
                MainUI.GameData.MovieName + ".swf");

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

        private Task<bool> VerifyGameClientAsync(string path)
        {
            return VerifyGameClientAsync(new ShockwaveFlash(path));
        }
        private async Task<bool> VerifyGameClientAsync(ShockwaveFlash flash)
        {
            if (flash.IsCompressed)
            {
                StatusTxt.SetDotAnimation("Decompressing Client");
                bool decompressed = await flash.DecompressAsync()
                    .ConfigureAwait(false);
            }

            if (!flash.IsCompressed)
                MainUI.Game = flash;

            return MainUI.Game != null;
        }

        private void CTDestroyCertificatesBtn_Click(object sender, EventArgs e)
        {
            Eavesdropper.CertificateMngr.DestroySignedCertificates();
            CreateTrustedRootCertificate();
        }
    }
}