using System;
using System.Windows.Forms;

namespace Tanji.Pages
{
    public abstract class TanjiPage
    {
        private readonly TabControl _tabControl;

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
                    Tab.Invoke(new MethodInvoker(() =>
                    {
                        Tab.Text =
                            (Title + (value ? "(!)" : string.Empty));
                    }));
                }
            }
        }

        public TanjiPage(MainFrm ui, TabPage tab)
        {
            UI = ui;
            Tab = tab;
            Name = tab.Name;
            Title = tab.Text;

            Tab.Enter += Tab_Enter;

            _tabControl = (TabControl)tab.Parent;
        }

        protected virtual void OnTabEnter()
        {
            WriteLog(nameof(OnTabEnter), $"'{Name}' has accquired focus.");
        }
        private void Tab_Enter(object sender, EventArgs e)
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
    }
}