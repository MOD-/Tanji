/*
    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    This file is part of Tanji.
    Copyright (C) 2015 ArachisH
    
    This code is licensed under the GNU General Public License.
    See License.txt in the project root for license information.
*/

using System;
using System.Threading;
using System.Windows.Forms;

namespace Tanji.Managers.Injection
{
    public class ConstructerManager
    {
        private const string INVALID_INTEGER_VALUE =
            "The given value is either too large, or too small to be identified as a 32-bit signed integer.";

        public MainFrm MainUI { get; }

        public ConstructerManager(MainFrm main)
        {
            MainUI = main;

            MainUI.CTClearBtn.Click += CTClearBtn_Click;
            MainUI.CTRemoveBtn.Click += CTRemoveBtn_Click;
            MainUI.CTHeaderTxt.TextChanged += CTHeaderTxt_TextChanged;

            MainUI.CTAppendStringBtn.Click += CTAppendStringBtn_Click;
            MainUI.CTAppendBooleanBtn.Click += CTAppendBooleanBtn_Click;
            MainUI.CTAppendIntegerBtn.Click += CTAppendIntegerBtn_Click;

            MainUI.CTMoveUpBtn.Click += CTMoveUpBtn_Click;
            MainUI.CTMoveDownBtn.Click += CTMoveDownBtn_Click;
            MainUI.CTTransferBelowBtn.Click += CTTransferBelowBtn_Click;

            MainUI.CTConstructerVw.ItemActivate += CTConstructerVw_ItemActivate;
            MainUI.CTConstructerVw.ItemSelected += CTConstructerVw_ItemSelected;
            MainUI.CTConstructerVw.ItemsDeselected += CTConstructerVw_ItemsDeselected;

            MainUI.CTLiveEditingChckbx.CheckedChanged += CTLiveEditingChckbx_CheckedChanged;
            MainUI.CTLiveEditingChckbx.Checked = true;

            UpdatePacketTextLabel();
        }

        private void CTClearBtn_Click(object sender, EventArgs e)
        {
            MainUI.CTConstructerVw.ClearWritten();
            UpdateChunkCountLabel();
            UpdatePacketTextLabel();
        }
        private void CTRemoveBtn_Click(object sender, EventArgs e)
        {
            MainUI.CTConstructerVw.RemoveSelectedItem();
            UpdateChunkCountLabel();
            UpdatePacketTextLabel();
        }
        private void CTHeaderTxt_TextChanged(object sender, EventArgs e)
        {
            if (!Monitor.IsEntered(MainUI.CTHeaderTxt) &&
                Monitor.TryEnter(MainUI.CTHeaderTxt))
            {
                try
                {
                    ushort header = 0;
                    if (!ushort.TryParse(MainUI.CTHeaderTxt.Text, out header) ||
                        header.ToString() != MainUI.CTHeaderTxt.Text)
                    {
                        MainUI.CTHeaderTxt.Text = header.ToString();
                    }

                    MainUI.CTConstructerVw.Header = header;
                    UpdatePacketTextLabel();
                }
                finally { Monitor.Exit(MainUI.CTHeaderTxt); }
            }
            else return;
        }

        private void CTMoveUpBtn_Click(object sender, EventArgs e)
        {
            MainUI.CTConstructerVw.MoveSelectedItemUp();
            UpdatePacketTextLabel();
        }
        private void CTMoveDownBtn_Click(object sender, EventArgs e)
        {
            MainUI.CTConstructerVw.MoveSelectedItemDown();
            UpdatePacketTextLabel();
        }
        private void CTTransferBelowBtn_Click(object sender, EventArgs e)
        {
            MainUI.ITPacketTxt.Text = MainUI.CTConstructerVw.GetString();
        }

        private void CTAppendStringBtn_Click(object sender, EventArgs e)
        {
            Write(MainUI.CTValueTxt.Text);
        }
        private void CTAppendIntegerBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (!int.TryParse(MainUI.CTValueTxt.Text, out result))
            {
                MessageBox.Show(INVALID_INTEGER_VALUE,
                    "Tanji ~ Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            Write(result);
        }
        private void CTAppendBooleanBtn_Click(object sender, EventArgs e)
        {
            Write(ToBooleanValue(MainUI.CTValueTxt.Text));
        }

        private void CTValueTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            ListViewItem item = MainUI.CTConstructerVw.GetSelectedItem();
            if (item == null) return;

            object replacement = null;
            string original = MainUI.CTValueTxt.Text;
            switch (item.SubItems[0].Text)
            {
                case "Integer":
                {
                    int result = 0;
                    int.TryParse(original, out result);

                    replacement = result;
                    break;
                }
                case "String":
                {
                    replacement = original;
                    break;
                }
                case "Boolean":
                {
                    replacement = ToBooleanValue(original);
                    break;
                }
            }

            if (replacement != null)
            {
                MainUI.CTConstructerVw.ReplaceItem(replacement);
                UpdatePacketTextLabel();

                string replacementString = replacement.ToString();
                if (!MainUI.CTValueTxt.Items.Contains(replacementString))
                    MainUI.CTValueTxt.Items.Add(replacementString);
            }
        }
        private void CTLiveEditingChckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (MainUI.CTLiveEditingChckbx.Checked)
            {
                MainUI.CTValueTxt.KeyDown += CTValueTxt_KeyDown;
            }
            else
            {
                MainUI.CTValueTxt.KeyDown -= CTValueTxt_KeyDown;
            }
        }

        private void CTConstructerVw_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = MainUI.CTConstructerVw.GetSelectedItem();
            MainUI.CTValueTxt.Text = item.SubItems[1].Text;
            MainUI.CTValueTxt.Focus();
        }
        private void CTConstructerVw_ItemsDeselected(object sender, EventArgs e)
        {
            ToggleModifiers(false);
        }
        private void CTConstructerVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ToggleModifiers(true);
        }

        private void Write(object chunk)
        {
            string chunkString = chunk.ToString();
            if (!MainUI.CTValueTxt.Items.Contains(chunkString))
                MainUI.CTValueTxt.Items.Add(chunkString);

            var chunks = new object[(int)MainUI.CTCountTxt.Value];
            for (int i = 0; i < chunks.Length; i++)
                chunks[i] = chunk;

            MainUI.CTConstructerVw.Write(chunks);
            UpdateChunkCountLabel();
            UpdatePacketTextLabel();
        }
        private void UpdateChunkCountLabel()
        {
            MainUI.CTChunkCountLbl.Text = "Chunk Count: " +
                MainUI.CTConstructerVw.ValuesWritten.Count;
        }
        private void UpdatePacketTextLabel()
        {
            MainUI.CTPacketTxt.Text =
                MainUI.CTConstructerVw.GetString();
        }
        private void ToggleModifiers(bool enable)
        {
            MainUI.CTRemoveBtn.Enabled =
                MainUI.CTMoveUpBtn.Enabled =
                MainUI.CTMoveDownBtn.Enabled = enable;
        }
        private bool ToBooleanValue(string value)
        {
            value = value.ToLower();
            if (string.IsNullOrWhiteSpace(value)) return false;
            else
            {
                char c1 = value[0];
                return (c1 == 't' || (c1 == '1' && value.Length == 1));
            }
        }
    }
}