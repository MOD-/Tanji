﻿using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Tanji.Pages
{
    public abstract class TanjiPage : INotifyPropertyChanged
    {
        private readonly TabControl _tabControl;
        private readonly MethodInvoker _onNotifyingChanged;
        private readonly Action<PropertyChangedEventArgs> _onPropertyChanged;

        public MainFrm UI { get; }
        public TabPage Tab { get; }
        public string Name { get; }
        public string Title { get; }

        private bool _isNotifying;
        public bool IsNotifying
        {
            get { return _isNotifying; }
            set
            {
                if (_isNotifying != value)
                {
                    _isNotifying = value;
                    Tab.Invoke(_onNotifyingChanged);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaiseOnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (UI.InvokeRequired)
                UI.Invoke(_onPropertyChanged, e);
            else
                PropertyChanged?.Invoke(this, e);
        }

        public TanjiPage(MainFrm ui, TabPage tab)
        {
            UI = ui;
            Tab = tab;
            Name = tab.Name;
            Title = tab.Text;

            Tab.Enter += TabEnter;

            _tabControl = (TabControl)tab.Parent;
            _onNotifyingChanged = OnNotifyingChanged;
        }

        protected virtual void OnTabEnter()
        {
            WriteLog(nameof(OnTabEnter), $"'{Name}' has accquired focus.");
        }
        private void TabEnter(object sender, EventArgs e)
        {
            IsNotifying = false;
            OnTabEnter();
        }

        public virtual void Select()
        {
            _tabControl.SelectedTab = Tab;
        }
        public void WriteLog(string title, string message)
        {
            title = (string.IsNullOrWhiteSpace(title) ? nameof(WriteLog) : title);
            title = $"[{title}, {Name}, {DateTime.Now}]";

            string log = (title + ": " + message);
            // TODO: Write this log somewhere.
        }

        protected virtual void OnNotifyingChanged()
        {
            Tab.Text = (Title +
                (IsNotifying ? "(!)" : string.Empty));
        }
    }
}