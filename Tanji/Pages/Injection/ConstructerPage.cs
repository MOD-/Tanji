using System.Windows.Forms;

namespace Tanji.Pages.Injection
{
    public class ConstructerPage : TanjiSubPage<InjectionPage>
    {
        private const string INVALID_INTEGER_VALUE =
            "The given value is either too large, or too small to be identified as a 32-bit signed integer.";

        public ConstructerPage(InjectionPage parent, TabPage tab)
            : base(parent, tab)
        { }
    }
}