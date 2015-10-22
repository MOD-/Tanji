/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Sulakore.Protocol;
using Sulakore.Communication;

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
                    int length = BigEndian.ToInt32(data, 0);

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