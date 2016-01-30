using System.Windows.Forms;

namespace Tanji.Pages.Injection
{
    public class InjectionPage : TanjiPage
    {
        public FiltersPage FiltersPg { get; }
        public PrimitivePage PrimitivePg { get; }
        public SchedulerPage SchedulerPg { get; }
        public ConstructerPage ConstructerPg { get; }

        public InjectionPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            FiltersPg = new FiltersPage(this, UI.FiltersTab);
            PrimitivePg = new PrimitivePage(this, UI.PrimitiveTab);
            SchedulerPg = new SchedulerPage(this, UI.SchedulerTab);
            ConstructerPg = new ConstructerPage(this, UI.ConstructerTab);
        }
    }
}