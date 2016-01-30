using System.Windows.Forms;

namespace Tanji.Pages.Injection
{
    public class FiltersPage : TanjiSubPage<InjectionPage>
    {
        public FiltersPage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        {
            UI.InjectionTabs.TabPages.Remove(UI.FiltersTab);
        }
    }
}