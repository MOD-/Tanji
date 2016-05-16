using System;
using System.IO;
using System.Net;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

using Tanji.Manipulators;

using Sulakore;
using Sulakore.Communication;

using Tangine.Habbo;

using Eavesdrop;
using System.Linq;
using Sulakore.Protocol.Encryption;
using Sulakore.Protocol;

namespace Tanji.Components.Pages
{
    [DesignerCategory("UserControl")]
    public partial class ConnectionPage : PageControl, IReceiver
    {
        private const string EAVESDROP_ROOT_CERTIFICATE_NAME = "EavesdropRoot.cer";

        #region Tanji States(Constants)
        private const string STANDING_BY = "Standing By";
        private const string EXTRACTING_GAME_DATA = "Extracing Game Data";
        private const string INTERCEPTING_CLIENT = "Intercepting Client";
        private const string MODIFYING_CLIENT = "Modifying Client";
        private const string INJECTING_CLIENT = "Injecting Client";

        private const string COMPRESSING_CLIENT = "Compressing Client";
        private const string DECOMPRESSING_CLIENT = "Decompressing Client";

        private const string ASSEMBLING_CLIENT = "Assembling Client";
        private const string DISASSEMBLING_CLIENT = "Disassembling Client";

        private const string REPLACING_RESOURCES = "Replacing Resources";
        private const string INTERCEPTING_CONNECTING = "Intercepting Connection";
        private const string GENERATING_MESSAGE_HASHES = "Generating Message Hashes";
        #endregion

        private static readonly string[] _varNames;
        private readonly DirectoryInfo _modifiedClientsDir;
        private readonly Dictionary<string, string> _replacedVars;

        private string _customClientPath;
        /// <summary>
        /// Gets or sets the path of a custom Habbo Hotel flash client.
        /// </summary>
        [Description("The path of a custom Habbo Hotel flash client.")]
        public string CustomClientPath
        {
            get { return _customClientPath; }
            set
            {
                _customClientPath = value;
                RaiseOnPropertyChanged(nameof(CustomClientPath));
            }
        }

        private ushort _proxyPort = 8081;
        /// <summary>
        /// Gets or sets the port for the local proxy to use.
        /// </summary>
        [DefaultValue(typeof(ushort), "8081")]
        [Description("The port for the local proxy to use.")]
        public ushort ProxyPort
        {
            get { return _proxyPort; }
            set
            {
                _proxyPort = value;
                RaiseOnPropertyChanged(nameof(ProxyPort));
            }
        }

