using Sulakore.Communication;
using Sulakore.Protocol.Encryption;

namespace Tanji.Managers
{
    public class HandshakeManager
    {
        private readonly MainFrm _main;

        private byte[] _localKey, _remoteKey;

        public HNode Local
        {
            get { return _main.Connection.Local; }
        }
        public HNode Remote
        {
            get { return _main.Connection.Remote; }
        }

        public HandshakeManager(MainFrm main)
        {
            _main = main;

            _main.Connection.DataIncoming += DataIncoming;
            _main.Connection.DataOutgoing += DataOutgoing;
        }

        private void DataIncoming(object sender, InterceptedEventArgs e)
        {
            switch (e.Step)
            {
                case 1:
                {
                    Remote.Exchange.DoHandshake(e.Packet.ReadString(),
                        e.Packet.ReadString(e.Packet.Position));

                    e.Replacement.Replace<string>(0, Local.Exchange.GetSignedPrime());
                    e.Replacement.Replace<string>(e.Packet.Position, Local.Exchange.GetSignedGenerator());
                    break;
                }
                case 2:
                {
                    _remoteKey = Remote.Exchange.GetSharedKey(e.Packet.ReadString());
                    e.Replacement.Replace<string>(0, Local.Exchange.GetPublicKey());

                    Local.Decrypter = new Rc4(_localKey);
                    Remote.Decrypter = new Rc4(_remoteKey);

                    _main.Connection.DataIncoming -= DataIncoming;
                    break;
                }
            }
        }
        private void DataOutgoing(object sender, InterceptedEventArgs e)
        {
            switch (e.Step)
            {
                case 3:
                {
                    _localKey = Local.Exchange.GetSharedKey(e.Packet.ReadString());
                    e.Replacement.Replace<string>(0, Remote.Exchange.GetPublicKey());
                    break;
                }
                case 4:
                {
                    Local.Encrypter = new Rc4(_localKey);
                    Remote.Encrypter = new Rc4(_remoteKey);

                    _main.Connection.DataOutgoing -= DataOutgoing;
                    break;
                }
            }
        }
    }
}