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
    test
*/

using System;
using System.Windows.Forms;

using Sulakore.Protocol;
using Sulakore.Components;
using Sulakore.Communication;

namespace Tanji.Managers.Injection
{
    public class SchedulerManager
    {
        public MainFrm MainUI { get; }

        public SchedulerManager(MainFrm main)
        {
            MainUI = main;

            MainUI.STClearBtn.Click += STClearBtn_Click;
            MainUI.STRemoveBtn.Click += STRemoveBtn_Click;
            MainUI.STCreateBtn.Click += STCreateBtn_Click;
            MainUI.STStopAllBtn.Click += STStopAllBtn_Click;
            MainUI.STStartAllBtn.Click += STStartAllBtn_Click;
            MainUI.STSchedulerVw.ScheduleTick += STSchedulerVw_ScheduleTick;
            MainUI.STAutoStartChckbx.CheckedChanged += STAutoStartChckbx_CheckedChanged;

            MainUI.STSchedulerVw.ItemChecked += STSchedulerVw_ItemChecked;
            MainUI.STSchedulerVw.ItemSelected += STSchedulerVw_ItemSelected;
            MainUI.STSchedulerVw.ItemsDeselected += STSchedulerVw_ItemsDeselected;

            MainUI.STDestinationTxt.SelectedIndex = 1;
        }

        private void STClearBtn_Click(object sender, EventArgs e)
        {
            MainUI.STSchedulerVw.ClearItems();
            UpdateSchedulesActiveLabel();
        }
        private void STCreateBtn_Click(object sender, EventArgs e)
        {
            var destination = ((HDestination)MainUI.STDestinationTxt.SelectedIndex);
            var packet = new HMessage(MainUI.STPacketTxt.Text, destination);

            if (packet.IsCorrupted)
            {
                MessageBox.Show("The given data seems corrupted, the schedule will not be created.",
                    "Tanji ~ Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainUI.STSchedulerVw.AddSchedule(packet,
                    (int)MainUI.STIntervalTxt.Value, (int)MainUI.STBurstTxt.Value);

                UpdateSchedulesActiveLabel();
            }
        }
        private void STRemoveBtn_Click(object sender, EventArgs e)
        {
            MainUI.STSchedulerVw.RemoveSelectedItem();
            UpdateSchedulesActiveLabel();
        }
        private void STStopAllBtn_Click(object sender, EventArgs e)
        {
            MainUI.STSchedulerVw.StopAll();
            UpdateSchedulesActiveLabel();
        }
        private void STStartAllBtn_Click(object sender, EventArgs e)
        {
            MainUI.STSchedulerVw.StartAll();
            UpdateSchedulesActiveLabel();
        }
        private void STAutoStartChckbx_CheckedChanged(object sender, EventArgs e)
        {
            MainUI.STSchedulerVw.AutoStart =
                MainUI.STAutoStartChckbx.Checked;
        }
        private void STSchedulerVw_ScheduleTick(object sender, ScheduleTickEventArgs e)
        {
            e.Cancel = e.Packet.IsCorrupted;
            if (e.Cancel) return;

            HNode node = (e.Packet.Destination == HDestination.Server ?
                MainUI.Connection.Remote : MainUI.Connection.Local);

            // Fire n forget m8
            node?.SendAsync(e.Packet.ToBytes());
        }

        private void STSchedulerVw_ItemsDeselected(object sender, EventArgs e)
        {
            ToggleModifiers(false);
        }
        private void STSchedulerVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateSchedulesActiveLabel();
        }
        private void STSchedulerVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ToggleModifiers(true);
        }

        private void ToggleModifiers(bool enable)
        {
            int itemCount = MainUI.STSchedulerVw.Items.Count;

            MainUI.STStartAllBtn.Enabled =
                MainUI.STStopAllBtn.Enabled =
                MainUI.STClearBtn.Enabled = itemCount > 0;

            MainUI.STRemoveBtn.Enabled = enable;
        }
        private void UpdateSchedulesActiveLabel()
        {
            MainUI.SchedulesActiveTxt.Text =
                $"Schedules Active: {MainUI.STSchedulerVw.SchedulesRunning}/{MainUI.STSchedulerVw.Items.Count}";
        }
    }
}