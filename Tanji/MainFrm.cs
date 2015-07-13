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
using System.Text;
using System.Windows.Forms;

using Tanji.Dialogs;
using Tanji.Applications;

using Sulakore.Habbo.Web;
using Sulakore.Extensions;
using Sulakore.Communication;
using Sulakore.Protocol.Encryption;

using Eavesdrop;

using FlashInspect;

// TODO: Finish all the things.
namespace Tanji
{
    public partial class MainFrm : Form
    {
        public bool IsRetro { get; set; }
        public HGameData GameData { get; set; }
        public ShockwaveFlash Game { get; set; }

        public Contractor Contractor { get; private set; }
        public HConnection Connection { get; private set; }

        public TanjiConnectFrm TanjiConnect { get; private set; }
        public PacketLoggerFrm PacketLogger { get; private set; }

        public MainFrm()
        {
            InitializeComponent();

            Connection = new HConnection();
            TanjiConnect = new TanjiConnectFrm(this);
            PacketLogger = new PacketLoggerFrm(this);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            PromptConnect();
        }

        private void PromptConnect()
        {
            TanjiConnect.ShowDialog();
        }
    }
}