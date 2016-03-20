using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

using Sulakore;
using Sulakore.Modules;
using Sulakore.Habbo.Web;
using Sulakore.Communication;
using System.Collections.Generic;

using Tangine;

namespace Tanji.Pages.Modules.Managers
{
    public class ModulesManager : Contractor
    {
        private bool _suppressUIUpdating;

        private readonly Dictionary<Type, ITService> _services;
        private readonly Dictionary<Type, Form> _extensionForms;
        private readonly Dictionary<Type, ITExtension> _extensions;

        public MainFrm UI { get; }

        public override HHotel Hotel => UI.Hotel;
        public override HGameData GameData => UI.GameData;
        public override IHConnection Connection => UI.Connection;

        public ModulesManager(MainFrm ui)
            : base("Modules")
        {
            _services = new Dictionary<Type, ITService>();
            _extensionForms = new Dictionary<Type, Form>();
            _extensions = new Dictionary<Type, ITExtension>();

            UI = ui;
            UI.MTModulesVw.ItemActivate += MModulesVw_ItemActivate;
        }

        private void MModulesVw_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = UI.MTModulesVw.SelectedItem;
            if (item == null) return;

            var moduleType = (Type)item.Tag;
            if (_extensionForms.ContainsKey(moduleType))
            {
                _extensionForms[moduleType].BringToFront();
            }
            else InitializeModule(moduleType);
        }

        public void LoadModules()
        {
            try
            {
                _suppressUIUpdating = true;
                foreach (FileSystemInfo fileSysInfo in
                    ModulesDirectory.EnumerateFileSystemInfos())
                {
                    if (fileSysInfo.Extension.EndsWith(".exe") ||
                        fileSysInfo.Extension.EndsWith(".dll"))
                    {
                        InstallModule(fileSysInfo.FullName);
                    }
                }
            }
            finally
            {
                _suppressUIUpdating = false;
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            if (!_suppressUIUpdating)
            {
                UI.ModulesTxt.Text =
                    $"Modules: {GetInitializedCount()}/{UI.MTModulesVw.Items.Count}";
            }
        }

        protected override void OnModuleInstalled(Type type)
        {
            ModuleAttribute moduleAtt = GetModuleAttribute(type);

            string moduleFilePath = GetModuleFilePath(type);
            var moduleFileInfo = FileVersionInfo.GetVersionInfo(moduleFilePath);

            ListViewItem item = UI.MTModulesVw.AddFocusedItem(
                moduleAtt.Name, moduleFileInfo.FileVersion);

            item.Tag = type;
            UpdateUI();
        }
        protected override void OnModuleReinstalled(IModule module, Type type)
        { }
        protected override void OnModuleUninstalled(IModule module, Type type)
        {
            UpdateUI();
        }

        protected override void OnModuleDisposed(IModule module, Type type)
        {
            if (_extensions.ContainsKey(type))
                _extensions.Remove(type);

            if (_extensionForms.ContainsKey(type))
                _extensionForms.Remove(type);

            if (_services.ContainsKey(type))
                _services.Remove(type);

            UpdateUI();
        }
        protected override void OnModuleInitialized(IModule module, Type type)
        {
            var extension = (module as ITExtension);
            if (extension != null)
            {
                _services[type] = extension;
                _extensions[type] = extension;

                var extensionForm = (module as Form);
                if (extensionForm != null)
                {
                    _extensionForms[type] = extensionForm;
                    extensionForm.Show(UI);
                }
            }
            else
            {
                var service = (module as ITService);
                if (service != null)
                {
                    _services[type] = service;
                }
            }
            UpdateUI();
        }
    }
}