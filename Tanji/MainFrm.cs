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
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Dialogs;
using Tanji.Managers;
using Tanji.Applications;

using Sulakore;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using FlashInspect;
using Sulakore.Protocol;
using System.Text;
using System.Drawing;
using Sulakore.Protocol.Encoders;

namespace Tanji
{
    public partial class MainFrm : Form
    {
        public bool IsRetro { get; set; }
        public bool IsDebugging { get; } = false;

        public HConnection Connection { get; }
        public HGameData GameData { get; set; }
        public ShockwaveFlash Game { get; set; }
        public Task<bool> CheckForUpdatesTask { get; }

        public HandshakeManager HandshakeMngr { get; }
        public ExtensionManager ExtensionMngr { get; }
        public InjectionManager InjectionMngr { get; }

        public UpdateFrm UpdateUI { get; }
        public ConnectFrm ConnectUI { get; }
        public PacketLoggerFrm PacketLoggerUI { get; }

        private const string PRIMITIVE_INFO_FORMAT = "Header: {0} | Length: {1} | Corrupted:";
        private const string CHUNK_COUNT_FORMAT = "Chunk Count: {0}";

        private const string InjClientCanc = "The specified data is corrupted, injection to client cancelled!";
        private const string InjServerCanc = "The specified data is corrupted, injection to server cancelled!";
        private const string NotInt32 = "The given value does not qualify as an Int32 type.";
        private const string NotUInt16 = "The given value does not qualify as an UInt16 type.";

        public MainFrm()
        {
            InitializeComponent();
            Connection = new HConnection();

            if (!IsDebugging)
            {
                Load += MainFrm_Load;
                Shown += MainFrm_Shown;
            }

            UpdateUI = new UpdateFrm(this);
            ConnectUI = new ConnectFrm(this);

            Connection.Connected += Connected;
            Connection.Disconnected += Disconnected;

            // Data Priority - #1 | Notify Extensions
            ExtensionMngr = new ExtensionManager(this);
            // Data Priority - #2 | Process Handshake
            HandshakeMngr = new HandshakeManager(this);
            // Data Priority - #3 | Display Data
            PacketLoggerUI = new PacketLoggerFrm(this);

            InjectionMngr = new InjectionManager(this);

            // Begin checking for updates asynchronously, await once ConnectUI is shown.
            CheckForUpdatesTask = UpdateUI.CheckForUpdatesAsync();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            PromptConnect();
            Text = $"Tanji ~ Connected[{GameData.Host}:{GameData.Port}]";
        }
        private void MainFrm_Shown(object sender, EventArgs e)
        {
            if (!PacketLoggerUI.IsLoaded)
                PacketLoggerUI.Show();
        }

