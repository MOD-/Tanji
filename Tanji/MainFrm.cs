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
using System.Windows.Forms;

using Tanji.Dialogs;
using Tanji.Managers;
using Tanji.Applications;

using Sulakore.Habbo.Web;
using Sulakore.Communication;

using FlashInspect;
using System.Threading.Tasks;

namespace Tanji
{
    public partial class MainFrm : Form
    {
        public bool IsRetro { get; set; }
        public HGameData GameData { get; set; }
        public ShockwaveFlash Game { get; set; }

        public HConnection Connection { get; }
        public HandshakeManager HandshakeMngr { get; }
        public ExtensionManager ExtensionMngr { get; }

        public UpdateFrm UpdateUI { get; }
        public ConnectFrm ConnectUI { get; }
        public PacketLoggerFrm PacketLoggerUI { get; }

        public Task<bool> CheckForUpdatesTask { get; }

        public MainFrm()
        {
            InitializeComponent();

            Connection = new HConnection();

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

            // Begin checking for updates asynchronously, await once ConnectUI is shown.
            CheckForUpdatesTask = UpdateUI.CheckForUpdatesAsync();
        }
        private void Connected(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(ConnectUI.Close));
        }
        private void Disconnected(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PromptConnect()
        {
            ConnectUI.ShowDialog();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            PromptConnect();
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            if (!PacketLoggerUI.IsLoaded)
                PacketLoggerUI.Show();
        }
    }
}