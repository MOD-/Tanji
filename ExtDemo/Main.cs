using System.Threading;

using Sulakore;
using Sulakore.Extensions;
using Sulakore.Communication;

namespace ExtDemo
{
    // This is initialized when the Contractor calls 'LoadInstalledExtensions', or 'Install'.
    // The main extension form SHOULD inherit from ExtensionForm, that is all.
    public partial class Main : ExtensionForm
    {
        public Main()
        {
            InitializeComponent();

            /* If you wish to receive ALL in/out data, subcribe to these events. */
            /* Begins listening for outgoing data. */
            //Connection.DataOutgoing += Connection_DataOutgoing;
            /* Begins listening for incoming data. */
            //Connection.DataIncoming += Connection_DataIncoming;

            // When a packet with the header value of '2031' is intercepted, pass the data to 'MyOutCallback' for further processing.
            Triggers.OutAttach(2031, MyOutCallback);

            // Block an incoming packet with the header value of '4002'.
            //Connection.IncomingBlocked.Add(4002);

            // Specify that we want to Triggers to detect supported outgoing packet types.
            Triggers.DetectOutgoing = true;
            // When the 'HostNavigateRoom' packet is detected, call 'Triggers_HostNavigateRoom'.
            Triggers.HostNavigateRoom += Triggers_HostNavigateRoom;

            // Our IHConnection object to send/block data.
            // Connection
        }

        // We can block/replace packets in detected in-game events.
        private void Triggers_HostNavigateRoom(object sender, HostNavigateRoomEventArgs e)
        {
            // Force people to come to The Nut House.
            if (Hotel == HHotel.Com && e.RoomId != 68219082)
                e.Replacement.Replace<int>(68219082);
        }

        // We can block/replace packets in attach methods.
        private void MyOutCallback(object sender, InterceptedEventArgs e)
        {
            // We can't read an integer for this packet, let's leave.
            if (!e.Packet.CanRead<string>()) return;

            string value = e.Packet.ReadString(0);
            switch (value)
            {
                // If the string value is "block", let's block it.
                case "block":
                {
                    e.IsBlocked = true;
                    break;
                }

                // If the string value is "replace", let's replace it with "REPLACED!".
                case "replace":
                {
                    e.Replacement.Replace<string>("REPLACED");
                    break;
                }

                // If the string value is "wait", let's do some heavy processing, and still allow data to come through.
                case "wait":
                {
                    // This will tell the caller to continue spitting out data, while we have it wait for this end result.
                    // We can still replace/block this packet while more data comes through.
                    e.ContinueRead();

                    // Simulate long process.
                    Thread.Sleep(5000);

                    // It turns out Clyde DOES want to replace this packet after waiting 5 seconds, god dammit.
                    e.Replacement.Replace<string>("We waited 5 seconds, and replaced. God dammit Clyde");

                    // Don't worry though, we got you, now you never have to worry about Clyde messing up your day ever again.
                    break;
                }
            }
        }

        private void Connection_DataIncoming(object sender, InterceptedEventArgs e)
        { }
        private void Connection_DataOutgoing(object sender, InterceptedEventArgs e)
        { }
    }
}