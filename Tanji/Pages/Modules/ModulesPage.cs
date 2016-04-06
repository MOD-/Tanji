using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Tanji.Properties;
using Tanji.Manipulators;
using Tanji.Pages.Modules.Handlers;

using Sulakore;
using Sulakore.Habbo;
using Sulakore.Modules;
using Sulakore.Protocol;
using Sulakore.Habbo.Web;
using Sulakore.Communication;

using Tangine;
using Tangine.Habbo;
using Tangine.GitHub;

namespace Tanji.Pages.Modules
{
    public class ModulesPage : TanjiPage, IReceiver, IHaltable
    {
        private bool _suppressUIUpdating;

        private readonly Dictionary<string, bool> _isValidUrl;
        private readonly Dictionary<string, Bitmap> _avatarCache;
        private readonly Dictionary<HHotel, Dictionary<string, HProfile>> _profileCache;
        private readonly Action<ModuleItem, DataInterceptedEventArgs, Exception> _displayModuleException;

        public ModulesManager Contractor { get; }
        public bool IsReceiving => (Contractor.GetInitializedCount() > 0);

        public ModuleItem SelectedModuleItem
        {
            get
            {
                ListViewItem item = UI.MTModulesVw.SelectedItem;
                return (item?.Tag as ModuleItem);
            }
        }
        public AuthorAttribute SelectedAuthor
        {
            get
            {
                return (UI.MTAuthorsTxt
                    .SelectedValue as AuthorAttribute);
            }
        }

        public ModulesPage(MainFrm ui, TabPage tab)
            : base(ui, tab)
        {
            _isValidUrl = new Dictionary<string, bool>();
            _avatarCache = new Dictionary<string, Bitmap>();
            _displayModuleException = DisplayModuleException;
            _profileCache = new Dictionary<HHotel, Dictionary<string, HProfile>>();

            Contractor = new ModulesManager(UI);
            Contractor.OnModuleAction = OnModuleAction;
            LoadModules();

            Tab.DragDrop += Tab_DragDrop;
            Tab.DragEnter += Tab_DragEnter;

            UI.MTReleasesBtn.Click += MTReleasesBtn_Click;
            UI.MTResourceBtn.Click += MTResourceBtn_Click;
            UI.MTDownloadLatestBtn.Click += MTDownloadLatestBtn_Click;
            UI.MTAuthorsTxt.SelectedValueChanged += MTAuthorsTxt_SelectedValueChanged;

            UI.MTInstallModuleBtn.Click += MTInstallModuleBtn_Click;
            UI.MTUninstallModuleBtn.Click += MTUninstallModuleBtn_Click;

            UI.MTModulesVw.ItemActivate += MTModulesVw_ItemActivate;
            UI.MTModulesVw.ItemSelected += MTModulesVw_ItemSelected;
            UI.MTModulesVw.ItemSelectionStateChanged += MTModulesVw_ItemSelectionStateChanged;
        }

        private void MTReleasesBtn_Click(object sender, EventArgs e)
        {
            GitRepository repo = SelectedModuleItem.Repository;
            Process.Start($"https://github.com/{repo.OwnerName}/{repo.RepoName}/releases");
        }
        private void MTResourceBtn_Click(object sender, EventArgs e)
        {
            Process.Start(SelectedAuthor.ResourceUrl);
        }
        private void MTDownloadLatestBtn_Click(object sender, EventArgs e)
        {
            Process.Start(SelectedModuleItem.Repository.LatestRelease.HtmlUrl);
        }
        private async void MTAuthorsTxt_SelectedValueChanged(object sender, EventArgs e)
        {
            AuthorAttribute author = SelectedAuthor;
            UI.MTResourceBtn.Text = (author?.ResourceName);
            UI.MTResourceBtn.Enabled = (IsValidUrl(author?.ResourceUrl));

            if (string.IsNullOrWhiteSpace(author?.HabboName))
            {
                UI.MTHotelTxt.Text = string.Empty;
                UI.MTHabboNameTxt.Text = string.Empty;
                UI.MTAuthorPctbx.Image = Resources.Avatar;
                return;
            }

            UI.MTHabboNameTxt.Text = author.HabboName;
            UI.MTHotelTxt.Text = ("Habbo." + author.Hotel.ToDomain());

            Bitmap avatar = await GetAvatarAsync(author);
            if (author == SelectedAuthor)
            {
                UI.MTAuthorPctbx.Image = avatar;
            }
        }

