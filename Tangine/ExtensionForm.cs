using System;
using System.Windows.Forms;
using System.ComponentModel;

using Tangine.Habbo;

using Sulakore.Habbo;
using Sulakore.Modules;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

namespace Tangine
{
    public class ExtensionForm : ExtensionForm<HTriggers>
    { }
    public class ExtensionForm<T> : Form, ITExtension where T : HTriggers
    {
        private readonly ITContext _context;
        private readonly IContractor _installer;
        
        ITContext ITExtension.Context => _context;
        HTriggers ITExtension.Triggers => Triggers;
        IContractor IModule.Installer => _installer;

        [Browsable(false)]
        public HGame Game
        {
            get { return _context?.Game; }
        }

        [Browsable(false)]
        public HHotel Hotel
        {
            get { return (_installer?.Hotel ?? HHotel.Com); }
        }

        [Browsable(false)]
        public T Triggers { get; }

        [Browsable(false)]
        public HGameData GameData
        {
            get { return _installer?.GameData; }
        }

        [Browsable(false)]
        public IHConnection Connection
        {
            get { return _installer?.Connection; }
        }

        public ExtensionForm()
        {
            _installer = Contractor.GetInstaller(GetType());
            _context = (_installer as ITContext);

            Triggers = Activator.CreateInstance<T>();
        }

        public virtual void ModifyGame(HGame game)
        { }
        public virtual void ModifyGameData(HGameData gameData)
        { }

        public virtual void HandleOutgoing(DataInterceptedEventArgs e)
        { }
        public virtual void HandleIncoming(DataInterceptedEventArgs e)
        { }
    }
}