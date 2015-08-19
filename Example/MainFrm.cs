using System;
using System.Threading;

using Sulakore.Protocol;
using Sulakore.Extensions;
using Sulakore.Communication;

namespace Example
{
    public partial class MainFrm : ExtensionForm
    {
        public MainFrm()
        {
            InitializeComponent();
            
            // Attach - Block/Replace examaple.
            Triggers.InAttach(1000, AttachedIncoming);
        }

        private void AttachedIncoming(InterceptedEventArgs e)
        {
            // If we can't read a string, leave this method.
            if (!e.Packet.CanRead<string>()) return;

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
                    e.Replacement.Replace<string>(0, "Replaced!");
                    break;
                }

                case "freeze":
                {
                    // Tell the contractor to continue reading data from local/remote endpoint.
                    // Does not wait for this method to finish, but the packet being processed
                    // can still be used: blocked/replaced
                    if (e.IsAsyncCapable)
                        e.ContinueRead();

                    // Simulate a long synchronous process for one second(1000ms).
                    Thread.Sleep(1000);
                    break;
                }
            }
        }

        // Asynchronously send data to the local/remote endpoint(s).
        private byte[] GetInputPacket()
        {
            return PacketTxt.TextLength > 0 ?
                HMessage.ToBytes(PacketTxt.Text) : null;
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