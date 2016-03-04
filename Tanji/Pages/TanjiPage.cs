﻿using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tanji.Pages
{
    public abstract class TanjiPage : INotifyPropertyChanged
    {
        private readonly MethodInvoker _onNotifyingChanged;
        private readonly Action<PropertyChangedEventArgs> _onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaiseOnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(
                new PropertyChangedEventArgs(propertyName));
        }
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (UI.InvokeRequired)
            {
                UI.Invoke(_onPropertyChanged, e);
            }
            else
            {
                PropertyChanged?.Invoke(this, e);
            }
        }

        public MainFrm UI { get; }
        public TabPage Tab { get; }
        public string Title { get; }
        protected TabControl TabControl { get; }
        protected bool IsSelectedTab => (TabControl.SelectedTab == Tab);

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

        public TanjiPage(MainFrm ui, TabPage tab)
        {
            UI = ui;
            Tab = tab;
            Title = tab.Text;

            TabControl = (TabControl)tab.Parent;
            TabControl.Selecting += TabControl_Selecting;
            TabControl.Deselecting += TabControl_Deselecting;

            _onPropertyChanged = OnPropertyChanged;
            _onNotifyingChanged = OnNotifyingChanged;
        }

        public virtual void Select()
        {
            TabControl.SelectedTab = Tab;
        }

        protected virtual void OnTabSelecting(TabControlCancelEventArgs e)
        {
            IsNotifying = false;
        }
        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Tab)
                OnTabSelecting(e);
        }

        protected virtual void OnTabDeselecting(TabControlCancelEventArgs e)
        { }
        private void TabControl_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == Tab)
                OnTabDeselecting(e);
        }

        public virtual void WriteLog(string message,
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            if (string.IsNullOrWhiteSpace(memberName))
                memberName = Title;

            string log = $"{memberName}[#{sourceLineNumber}, {DateTime.Now}]: {message}";
            Console.WriteLine(log);
        }

        public virtual void WriteLog(Exception exception,
            [CallerMemberName] string memberName = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            WriteLog($"[{exception.GetType()}]" + exception.Message,
                memberName, sourceLineNumber);
        }

        protected virtual void OnNotifyingChanged()
        {
            Tab.Text = (Title +
                (IsNotifying ? "(!)" : string.Empty));
        }
    }
}