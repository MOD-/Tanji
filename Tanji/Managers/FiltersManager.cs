using Sulakore.Communication;
using Sulakore.Protocol;

namespace Tanji.Managers
{
    public class FiltersManager
    {
        public MainFrm MainUI { get; }

        public FiltersManager(MainFrm main)
        {
            MainUI = main;
            MainUI.Connection.DataOutgoing += DataOutgoing;
            MainUI.Connection.DataIncoming += DataIncoming;

            MainUI.IFTypeTxt.SelectedIndex = 0;
            MainUI.IFActionTxt.SelectedIndex = 0;
        }

        private void DataOutgoing(object sender, InterceptedEventArgs e)
        { }
        private void DataIncoming(object sender, InterceptedEventArgs e)
        { }
    }
}