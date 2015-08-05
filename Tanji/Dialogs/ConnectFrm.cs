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

namespace Tanji.Dialogs
{
    public partial class ConnectFrm : Form
    {
        private bool _hasCorrectPort;
        private readonly Regex _ipMatcher;

        public MainFrm MainUI { get; }

        public bool IsConnecting { get; private set; }
        public bool IsReplacingClient { get; private set; }
        public bool IsExtracingHostPort { get; private set; }

        public ConnectFrm(MainFrm main)
        {
            InitializeComponent();
            MainUI = main;

            _ipMatcher = new Regex(
                "^(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)(\\.(25[0-5]|2[0-4]\\d|[0-1]?\\d?\\d)){3}$");

            if (!Directory.Exists("Modified Clients"))
                Directory.CreateDirectory("Modified Clients");

            CreateTrustedRootCertificate();
            Eavesdropper.IsSslSupported = true;
        }

        private async void ConnectFrm_Shown(object sender, EventArgs e)
        {
            BrowseBtn.Enabled =
                ConnectBtn.Enabled = ModePnl.Enabled = false;
            StatusTxt.SetDotAnimation("Searching For Updates");

            try
            {
                if (await MainUI.CheckForUpdatesTask)
                {
                    StatusTxt.StopDotAnimation("Update Found!");
                    MainUI.UpdateUI.ShowDialog();
                }
            }
            catch { /* Update check failed. */ }
            finally
            {
                BrowseBtn.Enabled =
                    ConnectBtn.Enabled = ModePnl.Enabled = true;

                StatusTxt.StopDotAnimation("Standing By...");
            }
        }
        private void ConnectFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (IsReplacingClient)
                    Eavesdropper.EavesdropperResponse -= ReplaceClient;

                if (IsExtracingHostPort)
                    Eavesdropper.EavesdropperResponse -= ExtractHostPort;

