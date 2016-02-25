using System;
using System.Threading;

using Sulakore.Protocol;
using Sulakore.Extensions;
using Sulakore.Communication;
using System.Threading.Tasks;

namespace Extension_Demo
{
    public partial class MainFrm : ExtensionForm
    {
        public MainFrm()
        {
            InitializeComponent();

            /* Attach - Block/Replace examaple. */
            Triggers.InAttach(1000, AttachedIncoming);
        }

        private byte[] GetInputPacket()
        {
            return PacketTxt.TextLength > 0 ?
                HMessage.ToBytes(PacketTxt.Text) : null;
        }
        private void AttachedIncoming(DataInterceptedEventArgs e)
        {
            // If we can't read a string, leave this method.
            if (!e.Packet.CanReadString()) return;

            string value = e.Packet.ReadString();
            switch (value.ToLower())
            {
                case "block":
                {
                    e.IsBlocked = true;
                    break;
                }

                case "replace":
                {
                    // Replace the first string found in the packet.
                    e.Packet.RemoveString(0);
                    e.Packet.WriteString("Replaced!", 0);
                    break;
                }

                case "freeze":
                {
                    // Tell the contractor to continue reading data from local/remote endpoint.
                    // Does not wait for this method to finish, but the packet being processed
                    // can still be used: blocked/replaced
                    if (e.IsContinuable)
                    {
                        Task continuedTask = e.Continue();
                        // Uncommenting this code will wait for the continued task to finish,
                        // in this case, it having processed one other incoming packet.
                        //continuedTask.Wait();
                    }
                    // Simulate a long synchronous process for one second(1000ms).
                    Thread.Sleep(1000);
                    break;
                }
            }
        }

        private async void ToClientBtn_Click(object sender, EventArgs e)
        {
            byte[] data = GetInputPacket();

            if (data != null)
                await Connection?.SendToClientAsync(data);
        }
        private async void ToServerBtn_Click(object sender, EventArgs e)
        {
            byte[] data = GetInputPacket();

            if (data != null)
                await Connection?.SendToServerAsync(data);
        }
    }
}