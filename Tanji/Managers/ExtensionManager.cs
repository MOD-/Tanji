using Sulakore.Extensions;
using Sulakore.Communication;

namespace Tanji.Managers
{
    public class ExtensionManager : Contractor
    {
        public MainFrm Main { get; }

        public ExtensionManager(MainFrm main) :
            base(main.Connection)
        {
            Main = main;
            Main.Connection.DataIncoming += DataIncoming;
            Main.Connection.DataOutgoing += DataOutgoing;
        }

        private void DataIncoming(object sender, InterceptedEventArgs e) => HandleIncoming(e);
        private void DataOutgoing(object sender, InterceptedEventArgs e) => HandleOutgoing(e);
    }
}