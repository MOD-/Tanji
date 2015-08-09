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
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

using Tanji.Dialogs;
using Tanji.Managers;
using Tanji.Applications;

using Sulakore.Habbo.Web;
using Sulakore.Protocol;
using Sulakore.Communication;
using Sulakore.Protocol.Encoders;

using FlashInspect;

namespace Tanji
{
    public partial class MainFrm : Form
    {
        public bool IsRetro { get; set; }
        public bool IsDebugging { get; } = true;

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

        //private void IPPrimitiveTxt_TextChanged(object sender, EventArgs e)
        //{
        //    if (IPPrimitiveTxt.TextLength < 1) ITPacketTxt.Text = string.Empty;
        //    else if (IPPrimitiveTxt.TextLength < 2) return;

        //    HMessage packet = null;
        //    bool isCorrupted = false;
        //    try
        //    {
        //        byte[] data = HMessage.ToBytes(IPPrimitiveTxt.Text);
        //        if (data.Length >= 6)

        //        {
        //            packet = new HMessage(data);
        //            isCorrupted = (data.Length < 2 || packet.IsCorrupted);
        //        }
        //        else isCorrupted = true;
        //    }
        //    catch { isCorrupted = true; }
        //    finally
        //    {
        //        ITPacketTxt.Text = isCorrupted ? IPPrimitiveTxt.Text : packet.ToString();

        //        IPPacketInfoLbl.Text = string.Format(PRIMITIVE_INFO_FORMAT,
        //            (isCorrupted ? 0 : packet.Header),
        //            (isCorrupted ? IPPrimitiveTxt.TextLength : packet.Length));
        //        IPIsCorruptedLbl.Text = isCorrupted.ToString();
        //        IPIsCorruptedLbl.ForeColor = isCorrupted ? Color.Firebrick : SystemColors.HotTrack;

        //        IPIsCorruptedLbl.Location = new Point((IPPacketInfoLbl.Location.X + IPPacketInfoLbl.Width) - 5,
        //            IPIsCorruptedLbl.Location.Y);
        //    }
        //}
        //private void IPInserHeaderBtn_Click(object sender, EventArgs e)
        //{
        //    int position;
        //    IPPrimitiveTxt.Focus();
        //    if (IPPrimitiveTxt.Text.Length < 1)
        //    {
        //        position = IPPrimitiveTxt.SelectionStart;
        //        IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{l}{u:}");
        //        IPPrimitiveTxt.SelectionStart = position + 6;
        //    }
        //    else
        //    {
        //        position = IPPrimitiveTxt.SelectionStart;
        //        IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{u:}");
        //        IPPrimitiveTxt.SelectionStart = position + 3;
        //    }
        //}
        //private void IPInsertIntegerBtn_Click(object sender, EventArgs e)
        //{
        //    int position;
        //    IPPrimitiveTxt.Focus();
        //    position = IPPrimitiveTxt.SelectionStart;
        //    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{i:}");
        //    IPPrimitiveTxt.SelectionStart = position + 3;
        //}
        //private void IPInsertStringBtn_Click(object sender, EventArgs e)
        //{
        //    //if (IPPrimitiveTxt.SelectedText.Length < 1)
        //    //{
        //    int position;
        //    IPPrimitiveTxt.Focus();
        //    position = IPPrimitiveTxt.SelectionStart;
        //    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{s:}");
        //    IPPrimitiveTxt.SelectionStart = position + 3;
        //    //}
        //    //else
        //    //{
        //    //    string selected = IPPrimitiveTxt.SelectedText;
        //    //    byte[] stringData = HMessage.ToBytes(selected);

        //    //    int stringLength = BigEndian.ToUI16(stringData);
        //    //    if ((stringData.Length - 2) != stringLength) return;

        //    //    string stringValue = Encoding.UTF8.GetString(stringData, 2, stringLength);

        //    //    int selectedStart = IPPrimitiveTxt.SelectionStart;
        //    //    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Remove(
        //    //        IPPrimitiveTxt.SelectionStart, IPPrimitiveTxt.SelectionLength)
        //    //        .Insert(selectedStart, $"{{s:{stringValue}}}");
        //    //    IPPrimitiveTxt.SelectionStart = selectedStart + 4 + stringValue.Length;
        //    //}
        //}
        //private void IPInsertBooleanBtn_Click(object sender, EventArgs e)
        //{
        //    //if (IPPrimitiveTxt.SelectedText.Length < 1)
        //    //{
        //    int position;
        //    IPPrimitiveTxt.Focus();
        //    position = IPPrimitiveTxt.SelectionStart;
        //    IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{b:}");
        //    IPPrimitiveTxt.SelectionStart = position + 3;
        //    //            //}
        //    //            else
        //    //            {
        //    //                string selected = IPPrimitiveTxt.SelectedText;
        //    //                int selectedStart = IPPrimitiveTxt.SelectionStart;
        //    //                if (selected == "[0]") {
        //    //                    IPPrimitiveTxt.Text.Remove(
        //    //                    IPPrimitiveTxt.SelectionStart, IPPrimitiveTxt.SelectionLength)
        //    //                    .Insert(selectedStart, "{b:false}"); IPPrimitiveTxt.SelectionStart = selectedStart + 9;
        //    //                }
        //    //                else if (selected == "[1]")
        //    //                    IPPrimitiveTxt.Text.Remove(
        //    //IPPrimitiveTxt.SelectionStart, IPPrimitiveTxt.SelectionLength)
        //    //.Insert(selectedStart, "{b:true}");
        //    //            }
        //}
        //private void IPPrimitiveTxt_KeyDown(object sender, KeyEventArgs e)
        //{
        //    int position;
        //    if (e.Alt && e.KeyCode == Keys.N) IPPrimitiveTxt.SelectionStart = IPPrimitiveTxt.SelectionStart + 1;
        //    if (e.Control && e.KeyCode == Keys.A) IPPrimitiveTxt.SelectAll();
        //    if (e.Alt && e.KeyCode == Keys.H || e.Alt && e.KeyCode == Keys.L)
        //    {
        //        if (IPPrimitiveTxt.Text.Length < 1)
        //        {
        //            position = IPPrimitiveTxt.SelectionStart;
        //            IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{l}{u:}");
        //            IPPrimitiveTxt.SelectionStart = position + 6;
        //        }
        //        else
        //        {
        //            position = IPPrimitiveTxt.SelectionStart;
        //            IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{u:}");
        //            IPPrimitiveTxt.SelectionStart = position + 3;
        //        }
        //    }
        //    if (e.Alt && e.KeyCode == Keys.I)
        //    {
        //        position = IPPrimitiveTxt.SelectionStart;
        //        IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{i:}");
        //        IPPrimitiveTxt.SelectionStart = position + 3;
        //    }
        //    if (e.Alt && e.KeyCode == Keys.S)
        //    {
        //        position = IPPrimitiveTxt.SelectionStart;
        //        IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{s:}");
        //        IPPrimitiveTxt.SelectionStart = position + 3;
        //    }
        //    if (e.Alt && e.KeyCode == Keys.B)
        //    {
        //        position = IPPrimitiveTxt.SelectionStart;
        //        IPPrimitiveTxt.Text = IPPrimitiveTxt.Text.Insert(IPPrimitiveTxt.SelectionStart, "{b:}");
        //        IPPrimitiveTxt.SelectionStart = position + 3;
        //    }
        //}
        
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