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

using System.IO;
using System.Drawing;

using Eavesdrop;

using Sulakore.Communication;
using Sulakore.Protocol.Encryption;
using Sulakore.Protocol;

namespace Tanji.Managers
{
    public class HandshakeManager
    {
        private Bitmap _banner;
        private string _bannerToken;
        private byte[] _localKey, _remoteKey;

        public MainFrm MainUI { get; }
        private HNode Local => MainUI.Connection.Local;
        private HNode Remote => MainUI.Connection.Remote;

        public const int FAKE_EXPONENT = 3;
        public const string FAKE_MODULUS = "86851dd364d5c5cece3c883171cc6ddc5760779b992482bd1e20dd296888df91b33b936a7b93f06d29e8870f703a216257dec7c81de0058fea4cc5116f75e6efc4e9113513e45357dc3fd43d4efab5963ef178b78bd61e81a14c603b24c8bcce0a12230b320045498edc29282ff0603bc7b7dae8fc1b05b52b2f301a9dc783b7";
        public const string FAKE_PRIVATE_EXPONENT = "59ae13e243392e89ded305764bdd9e92e4eafa67bb6dac7e1415e8c645b0950bccd26246fd0d4af37145af5fa026c0ec3a94853013eaae5ff1888360f4f9449ee023762ec195dff3f30ca0b08b8c947e3859877b5d7dced5c8715c58b53740b84e11fbc71349a27c31745fcefeeea57cff291099205e230e0c7c27e8e1c0512b";

        public const int DEFAULT_REAL_EXPONENT = 10001;
        public const string DEFAULT_REAL_MODULUS = "e052808c1abef69a1a62c396396b85955e2ff522f5157639fa6a19a98b54e0e4d6e44f44c4c0390fee8ccf642a22b6d46d7228b10e34ae6fffb61a35c11333780af6dd1aaafa7388fa6c65b51e8225c6b57cf5fbac30856e896229512e1f9af034895937b2cb6637eb6edf768c10189df30c10d8a3ec20488a198063599ca6ad";

        public int RealExponent { get; set; }
        public string RealModulus { get; set; }

        public HandshakeManager(MainFrm main)
        {
            MainUI = main;
            MainUI.Connection.DataIncoming += DataIncoming;
            MainUI.Connection.DataOutgoing += DataOutgoing;
        }

        private void DataIncoming(object sender, InterceptedEventArgs e)
        {
            switch (e.Step)
            {
                case 1:
                {
                    if (RealExponent == 0)
                        RealExponent = DEFAULT_REAL_EXPONENT;

                    if (string.IsNullOrWhiteSpace(RealModulus))
                        RealModulus = DEFAULT_REAL_MODULUS;

                    Remote.Exchange = new HKeyExchange(RealExponent, RealModulus);
                    Local.Exchange = new HKeyExchange(FAKE_EXPONENT, FAKE_MODULUS, FAKE_PRIVATE_EXPONENT);

                    string possibleSignedPrime = e.Packet.ReadString();
                    if (!e.Packet.CanRead<string>())
                    {
                        _bannerToken = possibleSignedPrime;

                        Eavesdropper.EavesdropperResponse += EavesdropperResponse;
                        Eavesdropper.Initiate(8080);
                        return;
                    }
                    string signedGenerator = e.Packet.ReadString();

                    Remote.Exchange.DoHandshake(possibleSignedPrime, signedGenerator);
                    Local.Exchange.Rsa.Padding = Remote.Exchange.Rsa.Padding;

                    e.Replacement = new HMessage(e.Packet.Header,
                        Local.Exchange.GetSignedPrime(), Local.Exchange.GetSignedGenerator());
                    break;
                }
                case 2:
                {
                    _remoteKey = Remote.Exchange.GetSharedKey(e.Packet.ReadString());
                    if (_banner == null)
                    {
                        Local.Exchange.Rsa.Padding = Remote.Exchange.Rsa.Padding;
                        e.Replacement.Replace<string>(0, Local.Exchange.GetPublicKey());
                    }
                    else e.Replacement = new HMessage(e.Packet.Header, "1");

                    RealExponent = 0;
                    RealModulus = string.Empty;

                    Local.Exchange.Dispose();
                    Remote.Exchange.Dispose();

                    Local.Decrypter = new Rc4(_localKey);
                    Remote.Decrypter = new Rc4(_remoteKey);
                    break;
                }
                case 3:
                {
                    if (Remote.IsDecryptionRequired)
                        Local.Encrypter = new Rc4(_localKey);

                    MainUI.Connection.DataIncoming -= DataIncoming;
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
                    if (!string.IsNullOrWhiteSpace(_bannerToken))
                    {
                        if (_banner == null)
                        {
                            MainUI.Connection.DataIncoming -= DataIncoming;
                            MainUI.Connection.DataOutgoing -= DataOutgoing;

                            Eavesdropper.Terminate();
                            Eavesdropper.EavesdropperResponse -= EavesdropperResponse;

                            return;
                        }
                        else _localKey = new byte[] { 1 };
                    }
                    else _localKey = Local.Exchange.GetSharedKey(e.Packet.ReadString());

                    Remote.Exchange.Rsa.Padding = Local.Exchange.Rsa.Padding;
                    e.Replacement.Replace<string>(0, Remote.Exchange.GetPublicKey());
                    break;
                }
                case 4:
                {
                    if (Local.IsDecryptionRequired)
                        Remote.Encrypter = new Rc4(_remoteKey);

                    MainUI.Connection.DataOutgoing -= DataOutgoing;
                    break;
                }
            }
        }

        private void EavesdropperResponse(object sender, EavesdropperResponseEventArgs e)
        {
            if (e.Response.ResponseUri.OriginalString.Contains(_bannerToken))
            {
                using (var bannerStream = new MemoryStream(e.Payload))
                    _banner = new Bitmap(bannerStream);

                Remote.Exchange.DoHandshake(_banner, _bannerToken);
                Local.Exchange.Rsa.Padding = Remote.Exchange.Rsa.Padding;

                Eavesdropper.Terminate();
                Eavesdropper.EavesdropperResponse -= EavesdropperResponse;
            }
        }
    }
}