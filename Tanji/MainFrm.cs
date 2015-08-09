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