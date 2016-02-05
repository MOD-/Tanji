using System;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Sulakore;
using Sulakore.Habbo;
using Sulakore.Habbo.Web;
using Sulakore.Communication;
using Tanji.Pages.Connection.Managers;

namespace Tanji.Pages.Connection
{
    public enum TanjiState
    {
        StandingBy = 0,
        ExtractingGameData = 1,
        InjectingClient = 2,
        ReplacingClient = 3,
        InterceptingClient = 4,
        DecompressingClient = 5,
        DisassemblingClient = 6,
        ReplacingResources = 7,
        ReconstructingClient = 8,
        InterceptingConnection = 9,
        ModifyingClient = 10
    }

    public class ConnectionPage : TanjiPage
    {
        private const string EAVESDROPPER_ROOT_CERTIFICATE_NAME = "EavesdropperRoot.cer";

        private readonly Action<TanjiState> _setStatus;

        private ushort _proxyPort = 8081;
        public ushort ProxyPort
        {
            get { return _proxyPort; }
            set
            {
                _proxyPort = value;
                RaiseOnPropertyChanged(nameof(ProxyPort));
            }
        }

        public HConnection Connection { get; }
        public HandshakeManager HandshakeMngr { get; }
        public Dictionary<string, string> ResourceReplacements { get; }

        public HFlash Game { get; private set; }
        public HHotel Hotel { get; private set; }
        public TanjiState State { get; private set; }
        public HGameData GameData { get; private set; }

        public ConnectionPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            _setStatus = SetStatus;
            Eavesdropper.IsSslSupported = true;

            Connection = new HConnection();
            HandshakeMngr = new HandshakeManager(Connection);

            UI.CoTVariablesVw.Add("productdata.load.url", "");
            UI.CoTVariablesVw.Add("external.texts.txt", "");
            UI.CoTVariablesVw.Add("external.variables.txt", "");
            UI.CoTVariablesVw.Add("external.override.texts.txt", "");
            UI.CoTVariablesVw.Add("external.figurepartlist.txt", "");
            UI.CoTVariablesVw.Add("external.override.variables.txt", "");

            ResourceReplacements = new Dictionary<string, string>(
                UI.CoTVariablesVw.Items.Count);

            UI.CoTProxyPortTxt.DataBindings.Add("Value", this,
                nameof(ProxyPort), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.CoTConnectBtn.Click += CoTConnectBtn_Click;

            UI.CoTDestroyCertificatesBtn.Click += CoTDestroyCertificatesBtn_Click;
            UI.CoTExportRootCertificateBtn.Click += CoTExportRootCertificateBtn_Click;

            UI.CoTClearVariableBtn.Click += CoTClearVariableBtn_Click;
            UI.CoTUpdateVariableBtn.Click += CoTUpdateVariableBtn_Click;

            UI.CoTVariablesVw.ItemChecked += CoTVariablesVw_ItemChecked;
            UI.CoTVariablesVw.ItemSelected += CoTVariablesVw_ItemSelected;
            UI.CoTVariablesVw.ItemsDeselected += CoTVariablesVw_ItemsDeselected;
        }

        private void CoTConnectBtn_Click(object sender, EventArgs e)
        {
            if (State != TanjiState.StandingBy)
            {
                Cancel();
            }
            else Connect();
        }

        private void CoTClearVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                UI.CoTVariablesVw.GetSelectedItem();

            item.SubItems[1].Text = string.Empty;
            UI.CoTClearVariableBtn.Enabled = false;
            UI.CoTValueTxt.Text = string.Empty;
            item.Checked = false;
        }
        private void CoTUpdateVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                UI.CoTVariablesVw.GetSelectedItem();

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

        private void CoTVariablesVw_ItemsDeselected(object sender, EventArgs e)
        {
            UI.CoTUpdateVariableBtn.Enabled =
                (UI.CoTClearVariableBtn.Enabled = false);

            UI.CoTNameTxt.Text =
               (UI.CoTValueTxt.Text = string.Empty);
        }
        private void CoTVariablesVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string name = e.Item.Text;
            string value = e.Item.SubItems[1].Text;
            bool updateValue = (e.Item.Checked && !string.IsNullOrWhiteSpace(value));

