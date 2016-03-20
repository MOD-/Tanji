using System;
using System.Reflection;
using System.Windows.Forms;

using Tangine.Habbo;

using Sulakore;
using Sulakore.Modules;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using System.ComponentModel;

namespace Tangine
{
    public class ExtensionForm : ExtensionForm<HTriggers>
    { }
    public class ExtensionForm<T> : Form, ITExtension where T : HTriggers, new()
    {
        [Browsable(false)]
        public T Triggers { get; }
        HTriggers ITExtension.Triggers => Triggers;

        [Browsable(false)]
        public IContractor Installer { get; }

        [Browsable(false)]
        public HHotel Hotel => Installer.Hotel;

        [Browsable(false)]
        public HGameData GameData => Installer?.GameData;

        [Browsable(false)]
        public IHConnection Connection => Installer?.Connection;

        public ExtensionForm()
        {
            Triggers = Activator.CreateInstance<T>();
            Installer = Contractor.GetInstaller(Assembly.GetCallingAssembly());
        }

        public virtual void HandleOutgoing(DataInterceptedEventArgs e)
        { }
        public virtual void HandleIncoming(DataInterceptedEventArgs e)
        { }

        public virtual void ModifyClient(HGame game)
        { }
        public virtual void ModifyGameData(HGameData gameData)
        { }

        protected override void Dispose(bool disposing)
        {
            if (!IsDisposed && disposing)
            {
                Triggers?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}