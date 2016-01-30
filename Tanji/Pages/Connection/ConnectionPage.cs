using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Sulakore;
using Sulakore.Habbo;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

namespace Tanji.Pages.Connection
{
    public class ConnectionPage : TanjiPage
    {
        private const string ROOT_CERTIFICATE_NAME = "EavesdropRoot.cer";

        public HConnection Connection { get; }
        public IDictionary<string, string> UriReplacements { get; }

        public HFlash Game { get; private set; }
        public HHotel Hotel { get; private set; }
        public HGameData GameData { get; private set; }

        public ConnectionPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            Eavesdropper.IsSslSupported = true;
            CreateTrustedRootCertificate();

            Connection = new HConnection();

            UI.CoTConnectBtn.Click += CTConnectBtn_Click;
            
            UI.CoTDestroyCertificatesBtn.Click += STDestroyCertificatesBtn_Click;
            UI.CoTExportRootCertificateBtn.Click += STExportRootCertificateAuthorityBtn_Click;
            
            UI.CoTClearVariableBtn.Click += VTClearVariableBtn_Click;
            UI.CoTUpdateVariableBtn.Click += VTUpdateVariableBtn_Click;

            UI.CoTVariablesVw.Add("furnidata.load.url", "");
            UI.CoTVariablesVw.Add("productdata.load.url", "");
            UI.CoTVariablesVw.Add("external.texts.txt", "");
            UI.CoTVariablesVw.Add("external.variables.txt", "");
            UI.CoTVariablesVw.Add("external.override.texts.txt", "");
            UI.CoTVariablesVw.Add("external.figurepartlist.txt", "");
            UI.CoTVariablesVw.Add("external.override.variables.txt", "");

            int capcity = UI.CoTVariablesVw.Items.Count;
            UriReplacements = new Dictionary<string, string>(capcity);

            UI.CoTVariablesVw.ItemChecked += VTVariablesVw_ItemChecked;
            UI.CoTVariablesVw.ItemSelected += VTVariablesVw_ItemSelected;
            UI.CoTVariablesVw.ItemsDeselected += VTVariablesVw_ItemsDeselected;

        }
        
        public void TerminateReplacing()
        {
            Eavesdropper.EavesdropperResponse -= ReplaceResources;
            Eavesdropper.Terminate();
        }
        public void DisableReplacements()
        {
            foreach (ListViewItem item in UI.CoTVariablesVw.Items)
                item.Checked = false;
        }
        public void InitiateReplacing(int port)
        {
            if (UriReplacements.Count < 1) return;

            Eavesdropper.EavesdropperResponse += ReplaceResources;
            Eavesdropper.Initiate(port);
        }

        private void ToggleClearResetButton(ListViewItem item)
        {
            UI.CoTClearVariableBtn.Enabled =
                (!string.IsNullOrWhiteSpace(item.SubItems[1].Text));
        }
        private void ReplaceResources(object sender, EavesdropperResponseEventArgs e)
        {
            string absoluteUri = e.Response.ResponseUri.AbsoluteUri;
            if (UriReplacements.ContainsKey(absoluteUri))
            {
                var httpResponse = (HttpWebResponse)e.Response;
                string replacementUrl = UriReplacements[absoluteUri];

                if (httpResponse.StatusCode == HttpStatusCode.TemporaryRedirect)
                {
                    UriReplacements.Remove(absoluteUri);
                    absoluteUri = httpResponse.Headers["Location"];
                    UriReplacements[absoluteUri] = replacementUrl;
                    return;
                }

                if (replacementUrl.StartsWith("http"))
                {
                    using (var webClient = new WebClient())
                        e.Payload = webClient.DownloadData(replacementUrl);
                }
                else e.Payload = File.ReadAllBytes(replacementUrl);

                UriReplacements.Remove(absoluteUri);
                if (UriReplacements.Count < 1)
                    TerminateReplacing();
            }
        }

        private void VTClearVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                UI.CoTVariablesVw.GetSelectedItem();

            item.SubItems[1].Text = string.Empty;

            UI.CoTClearVariableBtn.Enabled = false;
            UI.CoTValueTxt.Text = string.Empty;

