/* Copyright

    GitHub(Source): https://GitHub.com/ArachisH/Tanji

    Habbo Hotel Packet(Logger/Manipulator)
    Copyright (C) 2015 ArachisH

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

    See License.txt in the project root for license information.
*/

using System;
using System.Linq;
using System.Windows.Forms;

using Sulakore.Extensions;
using Sulakore.Communication;

namespace Tanji.Managers
{
    public class ExtensionManager : Contractor
    {
        private readonly OpenFileDialog _openFileDialog;

        public MainFrm MainUI { get; }

        public ExtensionManager(MainFrm main)
            : base(main.Connection)
        {
            MainUI = main;
            ExtensionAction += ExtensionManager_ExtensionAction;

            MainUI.ETOpenMenuBtn.Click += ETOpenMenuBtn_Click;
            MainUI.ETInstallMenuBtn.Click += ETInstallExtensionBtn_Click;
            MainUI.ETUninstallMenuBtn.Click += ETUninstallExtensionBtn_Click;

            MainUI.ETInstallExtensionBtn.Click += ETInstallExtensionBtn_Click;
            MainUI.ETUninstallExtensionBtn.Click += ETUninstallExtensionBtn_Click;
            MainUI.ETExtensionAOTChckbx.CheckedChanged += ETExtensionAOTChckbx_CheckedChanged;

            MainUI.ContractorVw.InitializeContractor(this);

            MainUI.ContractorVw.ItemSelected += ContractorVw_ItemSelected;
            MainUI.ContractorVw.ItemsDeselected += ContractorVw_ItemsDeselected;

            _openFileDialog = new OpenFileDialog();
            _openFileDialog.DefaultExt = "dll";
            _openFileDialog.Title = "Tanji ~ Install Extension";
            _openFileDialog.Filter = "Executable (*.exe)|*.exe|Dynamic Link Library (*.dll)|*.dll";

            MainUI.Connection.DataIncoming += DataIncoming;
            MainUI.Connection.DataOutgoing += DataOutgoing;
        }

        private void ETOpenMenuBtn_Click(object sender, EventArgs e)
        {
            MainUI.ContractorVw.OpenSelected();
        }
        private void ETInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            _openFileDialog.FileName = _openFileDialog.SafeFileName;
            if (_openFileDialog.ShowDialog() != DialogResult.OK) return;

            MainUI.ContractorVw.Install(_openFileDialog.FileName);
        }
        private void ETUninstallExtensionBtn_Click(object sender, EventArgs e)
        {
            MainUI.ContractorVw.UninstallSelected();
        }
        private void ETExtensionAOTChckbx_CheckedChanged(object sender, EventArgs e)
        {
            ExtensionForm extension = MainUI.ContractorVw.GetSelected();
            if (extension == null) return;

            extension.TopMost = MainUI.ETExtensionAOTChckbx.Checked;
        }

        private void ExtensionManager_ExtensionAction(object sender, ExtensionActionEventArgs e)
        {
            int runningCount = Extensions.Count(ext => ext.IsRunning);

            MainUI.ExtensionsActiveTxt.Text =
                $"Extensions Active: {runningCount}/{Extensions.Count}";
        }

        private void ContractorVw_ItemsDeselected(object sender, EventArgs e)
        {
            MainUI.ETExtensionAOTChckbx.Enabled = false;
            MainUI.ETUninstallExtensionBtn.Enabled = false;

            MainUI.ETOpenMenuBtn.Enabled = false;
            MainUI.ETUninstallMenuBtn.Enabled = false;
        }
        private void ContractorVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!MainUI.ETUninstallExtensionBtn.Enabled)
            {
                MainUI.ETUninstallExtensionBtn.Enabled =
                    MainUI.ETExtensionAOTChckbx.Enabled =
                    MainUI.ETOpenMenuBtn.Enabled =
                    MainUI.ETUninstallMenuBtn.Enabled =
                    MainUI.ETInstallMenuBtn.Enabled = true;
            }
        }

        private void DataIncoming(object sender, InterceptedEventArgs e) =>
            HandleIncoming(e);

        private void DataOutgoing(object sender, InterceptedEventArgs e) =>
            HandleOutgoing(e);
    }
}