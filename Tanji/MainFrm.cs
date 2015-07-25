/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    .NET library for creating Habbo Hotel related desktop applications.
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

        public TanjiConnectFrm TanjiConnect { get; }
        public PacketLoggerFrm PacketLogger { get; }

        public MainFrm()
        {
            InitializeComponent();

            Connection = new HConnection();
            TanjiConnect = new TanjiConnectFrm(this);

            // Lazy restart.
            Connection.Disconnected += Disconnected;
            Connection.Connected += Connected;

            // Data Priority - #1 | Notify Extensions
            ExtensionMngr = new ExtensionManager(this);
            // Data Priority - #2 | Process Handshake
            HandshakeMngr = new HandshakeManager(this);
            // Data Priority - #3 | Display Data
            PacketLogger = new PacketLoggerFrm(this);
        }

        protected override void OnShown(EventArgs e)
        {
            if (!PacketLogger.IsLoaded)
            {
                PacketLogger.Show();

                PacketLogger.BringToFront();
                BringToFront();
            }
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            PromptConnect();
        }

        private void Connected(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(TanjiConnect.Close));
        }
        private void Disconnected(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void PromptConnect()
        {
            TanjiConnect.ShowDialog();
        }
    }
}