        private void MTModulesVw_ItemActivate(object sender, EventArgs e)
        {
            if (!SelectedModuleItem.IsInitialized)
            {
                Contractor.InitializeModule(
                    SelectedModuleItem.Type);
            }
            else if (SelectedModuleItem.ExtensionForm != null)
            {
                SelectedModuleItem.ExtensionForm.BringToFront();
            }
        }
        private void MTInstallModuleBtn_Click(object sender, EventArgs e)
        {
            UI.InstallModuleDlg.FileName = string.Empty;
            if (UI.InstallModuleDlg.ShowDialog() != DialogResult.OK) return;

            Contractor.InstallModule(UI.InstallModuleDlg.FileName);
        }
        private void MTUninstallModuleBtn_Click(object sender, EventArgs e)
        {
            Contractor.UninstallModule(SelectedModuleItem.Type);
        }

        private async void MTModulesVw_ItemSelected(object sender, EventArgs e)
        {
            ModuleItem moduleItem = SelectedModuleItem;
            bool hasAuthors = (moduleItem.Authors.Count > 0);

            UI.MTAuthorsTxt.Enabled = hasAuthors;
            UI.MTAuthorsTxt.DataSource = (hasAuthors ? SelectedModuleItem.Authors : null);

            GitRepository repository = (moduleItem.Repository);
            if (UI.MTReleasesBtn.Enabled = (repository != null))
            {
                GitRelease currentRelease = (repository.LatestRelease ??
                    await repository.GetLatestReleaseAsync());

                bool hasReleaseMatch =
                    (currentRelease.GetVersion() == moduleItem.Version);

                if (currentRelease != null && !hasReleaseMatch)
                {
                    List<GitRelease> releases = (repository.Releases ??
                        await repository.GetReleasesAsync());

                    foreach (GitRelease release in releases)
                    {
                        if (release.GetVersion() == moduleItem.Version)
                        {
                            hasReleaseMatch = true;
                            currentRelease = release;
                            break;
                        }
                    }
                }

                if (currentRelease != null &&
                    moduleItem == SelectedModuleItem)
                {
                    if (hasReleaseMatch)
                        DisplayDownloads(currentRelease);

                    UI.MTDownloadLatestBtn.Enabled =
                        (repository.LatestRelease.GetVersion() > moduleItem.Version);
                }
            }
            else
            {
                UI.MTDownloadsLbl.Text = "Downloads: 0";

                UI.MTDownloadLatestBtn.Enabled =
                    UI.MTReleasesBtn.Enabled = false;
            }
        }
        private void MTModulesVw_ItemSelectionStateChanged(object sender, EventArgs e)
        {
            bool isSelected = UI.MTModulesVw.HasSelectedItem;
            UI.MTUninstallModuleBtn.Enabled = isSelected;

            if (!isSelected)
            {
                UI.MTAuthorsTxt.Enabled = false;
                UI.MTAuthorsTxt.DataSource = null;

                UI.MTDownloadsLbl.Text = "Downloads: 0";

                UI.MTDownloadLatestBtn.Enabled =
                    UI.MTReleasesBtn.Enabled = false;
            }
        }

