namespace Tanji
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.TanjiStrip = new System.Windows.Forms.StatusStrip();
            this.TanjiVersionTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.SchedulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.FiltersTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ModulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.InjectionMenu = new Sulakore.Components.SKoreInjectionMenu(this.components);
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.DonateBtn = new Sulakore.Components.SKoreButton();
            this.AboutTxt = new System.Windows.Forms.Label();
            this.ModulesTab = new System.Windows.Forms.TabPage();
            this.MTAuthorPctbx = new System.Windows.Forms.PictureBox();
            this.MTDownloadsLbl = new System.Windows.Forms.Label();
            this.MTReleasesBtn = new Sulakore.Components.SKoreButton();
            this.MTResourceBtn = new Sulakore.Components.SKoreButton();
            this.MTHotelTxt = new System.Windows.Forms.TextBox();
            this.MTHotelLbl = new System.Windows.Forms.Label();
            this.MTHabboNameTxt = new System.Windows.Forms.TextBox();
            this.MTHabboNameLbl = new System.Windows.Forms.Label();
            this.MTAuthorsLbl = new System.Windows.Forms.Label();
            this.MTAuthorsTxt = new System.Windows.Forms.ComboBox();
            this.MTGlow1 = new System.Windows.Forms.Panel();
            this.MTDownloadLatestBtn = new Sulakore.Components.SKoreButton();
            this.MTUninstallModuleBtn = new Sulakore.Components.SKoreButton();
            this.MTInstallModuleBtn = new Sulakore.Components.SKoreButton();
            this.MTModulesVw = new Sulakore.Components.SKoreListView();
            this.MTNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MTStateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.TT16BitInputLbl = new System.Windows.Forms.Label();
            this.TT32BitInputLbl = new System.Windows.Forms.Label();
            this.TTIntInputTxt = new System.Windows.Forms.NumericUpDown();
            this.TTIntOutputTxt = new System.Windows.Forms.TextBox();
            this.TTUShortOutputTxt = new System.Windows.Forms.TextBox();
            this.TTDecodeIntBtn = new Sulakore.Components.SKoreButton();
            this.TTDecodeUShortBtn = new Sulakore.Components.SKoreButton();
            this.TTUShortInputTxt = new System.Windows.Forms.NumericUpDown();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.ITSendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ITSendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.ConstructerTab = new System.Windows.Forms.TabPage();
            this.CTValueTxt = new System.Windows.Forms.ComboBox();
            this.CTHeaderTxt = new System.Windows.Forms.NumericUpDown();
            this.CTHeaderLbl = new System.Windows.Forms.Label();
            this.CTAmountLbl = new System.Windows.Forms.Label();
            this.CTStructureTxt = new System.Windows.Forms.TextBox();
            this.CTTransferBelowBtn = new Sulakore.Components.SKoreButton();
            this.CTChunkCountLbl = new Sulakore.Components.SKoreLabel();
            this.CTAmountTxt = new System.Windows.Forms.NumericUpDown();
            this.CTRemoveBtn = new Sulakore.Components.SKoreButton();
            this.CTMoveDownBtn = new Sulakore.Components.SKoreButton();
            this.CTMoveUpBtn = new Sulakore.Components.SKoreButton();
            this.CTClearBtn = new Sulakore.Components.SKoreButton();
            this.CTWriteBooleanBtn = new Sulakore.Components.SKoreButton();
            this.CTWriteStringBtn = new Sulakore.Components.SKoreButton();
            this.CTWriteIntegerBtn = new Sulakore.Components.SKoreButton();
            this.CTValueLbl = new System.Windows.Forms.Label();
            this.CTConstructerVw = new Sulakore.Components.SKoreConstructView();
            this.CTTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTUpdateOnEnterChckbx = new System.Windows.Forms.CheckBox();
            this.SchedulerTab = new System.Windows.Forms.TabPage();
            this.STUpdateBtn = new Sulakore.Components.SKoreButton();
            this.STRemoveBtn = new Sulakore.Components.SKoreButton();
            this.STAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.STDestinationLbl = new System.Windows.Forms.Label();
            this.STCyclesLbl = new System.Windows.Forms.Label();
            this.STCyclesTxt = new System.Windows.Forms.NumericUpDown();
            this.STIntervalLbl = new System.Windows.Forms.Label();
            this.STClearBtn = new Sulakore.Components.SKoreButton();
            this.STCreateBtn = new Sulakore.Components.SKoreButton();
            this.STIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.STDestinationTxt = new System.Windows.Forms.ComboBox();
            this.STPacketLbl = new System.Windows.Forms.Label();
            this.STPacketTxt = new System.Windows.Forms.TextBox();
            this.STSchedulerVw = new Sulakore.Components.SKoreScheduleView();
            this.STPacketCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STIntervalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STCyclesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STHotkeyCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.PTPacketInfoLbl = new System.Windows.Forms.Label();
            this.PTGlow1 = new System.Windows.Forms.Panel();
            this.PTCorruptedLbl = new System.Windows.Forms.Label();
            this.PTCorruptedValueLbl = new System.Windows.Forms.Label();
            this.PTPacketTxt = new System.Windows.Forms.TextBox();
            this.FiltersTab = new System.Windows.Forms.TabPage();
            this.FTDestinationLbl = new System.Windows.Forms.Label();
            this.FTDestinationTxt = new System.Windows.Forms.ComboBox();
            this.FTHeaderTxt = new System.Windows.Forms.NumericUpDown();
            this.FTHeaderLbl = new System.Windows.Forms.Label();
            this.FTRemoveBtn = new Sulakore.Components.SKoreButton();
            this.FTCreateBtn = new Sulakore.Components.SKoreButton();
            this.FTReplacementLbl = new System.Windows.Forms.Label();
            this.FTReplacementTxt = new System.Windows.Forms.TextBox();
            this.FTActionLbl = new System.Windows.Forms.Label();
            this.FTActionTxt = new System.Windows.Forms.ComboBox();
            this.FTFiltersVw = new Sulakore.Components.SKoreListView();
            this.FTHeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTActionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTReplacementCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITPacketTxt = new System.Windows.Forms.ComboBox();
            this.ConnectionTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CoTValueLbl = new System.Windows.Forms.Label();
            this.CoTGlow2Pnl = new System.Windows.Forms.Panel();
            this.CoTCustomClientLbl = new System.Windows.Forms.Label();
            this.CoTGlow3Pnl = new System.Windows.Forms.Panel();
            this.CoTBrowseBtn = new Sulakore.Components.SKoreButton();
            this.CoTProxyPortLbl = new System.Windows.Forms.Label();
            this.CoTExportRootCertificateBtn = new Sulakore.Components.SKoreButton();
            this.CoTDestroyCertificatesBtn = new Sulakore.Components.SKoreButton();
            this.CoTValueTxt = new System.Windows.Forms.TextBox();
            this.CoTCustomClientTxt = new System.Windows.Forms.TextBox();
            this.CoTVariableLbl = new System.Windows.Forms.Label();
            this.CoTClearVariableBtn = new Sulakore.Components.SKoreButton();
            this.CoTUpdateVariableBtn = new Sulakore.Components.SKoreButton();
            this.CoTStatusTxt = new Sulakore.Components.SKoreLabel();
            this.CoTConnectBtn = new Sulakore.Components.SKoreButton();
            this.CoTProxyPortTxt = new System.Windows.Forms.NumericUpDown();
            this.CoTVariablesVw = new Sulakore.Components.SKoreListView();
            this.CoTVariableCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CoTValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CoTNameTxt = new System.Windows.Forms.TextBox();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.CustomClientDlg = new System.Windows.Forms.OpenFileDialog();
            this.InstallModuleDlg = new System.Windows.Forms.OpenFileDialog();
            this.STHotkeyLbl = new System.Windows.Forms.Label();
            this.STHotkeyTxt = new Sulakore.Components.SKoreKeyBox();
            this.TanjiStrip.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.ModulesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTAuthorPctbx)).BeginInit();
            this.ToolboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).BeginInit();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.ConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTHeaderTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTAmountTxt)).BeginInit();
            this.SchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STCyclesTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STIntervalTxt)).BeginInit();
            this.PrimitiveTab.SuspendLayout();
            this.FiltersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FTHeaderTxt)).BeginInit();
            this.ConnectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoTProxyPortTxt)).BeginInit();
            this.TanjiTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanjiVersionTxt,
            this.SchedulesTxt,
            this.FiltersTxt,
            this.ModulesTxt,
            this.TanjiInfoTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(484, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 5;
            this.TanjiStrip.Text = "TanjiStrip";
            // 
            // TanjiVersionTxt
            // 
            this.TanjiVersionTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TanjiVersionTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiVersionTxt.Name = "TanjiVersionTxt";
            this.TanjiVersionTxt.Size = new System.Drawing.Size(50, 19);
            this.TanjiVersionTxt.Text = "v0.0.0.0";
            this.TanjiVersionTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiVersionTxt.Click += new System.EventHandler(this.TanjiVersionTxt_Click);
            // 
            // SchedulesTxt
            // 
            this.SchedulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SchedulesTxt.Name = "SchedulesTxt";
            this.SchedulesTxt.Size = new System.Drawing.Size(87, 19);
            this.SchedulesTxt.Text = "Schedules: 0/0";
            // 
            // FiltersTxt
            // 
            this.FiltersTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.FiltersTxt.Name = "FiltersTxt";
            this.FiltersTxt.Size = new System.Drawing.Size(65, 19);
            this.FiltersTxt.Text = "Filters: 0/0";
            // 
            // ModulesTxt
            // 
            this.ModulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ModulesTxt.Name = "ModulesTxt";
            this.ModulesTxt.Size = new System.Drawing.Size(80, 19);
            this.ModulesTxt.Text = "Modules: 0/0";
            // 
            // TanjiInfoTxt
            // 
            this.TanjiInfoTxt.IsLink = true;
            this.TanjiInfoTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiInfoTxt.Name = "TanjiInfoTxt";
            this.TanjiInfoTxt.Size = new System.Drawing.Size(187, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "GitHub | ArachisH/Tanji";
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // InjectionMenu
            // 
            this.InjectionMenu.InputBox = null;
            this.InjectionMenu.Name = "InjectionMenu";
            this.InjectionMenu.Size = new System.Drawing.Size(174, 170);
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.DonateBtn);
            this.AboutTab.Controls.Add(this.AboutTxt);
            this.AboutTab.Location = new System.Drawing.Point(4, 28);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(476, 313);
            this.AboutTab.TabIndex = 5;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // DonateBtn
            // 
            this.DonateBtn.BackColor = System.Drawing.Color.Transparent;
            this.DonateBtn.Location = new System.Drawing.Point(173, 243);
            this.DonateBtn.Name = "DonateBtn";
            this.DonateBtn.Size = new System.Drawing.Size(131, 22);
            this.DonateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DonateBtn.TabIndex = 1;
            this.DonateBtn.Text = "Donate to Clyde";
            // 
            // AboutTxt
            // 
            this.AboutTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutTxt.Location = new System.Drawing.Point(3, 3);
            this.AboutTxt.Name = "AboutTxt";
            this.AboutTxt.Size = new System.Drawing.Size(470, 194);
            this.AboutTxt.TabIndex = 0;
            this.AboutTxt.Text = resources.GetString("AboutTxt.Text");
            this.AboutTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModulesTab
            // 
            this.ModulesTab.AllowDrop = true;
            this.ModulesTab.Controls.Add(this.MTAuthorPctbx);
            this.ModulesTab.Controls.Add(this.MTDownloadsLbl);
            this.ModulesTab.Controls.Add(this.MTReleasesBtn);
            this.ModulesTab.Controls.Add(this.MTResourceBtn);
            this.ModulesTab.Controls.Add(this.MTHotelTxt);
            this.ModulesTab.Controls.Add(this.MTHotelLbl);
            this.ModulesTab.Controls.Add(this.MTHabboNameTxt);
            this.ModulesTab.Controls.Add(this.MTHabboNameLbl);
            this.ModulesTab.Controls.Add(this.MTAuthorsLbl);
            this.ModulesTab.Controls.Add(this.MTAuthorsTxt);
            this.ModulesTab.Controls.Add(this.MTGlow1);
            this.ModulesTab.Controls.Add(this.MTDownloadLatestBtn);
            this.ModulesTab.Controls.Add(this.MTUninstallModuleBtn);
            this.ModulesTab.Controls.Add(this.MTInstallModuleBtn);
            this.ModulesTab.Controls.Add(this.MTModulesVw);
            this.ModulesTab.Location = new System.Drawing.Point(4, 28);
            this.ModulesTab.Name = "ModulesTab";
            this.ModulesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModulesTab.Size = new System.Drawing.Size(476, 313);
            this.ModulesTab.TabIndex = 1;
            this.ModulesTab.Text = "Modules";
            this.ModulesTab.UseVisualStyleBackColor = true;
            // 
            // MTAuthorPctbx
            // 
            this.MTAuthorPctbx.Dock = System.Windows.Forms.DockStyle.Left;
            this.MTAuthorPctbx.Enabled = false;
            this.MTAuthorPctbx.ErrorImage = null;
            this.MTAuthorPctbx.Image = global::Tanji.Properties.Resources.Avatar;
            this.MTAuthorPctbx.InitialImage = null;
            this.MTAuthorPctbx.Location = new System.Drawing.Point(3, 196);
            this.MTAuthorPctbx.Name = "MTAuthorPctbx";
            this.MTAuthorPctbx.Size = new System.Drawing.Size(68, 114);
            this.MTAuthorPctbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MTAuthorPctbx.TabIndex = 1;
            this.MTAuthorPctbx.TabStop = false;
            // 
            // MTDownloadsLbl
            // 
            this.MTDownloadsLbl.Location = new System.Drawing.Point(345, 214);
            this.MTDownloadsLbl.Name = "MTDownloadsLbl";
            this.MTDownloadsLbl.Size = new System.Drawing.Size(128, 22);
            this.MTDownloadsLbl.TabIndex = 15;
            this.MTDownloadsLbl.Text = "Downloads: 0";
            this.MTDownloadsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MTReleasesBtn
            // 
            this.MTReleasesBtn.BackColor = System.Drawing.Color.Transparent;
            this.MTReleasesBtn.Enabled = false;
            this.MTReleasesBtn.Location = new System.Drawing.Point(345, 253);
            this.MTReleasesBtn.Name = "MTReleasesBtn";
            this.MTReleasesBtn.Size = new System.Drawing.Size(128, 22);
            this.MTReleasesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MTReleasesBtn.TabIndex = 14;
            this.MTReleasesBtn.Text = "Releases";
            // 
            // MTResourceBtn
            // 
            this.MTResourceBtn.BackColor = System.Drawing.Color.Transparent;
            this.MTResourceBtn.Enabled = false;
            this.MTResourceBtn.Location = new System.Drawing.Point(211, 214);
            this.MTResourceBtn.Name = "MTResourceBtn";
            this.MTResourceBtn.Size = new System.Drawing.Size(128, 22);
            this.MTResourceBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MTResourceBtn.TabIndex = 13;
            // 
            // MTHotelTxt
            // 
            this.MTHotelTxt.Location = new System.Drawing.Point(211, 255);
            this.MTHotelTxt.Name = "MTHotelTxt";
            this.MTHotelTxt.ReadOnly = true;
            this.MTHotelTxt.Size = new System.Drawing.Size(128, 20);
            this.MTHotelTxt.TabIndex = 11;
            this.MTHotelTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MTHotelLbl
            // 
            this.MTHotelLbl.AutoSize = true;
            this.MTHotelLbl.Location = new System.Drawing.Point(208, 239);
            this.MTHotelLbl.Name = "MTHotelLbl";
            this.MTHotelLbl.Size = new System.Drawing.Size(32, 13);
            this.MTHotelLbl.TabIndex = 10;
            this.MTHotelLbl.Text = "Hotel";
            // 
            // MTHabboNameTxt
            // 
            this.MTHabboNameTxt.Location = new System.Drawing.Point(77, 255);
            this.MTHabboNameTxt.Name = "MTHabboNameTxt";
            this.MTHabboNameTxt.ReadOnly = true;
            this.MTHabboNameTxt.Size = new System.Drawing.Size(128, 20);
            this.MTHabboNameTxt.TabIndex = 9;
            this.MTHabboNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MTHabboNameLbl
            // 
            this.MTHabboNameLbl.AutoSize = true;
            this.MTHabboNameLbl.Location = new System.Drawing.Point(74, 239);
            this.MTHabboNameLbl.Name = "MTHabboNameLbl";
            this.MTHabboNameLbl.Size = new System.Drawing.Size(70, 13);
            this.MTHabboNameLbl.TabIndex = 8;
            this.MTHabboNameLbl.Text = "Habbo Name";
            // 
            // MTAuthorsLbl
            // 
            this.MTAuthorsLbl.AutoSize = true;
            this.MTAuthorsLbl.Location = new System.Drawing.Point(74, 199);
            this.MTAuthorsLbl.Name = "MTAuthorsLbl";
            this.MTAuthorsLbl.Size = new System.Drawing.Size(49, 13);
            this.MTAuthorsLbl.TabIndex = 7;
            this.MTAuthorsLbl.Text = "Author(s)";
            // 
            // MTAuthorsTxt
            // 
            this.MTAuthorsTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MTAuthorsTxt.Enabled = false;
            this.MTAuthorsTxt.FormattingEnabled = true;
            this.MTAuthorsTxt.Location = new System.Drawing.Point(77, 215);
            this.MTAuthorsTxt.Name = "MTAuthorsTxt";
            this.MTAuthorsTxt.Size = new System.Drawing.Size(128, 21);
            this.MTAuthorsTxt.TabIndex = 6;
            // 
            // MTGlow1
            // 
            this.MTGlow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MTGlow1.Location = new System.Drawing.Point(77, 281);
            this.MTGlow1.Name = "MTGlow1";
            this.MTGlow1.Size = new System.Drawing.Size(396, 1);
            this.MTGlow1.TabIndex = 5;
            // 
            // MTDownloadLatestBtn
            // 
            this.MTDownloadLatestBtn.BackColor = System.Drawing.Color.Transparent;
            this.MTDownloadLatestBtn.Enabled = false;
            this.MTDownloadLatestBtn.Location = new System.Drawing.Point(77, 288);
            this.MTDownloadLatestBtn.Name = "MTDownloadLatestBtn";
            this.MTDownloadLatestBtn.Size = new System.Drawing.Size(128, 22);
            this.MTDownloadLatestBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MTDownloadLatestBtn.TabIndex = 4;
            this.MTDownloadLatestBtn.Text = "Download Latest";
            // 
            // MTUninstallModuleBtn
            // 
            this.MTUninstallModuleBtn.BackColor = System.Drawing.Color.Transparent;
            this.MTUninstallModuleBtn.Enabled = false;
            this.MTUninstallModuleBtn.Location = new System.Drawing.Point(211, 288);
            this.MTUninstallModuleBtn.Name = "MTUninstallModuleBtn";
            this.MTUninstallModuleBtn.Size = new System.Drawing.Size(128, 22);
            this.MTUninstallModuleBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MTUninstallModuleBtn.TabIndex = 3;
            this.MTUninstallModuleBtn.Text = "Uninstall Module";
            // 
            // MTInstallModuleBtn
            // 
            this.MTInstallModuleBtn.BackColor = System.Drawing.Color.Transparent;
            this.MTInstallModuleBtn.Location = new System.Drawing.Point(345, 288);
            this.MTInstallModuleBtn.Name = "MTInstallModuleBtn";
            this.MTInstallModuleBtn.Size = new System.Drawing.Size(128, 22);
            this.MTInstallModuleBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MTInstallModuleBtn.TabIndex = 2;
            this.MTInstallModuleBtn.Text = "Install Module";
            // 
            // MTModulesVw
            // 
            this.MTModulesVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MTNameCol,
            this.MTDescriptionCol,
            this.MTVersionCol,
            this.MTStateCol});
            this.MTModulesVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.MTModulesVw.FullRowSelect = true;
            this.MTModulesVw.GridLines = true;
            this.MTModulesVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MTModulesVw.HideSelection = false;
            this.MTModulesVw.Location = new System.Drawing.Point(3, 3);
            this.MTModulesVw.MultiSelect = false;
            this.MTModulesVw.Name = "MTModulesVw";
            this.MTModulesVw.ShowItemToolTips = true;
            this.MTModulesVw.Size = new System.Drawing.Size(470, 193);
            this.MTModulesVw.TabIndex = 0;
            this.MTModulesVw.UseCompatibleStateImageBehavior = false;
            this.MTModulesVw.View = System.Windows.Forms.View.Details;
            // 
            // MTNameCol
            // 
            this.MTNameCol.Text = "Name";
            this.MTNameCol.Width = 98;
            // 
            // MTDescriptionCol
            // 
            this.MTDescriptionCol.Text = "Description";
            this.MTDescriptionCol.Width = 215;
            // 
            // MTVersionCol
            // 
            this.MTVersionCol.Text = "Version";
            this.MTVersionCol.Width = 68;
            // 
            // MTStateCol
            // 
            this.MTStateCol.Text = "State";
            this.MTStateCol.Width = 68;
            // 
            // ToolboxTab
            // 
            this.ToolboxTab.Controls.Add(this.TT16BitInputLbl);
            this.ToolboxTab.Controls.Add(this.TT32BitInputLbl);
            this.ToolboxTab.Controls.Add(this.TTIntInputTxt);
            this.ToolboxTab.Controls.Add(this.TTIntOutputTxt);
            this.ToolboxTab.Controls.Add(this.TTUShortOutputTxt);
            this.ToolboxTab.Controls.Add(this.TTDecodeIntBtn);
            this.ToolboxTab.Controls.Add(this.TTDecodeUShortBtn);
            this.ToolboxTab.Controls.Add(this.TTUShortInputTxt);
            this.ToolboxTab.Location = new System.Drawing.Point(4, 28);
            this.ToolboxTab.Name = "ToolboxTab";
            this.ToolboxTab.Size = new System.Drawing.Size(476, 313);
            this.ToolboxTab.TabIndex = 3;
            this.ToolboxTab.Text = "Toolbox";
            this.ToolboxTab.UseVisualStyleBackColor = true;
            // 
            // TT16BitInputLbl
            // 
            this.TT16BitInputLbl.AutoSize = true;
            this.TT16BitInputLbl.Location = new System.Drawing.Point(5, 263);
            this.TT16BitInputLbl.Name = "TT16BitInputLbl";
            this.TT16BitInputLbl.Size = new System.Drawing.Size(100, 13);
            this.TT16BitInputLbl.TabIndex = 50;
            this.TT16BitInputLbl.Text = "16-Bit Integer Input:";
            // 
            // TT32BitInputLbl
            // 
            this.TT32BitInputLbl.AutoSize = true;
            this.TT32BitInputLbl.Location = new System.Drawing.Point(5, 291);
            this.TT32BitInputLbl.Name = "TT32BitInputLbl";
            this.TT32BitInputLbl.Size = new System.Drawing.Size(100, 13);
            this.TT32BitInputLbl.TabIndex = 0;
            this.TT32BitInputLbl.Text = "32-Bit Integer Input:";
            // 
            // TTIntInputTxt
            // 
            this.TTIntInputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TTIntInputTxt.Location = new System.Drawing.Point(111, 288);
            this.TTIntInputTxt.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TTIntInputTxt.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.TTIntInputTxt.Name = "TTIntInputTxt";
            this.TTIntInputTxt.Size = new System.Drawing.Size(126, 22);
            this.TTIntInputTxt.TabIndex = 0;
            this.TTIntInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTIntOutputTxt
            // 
            this.TTIntOutputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TTIntOutputTxt.Location = new System.Drawing.Point(243, 288);
            this.TTIntOutputTxt.Name = "TTIntOutputTxt";
            this.TTIntOutputTxt.Size = new System.Drawing.Size(126, 22);
            this.TTIntOutputTxt.TabIndex = 37;
            this.TTIntOutputTxt.Text = "[0][0][0][0]";
            this.TTIntOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTUShortOutputTxt
            // 
            this.TTUShortOutputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTUShortOutputTxt.Location = new System.Drawing.Point(243, 260);
            this.TTUShortOutputTxt.Name = "TTUShortOutputTxt";
            this.TTUShortOutputTxt.Size = new System.Drawing.Size(126, 22);
            this.TTUShortOutputTxt.TabIndex = 38;
            this.TTUShortOutputTxt.Text = "[0][0]";
            this.TTUShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTDecodeIntBtn
            // 
            this.TTDecodeIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.TTDecodeIntBtn.Location = new System.Drawing.Point(375, 288);
            this.TTDecodeIntBtn.Name = "TTDecodeIntBtn";
            this.TTDecodeIntBtn.Size = new System.Drawing.Size(98, 22);
            this.TTDecodeIntBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TTDecodeIntBtn.TabIndex = 34;
            this.TTDecodeIntBtn.Text = "Decode Int32";
            // 
            // TTDecodeUShortBtn
            // 
            this.TTDecodeUShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.TTDecodeUShortBtn.Location = new System.Drawing.Point(375, 260);
            this.TTDecodeUShortBtn.Name = "TTDecodeUShortBtn";
            this.TTDecodeUShortBtn.Size = new System.Drawing.Size(98, 22);
            this.TTDecodeUShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TTDecodeUShortBtn.TabIndex = 35;
            this.TTDecodeUShortBtn.Text = "Decode UInt16";
            // 
            // TTUShortInputTxt
            // 
            this.TTUShortInputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TTUShortInputTxt.Location = new System.Drawing.Point(111, 260);
            this.TTUShortInputTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.TTUShortInputTxt.Name = "TTUShortInputTxt";
            this.TTUShortInputTxt.Size = new System.Drawing.Size(126, 22);
            this.TTUShortInputTxt.TabIndex = 49;
            this.TTUShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InjectionTab
            // 
            this.InjectionTab.Controls.Add(this.ITSendToClientBtn);
            this.InjectionTab.Controls.Add(this.ITSendToServerBtn);
            this.InjectionTab.Controls.Add(this.InjectionTabs);
            this.InjectionTab.Controls.Add(this.ITPacketTxt);
            this.InjectionTab.Location = new System.Drawing.Point(4, 28);
            this.InjectionTab.Name = "InjectionTab";
            this.InjectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.InjectionTab.Size = new System.Drawing.Size(476, 313);
            this.InjectionTab.TabIndex = 2;
            this.InjectionTab.Text = "Injection";
            this.InjectionTab.UseVisualStyleBackColor = true;
            // 
            // ITSendToClientBtn
            // 
            this.ITSendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToClientBtn.Location = new System.Drawing.Point(267, 288);
            this.ITSendToClientBtn.Name = "ITSendToClientBtn";
            this.ITSendToClientBtn.Size = new System.Drawing.Size(100, 22);
            this.ITSendToClientBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ITSendToClientBtn.TabIndex = 7;
            this.ITSendToClientBtn.Text = "Send To Client";
            // 
            // ITSendToServerBtn
            // 
            this.ITSendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToServerBtn.Location = new System.Drawing.Point(373, 288);
            this.ITSendToServerBtn.Name = "ITSendToServerBtn";
            this.ITSendToServerBtn.Size = new System.Drawing.Size(100, 22);
            this.ITSendToServerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ITSendToServerBtn.TabIndex = 6;
            this.ITSendToServerBtn.Text = "Send To Server";
            // 
            // InjectionTabs
            // 
            this.InjectionTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.InjectionTabs.Controls.Add(this.ConstructerTab);
            this.InjectionTabs.Controls.Add(this.SchedulerTab);
            this.InjectionTabs.Controls.Add(this.PrimitiveTab);
            this.InjectionTabs.Controls.Add(this.FiltersTab);
            this.InjectionTabs.DisplayBoundary = true;
            this.InjectionTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.InjectionTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.InjectionTabs.ItemSize = new System.Drawing.Size(24, 65);
            this.InjectionTabs.Location = new System.Drawing.Point(3, 3);
            this.InjectionTabs.Multiline = true;
            this.InjectionTabs.Name = "InjectionTabs";
            this.InjectionTabs.SelectedIndex = 0;
            this.InjectionTabs.Size = new System.Drawing.Size(470, 279);
            this.InjectionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.InjectionTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InjectionTabs.TabIndex = 0;
            // 
            // ConstructerTab
            // 
            this.ConstructerTab.Controls.Add(this.CTValueTxt);
            this.ConstructerTab.Controls.Add(this.CTHeaderTxt);
            this.ConstructerTab.Controls.Add(this.CTHeaderLbl);
            this.ConstructerTab.Controls.Add(this.CTAmountLbl);
            this.ConstructerTab.Controls.Add(this.CTStructureTxt);
            this.ConstructerTab.Controls.Add(this.CTTransferBelowBtn);
            this.ConstructerTab.Controls.Add(this.CTChunkCountLbl);
            this.ConstructerTab.Controls.Add(this.CTAmountTxt);
            this.ConstructerTab.Controls.Add(this.CTRemoveBtn);
            this.ConstructerTab.Controls.Add(this.CTMoveDownBtn);
            this.ConstructerTab.Controls.Add(this.CTMoveUpBtn);
            this.ConstructerTab.Controls.Add(this.CTClearBtn);
            this.ConstructerTab.Controls.Add(this.CTWriteBooleanBtn);
            this.ConstructerTab.Controls.Add(this.CTWriteStringBtn);
            this.ConstructerTab.Controls.Add(this.CTWriteIntegerBtn);
            this.ConstructerTab.Controls.Add(this.CTValueLbl);
            this.ConstructerTab.Controls.Add(this.CTConstructerVw);
            this.ConstructerTab.Controls.Add(this.CTUpdateOnEnterChckbx);
            this.ConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.ConstructerTab.Name = "ConstructerTab";
            this.ConstructerTab.Size = new System.Drawing.Size(397, 271);
            this.ConstructerTab.TabIndex = 2;
            this.ConstructerTab.Text = "Constructer";
            this.ConstructerTab.UseVisualStyleBackColor = true;
            // 
            // CTValueTxt
            // 
            this.CTValueTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CTValueTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CTValueTxt.IntegralHeight = false;
            this.CTValueTxt.ItemHeight = 13;
            this.CTValueTxt.Location = new System.Drawing.Point(88, 15);
            this.CTValueTxt.Name = "CTValueTxt";
            this.CTValueTxt.Size = new System.Drawing.Size(240, 21);
            this.CTValueTxt.TabIndex = 28;
            // 
            // CTHeaderTxt
            // 
            this.CTHeaderTxt.Location = new System.Drawing.Point(3, 16);
            this.CTHeaderTxt.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.CTHeaderTxt.Name = "CTHeaderTxt";
            this.CTHeaderTxt.Size = new System.Drawing.Size(79, 20);
            this.CTHeaderTxt.TabIndex = 49;
            this.CTHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CTHeaderLbl
            // 
            this.CTHeaderLbl.AutoSize = true;
            this.CTHeaderLbl.Location = new System.Drawing.Point(0, 0);
            this.CTHeaderLbl.Name = "CTHeaderLbl";
            this.CTHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.CTHeaderLbl.TabIndex = 31;
            this.CTHeaderLbl.Text = "Header";
            // 
            // CTAmountLbl
            // 
            this.CTAmountLbl.AutoSize = true;
            this.CTAmountLbl.Location = new System.Drawing.Point(331, 0);
            this.CTAmountLbl.Name = "CTAmountLbl";
            this.CTAmountLbl.Size = new System.Drawing.Size(43, 13);
            this.CTAmountLbl.TabIndex = 39;
            this.CTAmountLbl.Text = "Amount";
            // 
            // CTStructureTxt
            // 
            this.CTStructureTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTStructureTxt.Location = new System.Drawing.Point(115, 220);
            this.CTStructureTxt.Name = "CTStructureTxt";
            this.CTStructureTxt.ReadOnly = true;
            this.CTStructureTxt.Size = new System.Drawing.Size(279, 20);
            this.CTStructureTxt.TabIndex = 48;
            this.CTStructureTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CTTransferBelowBtn
            // 
            this.CTTransferBelowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTTransferBelowBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTTransferBelowBtn.Location = new System.Drawing.Point(3, 246);
            this.CTTransferBelowBtn.Name = "CTTransferBelowBtn";
            this.CTTransferBelowBtn.Size = new System.Drawing.Size(106, 22);
            this.CTTransferBelowBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTTransferBelowBtn.TabIndex = 46;
            this.CTTransferBelowBtn.Text = "Transfer Below";
            // 
            // CTChunkCountLbl
            // 
            this.CTChunkCountLbl.BorderWidth = 1;
            this.CTChunkCountLbl.DisplayBoundary = true;
            this.CTChunkCountLbl.Location = new System.Drawing.Point(3, 220);
            this.CTChunkCountLbl.Name = "CTChunkCountLbl";
            this.CTChunkCountLbl.Size = new System.Drawing.Size(106, 20);
            this.CTChunkCountLbl.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTChunkCountLbl.TabIndex = 45;
            this.CTChunkCountLbl.Text = "Chunk Count: 0";
            this.CTChunkCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CTAmountTxt
            // 
            this.CTAmountTxt.Location = new System.Drawing.Point(334, 16);
            this.CTAmountTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CTAmountTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CTAmountTxt.Name = "CTAmountTxt";
            this.CTAmountTxt.Size = new System.Drawing.Size(60, 20);
            this.CTAmountTxt.TabIndex = 40;
            this.CTAmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CTAmountTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CTRemoveBtn
            // 
            this.CTRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTRemoveBtn.Enabled = false;
            this.CTRemoveBtn.Location = new System.Drawing.Point(115, 246);
            this.CTRemoveBtn.Name = "CTRemoveBtn";
            this.CTRemoveBtn.Size = new System.Drawing.Size(89, 22);
            this.CTRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTRemoveBtn.TabIndex = 38;
            this.CTRemoveBtn.Text = "Remove";
            // 
            // CTMoveDownBtn
            // 
            this.CTMoveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTMoveDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTMoveDownBtn.Enabled = false;
            this.CTMoveDownBtn.Location = new System.Drawing.Point(305, 246);
            this.CTMoveDownBtn.Name = "CTMoveDownBtn";
            this.CTMoveDownBtn.Size = new System.Drawing.Size(89, 22);
            this.CTMoveDownBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTMoveDownBtn.TabIndex = 37;
            this.CTMoveDownBtn.Text = "Move Down";
            // 
            // CTMoveUpBtn
            // 
            this.CTMoveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTMoveUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTMoveUpBtn.Enabled = false;
            this.CTMoveUpBtn.Location = new System.Drawing.Point(210, 246);
            this.CTMoveUpBtn.Name = "CTMoveUpBtn";
            this.CTMoveUpBtn.Size = new System.Drawing.Size(89, 22);
            this.CTMoveUpBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTMoveUpBtn.TabIndex = 36;
            this.CTMoveUpBtn.Text = "Move Up";
            // 
            // CTClearBtn
            // 
            this.CTClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTClearBtn.Location = new System.Drawing.Point(3, 42);
            this.CTClearBtn.Name = "CTClearBtn";
            this.CTClearBtn.Size = new System.Drawing.Size(79, 22);
            this.CTClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTClearBtn.TabIndex = 35;
            this.CTClearBtn.Text = "Clear";
            // 
            // CTWriteBooleanBtn
            // 
            this.CTWriteBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTWriteBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTWriteBooleanBtn.Location = new System.Drawing.Point(296, 42);
            this.CTWriteBooleanBtn.Name = "CTWriteBooleanBtn";
            this.CTWriteBooleanBtn.Size = new System.Drawing.Size(98, 22);
            this.CTWriteBooleanBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTWriteBooleanBtn.TabIndex = 34;
            this.CTWriteBooleanBtn.Text = "Write Boolean";
            // 
            // CTWriteStringBtn
            // 
            this.CTWriteStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTWriteStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTWriteStringBtn.Location = new System.Drawing.Point(192, 42);
            this.CTWriteStringBtn.Name = "CTWriteStringBtn";
            this.CTWriteStringBtn.Size = new System.Drawing.Size(98, 22);
            this.CTWriteStringBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTWriteStringBtn.TabIndex = 33;
            this.CTWriteStringBtn.Text = "Write String";
            // 
            // CTWriteIntegerBtn
            // 
            this.CTWriteIntegerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTWriteIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTWriteIntegerBtn.Location = new System.Drawing.Point(88, 42);
            this.CTWriteIntegerBtn.Name = "CTWriteIntegerBtn";
            this.CTWriteIntegerBtn.Size = new System.Drawing.Size(98, 22);
            this.CTWriteIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTWriteIntegerBtn.TabIndex = 32;
            this.CTWriteIntegerBtn.Text = "Write Integer";
            // 
            // CTValueLbl
            // 
            this.CTValueLbl.AutoSize = true;
            this.CTValueLbl.Location = new System.Drawing.Point(85, -1);
            this.CTValueLbl.Name = "CTValueLbl";
            this.CTValueLbl.Size = new System.Drawing.Size(34, 13);
            this.CTValueLbl.TabIndex = 29;
            this.CTValueLbl.Text = "Value";
            // 
            // CTConstructerVw
            // 
            this.CTConstructerVw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTConstructerVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CTTypeCol,
            this.CTValueCol,
            this.CTEncodedCol});
            this.CTConstructerVw.FullRowSelect = true;
            this.CTConstructerVw.GridLines = true;
            this.CTConstructerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CTConstructerVw.HideSelection = false;
            this.CTConstructerVw.Location = new System.Drawing.Point(3, 70);
            this.CTConstructerVw.MultiSelect = false;
            this.CTConstructerVw.Name = "CTConstructerVw";
            this.CTConstructerVw.ShowItemToolTips = true;
            this.CTConstructerVw.Size = new System.Drawing.Size(391, 144);
            this.CTConstructerVw.TabIndex = 44;
            this.CTConstructerVw.UseCompatibleStateImageBehavior = false;
            this.CTConstructerVw.View = System.Windows.Forms.View.Details;
            // 
            // CTTypeCol
            // 
            this.CTTypeCol.Text = "Type";
            this.CTTypeCol.Width = 72;
            // 
            // CTValueCol
            // 
            this.CTValueCol.Text = "Value";
            this.CTValueCol.Width = 149;
            // 
            // CTEncodedCol
            // 
            this.CTEncodedCol.Text = "Encoded";
            this.CTEncodedCol.Width = 149;
            // 
            // CTUpdateOnEnterChckbx
            // 
            this.CTUpdateOnEnterChckbx.AutoSize = true;
            this.CTUpdateOnEnterChckbx.Checked = true;
            this.CTUpdateOnEnterChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CTUpdateOnEnterChckbx.Enabled = false;
            this.CTUpdateOnEnterChckbx.Location = new System.Drawing.Point(209, -1);
            this.CTUpdateOnEnterChckbx.Name = "CTUpdateOnEnterChckbx";
            this.CTUpdateOnEnterChckbx.Size = new System.Drawing.Size(114, 17);
            this.CTUpdateOnEnterChckbx.TabIndex = 50;
            this.CTUpdateOnEnterChckbx.Text = "Update On {Enter}";
            this.CTUpdateOnEnterChckbx.UseVisualStyleBackColor = true;
            // 
            // SchedulerTab
            // 
            this.SchedulerTab.Controls.Add(this.STHotkeyTxt);
            this.SchedulerTab.Controls.Add(this.STHotkeyLbl);
            this.SchedulerTab.Controls.Add(this.STUpdateBtn);
            this.SchedulerTab.Controls.Add(this.STRemoveBtn);
            this.SchedulerTab.Controls.Add(this.STAutoStartChckbx);
            this.SchedulerTab.Controls.Add(this.STDestinationLbl);
            this.SchedulerTab.Controls.Add(this.STCyclesLbl);
            this.SchedulerTab.Controls.Add(this.STCyclesTxt);
            this.SchedulerTab.Controls.Add(this.STIntervalLbl);
            this.SchedulerTab.Controls.Add(this.STClearBtn);
            this.SchedulerTab.Controls.Add(this.STCreateBtn);
            this.SchedulerTab.Controls.Add(this.STIntervalTxt);
            this.SchedulerTab.Controls.Add(this.STDestinationTxt);
            this.SchedulerTab.Controls.Add(this.STPacketLbl);
            this.SchedulerTab.Controls.Add(this.STPacketTxt);
            this.SchedulerTab.Controls.Add(this.STSchedulerVw);
            this.SchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.SchedulerTab.Name = "SchedulerTab";
            this.SchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulerTab.Size = new System.Drawing.Size(397, 271);
            this.SchedulerTab.TabIndex = 0;
            this.SchedulerTab.Text = "Scheduler";
            this.SchedulerTab.UseVisualStyleBackColor = true;
            // 
            // STUpdateBtn
            // 
            this.STUpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.STUpdateBtn.Enabled = false;
            this.STUpdateBtn.Location = new System.Drawing.Point(82, 246);
            this.STUpdateBtn.Name = "STUpdateBtn";
            this.STUpdateBtn.Size = new System.Drawing.Size(73, 22);
            this.STUpdateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STUpdateBtn.TabIndex = 62;
            this.STUpdateBtn.Text = "Update";
            // 
            // STRemoveBtn
            // 
            this.STRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.STRemoveBtn.Enabled = false;
            this.STRemoveBtn.Location = new System.Drawing.Point(161, 246);
            this.STRemoveBtn.Name = "STRemoveBtn";
            this.STRemoveBtn.Size = new System.Drawing.Size(73, 22);
            this.STRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STRemoveBtn.TabIndex = 61;
            this.STRemoveBtn.Text = "Remove";
            // 
            // STAutoStartChckbx
            // 
            this.STAutoStartChckbx.Checked = true;
            this.STAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.STAutoStartChckbx.Location = new System.Drawing.Point(319, 246);
            this.STAutoStartChckbx.Name = "STAutoStartChckbx";
            this.STAutoStartChckbx.Size = new System.Drawing.Size(75, 22);
            this.STAutoStartChckbx.TabIndex = 53;
            this.STAutoStartChckbx.Text = "Auto Start";
            this.STAutoStartChckbx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.STAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // STDestinationLbl
            // 
            this.STDestinationLbl.AutoSize = true;
            this.STDestinationLbl.Location = new System.Drawing.Point(173, 204);
            this.STDestinationLbl.Name = "STDestinationLbl";
            this.STDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.STDestinationLbl.TabIndex = 48;
            this.STDestinationLbl.Text = "Destination";
            // 
            // STCyclesLbl
            // 
            this.STCyclesLbl.AutoSize = true;
            this.STCyclesLbl.Location = new System.Drawing.Point(306, 204);
            this.STCyclesLbl.Name = "STCyclesLbl";
            this.STCyclesLbl.Size = new System.Drawing.Size(38, 13);
            this.STCyclesLbl.TabIndex = 60;
            this.STCyclesLbl.Text = "Cycles";
            // 
            // STCyclesTxt
            // 
            this.STCyclesTxt.Location = new System.Drawing.Point(309, 220);
            this.STCyclesTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.STCyclesTxt.Name = "STCyclesTxt";
            this.STCyclesTxt.Size = new System.Drawing.Size(35, 20);
            this.STCyclesTxt.TabIndex = 59;
            this.STCyclesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STIntervalLbl
            // 
            this.STIntervalLbl.AutoSize = true;
            this.STIntervalLbl.Location = new System.Drawing.Point(239, 204);
            this.STIntervalLbl.Name = "STIntervalLbl";
            this.STIntervalLbl.Size = new System.Drawing.Size(61, 13);
            this.STIntervalLbl.TabIndex = 50;
            this.STIntervalLbl.Text = "Interval(ms)";
            // 
            // STClearBtn
            // 
            this.STClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.STClearBtn.Location = new System.Drawing.Point(240, 246);
            this.STClearBtn.Name = "STClearBtn";
            this.STClearBtn.Size = new System.Drawing.Size(73, 22);
            this.STClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STClearBtn.TabIndex = 58;
            this.STClearBtn.Text = "Clear";
            // 
            // STCreateBtn
            // 
            this.STCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.STCreateBtn.Location = new System.Drawing.Point(3, 246);
            this.STCreateBtn.Name = "STCreateBtn";
            this.STCreateBtn.Size = new System.Drawing.Size(73, 22);
            this.STCreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STCreateBtn.TabIndex = 54;
            this.STCreateBtn.Text = "Create";
            // 
            // STIntervalTxt
            // 
            this.STIntervalTxt.Location = new System.Drawing.Point(242, 221);
            this.STIntervalTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.STIntervalTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.STIntervalTxt.Name = "STIntervalTxt";
            this.STIntervalTxt.Size = new System.Drawing.Size(58, 20);
            this.STIntervalTxt.TabIndex = 49;
            this.STIntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STIntervalTxt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // STDestinationTxt
            // 
            this.STDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STDestinationTxt.FormattingEnabled = true;
            this.STDestinationTxt.Location = new System.Drawing.Point(176, 220);
            this.STDestinationTxt.Name = "STDestinationTxt";
            this.STDestinationTxt.Size = new System.Drawing.Size(57, 21);
            this.STDestinationTxt.TabIndex = 47;
            // 
            // STPacketLbl
            // 
            this.STPacketLbl.AutoSize = true;
            this.STPacketLbl.Location = new System.Drawing.Point(0, 204);
            this.STPacketLbl.Name = "STPacketLbl";
            this.STPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.STPacketLbl.TabIndex = 46;
            this.STPacketLbl.Text = "Packet";
            // 
            // STPacketTxt
            // 
            this.STPacketTxt.Location = new System.Drawing.Point(3, 220);
            this.STPacketTxt.MaxLength = 2147483647;
            this.STPacketTxt.Name = "STPacketTxt";
            this.STPacketTxt.Size = new System.Drawing.Size(167, 20);
            this.STPacketTxt.TabIndex = 45;
            // 
            // STSchedulerVw
            // 
            this.STSchedulerVw.CheckBoxes = true;
            this.STSchedulerVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STPacketCol,
            this.STDestinationCol,
            this.STIntervalCol,
            this.STCyclesCol,
            this.STHotkeyCol,
            this.STStatusCol});
            this.STSchedulerVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.STSchedulerVw.FullRowSelect = true;
            this.STSchedulerVw.GridLines = true;
            this.STSchedulerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.STSchedulerVw.HideSelection = false;
            this.STSchedulerVw.Location = new System.Drawing.Point(3, 3);
            this.STSchedulerVw.MultiSelect = false;
            this.STSchedulerVw.Name = "STSchedulerVw";
            this.STSchedulerVw.SelectedCycles = -1;
            this.STSchedulerVw.SelectedDestination = Sulakore.Protocol.HDestination.Client;
            this.STSchedulerVw.SelectedHotkey = null;
            this.STSchedulerVw.SelectedInterval = -1;
            this.STSchedulerVw.SelectedPacket = null;
            this.STSchedulerVw.ShowItemToolTips = true;
            this.STSchedulerVw.Size = new System.Drawing.Size(391, 198);
            this.STSchedulerVw.TabIndex = 0;
            this.STSchedulerVw.UseCompatibleStateImageBehavior = false;
            this.STSchedulerVw.View = System.Windows.Forms.View.Details;
            // 
            // STPacketCol
            // 
            this.STPacketCol.Text = "Packet";
            this.STPacketCol.Width = 109;
            // 
            // STDestinationCol
            // 
            this.STDestinationCol.Text = "Destination";
            this.STDestinationCol.Width = 69;
            // 
            // STIntervalCol
            // 
            this.STIntervalCol.Text = "Interval";
            this.STIntervalCol.Width = 49;
            // 
            // STCyclesCol
            // 
            this.STCyclesCol.Text = "Cycles";
            this.STCyclesCol.Width = 45;
            // 
            // STHotkeyCol
            // 
            this.STHotkeyCol.Text = "Hotkey";
            this.STHotkeyCol.Width = 46;
            // 
            // STStatusCol
            // 
            this.STStatusCol.Text = "Status";
            this.STStatusCol.Width = 52;
            // 
            // PrimitiveTab
            // 
            this.PrimitiveTab.Controls.Add(this.PTPacketInfoLbl);
            this.PrimitiveTab.Controls.Add(this.PTGlow1);
            this.PrimitiveTab.Controls.Add(this.PTCorruptedLbl);
            this.PrimitiveTab.Controls.Add(this.PTCorruptedValueLbl);
            this.PrimitiveTab.Controls.Add(this.PTPacketTxt);
            this.PrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.PrimitiveTab.Name = "PrimitiveTab";
            this.PrimitiveTab.Size = new System.Drawing.Size(397, 271);
            this.PrimitiveTab.TabIndex = 1;
            this.PrimitiveTab.Text = "Primitive";
            this.PrimitiveTab.UseVisualStyleBackColor = true;
            // 
            // PTPacketInfoLbl
            // 
            this.PTPacketInfoLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PTPacketInfoLbl.Location = new System.Drawing.Point(0, 240);
            this.PTPacketInfoLbl.Name = "PTPacketInfoLbl";
            this.PTPacketInfoLbl.Size = new System.Drawing.Size(297, 31);
            this.PTPacketInfoLbl.TabIndex = 7;
            this.PTPacketInfoLbl.Text = "Header: 0, Length: 0";
            this.PTPacketInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PTGlow1
            // 
            this.PTGlow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.PTGlow1.Location = new System.Drawing.Point(303, 246);
            this.PTGlow1.Name = "PTGlow1";
            this.PTGlow1.Size = new System.Drawing.Size(1, 22);
            this.PTGlow1.TabIndex = 6;
            // 
            // PTCorruptedLbl
            // 
            this.PTCorruptedLbl.AutoSize = true;
            this.PTCorruptedLbl.Location = new System.Drawing.Point(310, 250);
            this.PTCorruptedLbl.Name = "PTCorruptedLbl";
            this.PTCorruptedLbl.Size = new System.Drawing.Size(56, 13);
            this.PTCorruptedLbl.TabIndex = 4;
            this.PTCorruptedLbl.Text = "Corrupted:";
            this.PTCorruptedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PTCorruptedValueLbl
            // 
            this.PTCorruptedValueLbl.AutoSize = true;
            this.PTCorruptedValueLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.PTCorruptedValueLbl.Location = new System.Drawing.Point(362, 250);
            this.PTCorruptedValueLbl.Name = "PTCorruptedValueLbl";
            this.PTCorruptedValueLbl.Size = new System.Drawing.Size(29, 13);
            this.PTCorruptedValueLbl.TabIndex = 5;
            this.PTCorruptedValueLbl.Text = "True";
            this.PTCorruptedValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PTPacketTxt
            // 
            this.PTPacketTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTPacketTxt.Location = new System.Drawing.Point(0, 0);
            this.PTPacketTxt.MaxLength = 2147483647;
            this.PTPacketTxt.Multiline = true;
            this.PTPacketTxt.Name = "PTPacketTxt";
            this.PTPacketTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PTPacketTxt.Size = new System.Drawing.Size(397, 240);
            this.PTPacketTxt.TabIndex = 3;
            // 
            // FiltersTab
            // 
            this.FiltersTab.Controls.Add(this.FTDestinationLbl);
            this.FiltersTab.Controls.Add(this.FTDestinationTxt);
            this.FiltersTab.Controls.Add(this.FTHeaderTxt);
            this.FiltersTab.Controls.Add(this.FTHeaderLbl);
            this.FiltersTab.Controls.Add(this.FTRemoveBtn);
            this.FiltersTab.Controls.Add(this.FTCreateBtn);
            this.FiltersTab.Controls.Add(this.FTReplacementLbl);
            this.FiltersTab.Controls.Add(this.FTReplacementTxt);
            this.FiltersTab.Controls.Add(this.FTActionLbl);
            this.FiltersTab.Controls.Add(this.FTActionTxt);
            this.FiltersTab.Controls.Add(this.FTFiltersVw);
            this.FiltersTab.Location = new System.Drawing.Point(4, 4);
            this.FiltersTab.Name = "FiltersTab";
            this.FiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.FiltersTab.Size = new System.Drawing.Size(397, 271);
            this.FiltersTab.TabIndex = 3;
            this.FiltersTab.Text = "Filters";
            this.FiltersTab.UseVisualStyleBackColor = true;
            // 
            // FTDestinationLbl
            // 
            this.FTDestinationLbl.AutoSize = true;
            this.FTDestinationLbl.Location = new System.Drawing.Point(0, 231);
            this.FTDestinationLbl.Name = "FTDestinationLbl";
            this.FTDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.FTDestinationLbl.TabIndex = 53;
            this.FTDestinationLbl.Text = "Destination";
            // 
            // FTDestinationTxt
            // 
            this.FTDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FTDestinationTxt.FormattingEnabled = true;
            this.FTDestinationTxt.Location = new System.Drawing.Point(3, 247);
            this.FTDestinationTxt.Name = "FTDestinationTxt";
            this.FTDestinationTxt.Size = new System.Drawing.Size(73, 21);
            this.FTDestinationTxt.TabIndex = 52;
            // 
            // FTHeaderTxt
            // 
            this.FTHeaderTxt.Location = new System.Drawing.Point(3, 209);
            this.FTHeaderTxt.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.FTHeaderTxt.Name = "FTHeaderTxt";
            this.FTHeaderTxt.Size = new System.Drawing.Size(73, 20);
            this.FTHeaderTxt.TabIndex = 51;
            this.FTHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FTHeaderLbl
            // 
            this.FTHeaderLbl.AutoSize = true;
            this.FTHeaderLbl.Location = new System.Drawing.Point(0, 193);
            this.FTHeaderLbl.Name = "FTHeaderLbl";
            this.FTHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.FTHeaderLbl.TabIndex = 50;
            this.FTHeaderLbl.Text = "Header";
            // 
            // FTRemoveBtn
            // 
            this.FTRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.FTRemoveBtn.Enabled = false;
            this.FTRemoveBtn.Location = new System.Drawing.Point(279, 246);
            this.FTRemoveBtn.Name = "FTRemoveBtn";
            this.FTRemoveBtn.Size = new System.Drawing.Size(115, 22);
            this.FTRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.FTRemoveBtn.TabIndex = 8;
            this.FTRemoveBtn.Text = "Remove";
            // 
            // FTCreateBtn
            // 
            this.FTCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.FTCreateBtn.Location = new System.Drawing.Point(158, 246);
            this.FTCreateBtn.Name = "FTCreateBtn";
            this.FTCreateBtn.Size = new System.Drawing.Size(115, 22);
            this.FTCreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.FTCreateBtn.TabIndex = 7;
            this.FTCreateBtn.Text = "Create";
            // 
            // FTReplacementLbl
            // 
            this.FTReplacementLbl.AutoSize = true;
            this.FTReplacementLbl.Location = new System.Drawing.Point(79, 193);
            this.FTReplacementLbl.Name = "FTReplacementLbl";
            this.FTReplacementLbl.Size = new System.Drawing.Size(70, 13);
            this.FTReplacementLbl.TabIndex = 6;
            this.FTReplacementLbl.Text = "Replacement";
            // 
            // FTReplacementTxt
            // 
            this.FTReplacementTxt.Location = new System.Drawing.Point(82, 209);
            this.FTReplacementTxt.Name = "FTReplacementTxt";
            this.FTReplacementTxt.Size = new System.Drawing.Size(312, 20);
            this.FTReplacementTxt.TabIndex = 5;
            // 
            // FTActionLbl
            // 
            this.FTActionLbl.AutoSize = true;
            this.FTActionLbl.Location = new System.Drawing.Point(79, 231);
            this.FTActionLbl.Name = "FTActionLbl";
            this.FTActionLbl.Size = new System.Drawing.Size(37, 13);
            this.FTActionLbl.TabIndex = 2;
            this.FTActionLbl.Text = "Action";
            // 
            // FTActionTxt
            // 
            this.FTActionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FTActionTxt.FormattingEnabled = true;
            this.FTActionTxt.Items.AddRange(new object[] {
            "Block",
            "Replace",
            "Execute"});
            this.FTActionTxt.Location = new System.Drawing.Point(82, 247);
            this.FTActionTxt.Name = "FTActionTxt";
            this.FTActionTxt.Size = new System.Drawing.Size(70, 21);
            this.FTActionTxt.TabIndex = 1;
            // 
            // FTFiltersVw
            // 
            this.FTFiltersVw.CheckBoxes = true;
            this.FTFiltersVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FTHeaderCol,
            this.FTDestinationCol,
            this.FTActionCol,
            this.FTReplacementCol});
            this.FTFiltersVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.FTFiltersVw.FullRowSelect = true;
            this.FTFiltersVw.GridLines = true;
            this.FTFiltersVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FTFiltersVw.HideSelection = false;
            this.FTFiltersVw.Location = new System.Drawing.Point(3, 3);
            this.FTFiltersVw.MultiSelect = false;
            this.FTFiltersVw.Name = "FTFiltersVw";
            this.FTFiltersVw.ShowItemToolTips = true;
            this.FTFiltersVw.Size = new System.Drawing.Size(391, 187);
            this.FTFiltersVw.TabIndex = 0;
            this.FTFiltersVw.UseCompatibleStateImageBehavior = false;
            this.FTFiltersVw.View = System.Windows.Forms.View.Details;
            // 
            // FTHeaderCol
            // 
            this.FTHeaderCol.Text = "Header";
            this.FTHeaderCol.Width = 55;
            // 
            // FTDestinationCol
            // 
            this.FTDestinationCol.Text = "Destination";
            this.FTDestinationCol.Width = 68;
            // 
            // FTActionCol
            // 
            this.FTActionCol.Text = "Action";
            this.FTActionCol.Width = 68;
            // 
            // FTReplacementCol
            // 
            this.FTReplacementCol.Text = "Replacement";
            this.FTReplacementCol.Width = 176;
            // 
            // ITPacketTxt
            // 
            this.ITPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITPacketTxt.Location = new System.Drawing.Point(3, 289);
            this.ITPacketTxt.Name = "ITPacketTxt";
            this.ITPacketTxt.Size = new System.Drawing.Size(258, 21);
            this.ITPacketTxt.TabIndex = 8;
            // 
            // ConnectionTab
            // 
            this.ConnectionTab.Controls.Add(this.panel1);
            this.ConnectionTab.Controls.Add(this.CoTValueLbl);
            this.ConnectionTab.Controls.Add(this.CoTGlow2Pnl);
            this.ConnectionTab.Controls.Add(this.CoTCustomClientLbl);
            this.ConnectionTab.Controls.Add(this.CoTGlow3Pnl);
            this.ConnectionTab.Controls.Add(this.CoTBrowseBtn);
            this.ConnectionTab.Controls.Add(this.CoTProxyPortLbl);
            this.ConnectionTab.Controls.Add(this.CoTExportRootCertificateBtn);
            this.ConnectionTab.Controls.Add(this.CoTDestroyCertificatesBtn);
            this.ConnectionTab.Controls.Add(this.CoTValueTxt);
            this.ConnectionTab.Controls.Add(this.CoTCustomClientTxt);
            this.ConnectionTab.Controls.Add(this.CoTVariableLbl);
            this.ConnectionTab.Controls.Add(this.CoTClearVariableBtn);
            this.ConnectionTab.Controls.Add(this.CoTUpdateVariableBtn);
            this.ConnectionTab.Controls.Add(this.CoTStatusTxt);
            this.ConnectionTab.Controls.Add(this.CoTConnectBtn);
            this.ConnectionTab.Controls.Add(this.CoTProxyPortTxt);
            this.ConnectionTab.Controls.Add(this.CoTVariablesVw);
            this.ConnectionTab.Controls.Add(this.CoTNameTxt);
            this.ConnectionTab.Location = new System.Drawing.Point(4, 28);
            this.ConnectionTab.Name = "ConnectionTab";
            this.ConnectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionTab.Size = new System.Drawing.Size(476, 313);
            this.ConnectionTab.TabIndex = 4;
            this.ConnectionTab.Text = "Connection";
            this.ConnectionTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(322, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 59);
            this.panel1.TabIndex = 104;
            // 
            // CoTValueLbl
            // 
            this.CoTValueLbl.AutoSize = true;
            this.CoTValueLbl.Location = new System.Drawing.Point(0, 137);
            this.CoTValueLbl.Name = "CoTValueLbl";
            this.CoTValueLbl.Size = new System.Drawing.Size(34, 13);
            this.CoTValueLbl.TabIndex = 99;
            this.CoTValueLbl.Text = "Value";
            // 
            // CoTGlow2Pnl
            // 
            this.CoTGlow2Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTGlow2Pnl.Location = new System.Drawing.Point(3, 218);
            this.CoTGlow2Pnl.Name = "CoTGlow2Pnl";
            this.CoTGlow2Pnl.Size = new System.Drawing.Size(470, 1);
            this.CoTGlow2Pnl.TabIndex = 103;
            // 
            // CoTCustomClientLbl
            // 
            this.CoTCustomClientLbl.AutoSize = true;
            this.CoTCustomClientLbl.Location = new System.Drawing.Point(0, 258);
            this.CoTCustomClientLbl.Name = "CoTCustomClientLbl";
            this.CoTCustomClientLbl.Size = new System.Drawing.Size(74, 13);
            this.CoTCustomClientLbl.TabIndex = 103;
            this.CoTCustomClientLbl.Text = "Custom Client:";
            // 
            // CoTGlow3Pnl
            // 
            this.CoTGlow3Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTGlow3Pnl.Location = new System.Drawing.Point(3, 281);
            this.CoTGlow3Pnl.Name = "CoTGlow3Pnl";
            this.CoTGlow3Pnl.Size = new System.Drawing.Size(470, 1);
            this.CoTGlow3Pnl.TabIndex = 102;
            // 
            // CoTBrowseBtn
            // 
            this.CoTBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoTBrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTBrowseBtn.Location = new System.Drawing.Point(373, 253);
            this.CoTBrowseBtn.Name = "CoTBrowseBtn";
            this.CoTBrowseBtn.Size = new System.Drawing.Size(100, 22);
            this.CoTBrowseBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTBrowseBtn.TabIndex = 2;
            this.CoTBrowseBtn.Text = "Browse";
            // 
            // CoTProxyPortLbl
            // 
            this.CoTProxyPortLbl.AutoSize = true;
            this.CoTProxyPortLbl.Location = new System.Drawing.Point(326, 229);
            this.CoTProxyPortLbl.Name = "CoTProxyPortLbl";
            this.CoTProxyPortLbl.Size = new System.Drawing.Size(58, 13);
            this.CoTProxyPortLbl.TabIndex = 91;
            this.CoTProxyPortLbl.Text = "Proxy Port:";
            // 
            // CoTExportRootCertificateBtn
            // 
            this.CoTExportRootCertificateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTExportRootCertificateBtn.Location = new System.Drawing.Point(163, 225);
            this.CoTExportRootCertificateBtn.Name = "CoTExportRootCertificateBtn";
            this.CoTExportRootCertificateBtn.Size = new System.Drawing.Size(160, 22);
            this.CoTExportRootCertificateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTExportRootCertificateBtn.TabIndex = 3;
            this.CoTExportRootCertificateBtn.Text = "Export Root Certificate";
            // 
            // CoTDestroyCertificatesBtn
            // 
            this.CoTDestroyCertificatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTDestroyCertificatesBtn.Location = new System.Drawing.Point(3, 225);
            this.CoTDestroyCertificatesBtn.Name = "CoTDestroyCertificatesBtn";
            this.CoTDestroyCertificatesBtn.Size = new System.Drawing.Size(154, 22);
            this.CoTDestroyCertificatesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTDestroyCertificatesBtn.TabIndex = 2;
            this.CoTDestroyCertificatesBtn.Text = "Destroy Certificate(s)";
            // 
            // CoTValueTxt
            // 
            this.CoTValueTxt.Location = new System.Drawing.Point(3, 153);
            this.CoTValueTxt.Name = "CoTValueTxt";
            this.CoTValueTxt.Size = new System.Drawing.Size(313, 20);
            this.CoTValueTxt.TabIndex = 100;
            this.CoTValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoTCustomClientTxt
            // 
            this.CoTCustomClientTxt.Location = new System.Drawing.Point(74, 255);
            this.CoTCustomClientTxt.Name = "CoTCustomClientTxt";
            this.CoTCustomClientTxt.Size = new System.Drawing.Size(293, 20);
            this.CoTCustomClientTxt.TabIndex = 0;
            this.CoTCustomClientTxt.TabStop = false;
            // 
            // CoTVariableLbl
            // 
            this.CoTVariableLbl.AutoSize = true;
            this.CoTVariableLbl.Location = new System.Drawing.Point(0, 176);
            this.CoTVariableLbl.Name = "CoTVariableLbl";
            this.CoTVariableLbl.Size = new System.Drawing.Size(45, 13);
            this.CoTVariableLbl.TabIndex = 97;
            this.CoTVariableLbl.Text = "Variable";
            // 
            // CoTClearVariableBtn
            // 
            this.CoTClearVariableBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTClearVariableBtn.Enabled = false;
            this.CoTClearVariableBtn.Location = new System.Drawing.Point(329, 186);
            this.CoTClearVariableBtn.Name = "CoTClearVariableBtn";
            this.CoTClearVariableBtn.Size = new System.Drawing.Size(144, 22);
            this.CoTClearVariableBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTClearVariableBtn.TabIndex = 95;
            this.CoTClearVariableBtn.Text = "Clear Variable";
            // 
            // CoTUpdateVariableBtn
            // 
            this.CoTUpdateVariableBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTUpdateVariableBtn.Location = new System.Drawing.Point(329, 157);
            this.CoTUpdateVariableBtn.Name = "CoTUpdateVariableBtn";
            this.CoTUpdateVariableBtn.Size = new System.Drawing.Size(144, 22);
            this.CoTUpdateVariableBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTUpdateVariableBtn.TabIndex = 94;
            this.CoTUpdateVariableBtn.Text = "Update Variable";
            // 
            // CoTStatusTxt
            // 
            this.CoTStatusTxt.AnimationInterval = 500;
            this.CoTStatusTxt.BorderWidth = 1;
            this.CoTStatusTxt.Location = new System.Drawing.Point(3, 288);
            this.CoTStatusTxt.Name = "CoTStatusTxt";
            this.CoTStatusTxt.Size = new System.Drawing.Size(350, 22);
            this.CoTStatusTxt.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTStatusTxt.TabIndex = 2;
            this.CoTStatusTxt.Text = "Standing By...";
            this.CoTStatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoTConnectBtn
            // 
            this.CoTConnectBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTConnectBtn.Location = new System.Drawing.Point(359, 288);
            this.CoTConnectBtn.Name = "CoTConnectBtn";
            this.CoTConnectBtn.Size = new System.Drawing.Size(114, 22);
            this.CoTConnectBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTConnectBtn.TabIndex = 1;
            this.CoTConnectBtn.Text = "Connect";
            // 
            // CoTProxyPortTxt
            // 
            this.CoTProxyPortTxt.Location = new System.Drawing.Point(384, 227);
            this.CoTProxyPortTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CoTProxyPortTxt.Name = "CoTProxyPortTxt";
            this.CoTProxyPortTxt.Size = new System.Drawing.Size(89, 20);
            this.CoTProxyPortTxt.TabIndex = 92;
            this.CoTProxyPortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoTVariablesVw
            // 
            this.CoTVariablesVw.CheckBoxes = true;
            this.CoTVariablesVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CoTVariableCol,
            this.CoTValueCol});
            this.CoTVariablesVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.CoTVariablesVw.FullRowSelect = true;
            this.CoTVariablesVw.GridLines = true;
            this.CoTVariablesVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CoTVariablesVw.HideSelection = false;
            this.CoTVariablesVw.Location = new System.Drawing.Point(3, 3);
            this.CoTVariablesVw.MultiSelect = false;
            this.CoTVariablesVw.Name = "CoTVariablesVw";
            this.CoTVariablesVw.ShowItemToolTips = true;
            this.CoTVariablesVw.Size = new System.Drawing.Size(470, 131);
            this.CoTVariablesVw.TabIndex = 101;
            this.CoTVariablesVw.UseCompatibleStateImageBehavior = false;
            this.CoTVariablesVw.View = System.Windows.Forms.View.Details;
            // 
            // CoTVariableCol
            // 
            this.CoTVariableCol.Text = "Variable";
            this.CoTVariableCol.Width = 224;
            // 
            // CoTValueCol
            // 
            this.CoTValueCol.Text = "Value";
            this.CoTValueCol.Width = 225;
            // 
            // CoTNameTxt
            // 
            this.CoTNameTxt.Location = new System.Drawing.Point(3, 192);
            this.CoTNameTxt.Name = "CoTNameTxt";
            this.CoTNameTxt.ReadOnly = true;
            this.CoTNameTxt.Size = new System.Drawing.Size(313, 20);
            this.CoTNameTxt.TabIndex = 98;
            this.CoTNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.AllowDrop = true;
            this.TanjiTabs.Controls.Add(this.ConnectionTab);
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.ToolboxTab);
            this.TanjiTabs.Controls.Add(this.ModulesTab);
            this.TanjiTabs.Controls.Add(this.AboutTab);
            this.TanjiTabs.DisplayBoundary = true;
            this.TanjiTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanjiTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TanjiTabs.ItemSize = new System.Drawing.Size(96, 24);
            this.TanjiTabs.Location = new System.Drawing.Point(0, 0);
            this.TanjiTabs.Name = "TanjiTabs";
            this.TanjiTabs.SelectedIndex = 0;
            this.TanjiTabs.Size = new System.Drawing.Size(484, 345);
            this.TanjiTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TanjiTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiTabs.TabIndex = 6;
            // 
            // CustomClientDlg
            // 
            this.CustomClientDlg.DefaultExt = "swf";
            this.CustomClientDlg.Filter = "Shockwave Flash File (*.swf)|*.swf";
            this.CustomClientDlg.Title = "Tanji ~ Custom Client";
            // 
            // InstallModuleDlg
            // 
            this.InstallModuleDlg.DefaultExt = "dll";
            this.InstallModuleDlg.Filter = ".NET Assembly (*.dll, *.exe)|*.dll; *.exe|Dynamic Link Library (*.dll)|*.dll|Exec" +
    "utable (*.exe)|*.exe";
            this.InstallModuleDlg.Title = "Tanji ~ Install Module";
            // 
            // STHotkeyLbl
            // 
            this.STHotkeyLbl.AutoSize = true;
            this.STHotkeyLbl.Location = new System.Drawing.Point(350, 204);
            this.STHotkeyLbl.Name = "STHotkeyLbl";
            this.STHotkeyLbl.Size = new System.Drawing.Size(41, 13);
            this.STHotkeyLbl.TabIndex = 63;
            this.STHotkeyLbl.Text = "Hotkey";
            // 
            // STHotkeyTxt
            // 
            this.STHotkeyTxt.Location = new System.Drawing.Point(353, 220);
            this.STHotkeyTxt.Name = "STHotkeyTxt";
            this.STHotkeyTxt.Size = new System.Drawing.Size(41, 20);
            this.STHotkeyTxt.TabIndex = 64;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 369);
            this.Controls.Add(this.TanjiTabs);
            this.Controls.Add(this.TanjiStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Disconnected";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.ModulesTab.ResumeLayout(false);
            this.ModulesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTAuthorPctbx)).EndInit();
            this.ToolboxTab.ResumeLayout(false);
            this.ToolboxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).EndInit();
            this.InjectionTab.ResumeLayout(false);
            this.InjectionTabs.ResumeLayout(false);
            this.ConstructerTab.ResumeLayout(false);
            this.ConstructerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTHeaderTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTAmountTxt)).EndInit();
            this.SchedulerTab.ResumeLayout(false);
            this.SchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STCyclesTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STIntervalTxt)).EndInit();
            this.PrimitiveTab.ResumeLayout(false);
            this.PrimitiveTab.PerformLayout();
            this.FiltersTab.ResumeLayout(false);
            this.FiltersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FTHeaderTxt)).EndInit();
            this.ConnectionTab.ResumeLayout(false);
            this.ConnectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoTProxyPortTxt)).EndInit();
            this.TanjiTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        private System.Windows.Forms.ToolStripStatusLabel TanjiInfoTxt;
        internal System.Windows.Forms.ToolStripStatusLabel ModulesTxt;
        internal System.Windows.Forms.ToolStripStatusLabel SchedulesTxt;
        internal System.Windows.Forms.ToolStripStatusLabel TanjiVersionTxt;
        public Sulakore.Components.SKoreInjectionMenu InjectionMenu;
        internal System.Windows.Forms.ToolStripStatusLabel FiltersTxt;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.TabPage ModulesTab;
        private System.Windows.Forms.TabPage ToolboxTab;
        private System.Windows.Forms.Label TT16BitInputLbl;
        private System.Windows.Forms.Label TT32BitInputLbl;
        internal System.Windows.Forms.NumericUpDown TTIntInputTxt;
        internal System.Windows.Forms.TextBox TTIntOutputTxt;
        internal System.Windows.Forms.TextBox TTUShortOutputTxt;
        internal Sulakore.Components.SKoreButton TTDecodeIntBtn;
        internal Sulakore.Components.SKoreButton TTDecodeUShortBtn;
        internal System.Windows.Forms.NumericUpDown TTUShortInputTxt;
        private System.Windows.Forms.TabPage InjectionTab;
        internal Sulakore.Components.SKoreButton ITSendToClientBtn;
        internal Sulakore.Components.SKoreButton ITSendToServerBtn;
        internal Sulakore.Components.SKoreTabControl InjectionTabs;
        internal System.Windows.Forms.TabPage ConstructerTab;
        internal System.Windows.Forms.ComboBox CTValueTxt;
        internal System.Windows.Forms.NumericUpDown CTHeaderTxt;
        private System.Windows.Forms.Label CTHeaderLbl;
        private System.Windows.Forms.Label CTAmountLbl;
        internal System.Windows.Forms.TextBox CTStructureTxt;
        internal Sulakore.Components.SKoreButton CTTransferBelowBtn;
        internal Sulakore.Components.SKoreLabel CTChunkCountLbl;
        internal System.Windows.Forms.NumericUpDown CTAmountTxt;
        internal Sulakore.Components.SKoreButton CTRemoveBtn;
        internal Sulakore.Components.SKoreButton CTMoveDownBtn;
        internal Sulakore.Components.SKoreButton CTMoveUpBtn;
        internal Sulakore.Components.SKoreButton CTClearBtn;
        internal Sulakore.Components.SKoreButton CTWriteBooleanBtn;
        internal Sulakore.Components.SKoreButton CTWriteStringBtn;
        internal Sulakore.Components.SKoreButton CTWriteIntegerBtn;
        private System.Windows.Forms.Label CTValueLbl;
        internal Sulakore.Components.SKoreConstructView CTConstructerVw;
        private System.Windows.Forms.ColumnHeader CTTypeCol;
        private System.Windows.Forms.ColumnHeader CTValueCol;
        private System.Windows.Forms.ColumnHeader CTEncodedCol;
        private System.Windows.Forms.CheckBox CTUpdateOnEnterChckbx;
        internal System.Windows.Forms.TabPage SchedulerTab;
        internal Sulakore.Components.SKoreButton STUpdateBtn;
        internal Sulakore.Components.SKoreButton STRemoveBtn;
        internal System.Windows.Forms.CheckBox STAutoStartChckbx;
        private System.Windows.Forms.Label STDestinationLbl;
        private System.Windows.Forms.Label STCyclesLbl;
        internal System.Windows.Forms.NumericUpDown STCyclesTxt;
        private System.Windows.Forms.Label STIntervalLbl;
        internal Sulakore.Components.SKoreButton STClearBtn;
        internal Sulakore.Components.SKoreButton STCreateBtn;
        internal System.Windows.Forms.NumericUpDown STIntervalTxt;
        internal System.Windows.Forms.ComboBox STDestinationTxt;
        private System.Windows.Forms.Label STPacketLbl;
        internal System.Windows.Forms.TextBox STPacketTxt;
        internal Sulakore.Components.SKoreScheduleView STSchedulerVw;
        private System.Windows.Forms.ColumnHeader STPacketCol;
        private System.Windows.Forms.ColumnHeader STDestinationCol;
        private System.Windows.Forms.ColumnHeader STIntervalCol;
        private System.Windows.Forms.ColumnHeader STCyclesCol;
        private System.Windows.Forms.ColumnHeader STHotkeyCol;
        private System.Windows.Forms.ColumnHeader STStatusCol;
        internal System.Windows.Forms.TabPage PrimitiveTab;
        internal System.Windows.Forms.Label PTPacketInfoLbl;
        private System.Windows.Forms.Panel PTGlow1;
        private System.Windows.Forms.Label PTCorruptedLbl;
        internal System.Windows.Forms.Label PTCorruptedValueLbl;
        internal System.Windows.Forms.TextBox PTPacketTxt;
        internal System.Windows.Forms.TabPage FiltersTab;
        private System.Windows.Forms.Label FTDestinationLbl;
        internal System.Windows.Forms.ComboBox FTDestinationTxt;
        internal System.Windows.Forms.NumericUpDown FTHeaderTxt;
        private System.Windows.Forms.Label FTHeaderLbl;
        internal Sulakore.Components.SKoreButton FTRemoveBtn;
        internal Sulakore.Components.SKoreButton FTCreateBtn;
        private System.Windows.Forms.Label FTReplacementLbl;
        internal System.Windows.Forms.TextBox FTReplacementTxt;
        private System.Windows.Forms.Label FTActionLbl;
        internal System.Windows.Forms.ComboBox FTActionTxt;
        internal Sulakore.Components.SKoreListView FTFiltersVw;
        private System.Windows.Forms.ColumnHeader FTHeaderCol;
        private System.Windows.Forms.ColumnHeader FTDestinationCol;
        private System.Windows.Forms.ColumnHeader FTActionCol;
        private System.Windows.Forms.ColumnHeader FTReplacementCol;
        internal System.Windows.Forms.ComboBox ITPacketTxt;
        private System.Windows.Forms.TabPage ConnectionTab;
        private System.Windows.Forms.Panel CoTGlow2Pnl;
        private System.Windows.Forms.Label CoTCustomClientLbl;
        private System.Windows.Forms.Panel CoTGlow3Pnl;
        internal Sulakore.Components.SKoreButton CoTBrowseBtn;
        private System.Windows.Forms.Label CoTProxyPortLbl;
        internal Sulakore.Components.SKoreButton CoTExportRootCertificateBtn;
        internal Sulakore.Components.SKoreButton CoTDestroyCertificatesBtn;
        internal System.Windows.Forms.TextBox CoTValueTxt;
        internal System.Windows.Forms.TextBox CoTCustomClientTxt;
        internal System.Windows.Forms.TextBox CoTNameTxt;
        private System.Windows.Forms.Label CoTValueLbl;
        private System.Windows.Forms.Label CoTVariableLbl;
        internal Sulakore.Components.SKoreButton CoTClearVariableBtn;
        internal Sulakore.Components.SKoreButton CoTUpdateVariableBtn;
        internal Sulakore.Components.SKoreLabel CoTStatusTxt;
        internal Sulakore.Components.SKoreButton CoTConnectBtn;
        internal System.Windows.Forms.NumericUpDown CoTProxyPortTxt;
        internal Sulakore.Components.SKoreListView CoTVariablesVw;
        private System.Windows.Forms.ColumnHeader CoTVariableCol;
        private System.Windows.Forms.ColumnHeader CoTValueCol;
        internal Sulakore.Components.SKoreTabControl TanjiTabs;
        internal System.Windows.Forms.OpenFileDialog CustomClientDlg;
        internal System.Windows.Forms.OpenFileDialog InstallModuleDlg;
        internal Sulakore.Components.SKoreListView MTModulesVw;
        private System.Windows.Forms.ColumnHeader MTNameCol;
        private System.Windows.Forms.ColumnHeader MTVersionCol;
        private System.Windows.Forms.Panel MTGlow1;
        internal System.Windows.Forms.PictureBox MTAuthorPctbx;
        internal Sulakore.Components.SKoreButton MTDownloadLatestBtn;
        internal Sulakore.Components.SKoreButton MTUninstallModuleBtn;
        internal Sulakore.Components.SKoreButton MTInstallModuleBtn;
        private System.Windows.Forms.ColumnHeader MTDescriptionCol;
        private System.Windows.Forms.ColumnHeader MTStateCol;
        private System.Windows.Forms.Label MTAuthorsLbl;
        internal System.Windows.Forms.ComboBox MTAuthorsTxt;
        private System.Windows.Forms.Label MTHabboNameLbl;
        private System.Windows.Forms.Label MTHotelLbl;
        internal Sulakore.Components.SKoreButton MTResourceBtn;
        internal Sulakore.Components.SKoreButton MTReleasesBtn;
        internal System.Windows.Forms.TextBox MTHabboNameTxt;
        internal System.Windows.Forms.TextBox MTHotelTxt;
        internal System.Windows.Forms.Label MTDownloadsLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AboutTxt;
        internal Sulakore.Components.SKoreButton DonateBtn;
        internal Sulakore.Components.SKoreKeyBox STHotkeyTxt;
        private System.Windows.Forms.Label STHotkeyLbl;
    }
}