            if (updateValue) ResourceReplacements[name] = value;
            else if (ResourceReplacements.ContainsKey(name)) ResourceReplacements.Remove(name);
        }
        private void CoTVariablesVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ToggleClearVariableButton(e.Item);
            UI.CoTUpdateVariableBtn.Enabled = true;

            UI.CoTNameTxt.Text = e.Item.Text;
            UI.CoTValueTxt.Text = e.Item.SubItems[1].Text;
        }

        private void InjectClient(object sender, EavesdropperRequestEventArgs e)
        {
            if (e.Request.RequestUri.OriginalString.EndsWith(".swf?Tanji-"))
            {
                Eavesdropper.EavesdropperRequest -= InjectClient;
                e.Request = WebRequest.Create(new Uri(Game.Location));
                Eavesdropper.EavesdropperResponse += ReplaceClient;
            }
        }
        private void ReplaceClient(object sender, EavesdropperResponseEventArgs e)
        {
            if (e.Response.ContentType != "application/x-shockwave-flash" &&
                !File.Exists(e.Response.ResponseUri.LocalPath)) return;

            Eavesdropper.EavesdropperResponse -= ReplaceClient;

            ushort[] ports = GameData.Port.Split(',')
                .Select(s => ushort.Parse(s)).ToArray();

            if (Game == null)
            {
                VerifyGameClientAsync(e.Payload).Wait();
                SetStatus(TanjiState.ModifyingClient);

                Game.FindMessageInstances();
                Game.BypassRemoteHostCheck();
                Game.RemoveLocalUseRestrictions();
                Game.DisableExpirationDateCheck();
                Game.ReplaceRSA(HandshakeManager.FAKE_EXPONENT, HandshakeManager.FAKE_MODULUS);

                SetStatus(TanjiState.ReconstructingClient);
                Game.Reconstruct();

                File.WriteAllBytes(
                    $"Modified Clients\\{GameData.MovieName}.swf", Game.ToByteArray());
            }

            e.Payload = Game.ToByteArray();
            if (ResourceReplacements.Count > 0)
            {
                Eavesdropper.EavesdropperResponse += ReplaceResources;
            }
            else Halt();

            SetStatus(TanjiState.InterceptingConnection);
            Connection.ConnectAsync(GameData.Host, ports)
                .ContinueWith(ConnectTaskCompleted);
        }
        private void ExtractGameData(object sender, EavesdropperResponseEventArgs e)
        {
            if (e.Response.ContentType != "text/html") return;
            if (GameData != null) return;

            string responseBody = Encoding.UTF8.GetString(e.Payload);
            if (responseBody.Contains("swfobject.embedSWF") &&
                responseBody.Contains("connection.info.host"))
            {
                Eavesdropper.EavesdropperResponse -= ExtractGameData;
                try
                {
                    GameData = new HGameData(responseBody);
                    Hotel = SKore.ToHotel(GameData.Host);

                    Task<bool> gameClientVerifierTask =
                        VerifyGameClientAsync($"Modified Clients\\{GameData.MovieName}.swf");

                    if (e.Response.ResponseUri.Segments.Length > 2)
                    {
                        GameData.UniqueId =
                            e.Response.ResponseUri.Segments[2].TrimEnd('/');
                    }

                    string embeddedSwf = responseBody.GetChild("embedSWF(", ',');
                    string nonCachedSwf = $"{embeddedSwf} + \"?Tanji-{DateTime.Now.Ticks}\"";

                    responseBody = responseBody.Replace(
                        "embedSWF(" + embeddedSwf, "embedSWF(" + nonCachedSwf);
                    e.Payload = Encoding.UTF8.GetBytes(responseBody);

                    var resourceKeys = ResourceReplacements.Keys.ToArray();
                    foreach (string resourceKey in resourceKeys)
                    {
                        string realValue = GameData[resourceKey]
                            .Replace("\\/", "/");

                        string fakeValue =
                            ResourceReplacements[resourceKey];

                        ResourceReplacements.Remove(resourceKey);
                        ResourceReplacements[realValue] = fakeValue;
                    }
                    if (gameClientVerifierTask.Result)
                    {
                        SetStatus(TanjiState.InjectingClient);
                        Eavesdropper.EavesdropperRequest += InjectClient;
                    }
                    else
                    {
                        SetStatus(TanjiState.InterceptingClient);
                        Eavesdropper.EavesdropperResponse += ReplaceClient;
                    }
                }
                catch (Exception ex)
                {
                    WriteLog(nameof(ExtractGameData), ex.ToString());
                }
                finally
                {
                    if (GameData == null)
                        Eavesdropper.EavesdropperResponse += ExtractGameData;
                }
            }
        }
        private void ReplaceResources(object sender, EavesdropperResponseEventArgs e)
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
                Halt();
            }
        }

        /// <summary>
        /// Terminates the Eavesdropper proxy, and un-hooks from all request/response event handlers.
        /// </summary>
        public void Halt()
        {
            Eavesdropper.Terminate();
            Eavesdropper.EavesdropperRequest -= InjectClient;
            Eavesdropper.EavesdropperResponse -= ReplaceClient;
            Eavesdropper.EavesdropperResponse -= ExtractGameData;
            Eavesdropper.EavesdropperResponse -= ReplaceResources;
        }
        public void Reset()
        {
            DisableReplacements();
            Connection.Disconnect();

            Game = null;
            GameData = null;
        }
        public void Cancel()
        {
            Reset();

            UI.CoTConnectBtn.Text = "Connect";
            SetStatus(TanjiState.StandingBy);
        }
        public void Connect()
        {
            Eavesdropper.EavesdropperResponse += ExtractGameData;
            Eavesdropper.Initiate(ProxyPort);

            UI.CoTConnectBtn.Text = "Cancel";
            SetStatus(TanjiState.ExtractingGameData);
        }
        public void SetStatus(TanjiState state)
        {
            if (UI.InvokeRequired)
            {
                UI.Invoke(_setStatus, state);
                return;
            }
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

                case TanjiState.ReplacingClient:
                UI.CoTStatusTxt.SetDotAnimation("Replacing Client");
                break;

                case TanjiState.DecompressingClient:
                UI.CoTStatusTxt.SetDotAnimation("Decompressing Client");
                break;

                case TanjiState.DisassemblingClient:
                UI.CoTStatusTxt.SetDotAnimation("Disassembling Client");
                break;

                case TanjiState.ReplacingResources:
                UI.CoTStatusTxt.SetDotAnimation("Replacing Resources");
                break;

                case TanjiState.InterceptingConnection:
                UI.CoTStatusTxt.SetDotAnimation("Intercepting Connection");
                break;

                case TanjiState.ReconstructingClient:
                UI.CoTStatusTxt.SetDotAnimation("Reconstructing Client");
                break;

                case TanjiState.ModifyingClient:
                UI.CoTStatusTxt.SetDotAnimation("Modifying Client");
                break;
            }
        }

        protected virtual void ConnectTaskCompleted(Task connectTask)
        {
            // I forgot what I was going to do here.
            if (Connection.IsConnected)
            { }
        }

        public void DestroySignedCertificates()
        {
            Eavesdropper.Certificates.DestroySignedCertificates();
            CreateTrustedRootCertificate();
        }
        public void ExportTrustedRootCertificate()
        {
            string certificatePath =
                Path.GetFullPath(EAVESDROPPER_ROOT_CERTIFICATE_NAME);

            bool exportSuccess = Eavesdropper.Certificates
                .ExportTrustedRootCertificate(certificatePath);

            string message = (exportSuccess
                ? $"Successfully exported '{EAVESDROPPER_ROOT_CERTIFICATE_NAME}' to:\r\n\r\n" + certificatePath
                : $"Failed to export '{EAVESDROPPER_ROOT_CERTIFICATE_NAME}' root certificate.");

            MessageBox.Show(message,
                "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void CreateTrustedRootCertificate()
        {
            // WARNING: Do not call this method within a constructor.
            UI.BringToFront();
            while (!Eavesdropper.Certificates.CreateTrustedRootCertificate())
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

            return (Game != null);
        }
        public async Task<bool> VerifyGameClientAsync(byte[] data)
        {
            await VerifyGameClientAsync(null, data)
                .ConfigureAwait(false);

            return (Game != null);
        }
        protected virtual async Task<bool> VerifyGameClientAsync(string path, byte[] data)
        {
            var game = new HFlash(data);
            game.Location = path;
            try
            {
                if (game.IsCompressed)
                {
                    SetStatus(TanjiState.DecompressingClient);

                    await Task.Factory.StartNew(game.Decompress)
                        .ConfigureAwait(false);
                }

                if (game.IsCompressed) return false;
                else Game = game;

                SetStatus(TanjiState.DisassemblingClient);
                Game.ReadTags();
                return true;
            }
            catch (Exception ex)
            {
                WriteLog(nameof(VerifyGameClientAsync), ex.ToString());
                return false;
            }
            finally
            {
                if (Game != game)
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