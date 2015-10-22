/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

using System;

using Sulakore.Protocol;

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
                Encode(BigEndian.GetBytes, (ushort)MainUI.EDTShortInputTxt.Value);
        }
        private void EDTEncodeIntegerBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTIntegerOutputTxt.Text =
                Encode(BigEndian.GetBytes, (int)MainUI.EDTIntegerInputTxt.Value);
        }

        private void EDTDecodeShortBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTShortInputTxt.UpButton();
            MainUI.EDTShortInputTxt.Value =
                Decode(BigEndian.ToUInt16, MainUI.EDTShortOutputTxt.Text);
        }
        private void EDTDecodeIntegerBtn_Click(object sender, EventArgs e)
        {
            MainUI.EDTIntegerInputTxt.UpButton();
            MainUI.EDTIntegerInputTxt.Value =
                Decode(BigEndian.ToInt32, MainUI.EDTIntegerOutputTxt.Text);
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

                int value = BigEndian.ToInt32(block, 0);
                string encoded = HMessage.ToString(block);

                MainUI.EDTDecodedVw.FocusAdd(value, encoded, i);
            }
        }

        private string Encode<T>(Func<T, byte[]> encoder, T value)
        {
            byte[] data = encoder(value);
            return HMessage.ToString(data);
        }
        private T Decode<T>(Func<byte[], int, T> decoder, string encoded)
        {
            if (string.IsNullOrWhiteSpace(encoded))
                return default(T);

            byte[] data = HMessage.ToBytes(encoded);
            return decoder(data, 0);
        }
    }
}