﻿using Sulakore.Protocol;
using Sulakore.Communication;
using Sulakore.Protocol.Encryption;

namespace Tanji.Pages.Connection.Managers
{
    #region Handshake Process
    /*
        1[Outgoing](Irrelevant) 
        2[Outgoing](Irrelevant)

        1[Incoming](Receive signed diffie-hellman p/g values)
        3[Outgoing](Client verifies p/g, and sends public key to the server that was calculated using the verified primes)
        { public = ((g ^ private) mod p) }
        At this point, the server is able to calculate the shared key.
        This also means the server is expecting the next packet to be encrypted with the shared key.
        2[Incoming](Receive the server's public key)
        { sharedKey = ((serverPubKey ^ private) mod p) }
        Anything from here on out SHOULD, be encrypted/decrypted with the calculated key(s).
        Note that the "exploit" Tanji utilizes requires two handshake processes to take place.
    */
    #endregion
    public class HandshakeManager : IDataHandler
    {
        private int _incomingOffset;
        private byte[] _localSharedKey, _remoteSharedKey;

        public bool IsHandlingOutgoing { get; private set; } = true;
        public bool IsHandlingIncoming { get; private set; } = true;

        public IDataManager DataManager { get; }
        public HNode Local => DataManager.Connection.Local;
        public HNode Remote => DataManager.Connection.Remote;

        public const int FAKE_EXPONENT = 3;
        public const string FAKE_MODULUS = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        public const string FAKE_PRIVATE_EXPONENT = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";

        public const int REAL_EXPONENT = 65537;
        public const string REAL_MODULUS = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

        public HandshakeManager(IDataManager dataManager)
        {
            DataManager = dataManager;
        }

        private void InitializeKeys()
        {
            Remote.Exchange = new HKeyExchange(REAL_EXPONENT, REAL_MODULUS);
            Local.Exchange = new HKeyExchange(FAKE_EXPONENT, FAKE_MODULUS, FAKE_PRIVATE_EXPONENT);
        }
        private void FinalizeHandshake()
        {
            DataManager.RemoveDataHandler(this);
        }
        private void ReplaceLocalPublicKey(DataInterceptedEventArgs e)
        {
            string localPublicKey = e.Packet.ReadString();
            _localSharedKey = Local.Exchange.GetSharedKey(localPublicKey);

            // Use the same padding the client used when encrypting our public key.
            Remote.Exchange.Padding = Local.Exchange.Padding;

            string remotePublicKey = Remote.Exchange.GetPublicKey();
            e.Packet.ReplaceString(remotePublicKey, 0);
        }
        private void ReplaceRemotePublicKey(DataInterceptedEventArgs e)
        {
            string remotePublicKey = e.Packet.ReadString();
            _remoteSharedKey = Remote.Exchange.GetSharedKey(remotePublicKey);

            // Use the same padding the server used when signing our public key.
            Local.Exchange.Padding = Remote.Exchange.Padding;

            string localPublicKey = Local.Exchange.GetPublicKey();
            e.Packet.ReplaceString(localPublicKey, 0);

            Local.Exchange.Dispose();
            Remote.Exchange.Dispose();

            Local.Decrypter = new Rc4(_localSharedKey);
            Remote.Encrypter = new Rc4(_remoteSharedKey);
        }
        private void ReplaceRemoteSignedPrimes(DataInterceptedEventArgs e)
        {
            string remoteP = e.Packet.ReadString();
            string remoteG = e.Packet.ReadString();
            Remote.Exchange.VerifyDHPrimes(remoteP, remoteG);

            // Use the same padding the server used when signing our generated primes.
            Local.Exchange.Padding = Remote.Exchange.Padding;

            string localP = Local.Exchange.GetSignedP();
            string localG = Local.Exchange.GetSignedG();
            e.Packet = new HMessage(e.Packet.Header, localP, localG);
        }

        public void HandleOutgoing(DataInterceptedEventArgs e)
        {
            bool threwException = false;
            try
            {
                switch (e.Step)
                {
                    case 2: _incomingOffset = 0; break;
                    case 3:
                    {
                        ReplaceLocalPublicKey(e);
                        break;
                    }
                    case 4:
                    {
                        FinalizeHandshake();
                        break;
                    }
                }
            }
            catch { threwException = true; }
            finally { FinalizeInterception(e, threwException); }
        }
        public void HandleIncoming(DataInterceptedEventArgs e)
        {
            bool threwException = false;
            try
            {
                if (e.Step < 3 && e.Packet.Length == 2)
                {
                    _incomingOffset++;
                    return;
                }
                switch (e.Step - _incomingOffset)
                {
                    case 1:
                    {
                        InitializeKeys();
                        ReplaceRemoteSignedPrimes(e);
                        break;
                    }
                    case 2:
                    {
                        ReplaceRemotePublicKey(e);
                        break;
                    }
                }
            }
            catch { threwException = true; }
            finally { FinalizeInterception(e, threwException); }
        }

        private void FinalizeInterception(DataInterceptedEventArgs e, bool threwException)
        {
            e.IsBlocked = false;

            bool isOutgoing =
                (e.Packet.Destination == HDestination.Server);

            if (threwException ||
                (isOutgoing && e.Step == 2 && e.Packet.Length != 2))
            {
                Local.Encrypter = null;
                Local.Decrypter = null;
                Remote.Encrypter = null;
                Remote.Decrypter = null;

                Local.Exchange.Dispose();
                Remote.Exchange.Dispose();

                DataManager.RemoveDataHandler(this);
            }
        }
    }
}