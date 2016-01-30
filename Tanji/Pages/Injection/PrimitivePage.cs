using System.Windows.Forms;

namespace Tanji.Pages.Injection
{
    public class PrimitivePage : TanjiSubPage<InjectionPage>
    {
        public PrimitivePage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        {
            UI.PTInjectionMenu.InputBox = UI.PTPrimitiveTxt;
        }
    }
}