        private void Tab_DragDrop(object sender, DragEventArgs e)
        {
            Contractor.InstallModule(
                GetFirstFile((DataObject)e.Data));
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

        public void LoadModules()
        {
            try
            {
                _suppressUIUpdating = true;

                FileSystemInfo[] fileSysInfos = Contractor
                    .ModulesDirectory.GetFileSystemInfos();

                foreach (FileSystemInfo fileSysInfo in fileSysInfos)
                {
                    if (fileSysInfo.Extension.EndsWith(".exe") ||
                        fileSysInfo.Extension.EndsWith(".dll"))
                    {
                        Contractor.InstallModule(fileSysInfo.FullName);
                    }
                }
            }
            finally
            {
                _suppressUIUpdating = false;
                UpdateUI();
            }
        }
        public void DisposeModules()
        {
            ModuleItem[] moduleItems = Contractor.GetModuleItems();
            foreach (ModuleItem moduleItem in moduleItems)
            {
                if (moduleItem.IsInitialized)
                    Contractor.DisposeModule(moduleItem.Type);
            }
        }

        public async Task<Bitmap> GetAvatarAsync(AuthorAttribute authorAtt)
        {
            HProfile profile = await GetProfileAsync(
                authorAtt).ConfigureAwait(false);

            if (profile == null)
                return Resources.Avatar;

            if (_avatarCache.ContainsKey(profile.User.FigureId))
                return _avatarCache[profile.User.FigureId];

            Bitmap avatar = await SKore.GetAvatarAsync(
                profile.User.FigureId, HSize.Medium).ConfigureAwait(false);

            _avatarCache[profile.User.FigureId] = avatar;
            return avatar;
        }
        public async Task<HProfile> GetProfileAsync(AuthorAttribute authorAtt)
        {
            if (!_profileCache.ContainsKey(authorAtt.Hotel))
                _profileCache[authorAtt.Hotel] = new Dictionary<string, HProfile>();

            if (_profileCache[authorAtt.Hotel]
                .ContainsKey(authorAtt.HabboName))
            {
                return _profileCache[authorAtt.Hotel][authorAtt.HabboName];
            }

            HProfile profile = await SKore.GetProfileAsync(
                authorAtt.HabboName, authorAtt.Hotel).ConfigureAwait(false);

            _profileCache[authorAtt.Hotel][authorAtt.HabboName] = profile;
            return profile;
        }

        public void Halt() => DisposeModules();
        public void HandleOutgoing(DataInterceptedEventArgs e) => HandleData(e);
        public void HandleIncoming(DataInterceptedEventArgs e) => HandleData(e);

        public bool ModifyGame(HGame game)
        {
            bool possiblyModified = false;
            ModuleItem[] moduleItems = Contractor.GetModuleItems();

            foreach (ModuleItem moduleItem in moduleItems)
            {
                if (moduleItem.IsInitialized && moduleItem.Extension != null)
                {
                    moduleItem.Extension?.ModifyGame(game);
                    possiblyModified = true;
                }
            }
            return possiblyModified;
        }
        public bool ModifyGameData(HGameData gameData)
        {
            bool possiblyModified = false;
            ModuleItem[] moduleItems = Contractor.GetModuleItems();

            foreach (ModuleItem moduleItem in moduleItems)
            {
                if (moduleItem.IsInitialized &&
                    moduleItem.Extension != null)
                {
                    moduleItem.Extension.ModifyGameData(gameData);
                    possiblyModified = true;
                }
            }
            return possiblyModified;
        }

        private void UpdateUI()
        {
            if (!_suppressUIUpdating)
            {
                UI.ModulesTxt.Text =
                    $"Modules: {Contractor.GetInitializedCount()}/{Contractor.GetInstalledCount()}";
            }
        }
        private bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            if (_isValidUrl.ContainsKey(url))
                return _isValidUrl[url];

            Uri donationsUri = null;

            bool isValidUri = (Uri.TryCreate(
                url, UriKind.Absolute, out donationsUri));

            isValidUri = (isValidUri &&
                (donationsUri.Scheme == Uri.UriSchemeHttp ||
                donationsUri.Scheme == Uri.UriSchemeHttps));

            _isValidUrl[url] = isValidUri;
            return isValidUri;
        }
        private string GetFirstFile(DataObject data)
        {
            if (data.ContainsFileDropList())
                return data.GetFileDropList()[0];

            return string.Empty;
        }

