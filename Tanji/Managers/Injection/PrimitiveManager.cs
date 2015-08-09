using System;
using System.Drawing;
using System.Windows.Forms;

using Sulakore;
using Sulakore.Protocol;
using Sulakore.Protocol.Encoders;

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
            throw new NotImplementedException();
        }
        private void PTBooleanBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void PTIntegerBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
                    int length = BigEndian.ToSI32(data);
                    ushort header = BigEndian.ToUI16(data, 4);

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
                length = BigEndian.ToSI32(data);
                header = BigEndian.ToUI16(data, 4);

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
    }
}