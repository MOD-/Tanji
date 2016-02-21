using System;
using System.Windows.Forms;

using Sulakore.Protocol;
using Sulakore.Components;

namespace Tanji.Pages.Injection
{
    public class SchedulerPage : TanjiSubPage<InjectionPage>
    {
        private ushort _interval = 100;
        public ushort Interval
        {
            get { return _interval; }
            set
            {
                _interval = value;
                RaiseOnPropertyChanged(nameof(Interval));
            }
        }

        private int _cycles = 0;
        public int Cycles
        {
            get { return _cycles; }
            set
            {
                _cycles = value;
                RaiseOnPropertyChanged(nameof(Cycles));
            }
        }

        private bool _autoStart = true;
        public bool AutoStart
        {
            get { return _autoStart; }
            set
            {
                _autoStart = value;
                RaiseOnPropertyChanged(nameof(AutoStart));
            }
        }

        private HDestination _destination = HDestination.Server;
        public HDestination Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
                RaiseOnPropertyChanged(nameof(Destination));
            }
        }

        public SchedulerPage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        {
            UI.STDestinationTxt.DataSource = Enum.GetValues(typeof(HDestination));
            UI.STDestinationTxt.DataBindings.Add("SelectedItem", this,
                nameof(Destination), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.STCyclesTxt.DataBindings.Add("Value", this,
                nameof(Cycles), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.STIntervalTxt.DataBindings.Add("Value", this,
                nameof(Interval), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.STAutoStartChckbx.DataBindings.Add("Checked", this,
                nameof(AutoStart), false, DataSourceUpdateMode.OnPropertyChanged);

            UI.STClearBtn.Click += STClearBtn_Click;
            UI.STRemoveBtn.Click += STRemoveBtn_Click;
            UI.STCreateBtn.Click += STCreateBtn_Click;
            UI.STUpdateBtn.Click += STUpdateBtn_Click;

            UI.STSchedulerVw.ItemChecked += STSchedulerVw_ItemChecked;
            UI.STSchedulerVw.ScheduleTick += STSchedulerVw_ScheduleTick;
            UI.STSchedulerVw.ItemSelectionStateChanged += STSchedulerVw_ItemSelectionStateChanged;
        }

        private void UpdateUI()
        {
            UI.SchedulesActiveTxt.Text =
                $"Schedules Active: {UI.STSchedulerVw.CheckedItems.Count}/{UI.STSchedulerVw.Items.Count}";
        }
        public HMessage GetPacket()
        {
            return new HMessage(
                UI.STPacketTxt.Text, Destination);
        }

        protected override void OnTabSelecting(TabControlCancelEventArgs e)
        {
            UI.InjectionMenu.InputBox = UI.STPacketTxt;
            base.OnTabSelecting(e);
        }

        private void STClearBtn_Click(object sender, EventArgs e)
        {
            UI.STSchedulerVw.ClearItems();
            UpdateUI();
        }
        private void STUpdateBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetPacket();
            if (Parent.IsInjectionAuthorized(packet))
            {
                UI.STSchedulerVw.SelectedCycles = Cycles;
                UI.STSchedulerVw.SelectedInterval = Interval;
                UI.STSchedulerVw.SelectedDestination = Destination;
                UI.STSchedulerVw.SelectedPacket = GetPacket().ToString();
            }
        }
        private void STRemoveBtn_Click(object sender, EventArgs e)
        {
            UI.STSchedulerVw.RemoveSelectedItem();
            UpdateUI();
        }
        private void STCreateBtn_Click(object sender, EventArgs e)
        {
            HMessage packet = GetPacket();
            if (!Parent.IsInjectionAuthorized(packet)) return;

            packet.Destination = Destination;
            UI.STSchedulerVw.AddSchedule(packet, Interval, Cycles, AutoStart);
        }

        private void STSchedulerVw_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            UpdateUI();
        }
        private void STSchedulerVw_ScheduleTick(object sender, ScheduleTickEventArgs e)
        {
            if (Parent.SendAsync(e.Packet).Result < 6)
                e.Cancel = true;
        }
        private void STSchedulerVw_ItemSelectionStateChanged(object sender, EventArgs e)
        {
            UI.STUpdateBtn.Enabled =
                UI.STRemoveBtn.Enabled = UI.STSchedulerVw.HasSelectedItem;
        }
    }
}