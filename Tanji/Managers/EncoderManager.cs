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

using System;

using Sulakore.Protocol;
using Sulakore.Protocol.Encoders;

namespace Tanji.Managers
{
    public class EncoderManager
    {
        public MainFrm MainUI { get; }

        public EncoderManager(MainFrm main)
        {
            MainUI = main;

            MainUI.EDTDecodeShortBtn.Click += EDTDecodeShortBtn_Click;
            MainUI.EDTEncodeShortBtn.Click += EDTEncodeShortBtn_Click;

            MainUI.EDTEncodeIntegerBtn.Click += EDTEncodeIntegerBtn_Click;
            MainUI.EDTDecodeIntegerBtn.Click += EDTDecodeIntegerBtn_Click;

            MainUI.EDTDecodeValuesBtn.Click += EDTDecodeValuesBtn_Click;
        }

        private void EDTEncodeShortBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTShortOutputTxt.Text =
                Encode(BigEndian.FromUI16, (ushort)MainUI.EDTShortInputTxt.Value);
        }
        private void EDTEncodeIntegerBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTIntegerOutputTxt.Text =
                Encode(BigEndian.FromSI32, (int)MainUI.EDTIntegerInputTxt.Value);
        }

        private void EDTDecodeShortBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTShortInputTxt.UpButton();
            MainUI.EDTShortInputTxt.Value =
                Decode(BigEndian.ToUI16, MainUI.EDTShortOutputTxt.Text);
        }
        private void EDTDecodeIntegerBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTIntegerInputTxt.UpButton();
            MainUI.EDTIntegerInputTxt.Value =
                Decode(BigEndian.ToSI32, MainUI.EDTIntegerOutputTxt.Text);
        }

        private void EDTDecodeValuesBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTDecodedVw.Items.Clear();
            string encodedBlocks = MainUI.EDTEncodedValuesTxt.Text;
            byte[] data = HMessage.ToBytes(encodedBlocks);

            if (data.Length % 4 != 0) return;
            for (int i = 0; i < data.Length; i += 4)
            {
                var block = new byte[4];
                Buffer.BlockCopy(data, i, block, 0, 4);

                int value = BigEndian.ToSI32(block);
                string encoded = HMessage.ToString(block);

                MainUI.EDTDecodedVw.FocusAdd(value, encoded, i);
            }
        }

        private string Encode<T>(Func<T, byte[]> encoder, T value)
        {
            byte[] data = encoder(value);
            return HMessage.ToString(data);
        }
        private T Decode<T>(Func<byte[], T> decoder, string encoded)
        {
            if (string.IsNullOrWhiteSpace(encoded))
                return default(T);

            byte[] data = HMessage.ToBytes(encoded);
            return decoder(data);
        }
    }
}