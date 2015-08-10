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
    test
*/

using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Sulakore.Protocol;
using Sulakore.Communication;
using Sulakore.Protocol.Encoders;

using Tanji.Managers.Injection;

namespace Tanji.Managers
{
    public class InjectionManager
    {
        private const string NOT_ENOUGH_DATA = "There is not enough data present in the packet.";
        private const string INVALID_PACKET_LENGTH = "The length chunk of the packet does not match the amount of information actually present in the packet.";

        public MainFrm MainUI { get; }
        public PrimitiveManager PrimitiveMngr { get; }
        public SchedulerManager SchedulerMngr { get; }
        public ConstructerManager ConstructerMngr { get; }

        public InjectionManager(MainFrm main)
        {
            MainUI = main;
            PrimitiveMngr = new PrimitiveManager(main);
            SchedulerMngr = new SchedulerManager(main);
            ConstructerMngr = new ConstructerManager(main);

            MainUI.ITSendToClientBtn.Click += ITSendToClientBtn_Click;
            MainUI.ITSendToServerBtn.Click += ITSendToServerBtn_Click;
        }

        private async void ITSendToClientBtn_Click(object sender, EventArgs e)
        {
            await SendPacketInputAsync(MainUI.Connection.Local);
        }
        private async void ITSendToServerBtn_Click(object sender, EventArgs e)
        {
            await SendPacketInputAsync(MainUI.Connection.Remote);
        }

        private async Task<int> SendPacketInputAsync(HNode node)
        {
            try
            {
                MainUI.Cursor = Cursors.WaitCursor;
                string errorMessage = string.Empty;
                string packetTxt = MainUI.ITPacketTxt.Text;

                byte[] data = HMessage.ToBytes(packetTxt);
                if (data.Length < 6)
                {
                    errorMessage = NOT_ENOUGH_DATA;
                    errorMessage += $"\r\n\r\nYou're missing {6 - data.Length:#,##0} bytes.";
                }
                else
                {
                    int realLength = data.Length - 4;
                    int length = BigEndian.ToSI32(data);

                    if (realLength != length)
                    {
                        bool tooSmall = length > realLength;
                        int difference = Math.Abs(realLength - length);

                        errorMessage = INVALID_PACKET_LENGTH;
                        errorMessage += $"\r\n\r\nYou're {difference:#,##0} byte(s) too {(tooSmall ? "short" : "large")}.";
                    }
                    else
                    {
                        Task<int> sendTask = node.SendAsync(data);

                        if (!MainUI.ITPacketTxt.Items.Contains(packetTxt))
                            MainUI.ITPacketTxt.Items.Add(packetTxt);

                        return await sendTask;
                    }
                }

                MessageBox.Show(errorMessage,
                    "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            finally { MainUI.Cursor = Cursors.Default; }
        }
    }
}