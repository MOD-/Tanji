using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Tanji.Pages.Connection.Handlers;

using Sulakore;

using Eavesdrop;

using Tangine.Habbo;

namespace Tanji.Pages.Connection
{
    public enum TanjiState
    {
        StandingBy = 0,
        ExtractingGameData = 1,
        InjectingClient = 2,
        InterceptingClient = 3,
        DecompressingClient = 4,
        CompressingClient = 5,
        DisassemblingClient = 6,
        ModifyingClient = 7,
        AssemblingClient = 8,
        InterceptingConnection = 9,
        ReplacingResources = 10,
        GeneratingMessageHashes = 11
    }

    public class ConnectionPage : TanjiPage
    {
        private const string EAVESDROP_ROOT_CERTIFICATE_NAME = "EavesdropRoot.cer";

        private readonly Action<TanjiState> _setState;
        private readonly DirectoryInfo _modifiedClientsDir;
        private readonly Action<Task> _connectTaskCompleted;

        private ushort _proxyPort = 8081;
        public ushort ProxyPort
        {
            get { return _proxyPort; }
            set
            {
                if (value == 8055)
                {
                    // Reserved for remote module.
                    int difference = (value - _proxyPort);
                    value = (ushort)(8055 + difference);
                }

                _proxyPort = value;
                RaiseOnPropertyChanged(nameof(ProxyPort));
            }
        }

        private TanjiState _state;
        public TanjiState State
        {
            get { return _state; }
            set
            {
                _state = value;
                RaiseOnPropertyChanged(nameof(State));
            }
        }

        private string _customClientPath;
        public string CustomClientPath
        {
            get { return _customClientPath; }
            set
            {
                _customClientPath = value;
                RaiseOnPropertyChanged(nameof(CustomClientPath));
            }
        }

        public HandshakeManager HandshakeMngr { get; }
        public Dictionary<string, string> ResourceReplacements { get; }

        public ConnectionPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            _setState = SetState;
            _connectTaskCompleted = ConnectTaskCompleted;
            _modifiedClientsDir = Directory.CreateDirectory("Modified Clients");

            HandshakeMngr = new HandshakeManager(ui.Connection);

            UI.CoTVariablesVw.AddItem("productdata.load.url", "");
            UI.CoTVariablesVw.AddItem("external.texts.txt", "");
            UI.CoTVariablesVw.AddItem("external.variables.txt", "");
            UI.CoTVariablesVw.AddItem("external.override.texts.txt", "");
            UI.CoTVariablesVw.AddItem("external.figurepartlist.txt", "");
            UI.CoTVariablesVw.AddItem("external.override.variables.txt", "");

            ResourceReplacements = new Dictionary<string, string>(
                UI.CoTVariablesVw.Items.Count);

            UI.CoTProxyPortTxt.DataBindings.Add("Value", this,
                nameof(ProxyPort), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.CoTCustomClientTxt.DataBindings.Add("Text", this,
                nameof(CustomClientPath), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.CoTBrowseBtn.Click += CoTBrowseBtn_Click;
            UI.CoTConnectBtn.Click += CoTConnectBtn_Click;

            UI.CoTDestroyCertificatesBtn.Click += CoTDestroyCertificatesBtn_Click;
            UI.CoTExportRootCertificateBtn.Click += CoTExportRootCertificateBtn_Click;

            UI.CoTClearVariableBtn.Click += CoTClearVariableBtn_Click;
            UI.CoTUpdateVariableBtn.Click += CoTUpdateVariableBtn_Click;

            UI.CoTVariablesVw.ItemChecked += CoTVariablesVw_ItemChecked;
            UI.CoTVariablesVw.ItemSelected += CoTVariablesVw_ItemSelected;
        }

        private void CoTBrowseBtn_Click(object sender, EventArgs e)
        {
            UI.CustomClientDlg.FileName = string.Empty;
            if (UI.CustomClientDlg.ShowDialog() != DialogResult.OK) return;
            CustomClientPath = UI.CustomClientDlg.FileName;
        }
        private void CoTConnectBtn_Click(object sender, EventArgs e)
        {
            if (State != TanjiState.StandingBy)
            {
                // We only want to cancel the resource replacing at this point,
                // since a connection has already been established.
                if (State == TanjiState.ReplacingResources)
                {
                    Halt();
                    DisableReplacements();
                    SetState(TanjiState.StandingBy);
                }
                else Cancel();
            }
            else
            {
                if (UI.Connection.IsConnected)
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to disconnect from the current session?\r\nDon't worry, all of your current options/settings will still be intact.",
                        "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.No)
                        return;
                }

                UI.Connection.Disconnect();
                Connect();
            }
        }

