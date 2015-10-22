/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

using Sulakore;
using Sulakore.Protocol;

namespace Tanji.Managers.Injection
{
    public class PrimitiveManager
    {
        public MainFrm MainUI { get; }

        public PrimitiveManager(MainFrm main)
        {
            MainUI = main;

            MainUI.InjectionTabs.Selected += InjectionTabs_Selected;

            MainUI.PTCutBtn.Click += PTCutBtn_Click;
            MainUI.PTCopyBtn.Click += PTCopyBtn_Click;
            MainUI.PTPasteBtn.Click += PTPasteBtn_Click;

            MainUI.PTUndoBtn.Click += PTUndoBtn_Click;
            MainUI.PTSelectAllBtn.Click += PTSelectAllBtn_Click;

            MainUI.PTStringBtn.Click += PTStringBtn_Click;
            MainUI.PTBooleanBtn.Click += PTBooleanBtn_Click;
            MainUI.PTIntegerBtn.Click += PTIntegerBtn_Click;
            MainUI.PTLengthHeaderBtn.Click += PTLengthHeaderBtn_Click;

            MainUI.PTPacketInfoLbl.SizeChanged += PTPacketInfoLbl_SizeChanged;
        }

        private void PTStringBtn_Click(object sender, EventArgs e)
        {
            InsertParamter("s");
        }
        private void PTBooleanBtn_Click(object sender, EventArgs e)
        {
            InsertParamter("b");
        }
        private void PTIntegerBtn_Click(object sender, EventArgs e)
        {
            InsertParamter("i");
        }
        private void PTLengthHeaderBtn_Click(object sender, EventArgs e)
        {
            int endSelect = 0;
            if (!MainUI.PTPacketTxt.Text.StartsWith("{l}{u:"))
            {
                string headerString = "0";
                byte[] data = HMessage.ToBytes(MainUI.PTPacketTxt.Text);
                if (data.Length >= 6)
                {
                    int length = BigEndian.ToInt32(data, 0);
                    ushort header = BigEndian.ToUInt16(data, 4);

                    byte[] headerLength = new byte[6];
                    Buffer.BlockCopy(data, 0, headerLength, 0, 6);

                    if (length == (data.Length - 4))
                    {
                        headerString = header.ToString();
                        string toReplace = HMessage.ToString(headerLength);
                        MainUI.PTPacketTxt.Text = MainUI.PTPacketTxt.Text.Remove(0, toReplace.Length);
                    }
                }

                MainUI.PTPacketTxt.Text = MainUI.PTPacketTxt.Text.Insert(0, $"{{l}}{{u:{headerString}}}");
                endSelect = headerString.Length;
            }
            else
            {
                string headerLengthParamValue = MainUI.PTPacketTxt.Text
                    .GetChild("{l}{u:").GetParent("}");

                endSelect = headerLengthParamValue.Length;
            }
            MainUI.PTPacketTxt.Select(6, endSelect);
        }

        private void PTPacketTxt_TextChanged(object sender, EventArgs e)
        {
            ushort header = 0;
            bool isCorrupted = false;
            string packetTxt = MainUI.PTPacketTxt.Text;

            byte[] data = HMessage.ToBytes(packetTxt);
            int length = data.Length;

            if (length < 6) isCorrupted = true;
            else
            {
                length = BigEndian.ToInt32(data, 0);
                header = BigEndian.ToUInt16(data, 4);

                int realLength = data.Length - 4;
                isCorrupted = (realLength != length);
            }

            MainUI.ITPacketTxt.Text = isCorrupted ?
                MainUI.PTPacketTxt.Text : HMessage.ToString(data);

            MainUI.PTPacketInfoLbl.Text =
                $"Header: {header} | Length: {length} | IsCorrupted:";

            MainUI.PTIsCorruptedLbl.Text = isCorrupted.ToString();
            MainUI.PTIsCorruptedLbl.ForeColor = isCorrupted ?
                Color.Firebrick : SystemColors.HotTrack;
        }
        private void InjectionTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == MainUI.PrimitiveTab)
            {
                MainUI.PTPacketTxt.Text = MainUI.ITPacketTxt.Text;

                MainUI.ITPacketTxt.Enabled = false;
                MainUI.PTPacketTxt.TextChanged += PTPacketTxt_TextChanged;
            }
            else
            {
                MainUI.ITPacketTxt.Enabled = true;
                MainUI.PTPacketTxt.TextChanged -= PTPacketTxt_TextChanged;
            }
        }

        private void PTCutBtn_Click(object sender, EventArgs e)
        {
            MainUI.PTPacketTxt.Cut();
        }
        private void PTCopyBtn_Click(object sender, EventArgs e)
        {
            MainUI.PTPacketTxt.Copy();
        }
        private void PTUndoBtn_Click(object sender, EventArgs e)
        {
            MainUI.PTPacketTxt.Undo();
        }
        private void PTPasteBtn_Click(object sender, EventArgs e)
        {
            MainUI.PTPacketTxt.Paste();
        }
        private void PTSelectAllBtn_Click(object sender, EventArgs e)
        {
            MainUI.PTPacketTxt.SelectAll();
        }

        private void PTPacketInfoLbl_SizeChanged(object sender, EventArgs e)
        {
            MainUI.PTIsCorruptedLbl.Location = new Point(
                MainUI.PTPacketInfoLbl.Width - 2, MainUI.PTIsCorruptedLbl.Location.Y);
        }

        private void InsertParamter(string paramName)
        {
            object value = null;
            byte[] data = HMessage.ToBytes(MainUI.PTPacketTxt.SelectedText);
            switch (paramName)
            {
                case "i":
                {
                    if (data.Length == 4)
                        value = BigEndian.ToInt32(data, 0);
                    break;
                }
                case "s":
                {
                    if (data.Length >= 2)
                    {
                        int length = BigEndian.ToUInt16(data, 0);
                        if (length == data.Length - 2)
                            value = Encoding.UTF8.GetString(data, 2, length);
                    }
                    break;
                }
                case "b":
                {
                    if (data.Length == 1)
                        value = Convert.ToBoolean(data[0]);
                    break;
                }
            }

            string param = $"{{{paramName}:{value}}}";

            int start = (value == null ?
                MainUI.PTPacketTxt.TextLength : MainUI.PTPacketTxt.SelectionStart);

            if (value != null)
            {
                MainUI.PTPacketTxt.Text = MainUI.PTPacketTxt.Text.Remove(
                    start, MainUI.PTPacketTxt.SelectedText.Length);
            }

            string valueString = value == null ?
                string.Empty : value.ToString();

            MainUI.PTPacketTxt.Text = MainUI.PTPacketTxt.Text.Insert(start, param);
            MainUI.PTPacketTxt.Select(start + 3, valueString.Length);
        }
    }
}