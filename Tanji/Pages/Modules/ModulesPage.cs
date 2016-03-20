using System.Windows.Forms;
using System.Collections.Specialized;

using Tanji.Manipulators;
using Tanji.Pages.Modules.Managers;

using Sulakore.Communication;

namespace Tanji.Pages.Modules
{
    public class ModulesPage : TanjiPage, IReceiver, IHaltable
    {
        public bool IsReceiving { get; set; }

        public ModulesManager ModulesMngr { get; }

        public ModulesPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            ModulesMngr = new ModulesManager(ui);
            ModulesMngr.LoadModules();

            UI.MTInstallModuleBtn.Click += MTInstallModuleBtn_Click;

            Tab.DragDrop += Tab_DragDrop;
            Tab.DragEnter += Tab_DragEnter;

            Select();
        }

        private void MTInstallModuleBtn_Click(object sender, System.EventArgs e)
        {
            UI.InstallModuleDlg.FileName = string.Empty;
            if (UI.InstallModuleDlg.ShowDialog() != DialogResult.OK) return;

            ModulesMngr.InstallModule(UI.InstallModuleDlg.FileName);
        }

        private void Tab_DragDrop(object sender, DragEventArgs e)
        {
            ModulesMngr.InstallModule(GetFirstFile((DataObject)e.Data));
        }
        private void Tab_DragEnter(object sender, DragEventArgs e)
        {
            string firstFile = GetFirstFile((DataObject)e.Data);
            if (string.IsNullOrWhiteSpace(firstFile)) return;

            if (firstFile.EndsWith(".exe") ||
                firstFile.EndsWith(".dll"))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        public void Halt()
        { }
        public void HandleOutgoing(DataInterceptedEventArgs e)
        { }
        public void HandleIncoming(DataInterceptedEventArgs e)
        { }

        private string GetFirstFile(DataObject data)
        {
            if (!data.ContainsFileDropList())
                return string.Empty;

            StringCollection fileList = data.GetFileDropList();
            return fileList[0];
        }
    }
}