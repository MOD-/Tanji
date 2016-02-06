using System.Windows.Forms;

using Sulakore.Communication;

namespace Tanji.Pages.Extensions
{
    public class ExtensionsPage : TanjiPage, IDataHandler
    {
        public ExtensionsPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        { }

        public bool IsHandlingOutgoing { get; } = false;
        public bool IsHandlingIncoming { get; } = false;

        public void HandleOutgoing(InterceptedEventArgs e)
        { }
        public void HandleIncoming(InterceptedEventArgs e)
        { }
    }
}