        private void PromptConnect()
        {
            ConnectUI.ShowDialog();
        }
        private void Connected(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(ConnectUI.Close));
        }
        private void Disconnected(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TanjiInfoTxt_Click(object sender, EventArgs e)
        {
            TanjiInfoTxt.LinkVisited = true;
            Process.Start("https://GitHub.com/ArachisH/Tanji");
        }
        private void TanjiVersionTxt_Click(object sender, EventArgs e)
        {
            TanjiVersionTxt.LinkVisited = true;

            string htmlUrl = UpdateUI.Releases?[0].HtmlUrl;
            if (!string.IsNullOrWhiteSpace(htmlUrl))
                Process.Start(htmlUrl);
        }

        private async void ISendToServerBtn_Click(object sender, EventArgs e)
        {
            if (Encoding.ASCII.GetBytes(IPacketTxt.Text).Length > 5)
            {
                HMessage serverpacket = new HMessage(IPacketTxt.Text);
                if (!serverpacket.IsCorrupted) await Connection.SendToServerAsync(serverpacket.ToBytes());
                else MessageBox.Show(InjServerCanc, "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(InjServerCanc, "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void ISendToClientBtn_Click(object sender, EventArgs e)
        {
            if (Encoding.ASCII.GetBytes(IPacketTxt.Text).Length > 5)
            {
                HMessage clientpacket = new HMessage(IPacketTxt.Text);
                if (!clientpacket.IsCorrupted) await Connection.SendToServerAsync(clientpacket.ToBytes());
                else MessageBox.Show(InjClientCanc, "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(InjClientCanc, "Tanji ~ Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void IPPrimitiveTxt_TextChanged(object sender, EventArgs e)
        {
            if (IPPrimitiveTxt.TextLength < 1) IPacketTxt.Text = string.Empty;
            else if (IPPrimitiveTxt.TextLength < 2) return;

            HMessage packet = null;
            bool isCorrupted = false;
            try
            {
                byte[] data = HMessage.ToBytes(IPPrimitiveTxt.Text);
                if (data.Length >= 6)

                {
                    packet = new HMessage(data);
                    isCorrupted = (data.Length < 2 || packet.IsCorrupted);
                }
                else isCorrupted = true;
            }
            catch { isCorrupted = true; }
            finally
            {
                IPacketTxt.Text = isCorrupted ? IPPrimitiveTxt.Text : packet.ToString();

                IPPacketInfoLbl.Text = string.Format(PRIMITIVE_INFO_FORMAT,
                    (isCorrupted ? 0 : packet.Header),
                    (isCorrupted ? IPPrimitiveTxt.TextLength : packet.Length));
                IPIsCorruptedLbl.Text = isCorrupted.ToString();
                IPIsCorruptedLbl.ForeColor = isCorrupted ? Color.Firebrick : SystemColors.HotTrack;

                IPIsCorruptedLbl.Location = new Point((IPPacketInfoLbl.Location.X + IPPacketInfoLbl.Width) - 5,
                    IPIsCorruptedLbl.Location.Y);
            }
        }

        private void IPInserHeaderBtn_Click(object sender, EventArgs e)
        {
            int position;
            IPPrimitiveTxt.Focus();
            if (IPPrimitiveTxt.Text.Length < 1)
            {
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{l}{u:}");
                IPPrimitiveTxt.SelectionStart = position + 6;
            }
            else
            {
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{u:}");
                IPPrimitiveTxt.SelectionStart = position + 3;
            }
        }

        private void IPInsertIntegerBtn_Click(object sender, EventArgs e)
        {
            int position;
            IPPrimitiveTxt.Focus();
            position = IPPrimitiveTxt.SelectionStart;
            IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{i:}");
            IPPrimitiveTxt.SelectionStart = position + 3;
        }

        private void IPInsertStringBtn_Click(object sender, EventArgs e)
        {
            //if (IPPrimitiveTxt.SelectedText.Length < 1)
            //{
                int position;
                IPPrimitiveTxt.Focus();
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{s:}");
                IPPrimitiveTxt.SelectionStart = position + 3;
            //}
            //else
            //{
            //    string selected = IPPrimitiveTxt.SelectedText;
            //    byte[] stringData = HMessage.ToBytes(selected);

            //    int stringLength = BigEndian.ToUI16(stringData);
            //    if ((stringData.Length - 2) != stringLength) return;

            //    string stringValue = Encoding.UTF8.GetString(stringData, 2, stringLength);

            //    int selectedStart = IPPrimitiveTxt.SelectionStart;
            //    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Remove(
            //        IPPrimitiveTxt.SelectionStart, IPPrimitiveTxt.SelectionLength)
            //        .Insert(selectedStart, $"{{s:{stringValue}}}");
            //    IPPrimitiveTxt.SelectionStart = selectedStart + 4 + stringValue.Length;
            //}
        }

        private void IPInsertBooleanBtn_Click(object sender, EventArgs e)
        {
            //if (IPPrimitiveTxt.SelectedText.Length < 1)
            //{
                int position;
                IPPrimitiveTxt.Focus();
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{b:}");
                IPPrimitiveTxt.SelectionStart = position + 3;
//            //}
//            else
//            {
//                string selected = IPPrimitiveTxt.SelectedText;
//                int selectedStart = IPPrimitiveTxt.SelectionStart;
//                if (selected == "[0]") {
//                    IPPrimitiveTxt.Text.Remove(
//                    IPPrimitiveTxt.SelectionStart, IPPrimitiveTxt.SelectionLength)
//                    .Insert(selectedStart, "{b:false}"); IPPrimitiveTxt.SelectionStart = selectedStart + 9;
//                }
//                else if (selected == "[1]")
//                    IPPrimitiveTxt.Text.Remove(
//IPPrimitiveTxt.SelectionStart, IPPrimitiveTxt.SelectionLength)
//.Insert(selectedStart, "{b:true}");
//            }
        }

        private void IPPrimitiveTxt_KeyDown(object sender, KeyEventArgs e)
        {
            int position;
            if (e.Alt && e.KeyCode == Keys.N) IPPrimitiveTxt.SelectionStart = IPPrimitiveTxt.SelectionStart + 1;
            if (e.Control && e.KeyCode == Keys.A) IPPrimitiveTxt.SelectAll();
            if (e.Alt && e.KeyCode == Keys.H || e.Alt && e.KeyCode == Keys.L)
            {
                if (IPPrimitiveTxt.Text.Length < 1)
                {
                    position = IPPrimitiveTxt.SelectionStart;
                    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{l}{u:}");
                    IPPrimitiveTxt.SelectionStart = position + 6;
                }
                else
                {
                    position = IPPrimitiveTxt.SelectionStart;
                    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{u:}");
                    IPPrimitiveTxt.SelectionStart = position + 3;
                }
            }
            if (e.Alt && e.KeyCode == Keys.I)
            {
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{i:}");
                IPPrimitiveTxt.SelectionStart = position + 3;
            }
            if (e.Alt && e.KeyCode == Keys.S)
            {
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{s:}");
                IPPrimitiveTxt.SelectionStart = position + 3;
            }
            if (e.Alt && e.KeyCode == Keys.B)
            {
                position = IPPrimitiveTxt.SelectionStart;
                IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{b:}");
                IPPrimitiveTxt.SelectionStart = position + 3;
            }
        }

        private void ICClearBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.ClearItems();
            ICRemoveBtn.Enabled = ICMoveDownBtn.Enabled = ICMoveUpBtn.Enabled = false;

            ICChunkCountLbl.Text = string.Format(CHUNK_COUNT_FORMAT,
                ICConstructerLstvw.ChunksWritten.Count);
        }

        private void ICAppendBtn_Click(object sender, EventArgs e)
        {
            object value = null;
            int count = (int)ICCountTxt.Value;
            switch (((Control)sender).Text.Split(' ')[1])
            {
                case "String": value = ICValueTxt.Text; break;
                case "Integer":
                {
                    int outcome = 0;
                    int.TryParse(ICValueTxt.Text, out outcome);
                    value = outcome;
                    break;
                }
                case "Boolean":
                {
                    if (string.IsNullOrWhiteSpace(ICValueTxt.Text))
                        value = false;
                    else
                    {
                        char start = ICValueTxt.Text[0];
                        value = (start == 't' || start == '1');
                    }
                    break;
                }
            }

            var values = new object[count];
            for (int i = 0; i < values.Length; i++)
                values[i] = value;

            ICConstructerLstvw.Append(values);

            ICChunkCountLbl.Text = string.Format(CHUNK_COUNT_FORMAT,
                ICConstructerLstvw.ChunksWritten.Count);
        }

        private void ICRemoveBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.RemoveSelectedItem();

            ICChunkCountLbl.Text = string.Format(CHUNK_COUNT_FORMAT,
                ICConstructerLstvw.ChunksWritten.Count);
        }

        private void ICMoveUpBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.MoveSelectedItemUp();
        }

        private void ICMoveDownBtn_Click(object sender, EventArgs e)
        {
            ICConstructerLstvw.MoveSelectedItemDown();
        }

        private void ICConstructerLstvw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ICRemoveBtn.Enabled = true;

            ICMoveUpBtn.Enabled = e.ItemIndex != 0;
            ICMoveDownBtn.Enabled = e.ItemIndex != ICConstructerLstvw.Items.Count - 1;

            ICValueTxt.Text = e.IsSelected ? e.Item.SubItems[1].Text : string.Empty;
        }

        private void ICConstructerLstvw_ItemsDeselected(object sender, EventArgs e)
        {
            ICRemoveBtn.Enabled = false;
            ICMoveUpBtn.Enabled = false;
            ICMoveDownBtn.Enabled = false;

            ICValueTxt.Text = string.Empty;
        }

        private void ICConstructerLstvw_ItemActivate(object sender, EventArgs e)
        {
            if (ICConstructerLstvw.SelectedItems.Count < 1) return;

            object chunk = null;
            ListViewItem item = ICConstructerLstvw.SelectedItems[0];
            switch (item.SubItems[0].Text)
            {
                case "Integer": chunk = ""; break;
                case "String": chunk = false; break;
                case "Boolean": chunk = 0; break;
                default: return;
            }
            ICValueTxt.TextChanged -= ICValueTxt_TextChanged;
            ICValueTxt.Text = chunk.ToString();
            ICValueTxt.TextChanged += ICValueTxt_TextChanged;

            ICConstructerLstvw.ReplaceItem(chunk);
            ICValueTxt.Focus();
        }

        private void ICValueTxt_TextChanged(object sender, EventArgs e)
        {
            if (ICConstructerLstvw.SelectedItems.Count < 1) return;
            string typeName = ICConstructerLstvw.SelectedItems[0].SubItems[0].Text;

            object chunk = null;
            switch (typeName)
            {
                case "Integer":
                {
                    int value = 0;
                    chunk = int.TryParse(ICValueTxt.Text, out value) ? value : 0;
                    break;
                }
                case "String": chunk = ICValueTxt.Text; break;
                case "Boolean": chunk = (!string.IsNullOrEmpty(ICValueTxt.Text) && (ICValueTxt.Text[0] == 't' || ICValueTxt.Text[0] == '1')); break;
                default: return;
            }
            ICConstructerLstvw.ReplaceItem(chunk);
        }

        private void ICCopyPacketBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ICConstructerLstvw.GetString());
        }

        private void ICSchedulerBtn_Click(object sender, EventArgs e)
        {
            InjectionTabs.SelectTab(SchedulerTab);
            ISPacketTxt.Text = ICConstructerLstvw.GetString();
        }

        private void ICPrimitiveBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICConstructerLstvw.GetString();
            IPPrimitiveTxt.Text = ICConstructerLstvw.GetString();
            InjectionTabs.SelectTab(PrimitiveTab);
        }

