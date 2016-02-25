using System.Windows.Forms;

using Sulakore.Communication;

namespace Tanji.Pages.Extensions
{
    public class ExtensionsPage : TanjiPage, IDataHandler
    {
        public bool IsHandlingOutgoing { get; } = false;
        public bool IsHandlingIncoming { get; } = false;

        public ExtensionsPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        { }

        public void HandleOutgoing(DataInterceptedEventArgs e)
        { }
        public void HandleIncoming(DataInterceptedEventArgs e)
        { }

        protected override void OnTabSelecting(TabControlCancelEventArgs e)
        {
            e.Cancel = true;
            base.OnTabSelecting(e);
        }
    }
}