        private string _state = STANDING_BY;
        [Browsable(false)]
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
                RaiseOnPropertyChanged(nameof(State));
            }
        }

        static ConnectionPage()
        {
            _varNames = new string[]
            {
                "productdata.load.url",
                "external.texts.txt",
                "external.variables.txt",
                "external.override.texts.txt",
                "external.figurepartlist.txt",
                "external.override.variables.txt"
            };
        }
        public ConnectionPage()
        {
            _modifiedClientsDir = Directory.CreateDirectory("Modified Clients");
            _replacedVars = new Dictionary<string, string>(_varNames.Length);

            InitializeComponent();
            AssignVariables();

            Bind(ProxyPortTxt, "Value", nameof(ProxyPort));
            Bind(StatusTxt, "BaseAnimation", nameof(State));
            Bind(CustomClientTxt, "Value", nameof(CustomClientPath));
        }

        private void ConnectionPage_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(State):
                {
                    bool isConnecting = (State != STANDING_BY);
                    if (!isConnecting)
                    {
                        foreach (ListViewItem item in VariablesVw.Items)
                        {
                            item.Checked = false;
                        }
                        ConnectBtn.Text = "Connect";
                    }
                    else ConnectBtn.Text = "Cancel";

                    BrowseBtn.Enabled =
                        VariablesVw.CheckBoxes =
                        DestroyCertificatesBtn.Enabled = !isConnecting;

                    StatusTxt.IsAnimating = isConnecting;
                    break;
                }
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            BrowseClientDlg.FileName = string.Empty;
            if (BrowseClientDlg.ShowDialog() == DialogResult.OK)
            {
                CustomClientPath = BrowseClientDlg.FileName;
            }
        }
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            CreateTrustedRootCertificate();
            if (State != STANDING_BY)
            {
                if (State == REPLACING_RESOURCES)
                {
                    Halt();
                    State = STANDING_BY;
                }
                else Cancel();
            }
            else
            {
                if (Master.Connection.IsConnected)
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to disconnect from the current session?\r\nDon't worry, all of your current options/settings will still be intact.",
                        "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.No)
                        return;
                }
                Master.Connection.Disconnect();
                Connect();
            }
        }

        private void SetVariableBtn_Click(object sender, EventArgs e)
        {
            string value = ValueTxt.Value;
            if (string.IsNullOrWhiteSpace(value)) return;

            ListViewItem item = VariablesVw.SelectedItem;
            item.SubItems[1].Text = value;

            if (item.Checked)
            {
                VariablesVw_ItemChecked(sender,
                    new ItemCheckedEventArgs(item));
            }
            else item.Checked = true;
        }
        private void ResetVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item = VariablesVw.SelectedItem;
            item.SubItems[1].Text = string.Empty;
            ValueTxt.Value = string.Empty;

            if (!item.Checked)
            {
                VariablesVw_ItemChecked(sender,
                    new ItemCheckedEventArgs(item));
            }
            else item.Checked = false;
        }

        private void DestroyCertificatesBtn_Click(object sender, EventArgs e)
        {
            Eavesdropper.Certifier.DestroySignedCertificates();
            CreateTrustedRootCertificate();
        }
        private void ExportRootCertificateBtn_Click(object sender, EventArgs e)
        { }

        private void VariablesVw_ItemSelected(object sender, EventArgs e)
        {
            ListViewItem item = VariablesVw.SelectedItem;

            ValueTxt.Value = item.SubItems[1].Text;
            VariableTxt.Value = item.SubItems[0].Text;
        }
        private void VariablesVw_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewItem item = VariablesVw.Items[e.Index];
            if (string.IsNullOrWhiteSpace(item.SubItems[1].Text))
                e.NewValue = CheckState.Unchecked;
        }
        private void VariablesVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string variable = e.Item.SubItems[0].Text;
            string value = e.Item.SubItems[1].Text;

            if (e.Item.Checked)
            {
                _replacedVars[variable] = value;
            }
            else _replacedVars.Remove(variable);
        }
        private void VariablesVw_ItemSelectionStateChanged(object sender, EventArgs e)
        {
            ValueTxt.Value =
                VariableTxt.Value = string.Empty;

            SetVariableBtn.Enabled =
                ResetVariableBtn.Enabled = VariablesVw.HasSelectedItem;
        }

        private void InjectClient(object sender, RequestInterceptedEventArgs e)
        {
            if (e.Request.RequestUri.OriginalString.EndsWith("-Tanji"))
            {
                Eavesdropper.RequestIntercepted -= InjectClient;
                e.Request = WebRequest.Create(new Uri(Master.Game.Location));
                Eavesdropper.ResponseIntercepted += ReplaceClient;
            }
        }
        private void ReplaceClient(object sender, ResponseInterceptedEventArgs e)
        {
            if (e.Response.ContentType != "application/x-shockwave-flash" &&
                !File.Exists(e.Response.ResponseUri.LocalPath)) return;

            Eavesdropper.ResponseIntercepted -= ReplaceClient;
            ushort infoPort = ushort.Parse(Master.GameData.InfoPort.Split(',')[0]);

            if (Master.Game == null)
            {
                VerifyGameClientAsync(e.Payload).Wait();
                State = MODIFYING_CLIENT;

                Master.Game.BypassOriginCheck();
                Master.Game.BypassRemoteHostCheck();
                Master.Game.ReplaceRSAKeys(FAKE_EXPONENT, FAKE_MODULUS);
                // TODO: Master.ModulesPg.ModifyGame(Master.Game);

                State = ASSEMBLING_CLIENT;
                Master.Game.Assemble();

                State = COMPRESSING_CLIENT;
                e.Payload = Master.Game.Compress();

                string clientPath = Path.Combine(
                    _modifiedClientsDir.FullName, Master.Game.GetClientRevision());

                Directory.CreateDirectory(clientPath);
                File.WriteAllBytes(clientPath + "\\Habbo.swf", e.Payload);
            }
            else
            {
                // TODO: if (Master.ModulesPg.ModifyGame(Master.Game))
                //    Master.Game.Assemble();

                e.Payload = Master.Game.ToByteArray();
            }

            if (_replacedVars.Count > 0)
            {
                Eavesdropper.ResponseIntercepted += ReplaceResources;
            }
            else Halt();

            State = INTERCEPTING_CONNECTING;
            Master.Connection.ConnectAsync(Master.GameData.InfoHost,
                infoPort).ContinueWith(ConnectTaskCompleted);
        }
        private void ExtractGameData(object sender, ResponseInterceptedEventArgs e)
        {
            if (e.Response.ContentType != "text/html") return;
            if (State != EXTRACTING_GAME_DATA) return;

            string responseBody = Encoding.UTF8.GetString(e.Payload);
            if (responseBody.Contains("swfobject.embedSWF") &&
                responseBody.Contains("connection.info.host"))
            {
                byte[] replacementData = e.Payload;
                Eavesdropper.ResponseIntercepted -= ExtractGameData;
                try
                {
                    Master.GameData.Update(responseBody);
                    Master.Hotel = SKore.ToHotel(Master.GameData.InfoHost);

                    // TODO: Master.ModulesPg.ModifyGameData(Master.GameData);
                    responseBody = Master.GameData.Source;

                    var clientUri = new Uri(Master.GameData["flash.client.url"]);
                    string clientPath = clientUri.Segments[2].TrimEnd('/');

                    Task<bool> verifyGameClientTask = null;
                    if (!string.IsNullOrWhiteSpace(CustomClientPath))
                    {
                        verifyGameClientTask =
                            VerifyGameClientAsync(CustomClientPath);
                    }
                    if (verifyGameClientTask == null || !verifyGameClientTask.Result)
                    {
                        verifyGameClientTask =
                            VerifyGameClientAsync($"{_modifiedClientsDir.FullName}\\{clientPath}\\Habbo.swf");
                    }

                    string embeddedSwf = responseBody.GetChild("embedSWF(", ',');
                    string nonCachedSwf = $"{embeddedSwf} + \"?{DateTime.Now.Ticks}-Tanji\"";

                    responseBody = responseBody.Replace(
                        "embedSWF(" + embeddedSwf, "embedSWF(" + nonCachedSwf);

                    responseBody = responseBody.Replace(Master.GameData.InfoHost, "127.0.0.1");
                    replacementData = Encoding.UTF8.GetBytes(responseBody);

                    string[] variables = _replacedVars.Keys.ToArray();
                    foreach (string variable in variables)
                    {
                        string fakeValue = _replacedVars[variable];
                        string realValue = Master.GameData[variable].Replace("\\/", "/");

                        _replacedVars.Remove(variable);
                        _replacedVars[realValue] = fakeValue;
                    }
                    if (verifyGameClientTask.Result)
                    {
                        State = INJECTING_CLIENT;
                        Eavesdropper.RequestIntercepted += InjectClient;
                    }
                    else
                    {
                        State = INTERCEPTING_CLIENT;
                        Eavesdropper.ResponseIntercepted += ReplaceClient;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intercepted game data is not recognized as coming from a valid Habbo Hotel site.",
                        "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Master.Log(ex);
                }
                finally
                {
                    if (State == EXTRACTING_GAME_DATA)
                    {
                        Eavesdropper.ResponseIntercepted += ExtractGameData;
                    }
                    else e.Payload = replacementData;
                }
            }
        }
        private void ReplaceResources(object sender, ResponseInterceptedEventArgs e)
        {
            string absoluteUri = e.Response.ResponseUri.AbsoluteUri;
            if (_replacedVars.ContainsKey(absoluteUri))
            {
                var httpResponse = (HttpWebResponse)e.Response;
                string replacementUrl = _replacedVars[absoluteUri];

                if (httpResponse.StatusCode == HttpStatusCode.TemporaryRedirect)
                {
                    _replacedVars.Remove(absoluteUri);
                    absoluteUri = httpResponse.Headers[HttpResponseHeader.Location];
                    _replacedVars[absoluteUri] = replacementUrl;
                    return;
                }

                if (replacementUrl.StartsWith("http"))
                {
                    using (var webClient = new WebClient())
                        e.Payload = webClient.DownloadData(replacementUrl);
                }
                else e.Payload = File.ReadAllBytes(replacementUrl);

                _replacedVars.Remove(absoluteUri);
                if (_replacedVars.Count < 1)
                {
                    Halt();
                    State = STANDING_BY;
                }
            }
        }

        public void Halt()
        {
            Eavesdropper.Terminate();
            Eavesdropper.RequestIntercepted -= InjectClient;
            Eavesdropper.ResponseIntercepted -= ReplaceClient;
            Eavesdropper.ResponseIntercepted -= ExtractGameData;
            Eavesdropper.ResponseIntercepted -= ReplaceResources;
        }
        public void Reset()
        {
            Halt();
            Master.Connection.Disconnect();
            if (Master.Game != null)
            {
                Master.Game.Dispose();
                Master.Game = null;
            }
        }
        public void Cancel()
        {
            Reset();
            State = STANDING_BY;
        }
        public void Connect()
        {
            Eavesdropper.ResponseIntercepted += ExtractGameData;
            Eavesdropper.Initiate(ProxyPort);
            State = EXTRACTING_GAME_DATA;
        }

        public void DestroySignedCertificates()
        {
            Eavesdropper.Certifier.DestroySignedCertificates();
            CreateTrustedRootCertificate();
        }
        public void ExportTrustedRootCertificate()
        {
            string certificatePath =
                Path.GetFullPath(EAVESDROP_ROOT_CERTIFICATE_NAME);

            bool exportSuccess = Eavesdropper.Certifier
                .ExportTrustedRootCertificate(certificatePath);

            string message = (exportSuccess
                ? $"Successfully exported '{EAVESDROP_ROOT_CERTIFICATE_NAME}' to:\r\n\r\n" + certificatePath
                : $"Failed to export '{EAVESDROP_ROOT_CERTIFICATE_NAME}' root certificate.");

            MessageBox.Show(message,
                "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void CreateTrustedRootCertificate()
        {
            while (!Eavesdropper.Certifier.CreateTrustedRootCertificate())
            {
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to intercept HTTPS traffic.\r\n\r\nWould you like to retry the process?",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result != DialogResult.Yes)
                {
                    FindForm().Close();
                    return;
                }
            }
        }

        public async Task<bool> VerifyGameClientAsync(string path)
        {
            if (!File.Exists(path)) return false;
            byte[] data = File.ReadAllBytes(path);

            await VerifyGameClientAsync(path, data)
                .ConfigureAwait(false);

            return (Master.Game != null);
        }
        public async Task<bool> VerifyGameClientAsync(byte[] data)
        {
            await VerifyGameClientAsync(null, data)
                .ConfigureAwait(false);

            return (Master.Game != null);
        }
        private async Task<bool> VerifyGameClientAsync(string path, byte[] data)
        {
            var game = new HGame(data);
            game.Location = path;
            try
            {
                if (game.IsCompressed)
                {
                    State = DECOMPRESSING_CLIENT;
                    await Task.Factory.StartNew(game.Decompress)
                        .ConfigureAwait(false);
                }

                if (game.IsCompressed) return false;
                else Master.Game = game;

                State = DISASSEMBLING_CLIENT;
                Master.Game.Disassemble();

                State = GENERATING_MESSAGE_HASHES;
                Master.Game.GenerateMessageHashes();
                return true;
            }
            catch (Exception ex)
            {
                Master.Log(ex);
                return false;
            }
            finally
            {
                if (Master.Game != game)
                    game.Dispose();
            }
        }

        public override void AssignMaster(IMaster master)
        {
            master.AssignQuickAction(Keys.Alt | Keys.C, ConnectBtn.PerformClick);
            base.AssignMaster(master);
        }

        private void AssignVariables()
        {
            Array.ForEach(_varNames,
                variable => VariablesVw.AddItem(variable, string.Empty));
        }
        private void ConnectTaskCompleted(Task connectTask)
        {
            if (Master.Connection.IsConnected)
            {
                State = (_replacedVars.Count > 0 ?
                    REPLACING_RESOURCES : STANDING_BY);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var skin = new Pen(Color.FromArgb(243, 63, 63)))
            {
                e.Graphics.DrawLine(skin, 3, 218, 466, 218);
                e.Graphics.DrawLine(skin, 3, 277, 466, 277);
            }
            base.OnPaint(e);
        }

        #region IReceiver Implementation
        private const int FAKE_EXPONENT = 3;
        private const string FAKE_MODULUS = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        private const string FAKE_PRIVATE_EXPONENT = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";

        private const int REAL_EXPONENT = 65537;
        private const string REAL_MODULUS = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

        private int _incomingOffset;
        private byte[] _localSharedKey, _remoteSharedKey;

        public HNode Local => Master.Connection.Local;
        public HNode Remote => Master.Connection.Remote;

        /// <summary>
        /// Gets or sets a value that determines whether to process intercepted data from the master.
        /// </summary>
        [DefaultValue(false)]
        [Description("Determines whether to process intercepted data from the master.")]
        public bool IsReceiving { get; set; }

        public void HandleOutgoing(DataInterceptedEventArgs e)
        {
            try
            {
                switch (e.Step)
                {
                    case 3:
                    {
                        ReplaceLocalPublicKey(e);
                        break;
                    }
                    case 4:
                    {
                        FinalizeHandshake();
                        break;
                    }
                }
            }
            catch { CancelHandshake(e); }
            finally { e.IsBlocked = false; }
        }
        public void HandleIncoming(DataInterceptedEventArgs e)
        {
            try
            {
                if (e.Step < 3 && e.Packet.Length == 2)
                {
                    _incomingOffset++;
                    return;
                }
                switch (e.Step - _incomingOffset)
                {
                    case 1:
                    {
                        InitializeKeys();
                        ReplaceRemoteSignedPrimes(e);
                        break;
                    }
                    case 2:
                    {
                        ReplaceRemotePublicKey(e);
                        break;
                    }
                }
            }
            catch { CancelHandshake(e); }
            finally { e.IsBlocked = false; }
        }

        private void InitializeKeys()
        {
            Remote.Exchange = new HKeyExchange(REAL_EXPONENT, REAL_MODULUS);
            Local.Exchange = new HKeyExchange(FAKE_EXPONENT, FAKE_MODULUS, FAKE_PRIVATE_EXPONENT);
        }
        public void RestartHandshake()
        {
            IsReceiving = true;
            _incomingOffset = 0;
        }
        private void FinalizeHandshake()
        {
            _incomingOffset = 0;
            IsReceiving = false;
        }

        private void ReplaceLocalPublicKey(DataInterceptedEventArgs e)
        {
            string localPublicKey = e.Packet.ReadString();
            _localSharedKey = Local.Exchange.GetSharedKey(localPublicKey);

            // Use the same padding the client used when encrypting our public key.
            Remote.Exchange.Padding = Local.Exchange.Padding;

            string remotePublicKey = Remote.Exchange.GetPublicKey();
            e.Packet.ReplaceString(remotePublicKey, 0);
        }
        private void ReplaceRemotePublicKey(DataInterceptedEventArgs e)
        {
            string remotePublicKey = e.Packet.ReadString();
            _remoteSharedKey = Remote.Exchange.GetSharedKey(remotePublicKey);

            // Use the same padding the server used when signing our public key.
            Local.Exchange.Padding = Remote.Exchange.Padding;

            string localPublicKey = Local.Exchange.GetPublicKey();
            e.Packet.ReplaceString(localPublicKey, 0);

            Local.Exchange.Dispose();
            Remote.Exchange.Dispose();

            Local.Decrypter = new Rc4(_localSharedKey);
            Remote.Encrypter = new Rc4(_remoteSharedKey);
        }
        private void ReplaceRemoteSignedPrimes(DataInterceptedEventArgs e)
        {
            string remoteP = e.Packet.ReadString();
            string remoteG = e.Packet.ReadString();
            Remote.Exchange.VerifyDHPrimes(remoteP, remoteG);

            // Use the same padding the server used when signing our generated primes.
            Local.Exchange.Padding = Remote.Exchange.Padding;

            string localP = Local.Exchange.GetSignedP();
            string localG = Local.Exchange.GetSignedG();
            e.Packet = new HMessage(e.Packet.Header, localP, localG);
        }

        private void CancelHandshake(DataInterceptedEventArgs e)
        {
            e.Restore();
            FinalizeHandshake();

            Local.Decrypter = null;
            Remote.Encrypter = null;

            Local.Exchange.Dispose();
            Remote.Exchange.Dispose();
        }
        #endregion
    }
}