        private void ICInjectionBtn_Click(object sender, EventArgs e)
        {
            IPacketTxt.Text = ICConstructerLstvw.GetString();
        }

        private void InjectionTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (IPacketTxt.ReadOnly = (e.TabPage == PrimitiveTab))
                IPPrimitiveTxt.Text = IPacketTxt.Text;
        }

        private void ICHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            if (ushort.TryParse(ICHeaderTxt.Text, out header))
                ICConstructerLstvw.Header = header;
        }

        private void EDEncodeIntegerBtn_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(EDIntegerInputTxt.Text, out value))
                EDIntegerOutputTxt.Text = HMessage.ToString(BigEndian.FromSI32(value));
            else MessageBox.Show(NotInt32, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EDDecodeIntegerBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EDIntegerOutputTxt.Text))
                EDIntegerInputTxt.Text = BigEndian.ToSI32(HMessage.ToBytes(EDIntegerOutputTxt.Text)).ToString();
        }

        private void EDEncodeShortBtn_Click(object sender, EventArgs e)
        {
            ushort value;
            if (ushort.TryParse(EDShortInputTxt.Text, out value))
                EDShortOutputTxt.Text = HMessage.ToString(BigEndian.FromUI16(value));
            else MessageBox.Show(NotUInt16, "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EDDecodeShortBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EDShortOutputTxt.Text))
                EDShortInputTxt.Text = BigEndian.ToUI16(HMessage.ToBytes(EDShortOutputTxt.Text)).ToString();
        }
    }
}