                ResetInterface();
                Eavesdropper.Terminate();
                HConnection.RestoreHosts();
            }
            finally
            {
                if (!MainUI.Connection.IsConnected)
                    Environment.Exit(0);
            }
        }

        private void ModeChanged(object sender, EventArgs e)
        {
            GameHostTxt.ReadOnly =
                GamePortTxt.ReadOnly = !ModePnl.IsManual;

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
                MessageBox.Show("Unable to disassemble the Shockwave Flash(.swf) file.",
                    "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CustomClientTxt.Text = verifySuccess ?
                MainUI.Game.Location : string.Empty;
        }
        private async void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (IsConnecting = !IsConnecting)
            {
                ModePnl.Enabled = !(GameHostTxt.ReadOnly =
                    GamePortTxt.ReadOnly = ExponentTxt.ReadOnly = ModulusTxt.ReadOnly = true);

                ConnectBtn.Text = "Cancel";
                if (ModePnl.IsManual && !(await DoManualConnectAsync()))
                {
                    if (!IsConnecting) return;

                    ResetInterface();
                    MessageBox.Show("Something went wrong when attempting to intercept the connection.",
                        "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else DoAutomaticConnect();
            }
            else DoCancelConnect();
        }

        private void ReplaceClient(object sender, EavesdropperResponseEventArgs e)
        {
            if (e.Payload.Length > 3000000 &&
                e.Response.ContentType == "application/x-shockwave-flash")
            {
                if (MainUI.Game == null)
                {
                    bool verifySuccess = VerifyGameClientAsync(
                        new ShockwaveFlash(e.Payload)).Result;

                    if (verifySuccess)
                    {
                        StatusTxt.SetDotAnimation("Extracting Tags");
                        var flashTags = MainUI.Game.ExtractTags();

                        IEnumerable<FlashTag> viTags = null;
                        if (MainUI.IsRetro) viTags = flashTags.OfType<DoABCTag>();
                        else viTags = flashTags.OfType<DefineBinaryDataTag>();

                        SearchFlashTags(viTags);

                        StatusTxt.SetDotAnimation("Rebuilding Client");
                        MainUI.Game.Rebuild();
                    }

                    if (!MainUI.IsRetro)
                    {
                        MainUI.Game.Save(Path.Combine("Modified Clients",
                            MainUI.GameData.FlashClientBuild + ".swf"));
                    }
                }

                e.Payload = MainUI.Game.Data;

                Eavesdropper.EavesdropperResponse -= ReplaceClient;
                Eavesdropper.Terminate();

                Task connectTask = MainUI.Connection
                    .ConnectAsync(MainUI.GameData.Host, MainUI.GameData.Port);

                StatusTxt.SetDotAnimation("Intercepting Connection({0})", MainUI.GameData.Port);
            }
        }
        private void ExtractHostPort(object sender, EavesdropperResponseEventArgs e)
        {
            string responseBody = Encoding.UTF8.GetString(e.Payload);
            if (responseBody.Contains("info.host"))
            {
                MainUI.GameData = new HGameData(responseBody);
                MainUI.ExtensionMngr.Hotel = SKore.ToHotel(MainUI.GameData.Host);
                MainUI.IsRetro = (MainUI.ExtensionMngr.Hotel == HHotel.Unknown);

                if (MainUI.IsRetro)
                {
                    responseBody = responseBody
                        .Replace(MainUI.GameData.Host, "127.0.0.1")
                        .Replace(MainUI.GameData.ClientStarting, "Peeling Tangerines...");
                }

                if (!MainUI.IsRetro && MainUI.Game == null)
                    TryLoadModdedClientAsync().Wait();

                StatusTxt.SetDotAnimation((MainUI.Game == null ?
                    "Intercepting" : "Replacing") + " Client");

                responseBody = responseBody.Replace(".swf?", ".swf")
                    .Replace(".swf", ".swf?" + DateTime.Now.Ticks);

                Eavesdropper.EavesdropperResponse -= ExtractHostPort;
                Eavesdropper.EavesdropperResponse += ReplaceClient;

                e.Payload = Encoding.UTF8.GetBytes(responseBody);
            }
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

        private void ReplaceABC(DoABCTag abcTag)
        {
            bool foundModInABC = false;
            bool containedDefaultExpInABC = false;

            CPoolInfo cPool = abcTag.ABCData.ConstantPool;
            StatusTxt.SetDotAnimation("Squeezing ({0})", abcTag.Name);

            var ignorePorts = new List<string>();
            var possiblePorts = new List<ushort>();
            for (int i = 1; i < cPool.Strings.Length; i++)
            {
                string cString = cPool.Strings[i];
                if (cString.Length > 256 || cString.Length < 2) continue;

                if (cString.Length > 2 && cString.Length < 6)
                {
                    ushort possiblePort = 0;
                    if (ushort.TryParse(cString, out possiblePort))
                    {
                        if (!possiblePorts.Contains(possiblePort) &&
                            !ignorePorts.Contains(cString))
                        {
                            possiblePorts.Add(possiblePort);
                        }
                    }
                }

                if (cPool.Strings[i].Length == 256)
                {
                    foundModInABC = true;
                    if (string.IsNullOrWhiteSpace(MainUI.HandshakeMngr.RealModulus))
                    {
                        MainUI.HandshakeMngr.RealModulus = cString;
                        cPool.Strings[i] = HandshakeManager.FAKE_MODULUS;
                    }
                }
                else if (cString == "10001")
                {
                    containedDefaultExpInABC = true;
                    cPool.Strings[i] = HandshakeManager.FAKE_EXPONENT.ToString();
                }
                else if (_ipMatcher.Match(cString).Success)
                {
                    MainUI.GameData.Host = cString;
                    cPool.Strings[i] = "127.0.0.1";
                }
                else if (cString == "localhost")
                {
                    cPool.Strings[i] = "tsohlacol";
                }
            }

            if (foundModInABC &&
                !containedDefaultExpInABC && MainUI.IsRetro)
            {
                MainUI.HandshakeMngr.RealExponent = 3;
            }

            if (_hasCorrectPort) return;
            possiblePorts.Insert(0, (ushort)MainUI.GameData.Port);
            foreach (ushort possiblePort in possiblePorts)
            {
                if (AttemptConnect(possiblePort, ignorePorts))
                {
                    _hasCorrectPort = true;
                    MainUI.GameData.Port = possiblePort;
                    break;
                }
            }
        }
        private void ReplaceBIN(DefineBinaryDataTag binaryTag)
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

                return;
            }
        }
        private void SearchFlashTags(IEnumerable<FlashTag> viTags)
        {
            foreach (FlashTag tag in viTags)
            {
                switch (tag.TagType)
                {
                    case FlashTagType.DefineBinaryData:
                    {
                        ReplaceBIN((DefineBinaryDataTag)tag);
                        break;
                    }

                    case FlashTagType.DoABC:
                    case FlashTagType.DoABC2:
                    {
                        ReplaceABC((DoABCTag)tag);
                        break;
                    }
                }
            }
        }
        private bool AttemptConnect(ushort possiblePort, IList<string> ignorePorts)
        {
            Task<HNode> connectTask = HNode.ConnectAsync
                (MainUI.GameData.Host, possiblePort);

            Task timeout = Task.Delay(1250);
            Task completed = Task.WhenAny(connectTask, timeout).Result;
            if (completed == connectTask && !connectTask.IsFaulted)
            {
                using (HNode remote = connectTask.Result)
                {
                    try
                    {
                        var pingPacket = new byte[6] { 0, 0, 0, 2, 0, 0 };
                        remote.SendAsync(pingPacket).Wait();

                        var buffer = new byte[6];
                        Task<int> receiveTask = remote.ReceiveAsync(buffer, 0, 6);

                        timeout = Task.Delay(500);
                        completed = Task.WhenAny(receiveTask, timeout).Result;

                        return (receiveTask.Status != TaskStatus.Faulted);
                    }
                    catch { return false; }
                }
            }
            else ignorePorts.Add(possiblePort.ToString());
            return false;
        }

        private void DoCancelConnect()
        {
            ResetInterface();
            Eavesdropper.Terminate();
            MainUI.Connection.Disconnect();
        }
        private void DoAutomaticConnect()
        {
            Eavesdropper.EavesdropperResponse += ExtractHostPort;
            Eavesdropper.Initiate(8080);

            StatusTxt.SetDotAnimation("Extracting Host/Port");
        }
        private async Task<bool> DoManualConnectAsync()
        {
            StatusTxt.SetDotAnimation("Intercepting Connection");

            await MainUI.Connection.ConnectAsync(
                GameHostTxt.Text, int.Parse(GamePortTxt.Text));

            return MainUI.Connection.IsConnected;
        }

        private void ResetInterface()
        {
            IsConnecting = false;
            ConnectBtn.Text = "Connect";
            StatusTxt.StopDotAnimation("Standing By...");
            GameHostTxt.ReadOnly = GamePortTxt.ReadOnly = !ModePnl.IsManual;
            ModePnl.Enabled = !(ExponentTxt.ReadOnly = ModulusTxt.ReadOnly = false);
        }
        private void CreateTrustedRootCertificate()
        {
            while (!Eavesdropper.CreateTrustedRootCertificate())
            {
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to decrypt HTTPS traffic.\r\n\r\nWould you like to retry the process?\r\n\r\n",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.No)
                    Environment.Exit(0);
            }
        }
        private async Task<bool> TryLoadModdedClientAsync()
        {
            string possibleClientPath = Path.Combine("Modified Clients",
                MainUI.GameData.FlashClientBuild + ".swf");

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
    }
}