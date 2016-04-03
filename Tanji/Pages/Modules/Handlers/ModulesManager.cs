using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using Sulakore.Habbo;
using Sulakore.Modules;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using Tangine;
using Tangine.Habbo;

namespace Tanji.Pages.Modules.Handlers
{
    public class ModulesManager : Contractor, ITContext
    {
        private ModuleItem[] _moduleItemsArray;
        private readonly Dictionary<Type, ModuleItem> _moduleItems;

        public delegate void ModuleActionDelegate(Type moduleType, ModuleAction action);
        
        public HGame Game => UI.Game;
        public override HHotel Hotel => UI.Hotel;
        public override HGameData GameData => UI.GameData;
        public override IHConnection Connection => UI.Connection;

        public MainFrm UI { get; }
        public ModuleActionDelegate OnModuleAction { get; set; }

        public ModulesManager(MainFrm ui)
            : base("Installed Modules")
        {
            _moduleItems = new Dictionary<Type, ModuleItem>();

            UI = ui;
        }

        public ModuleItem[] GetModuleItems()
        {
            return (_moduleItemsArray ??
                (_moduleItemsArray = _moduleItems.Values.ToArray()));
        }
        public ModuleItem GetModuleItem(Type type)
        {
            ModuleItem moduleItem = null;
            _moduleItems.TryGetValue(type, out moduleItem);
            return moduleItem;
        }

        protected override void OnModuleInstalled(Type type)
        {
            if (!_moduleItems.ContainsKey(type))
            {
                _moduleItemsArray = null;
                _moduleItems[type] = new ModuleItem(type, this);
            }
            OnModuleAction?.Invoke(type, ModuleAction.Installed);
        }
        protected override void OnModuleReinstalled(Type type)
        {
            OnModuleAction?.Invoke(type, ModuleAction.Reinstalled);
        }
        protected override void OnModuleUninstalled(Type type)
        {
            OnModuleAction?.Invoke(type, ModuleAction.Uninstalled);
        }

        protected override void OnModuleDisposed(Type type)
        {
            ModuleItem moduleInfo = GetModuleItem(type);
            moduleInfo.IsInitialized = false;

            OnModuleAction?.Invoke(type, ModuleAction.Disposed);
        }
        protected override void OnModuleInitialized(Type type)
        {
            IModule module = GetModule(type);
            ModuleItem moduleInfo = GetModuleItem(type);

            var extension = (module as ITExtension);
            if (extension != null)
            {
                moduleInfo.Extension = extension;

                var extensionForm = (module as Form);
                if (extensionForm != null)
                {
                    moduleInfo.ExtensionForm = extensionForm;
                }
            }

            moduleInfo.IsInitialized = true;
            OnModuleAction?.Invoke(type, ModuleAction.Initialized);
        }
    }
}