        private void DisplayDownloads(GitRelease release)
        {
            UI.MTDownloadsLbl.Text =
                $"Downloads: {release.Assets[0].DownloadCount:n0}";
        }
        private void DisplayModuleException(ModuleItem moduleItem, DataInterceptedEventArgs args, Exception exception)
        {
            if (UI.InvokeRequired)
            {
                UI.Invoke(_displayModuleException, moduleItem, args, exception);
                return;
            }
            UI.BringToFront();

            string packetType = (args.Packet.Destination ==
                HDestination.Server ? "Outgoing" : "Incoming");

            string readPacketValues = string.Empty;
            if (args.Packet.ValuesRead.Count > 0)
            {
                foreach (object value in args.Packet.ValuesRead)
                {
                    Type valueType = value.GetType();
                    switch (Type.GetTypeCode(valueType))
                    {
                        default:
                        {
                            readPacketValues +=
                                (valueType.FullName + ": " + value);

                            break;
                        }
                        case TypeCode.Int32: readPacketValues += "Integer: " + value; break;
                        case TypeCode.String: readPacketValues += "String: " + value; break;
                        case TypeCode.Boolean: readPacketValues += "Boolean: " + value; break;
                    }
                    readPacketValues += "\r\n";
                }
                readPacketValues = ("\r\n" + readPacketValues.Trim());
            }

            string moduleData = $"Module: {moduleItem.Name}(v{moduleItem.Version})";
            string packetData = $"{packetType} Packet[{args.Packet.Header}]: {args.Packet}{readPacketValues}";

            MessageBox.Show($"{moduleData}\r\n\r\n{packetData}\r\n\r\nMessage: {exception.Message}",
                "Tanji ~ Unhandled Module Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HandleData(DataInterceptedEventArgs e)
        {
            ModuleItem[] moduleItems = Contractor.GetModuleItems();
            bool isOutgoing = (e.Packet.Destination == HDestination.Server);

            foreach (ModuleItem moduleItem in moduleItems)
            {
                if (!moduleItem.IsInitialized) continue;

                ITExtension extension = moduleItem.Extension;
                if (extension == null) continue;

                try
                {
                    if (isOutgoing)
                    {
                        extension.HandleOutgoing(e);
                        extension.Triggers?.HandleOutgoing(e);
                    }
                    else
                    {
                        extension.HandleIncoming(e);
                        extension.Triggers?.HandleIncoming(e);
                    }
                }
                catch (Exception ex)
                {
                    if (!e.HasContinued) e.Continue();

                    WriteLog(ex);
                    DisplayModuleException(moduleItem, e, ex);
                }
            }
        }
        private void OnModuleAction(Type type, ModuleAction action)
        {
            ModuleItem moduleItem = Contractor.GetModuleItem(type);
            switch (action)
            {
                case ModuleAction.Installed:
                {
                    UI.MTModulesVw.AddItem(moduleItem.ListItem);
                    break;
                }
                case ModuleAction.Initialized:
                {
                    moduleItem.ExtensionForm?.Show();
                    moduleItem.ListItem.SubItems[3].Text = "Initialized";
                    break;
                }
                case ModuleAction.Disposed:
                {
                    moduleItem.ListItem.SubItems[3].Text = "Uninitialized";
                    break;
                }
                case ModuleAction.Uninstalled:
                {
                    moduleItem.ListItem.Selected = false;
                    UI.MTModulesVw.RemoveItem(moduleItem.ListItem);
                    break;
                }
            }
            UpdateUI();
        }
    }
}