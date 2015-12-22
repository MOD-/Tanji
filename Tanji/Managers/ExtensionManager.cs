using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

using Sulakore.Protocol;
using Sulakore.Extensions;
using Sulakore.Communication;

namespace Tanji.Managers
{
    public class ExtensionManager : Contractor
    {
        private const ushort GRAB_EXTENSION_PORT = 8787;

        private readonly Action _resetGrabbedExtension;
        private readonly OpenFileDialog _openFileDialog;

        public MainFrm MainUI { get; }
        public HNode ExternalExtension { get; private set; }

        public ExtensionManager(MainFrm main)
        {
            MainUI = main;
            Connection = main.Connection;

            _resetGrabbedExtension = ResetGrabbedExtension;

            MainUI.ETOpenMenuBtn.Click += ETOpenMenuBtn_Click;
            MainUI.ETGrabMenuBtn.Click += ETGrabMenuBtn_Click;
            MainUI.ETInstallMenuBtn.Click += ETInstallExtensionBtn_Click;
            MainUI.ETUninstallMenuBtn.Click += ETUninstallExtensionBtn_Click;

            MainUI.ETInstallExtensionBtn.Click += ETInstallExtensionBtn_Click;
            MainUI.ETUninstallExtensionBtn.Click += ETUninstallExtensionBtn_Click;
            MainUI.ETExtensionAOTChckbx.CheckedChanged += ETExtensionAOTChckbx_CheckedChanged;

            MainUI.ETContractorVw.InitializeContractor(this);

            MainUI.ETContractorVw.ItemSelected += ETContractorVw_ItemSelected;
            MainUI.ETContractorVw.ItemsDeselected += ETContractorVw_ItemsDeselected;

            _openFileDialog = new OpenFileDialog();
            _openFileDialog.DefaultExt = "dll";
            _openFileDialog.Title = "Tanji ~ Install Extension";
            _openFileDialog.Filter = ".NET Assembly (*.dll, *.exe)|*.dll; *.exe|Dynamic Link Library (*.dll)|*.dll|Executable (*.exe)|*.exe";

            MainUI.Connection.DataIncoming += DataIncoming;
            MainUI.Connection.DataOutgoing += DataOutgoing;
        }

        private void ETOpenMenuBtn_Click(object sender, EventArgs e)
        {
            MainUI.ETContractorVw.OpenSelected();
        }
        private async void ETGrabMenuBtn_Click(object sender, EventArgs e)
        {
            HNode externalExtension = null;
            MainUI.ETGrabMenuBtn.Enabled = false;
            MainUI.ETGrabMenuBtn.Text = "Grabbing...";

            try
            {
                externalExtension =
                    await HNode.ListenAsync(GRAB_EXTENSION_PORT);

                var initializationMessage = new HMessage(2);
                initializationMessage.WriteShort((ushort)Hotel);
                initializationMessage.WriteString(GameData?.ToString() ?? string.Empty);
                initializationMessage.WriteString(GameData?.UniqueId ?? string.Empty);

                await externalExtension.SendAsync(initializationMessage.ToBytes());

                var connectionMessage = new HMessage(2);
                connectionMessage.WriteShort(Connection.Port);
                connectionMessage.WriteString(Connection.Host);
                connectionMessage.WriteString(Connection.Address);

                await externalExtension.SendAsync(connectionMessage.ToBytes());
            }
            catch
            {
                externalExtension = null;
                ResetGrabbedExtension();
            }
            finally
            {
                ExternalExtension = externalExtension;

                if (ExternalExtension != null)
                    MainUI.ETGrabMenuBtn.Text = "Extension Grabbed!";
            }
        }
        private void ETInstallExtensionBtn_Click(object sender, EventArgs e)
        {
            _openFileDialog.FileName = _openFileDialog.SafeFileName;
            if (_openFileDialog.ShowDialog() != DialogResult.OK) return;

            MainUI.ETContractorVw.Install(_openFileDialog.FileName);
        }
        private void ETUninstallExtensionBtn_Click(object sender, EventArgs e)
        {
            MainUI.ETContractorVw.UninstallSelected();
        }
        private void ETExtensionAOTChckbx_CheckedChanged(object sender, EventArgs e)
        {
            ExtensionForm extension = MainUI.ETContractorVw.GetSelected();
            if (extension == null) return;

            extension.TopMost = MainUI.ETExtensionAOTChckbx.Checked;
        }

        private void ETContractorVw_ItemsDeselected(object sender, EventArgs e)
        {
            MainUI.ETOpenMenuBtn.Enabled = false;
            MainUI.ETUninstallMenuBtn.Enabled = false;

            MainUI.ETExtensionAOTChckbx.Enabled = false;
            MainUI.ETUninstallExtensionBtn.Enabled = false;
        }
        private void ETContractorVw_ItemSelected(object sender, ListViewItemSelectionChangedEventArgs e)
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

        private void ResetGrabbedExtension()
        {
            if (MainUI.InvokeRequired) { MainUI.Invoke(_resetGrabbedExtension); }
            else
            {
                ExternalExtension = null;
                MainUI.ETGrabMenuBtn.Enabled = true;
                MainUI.ETGrabMenuBtn.Text = "Grab Extension";
            }
        }
        private byte[] GenerateMaskData(HMessage packet)
        {
            var maskData = new HMessage((ushort)packet.Destination);
            maskData.WriteBytes(packet.ToBytes());

            return maskData.ToBytes();
        }
        private void DataIncoming(object sender, InterceptedEventArgs e)
        {
            Task<int> sendTask = ExternalExtension
                ?.SendAsync(GenerateMaskData(e.Packet));

            HandleIncoming(e);

            if (sendTask != null && sendTask.Result == 0)
                ResetGrabbedExtension();
        }
        private void DataOutgoing(object sender, InterceptedEventArgs e)
        {
            Task<int> sendTask = ExternalExtension
                ?.SendAsync(GenerateMaskData(e.Packet));

            HandleOutgoing(e);

            if (sendTask != null && sendTask.Result == 0)
                ResetGrabbedExtension();
        }
        protected override void OnExtensionAction(ExtensionActionEventArgs e)
        {
            int runningCount =
                this.Count(ext => ext.IsRunning);

            MainUI.ExtensionsActiveTxt.Text =
                $"Extensions Active: {runningCount}/{Count}";

            base.OnExtensionAction(e);
        }
    }
}