        private void CoTClearVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                UI.CoTVariablesVw.SelectedItem;

            item.SubItems[1].Text = string.Empty;
            UI.CoTClearVariableBtn.Enabled = false;
            UI.CoTValueTxt.Text = string.Empty;
            item.Checked = false;
        }
        private void CoTUpdateVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                UI.CoTVariablesVw.SelectedItem;

            item.SubItems[1].Text =
                UI.CoTValueTxt.Text;

            ToggleClearVariableButton(item);

            if (!item.Checked) item.Checked = true;
            else CoTVariablesVw_ItemChecked(this, new ItemCheckedEventArgs(item));
        }

        private void CoTDestroyCertificatesBtn_Click(object sender, EventArgs e)
        {
            DestroySignedCertificates();
        }
        private void CoTExportRootCertificateBtn_Click(object sender, EventArgs e)
        {
            ExportTrustedRootCertificate();
        }

        private void CoTVariablesVw_ItemSelected(object sender, EventArgs e)
        {
            if (UI.CoTVariablesVw.HasSelectedItem)
            {
                ListViewItem item = UI.CoTVariablesVw.SelectedItem;

                ToggleClearVariableButton(item);
                UI.CoTUpdateVariableBtn.Enabled = true;

                UI.CoTNameTxt.Text = item.Text;
                UI.CoTValueTxt.Text = item.SubItems[1].Text;
            }
            else
            {
                UI.CoTUpdateVariableBtn.Enabled =
                    (UI.CoTClearVariableBtn.Enabled = false);

                UI.CoTNameTxt.Text =
                   (UI.CoTValueTxt.Text = string.Empty);
            }
        }
        private void CoTVariablesVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string name = e.Item.Text;
            string value = e.Item.SubItems[1].Text;
            bool updateValue = (e.Item.Checked && !string.IsNullOrWhiteSpace(value));

            if (updateValue) ResourceReplacements[name] = value;
            else if (ResourceReplacements.ContainsKey(name)) ResourceReplacements.Remove(name);
        }

        private void InjectClient(object sender, RequestInterceptedEventArgs e)
        {
            if (e.Request.RequestUri.OriginalString.EndsWith("-Tanji"))
            {
                Eavesdropper.RequestIntercepted -= InjectClient;
                e.Request = WebRequest.Create(new Uri(UI.Game.Location));
                Eavesdropper.ResponseIntercepted += ReplaceClient;
            }
        }
        private void ReplaceClient(object sender, ResponseInterceptedEventArgs e)
        {
            if (e.Response.ContentType != "application/x-shockwave-flash" &&
                !File.Exists(e.Response.ResponseUri.LocalPath)) return;

            Eavesdropper.ResponseIntercepted -= ReplaceClient;
            ushort infoPort = ushort.Parse(UI.GameData.InfoPort.Split(',')[0]);

            if (UI.Game == null)
            {
                VerifyGameClientAsync(e.Payload).Wait();
                SetState(TanjiState.ModifyingClient);

                UI.Game.BypassOriginCheck();
                UI.Game.BypassRemoteHostCheck();
                UI.Game.ReplaceRSAKeys(HandshakeManager.FAKE_EXPONENT, HandshakeManager.FAKE_MODULUS);
                UI.ModulesPg.ModifyGame(UI.Game);

                SetState(TanjiState.AssemblingClient);
                UI.Game.Assemble();

                SetState(TanjiState.CompressingClient);
                e.Payload = UI.Game.Compress();

                string clientPath = Path.Combine(
                    _modifiedClientsDir.FullName, UI.Game.GetClientRevision());

                Directory.CreateDirectory(clientPath);
                File.WriteAllBytes(clientPath + "\\Habbo.swf", e.Payload);
            }
            else
            {
                if (UI.ModulesPg.ModifyGame(UI.Game))
                    UI.Game.Assemble();

                e.Payload = UI.Game.ToByteArray();
            }

            if (ResourceReplacements.Count > 0)
            {
                Eavesdropper.ResponseIntercepted += ReplaceResources;
            }
            else Halt();

            SetState(TanjiState.InterceptingConnection);
            UI.Connection.ConnectAsync(UI.GameData.InfoHost,
                infoPort).ContinueWith(ConnectTaskCompleted);
        }
        private void ExtractGameData(object sender, ResponseInterceptedEventArgs e)
        {
            if (e.Response.ContentType != "text/html") return;
            if (State != TanjiState.ExtractingGameData) return;

            string responseBody = Encoding.UTF8.GetString(e.Payload);
            if (responseBody.Contains("swfobject.embedSWF") &&
                responseBody.Contains("connection.info.host"))
            {
                byte[] replacementData = e.Payload;
                Eavesdropper.ResponseIntercepted -= ExtractGameData;
                try
                {
                    UI.GameData.Update(responseBody);
                    UI.Hotel = SKore.ToHotel(UI.GameData.InfoHost);

                    UI.ModulesPg.ModifyGameData(UI.GameData);
                    responseBody = UI.GameData.Source;

                    var clientUri = new Uri(UI.GameData["flash.client.url"]);
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

                    responseBody = responseBody.Replace(UI.GameData.InfoHost, "127.0.0.1");
                    replacementData = Encoding.UTF8.GetBytes(responseBody);

                    string[] resourceKeys = ResourceReplacements.Keys.ToArray();
                    foreach (string resourceKey in resourceKeys)
                    {
                        string realValue = UI.GameData[resourceKey]
                            .Replace("\\/", "/");

                        string fakeValue =
                            ResourceReplacements[resourceKey];

                        ResourceReplacements.Remove(resourceKey);
                        ResourceReplacements[realValue] = fakeValue;
                    }
                    if (verifyGameClientTask.Result)
                    {
                        SetState(TanjiState.InjectingClient);
                        Eavesdropper.RequestIntercepted += InjectClient;
                    }
                    else
                    {
                        SetState(TanjiState.InterceptingClient);
                        Eavesdropper.ResponseIntercepted += ReplaceClient;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Intercepted game data is not recognized as coming from a valid Habbo Hotel site.",
                        "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    WriteLog(ex);
                }
                finally
                {
                    if (State == TanjiState.ExtractingGameData)
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
            if (ResourceReplacements.ContainsKey(absoluteUri))
            {
                var httpResponse = (HttpWebResponse)e.Response;
                string replacementUrl = ResourceReplacements[absoluteUri];

                if (httpResponse.StatusCode == HttpStatusCode.TemporaryRedirect)
                {
                    ResourceReplacements.Remove(absoluteUri);
                    absoluteUri = httpResponse.Headers[HttpResponseHeader.Location];
                    ResourceReplacements[absoluteUri] = replacementUrl;
                    return;
                }

                if (replacementUrl.StartsWith("http"))
                {
                    using (var webClient = new WebClient())
                        e.Payload = webClient.DownloadData(replacementUrl);
                }
                else e.Payload = File.ReadAllBytes(replacementUrl);

                ResourceReplacements.Remove(absoluteUri);
                if (ResourceReplacements.Count < 1)
                {
                    Halt();
                    SetState(TanjiState.StandingBy);
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
            DisableReplacements();
            UI.Connection.Disconnect();

            if (UI.Game != null)
            {
                UI.Game.Dispose();
                UI.Game = null;
            }
        }
        public void Cancel()
        {
            Reset();
            SetState(TanjiState.StandingBy);
        }
        public void Connect()
        {
            Eavesdropper.ResponseIntercepted += ExtractGameData;
            Eavesdropper.Initiate(ProxyPort);

            SetState(TanjiState.ExtractingGameData);
        }
        public void SetState(TanjiState state)
        {
            if (UI.InvokeRequired)
            {
                UI.Invoke(_setState, state);
                return;
            }

            UI.CoTConnectBtn.Text =
                (state == TanjiState.StandingBy ?
                "Connect" : "Cancel");

            #region Switch: state
            switch (State = state)
            {
                case TanjiState.StandingBy:
                UI.CoTStatusTxt.StopDotAnimation("Standing By...");
                break;

                case TanjiState.ExtractingGameData:
                UI.CoTStatusTxt.SetDotAnimation("Extracting Game Data");
                break;

                case TanjiState.InjectingClient:
                UI.CoTStatusTxt.SetDotAnimation("Injecting Client");
                break;

                case TanjiState.InterceptingClient:
                UI.CoTStatusTxt.SetDotAnimation("Intercepting Client");
                break;

                case TanjiState.DecompressingClient:
                UI.CoTStatusTxt.SetDotAnimation("Decompressing Client");
                break;

                case TanjiState.CompressingClient:
                UI.CoTStatusTxt.SetDotAnimation("Compressing Client");
                break;

                case TanjiState.DisassemblingClient:
                UI.CoTStatusTxt.SetDotAnimation("Disassembling Client");
                break;

                case TanjiState.ModifyingClient:
                UI.CoTStatusTxt.SetDotAnimation("Modifying Client");
                break;

                case TanjiState.AssemblingClient:
                UI.CoTStatusTxt.SetDotAnimation("Assembling Client");
                break;

                case TanjiState.InterceptingConnection:
                UI.CoTStatusTxt.SetDotAnimation("Intercepting Connection");
                break;

                case TanjiState.ReplacingResources:
                UI.CoTStatusTxt.SetDotAnimation("Replacing Resources");
                break;

                case TanjiState.GeneratingMessageHashes:
                UI.CoTStatusTxt.SetDotAnimation("Generating Message Hashes");
                break;
            }
            #endregion
        }

        protected virtual void ConnectTaskCompleted(Task connectTask)
        {
            if (UI.Connection.IsConnected)
            {
                if (ResourceReplacements.Count > 0)
                {
                    SetState(TanjiState.ReplacingResources);
                }
                else SetState(TanjiState.StandingBy);
            }
        }
        protected override void OnTabSelecting(TabControlCancelEventArgs e)
        {
            if (!UI.Connection.IsConnected)
                UI.TopMost = true;

            base.OnTabSelecting(e);
        }
        protected override void OnTabDeselecting(TabControlCancelEventArgs e)
        {
            UI.TopMost = UI.PacketLoggerUI.TopMost;
            base.OnTabDeselecting(e);
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
            UI.BringToFront();
            while (!Eavesdropper.Certifier.CreateTrustedRootCertificate())
            {
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to intercept HTTPS traffic.\r\n\r\nWould you like to retry the process?",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result != DialogResult.Yes)
                {
                    UI.Close();
                    return;
                }
            }
            UI.BringToFront();
        }

        public async Task<bool> VerifyGameClientAsync(string path)
        {
            if (!File.Exists(path)) return false;
            byte[] data = File.ReadAllBytes(path);

            await VerifyGameClientAsync(path, data)
                .ConfigureAwait(false);

            return (UI.Game != null);
        }
        public async Task<bool> VerifyGameClientAsync(byte[] data)
        {
            await VerifyGameClientAsync(null, data)
                .ConfigureAwait(false);

            return (UI.Game != null);
        }
        protected virtual async Task<bool> VerifyGameClientAsync(string path, byte[] data)
        {
            var game = new HGame(data);
            game.Location = path;
            try
            {
                if (game.IsCompressed)
                {
                    SetState(TanjiState.DecompressingClient);

                    await Task.Factory.StartNew(game.Decompress)
                        .ConfigureAwait(false);
                }

                if (game.IsCompressed) return false;
                else UI.Game = game;

                SetState(TanjiState.DisassemblingClient);
                UI.Game.Disassemble();

                SetState(TanjiState.GeneratingMessageHashes);
                UI.Game.GenerateMessageHashes();

                return true;
            }
            catch (Exception ex)
            {
                WriteLog(ex);
                return false;
            }
            finally
            {
                if (UI.Game != game)
                    game.Dispose();
            }
        }

        protected void DisableReplacements()
        {
            foreach (ListViewItem item in UI.CoTVariablesVw.Items)
                item.Checked = false;
        }
        protected void ToggleClearVariableButton(ListViewItem item)
        {
            UI.CoTClearVariableBtn.Enabled =
                (!string.IsNullOrWhiteSpace(item.SubItems[1].Text));
        }
    }
}