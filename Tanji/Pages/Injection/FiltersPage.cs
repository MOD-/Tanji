using System.Windows.Forms;

using Sulakore.Communication;

namespace Tanji.Pages.Injection
{
    public class FiltersPage : TanjiSubPage<InjectionPage>, IDataHandler
    {
        public bool IsHandlingOutgoing { get; private set; } = false;
        public bool IsHandlingIncoming { get; private set; } = false;

        public FiltersPage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        {
            UI.InjectionTabs.TabPages.Remove(tab);
        }

        public void HandleOutgoing(InterceptedEventArgs e)
        { }
        public void HandleIncoming(InterceptedEventArgs e)
        { }
    }
}