            item.Checked = false;
        }
        private void VTUpdateVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                UI.CoTVariablesVw.GetSelectedItem();

            item.SubItems[1].Text =
                UI.CoTValueTxt.Text;

            ToggleClearResetButton(item);

            if (!item.Checked) item.Checked = true;
            else VTVariablesVw_ItemChecked(this, new ItemCheckedEventArgs(item));
        }

        private void VTVariablesVw_ItemsDeselected(object sender, EventArgs e)
        {
            UI.CoTUpdateVariableBtn.Enabled =
                UI.CoTClearVariableBtn.Enabled = false;

            UI.CoTNameTxt.Text =
                UI.CoTValueTxt.Text = string.Empty;
        }
        private void VTVariablesVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            string name = e.Item.Text;
            string value = e.Item.SubItems[1].Text;
            bool updateValue = (e.Item.Checked && !string.IsNullOrWhiteSpace(value));

            if (updateValue) UriReplacements[name] = value;
            else if (UriReplacements.ContainsKey(name)) UriReplacements.Remove(name);
        }
        private void VTVariablesVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ToggleClearResetButton(e.Item);
            UI.CoTUpdateVariableBtn.Enabled = true;

            ListViewItem item = UI.CoTVariablesVw.GetSelectedItem();

            UI.CoTNameTxt.Text = item.Text;
            UI.CoTValueTxt.Text = item.SubItems[1].Text;
        }

        public void DestroySignedCertificates()
        {
            Eavesdropper.Certificates.DestroySignedCertificates();
            CreateTrustedRootCertificate();
        }
        public void ExportTrustedRootCertificate()
        {
            string certificatePath =
                Path.GetFullPath(ROOT_CERTIFICATE_NAME);

            bool exportSuccess = Eavesdropper.Certificates
                .ExportTrustedRootCertificate(certificatePath);

            string message = (exportSuccess
                ? $"Successfully exported '{ROOT_CERTIFICATE_NAME}' to:\r\n\r\n" + certificatePath
                : $"Failed to export '{ROOT_CERTIFICATE_NAME}' root certificate.");

            MessageBox.Show(message,
                "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void CreateTrustedRootCertificate()
        {
            while (!Eavesdropper.Certificates.CreateTrustedRootCertificate())
            {
                UI.BringToFront();
                var result = MessageBox.Show(
                    "Eavesdrop requires a self-signed certificate in the root store to intercept HTTPS traffic.\r\n\r\nWould you like to retry the process?",
                    "Tanji ~ Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (result != DialogResult.Yes)
                {
                    UI.Close();
                    break;
                }
            }
        }

        public async Task<bool> VerifyGameClientAsync(string path)
        {
            if (!File.Exists(path)) return false;
            byte[] data = File.ReadAllBytes(path);

            await VerifyGameClientAsync(path, data).ConfigureAwait(false);
            return (Game != null);
        }
        public async Task<bool> VerifyGameClientAsync(byte[] data)
        {
            await VerifyGameClientAsync(null, data).ConfigureAwait(false);
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
                    SetStatus("Decompressing");

                    await Task.Factory.StartNew(game.Decompress)
                        .ConfigureAwait(false);
                }

                if (game.IsCompressed) return false;
                else Game = game;

                SetStatus("Disassembling");
                Game.ReadTags();

                ResetStatus();
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

        private void STDestroyCertificatesBtn_Click(object sender, EventArgs e)
        {
            DestroySignedCertificates();
        }
        private void STExportRootCertificateAuthorityBtn_Click(object sender, EventArgs e)
        {
            ExportTrustedRootCertificate();
        }

        public void Connect()
        {
            SetStatus("Extracting Host/Port");
            UI.CoTConnectBtn.Text = "Cancel";
        }
        public void ResetStatus()
        {
            UI.CoTStatusTxt.StopDotAnimation("Standing By...");
        }
        public void SetStatus(string text)
        {
            UI.CoTStatusTxt.SetDotAnimation(text);
        }

        private void CTConnectBtn_Click(object sender, EventArgs e)
        {
            Connect();
        }
    }
}