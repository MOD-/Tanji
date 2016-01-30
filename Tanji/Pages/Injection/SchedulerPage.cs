using System.Windows.Forms;

namespace Tanji.Pages.Injection
{
    public class SchedulerPage : TanjiSubPage<InjectionPage>
    {
        public SchedulerPage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        { }
    }
}