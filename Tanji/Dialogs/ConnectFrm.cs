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
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using FlashInspect;
using FlashInspect.IO;
using FlashInspect.Tags;
using FlashInspect.ActionScript;
using FlashInspect.ActionScript.Constants;
using FlashInspect.ActionScript.Multinames;

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
                foreach (string port in ports)
                {
                    ushort possiblePort = 0;
                    if (ushort.TryParse(port, out possiblePort) &&
                        !_possiblePorts.Contains(possiblePort))
                    {
                        _possiblePorts.Add(possiblePort);
                    }
                }

                if (MainUI.Game == null)
                {
                    bool verifySuccess = VerifyGameClientAsync(
                        new ShockwaveFlash(e.Payload)).Result;

                    if (verifySuccess)
                    {
                        IEnumerable<FlashTag> tags = null;
                        if (MainUI.IsRetro) tags = MainUI.Game.Tags.OfType<DoABCTag>();
                        else tags = MainUI.Game.Tags.OfType<DefineBinaryDataTag>();

                        ModifyTags(tags);
                        StatusTxt.SetDotAnimation("Reconstructing");
                        MainUI.Game.Reconstruct();

                        // TODO: Save, and compress client?
                        //StatusTxt.SetDotAnimation("Compressing Client");
                        //MainUI.Game.Compress();
                    }

                    if (!MainUI.IsRetro)
                    {
                        File.WriteAllBytes(Path.Combine("Modified Clients",
                            MainUI.GameData.MovieName + ".swf"), MainUI.Game.ToArray());
                    }
                }

                e.Payload = MainUI.Game.ToArray();
                Eavesdropper.EavesdropperResponse -= ReplaceClient;
                Eavesdropper.Terminate();

                Task connectTask = MainUI.Connection.ConnectAsync(
                    MainUI.GameData.Host, _possiblePorts.ToArray());

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
                    TryLoadModdedClient();

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
            ASConstants constants = abcTag.ABC.Constants;
            StatusTxt.SetDotAnimation("Squeezing ({0})", abcTag.Name);

            for (int i = 1; i < constants.Strings.Count; i++)
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
            if (ConnectionMngr.PublicExponent != 0)
                MainUI.HandshakeMngr.RealExponent = ConnectionMngr.PublicExponent;

            if (!string.IsNullOrWhiteSpace(ConnectionMngr.PublicModulus))
                MainUI.HandshakeMngr.RealModulus = ConnectionMngr.PublicModulus;

            foreach (FlashTag tag in tags)
            {
                switch (tag.Header.TagType)
                {
                    case FlashTagType.DefineBinaryData:
                    {
                        ModifyBin((DefineBinaryDataTag)tag);
                        break;
                    }

                    case FlashTagType.DoABC:
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
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to intercept HTTPS traffic.\r\n\r\nWould you like to retry the process?",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result == DialogResult.No)
                {
                    Close();
                    return;
                }
            }
        }

        private void FindMessages(DoABCTag abcTag)
        {
            ABCFile abc = abcTag.ABC;
            ASClass habboMessages = abc.FindClassByName("HabboMessages");
            if (habboMessages == null) return;

            ASTrait incomingMap = habboMessages.Traits[0];
            ASTrait outgoingMap = habboMessages.Traits[1];

            using (var mapReader = new FlashReader(
                habboMessages.Constructor.Body.Code.ToArray()))
            {
                while (mapReader.Position != mapReader.Length)
                {
                    var op = (OPCode)mapReader.ReadByte();
                    if (op != OPCode.GetLex) continue;

                    int multinameIndex = mapReader.Read7BitEncodedInt();

                    bool isOutgoing = (multinameIndex == outgoingMap.NameIndex);
                    bool isIncoming = (multinameIndex == incomingMap.NameIndex);
                    if (!isOutgoing && !isIncoming) continue;
                    else if (isIncoming) break;

                    op = (OPCode)mapReader.ReadByte();
                    if (op != OPCode.PushShort && op != OPCode.PushByte) continue;

                    int header = mapReader.Read7BitEncodedInt();

                    op = (OPCode)mapReader.ReadByte();
                    if (op != OPCode.GetLex) continue;

                    int messageTypeIndex = mapReader.Read7BitEncodedInt();
                    ASMultiname messageType = abc.Constants.Multinames[messageTypeIndex];

                    ASInstance outgoingType =
                        abc.FindInstanceByName(messageType.ObjName);

                    var outgoingItems = new Tuple<string, string[]>(
                        messageType.ObjName, GetStructure(abc.Constants, outgoingType));

                    MainUI.OutStructs.Add((ushort)header, outgoingItems);
                }
            }
        }
        private string[] GetStructure(ASConstants constants, ASInstance instance)
        {
            ASMethod ctor = instance.Constructor;
            var typeNames = new List<string>(ctor.Parameters.Count);
            foreach (ASParameter param in ctor.Parameters)
            {
                string typeName = string.Empty;
                ASMultiname paramType = param.Type;
                if (paramType.MultinameType == ConstantType.Typename)
                {
                    var genericParam = (Typename)paramType.Data;
                    typeName = genericParam.Type.ObjName + ".<";

                    ASMultiname genericType =
                        constants.Multinames[genericParam.ParameterTypeIndices[0]];

                    typeName += genericType.ObjName + ">";
                }
                else typeName += paramType.ObjName;

                typeNames.Add(typeName.ToLower());
            }
            return typeNames.ToArray();
        }

        private async Task<bool> VerifyGameClientAsync(string path)
        {
            if (!File.Exists(path)) return false;

            return await VerifyGameClientAsync(
                new ShockwaveFlash(path)).ConfigureAwait(false);
        }
        private async Task<bool> VerifyGameClientAsync(ShockwaveFlash flash)
        {
            if (flash.IsCompressed)
            {
                StatusTxt.SetDotAnimation("Decompressing");

                await Task.Factory.StartNew(
                    flash.Decompress).ConfigureAwait(false);
            }

            if (!flash.IsCompressed)
            {
                MainUI.Game = flash;

                StatusTxt.SetDotAnimation("Disassembling");
                MainUI.Game.ReadTags();

                foreach (FlashTag tag in MainUI.Game.Tags)
                {
                    if (tag.Header.TagType != FlashTagType.DoABC) continue;
                    FindMessages((DoABCTag)tag);

                    if (MainUI.OutStructs.Count != 0) break;
                }
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
            Eavesdropper.Certificates.ExportTrustedRootCertificate("EavesdropRoot.cer");
        }
    }
}