using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Collections.Generic;

using Eavesdrop;

using Tanji.Dialogs;

namespace Tanji.Managers
{
    public class VariablesManager
    {
        public ConnectFrm ConnectUI { get; }
        public IDictionary<string, string> UriReplacements { get; }

        public VariablesManager(ConnectFrm connect)
        {
            ConnectUI = connect;
            ConnectUI.VTUpdateVariableBtn.Click += VTUpdateVariableBtn_Click;
            ConnectUI.VTClearResetVariableBtn.Click += VTClearResetVariableBtn_Click;

            ConnectUI.VTVariablesVw.Add("furnidata.load.url", "");
            ConnectUI.VTVariablesVw.Add("productdata.load.url", "");
            ConnectUI.VTVariablesVw.Add("external.texts.txt", "");
            ConnectUI.VTVariablesVw.Add("external.variables.txt", "");
            ConnectUI.VTVariablesVw.Add("external.override.texts.txt", "");
            ConnectUI.VTVariablesVw.Add("external.figurepartlist.txt", "");
            ConnectUI.VTVariablesVw.Add("external.override.variables.txt", "");

            int capcity = ConnectUI.VTVariablesVw.Items.Count;
            UriReplacements = new Dictionary<string, string>(capcity);

            ConnectUI.VTVariablesVw.ItemChecked += VTVariablesVw_ItemChecked;
            ConnectUI.VTVariablesVw.ItemSelected += VTVariablesVw_ItemSelected;
            ConnectUI.VTVariablesVw.ItemsDeselected += VTVariablesVw_ItemsDeselected;
        }

        public void TerminateReplacing()
        {
            Eavesdropper.EavesdropperResponse -= EavesdropperResponse;
            Eavesdropper.Terminate();
        }
        public void DisableReplacements()
        {
            foreach (ListViewItem item in ConnectUI.VTVariablesVw.Items)
                item.Checked = false;
        }
        public void InitiateReplacing(int port)
        {
            if (UriReplacements.Count < 1) return;

            Eavesdropper.EavesdropperResponse += EavesdropperResponse;
            Eavesdropper.Initiate(port);
        }
        private void ToggleClearResetButton(ListViewItem selectedItem)
        {
            ConnectUI.VTClearResetVariableBtn.Enabled =
                (!string.IsNullOrWhiteSpace(selectedItem.SubItems[1].Text));
        }

        private void EavesdropperResponse(object sender, EavesdropperResponseEventArgs e)
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

        private void VTUpdateVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                ConnectUI.VTVariablesVw.GetSelectedItem();

            item.SubItems[1].Text =
                ConnectUI.VTReplacementValueTxt.Text;

            ToggleClearResetButton(item);

            if (!item.Checked) item.Checked = true;
            else VTVariablesVw_ItemChecked(this, new ItemCheckedEventArgs(item));
        }
        private void VTClearResetVariableBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item =
                ConnectUI.VTVariablesVw.GetSelectedItem();

            item.SubItems[1].Text = string.Empty;

            ConnectUI.VTClearResetVariableBtn.Enabled = false;
            ConnectUI.VTReplacementValueTxt.Text = string.Empty;

            item.Checked = false;
        }

        private void VTVariablesVw_ItemsDeselected(object sender, EventArgs e)
        {
            ConnectUI.VTUpdateVariableBtn.Enabled =
                ConnectUI.VTClearResetVariableBtn.Enabled = false;

            ConnectUI.VTNameTxt.Text =
                ConnectUI.VTReplacementValueTxt.Text = string.Empty;
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
            ConnectUI.VTUpdateVariableBtn.Enabled = true;

            ListViewItem item = ConnectUI
                .VTVariablesVw.GetSelectedItem();

            ConnectUI.VTNameTxt.Text = item.Text;
            ConnectUI.VTReplacementValueTxt.Text = item.SubItems[1].Text;
        }
    }
}