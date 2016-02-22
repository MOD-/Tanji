using Tanji.Properties;

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
            this.TanjiStrip = new System.Windows.Forms.StatusStrip();
            this.TanjiVersionTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.FiltersTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.SchedulesTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ETExtensionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ETOpenMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETUninstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETTopMenuSplitter = new System.Windows.Forms.ToolStripSeparator();
            this.ETInstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.ConnectionTab = new System.Windows.Forms.TabPage();
            this.CoTGlow2Pnl = new System.Windows.Forms.Panel();
            this.CoTCustomClientLbl = new System.Windows.Forms.Label();
            this.CoTGlow3Pnl = new System.Windows.Forms.Panel();
            this.CoTBrowseBtn = new Sulakore.Components.SKoreButton();
            this.CoTProxyPortLbl = new System.Windows.Forms.Label();
            this.CoTExportRootCertificateBtn = new Sulakore.Components.SKoreButton();
            this.CoTDestroyCertificatesBtn = new Sulakore.Components.SKoreButton();
            this.CoTValueTxt = new System.Windows.Forms.TextBox();
            this.CoTValueLbl = new System.Windows.Forms.Label();
            this.CoTVariableLbl = new System.Windows.Forms.Label();
            this.CoTGlow1Pnl = new System.Windows.Forms.Panel();
            this.CoTClearVariableBtn = new Sulakore.Components.SKoreButton();
            this.CoTUpdateVariableBtn = new Sulakore.Components.SKoreButton();
            this.CoTStatusTxt = new Sulakore.Components.SKoreLabel();
            this.CoTConnectBtn = new Sulakore.Components.SKoreButton();
            this.CoTCustomClientTxt = new System.Windows.Forms.TextBox();
            this.CoTNameTxt = new System.Windows.Forms.TextBox();
            this.CoTProxyPortTxt = new System.Windows.Forms.NumericUpDown();
            this.CoTVariablesVw = new Sulakore.Components.SKoreListView();
            this.VTVariableCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VTValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.ICSTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.STStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.PTPacketInfoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.TT16BitInputLbl = new System.Windows.Forms.Label();
            this.TT32BitInputLbl = new System.Windows.Forms.Label();
            this.TTIntInputTxt = new System.Windows.Forms.NumericUpDown();
            this.ToolboxTabs = new Sulakore.Components.SKoreTabControl();
            this.ProfileTab = new System.Windows.Forms.TabPage();
            this.TTIntOutputTxt = new System.Windows.Forms.TextBox();
            this.TTDecodeIntBtn = new Sulakore.Components.SKoreButton();
            this.TTDecodeUShortBtn = new Sulakore.Components.SKoreButton();
            this.TTUShortOutputTxt = new System.Windows.Forms.TextBox();
            this.TTUShortInputTxt = new System.Windows.Forms.NumericUpDown();
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.ETUninstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.ETExtensionVw = new Sulakore.Components.SKoreExtensionView();
            this.ETIdentifierCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETCreatorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETInstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.InjectionMenu = new Sulakore.Components.SKoreInjectionMenu(this.components);
            this.TanjiStrip.SuspendLayout();
            this.ETExtensionMenu.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.ConnectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoTProxyPortTxt)).BeginInit();
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
            this.ToolboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).BeginInit();
            this.ToolboxTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).BeginInit();
            this.ExtensionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanjiVersionTxt,
            this.FiltersTxt,
            this.SchedulesTxt,
            this.ExtensionsTxt,
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
            // FiltersTxt
            // 
            this.FiltersTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.FiltersTxt.Name = "FiltersTxt";
            this.FiltersTxt.Size = new System.Drawing.Size(65, 19);
            this.FiltersTxt.Text = "Filters: 0/0";
            // 
            // SchedulesTxt
            // 
            this.SchedulesTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SchedulesTxt.Name = "SchedulesTxt";
            this.SchedulesTxt.Size = new System.Drawing.Size(87, 19);
            this.SchedulesTxt.Text = "Schedules: 0/0";
            // 
            // ExtensionsTxt
            // 
            this.ExtensionsTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ExtensionsTxt.Name = "ExtensionsTxt";
            this.ExtensionsTxt.Size = new System.Drawing.Size(89, 19);
            this.ExtensionsTxt.Text = "Extensions: 0/0";
            // 
            // TanjiInfoTxt
            // 
            this.TanjiInfoTxt.IsLink = true;
            this.TanjiInfoTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiInfoTxt.Name = "TanjiInfoTxt";
            this.TanjiInfoTxt.Size = new System.Drawing.Size(178, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "GitHub | ArachisH/Tanji";
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // ETExtensionMenu
            // 
            this.ETExtensionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ETOpenMenuBtn,
            this.ETUninstallMenuBtn,
            this.ETTopMenuSplitter,
            this.ETInstallMenuBtn});
            this.ETExtensionMenu.Name = "ConstructMenu";
            this.ETExtensionMenu.Size = new System.Drawing.Size(159, 76);
            // 
            // ETOpenMenuBtn
            // 
            this.ETOpenMenuBtn.Enabled = false;
            this.ETOpenMenuBtn.Name = "ETOpenMenuBtn";
            this.ETOpenMenuBtn.Size = new System.Drawing.Size(158, 22);
            this.ETOpenMenuBtn.Text = "Open";
            // 
            // ETUninstallMenuBtn
            // 
            this.ETUninstallMenuBtn.Enabled = false;
            this.ETUninstallMenuBtn.Name = "ETUninstallMenuBtn";
            this.ETUninstallMenuBtn.Size = new System.Drawing.Size(158, 22);
            this.ETUninstallMenuBtn.Text = "Uninstall";
            // 
            // ETTopMenuSplitter
            // 
            this.ETTopMenuSplitter.Name = "ETTopMenuSplitter";
            this.ETTopMenuSplitter.Size = new System.Drawing.Size(155, 6);
            // 
            // ETInstallMenuBtn
            // 
            this.ETInstallMenuBtn.Name = "ETInstallMenuBtn";
            this.ETInstallMenuBtn.Size = new System.Drawing.Size(158, 22);
            this.ETInstallMenuBtn.Text = "Install Extension";
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.Controls.Add(this.ConnectionTab);
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.ToolboxTab);
            this.TanjiTabs.Controls.Add(this.ExtensionsTab);
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
            // ConnectionTab
            // 
            this.ConnectionTab.Controls.Add(this.CoTGlow2Pnl);
            this.ConnectionTab.Controls.Add(this.CoTCustomClientLbl);
            this.ConnectionTab.Controls.Add(this.CoTGlow3Pnl);
            this.ConnectionTab.Controls.Add(this.CoTBrowseBtn);
            this.ConnectionTab.Controls.Add(this.CoTProxyPortLbl);
            this.ConnectionTab.Controls.Add(this.CoTExportRootCertificateBtn);
            this.ConnectionTab.Controls.Add(this.CoTDestroyCertificatesBtn);
            this.ConnectionTab.Controls.Add(this.CoTValueTxt);
            this.ConnectionTab.Controls.Add(this.CoTValueLbl);
            this.ConnectionTab.Controls.Add(this.CoTVariableLbl);
            this.ConnectionTab.Controls.Add(this.CoTGlow1Pnl);
            this.ConnectionTab.Controls.Add(this.CoTClearVariableBtn);
            this.ConnectionTab.Controls.Add(this.CoTUpdateVariableBtn);
            this.ConnectionTab.Controls.Add(this.CoTStatusTxt);
            this.ConnectionTab.Controls.Add(this.CoTConnectBtn);
            this.ConnectionTab.Controls.Add(this.CoTCustomClientTxt);
            this.ConnectionTab.Controls.Add(this.CoTNameTxt);
            this.ConnectionTab.Controls.Add(this.CoTProxyPortTxt);
            this.ConnectionTab.Controls.Add(this.CoTVariablesVw);
            this.ConnectionTab.Location = new System.Drawing.Point(4, 28);
            this.ConnectionTab.Name = "ConnectionTab";
            this.ConnectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionTab.Size = new System.Drawing.Size(476, 313);
            this.ConnectionTab.TabIndex = 4;
            this.ConnectionTab.Text = "Connection";
            this.ConnectionTab.UseVisualStyleBackColor = true;
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
            this.CoTBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CoTBrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTBrowseBtn.Location = new System.Drawing.Point(373, 253);
            this.CoTBrowseBtn.Name = "CoTBrowseBtn";
            this.CoTBrowseBtn.Size = new System.Drawing.Size(100, 22);
            this.CoTBrowseBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTBrowseBtn.TabIndex = 2;
            this.CoTBrowseBtn.TabStop = false;
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
            this.CoTValueTxt.Location = new System.Drawing.Point(3, 192);
            this.CoTValueTxt.Name = "CoTValueTxt";
            this.CoTValueTxt.Size = new System.Drawing.Size(312, 20);
            this.CoTValueTxt.TabIndex = 100;
            this.CoTValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoTValueLbl
            // 
            this.CoTValueLbl.AutoSize = true;
            this.CoTValueLbl.Location = new System.Drawing.Point(0, 176);
            this.CoTValueLbl.Name = "CoTValueLbl";
            this.CoTValueLbl.Size = new System.Drawing.Size(34, 13);
            this.CoTValueLbl.TabIndex = 99;
            this.CoTValueLbl.Text = "Value";
            // 
            // CoTVariableLbl
            // 
            this.CoTVariableLbl.AutoSize = true;
            this.CoTVariableLbl.Location = new System.Drawing.Point(0, 137);
            this.CoTVariableLbl.Name = "CoTVariableLbl";
            this.CoTVariableLbl.Size = new System.Drawing.Size(45, 13);
            this.CoTVariableLbl.TabIndex = 97;
            this.CoTVariableLbl.Text = "Variable";
            // 
            // CoTGlow1Pnl
            // 
            this.CoTGlow1Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTGlow1Pnl.Location = new System.Drawing.Point(321, 153);
            this.CoTGlow1Pnl.Name = "CoTGlow1Pnl";
            this.CoTGlow1Pnl.Size = new System.Drawing.Size(1, 59);
            this.CoTGlow1Pnl.TabIndex = 96;
            // 
            // CoTClearVariableBtn
            // 
            this.CoTClearVariableBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTClearVariableBtn.Enabled = false;
            this.CoTClearVariableBtn.Location = new System.Drawing.Point(328, 187);
            this.CoTClearVariableBtn.Name = "CoTClearVariableBtn";
            this.CoTClearVariableBtn.Size = new System.Drawing.Size(145, 22);
            this.CoTClearVariableBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTClearVariableBtn.TabIndex = 95;
            this.CoTClearVariableBtn.Text = "Clear Variable";
            // 
            // CoTUpdateVariableBtn
            // 
            this.CoTUpdateVariableBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTUpdateVariableBtn.Location = new System.Drawing.Point(328, 156);
            this.CoTUpdateVariableBtn.Name = "CoTUpdateVariableBtn";
            this.CoTUpdateVariableBtn.Size = new System.Drawing.Size(145, 22);
            this.CoTUpdateVariableBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTUpdateVariableBtn.TabIndex = 94;
            this.CoTUpdateVariableBtn.Text = "Update Variable";
            // 
            // CoTStatusTxt
            // 
            this.CoTStatusTxt.AnimationInterval = 500;
            this.CoTStatusTxt.BorderWidth = 1;
            this.CoTStatusTxt.DisplayBoundary = true;
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
            // CoTCustomClientTxt
            // 
            this.CoTCustomClientTxt.Location = new System.Drawing.Point(74, 255);
            this.CoTCustomClientTxt.Name = "CoTCustomClientTxt";
            this.CoTCustomClientTxt.ReadOnly = true;
            this.CoTCustomClientTxt.Size = new System.Drawing.Size(293, 20);
            this.CoTCustomClientTxt.TabIndex = 0;
            this.CoTCustomClientTxt.TabStop = false;
            // 
            // CoTNameTxt
            // 
            this.CoTNameTxt.Location = new System.Drawing.Point(3, 153);
            this.CoTNameTxt.Name = "CoTNameTxt";
            this.CoTNameTxt.ReadOnly = true;
            this.CoTNameTxt.Size = new System.Drawing.Size(312, 20);
            this.CoTNameTxt.TabIndex = 98;
            this.CoTNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.VTVariableCol,
            this.VTValueCol});
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
            // VTVariableCol
            // 
            this.VTVariableCol.Text = "Variable";
            this.VTVariableCol.Width = 224;
            // 
            // VTValueCol
            // 
            this.VTValueCol.Text = "Value";
            this.VTValueCol.Width = 225;
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
            this.InjectionTabs.ItemSize = new System.Drawing.Size(65, 24);
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
            this.ICSTypeCol,
            this.ICSValueCol,
            this.ICSEncodedCol});
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
            // ICSTypeCol
            // 
            this.ICSTypeCol.Text = "Type";
            this.ICSTypeCol.Width = 72;
            // 
            // ICSValueCol
            // 
            this.ICSValueCol.Text = "Value";
            this.ICSValueCol.Width = 149;
            // 
            // ICSEncodedCol
            // 
            this.ICSEncodedCol.Text = "Encoded";
            this.ICSEncodedCol.Width = 149;
            // 
            // CTUpdateOnEnterChckbx
            // 
            this.CTUpdateOnEnterChckbx.AutoSize = true;
            this.CTUpdateOnEnterChckbx.Checked = true;
            this.CTUpdateOnEnterChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CTUpdateOnEnterChckbx.Enabled = false;
            this.CTUpdateOnEnterChckbx.Location = new System.Drawing.Point(209, -1);
            this.CTUpdateOnEnterChckbx.Name = "CTUpdateOnEnterChckbx";
            this.CTUpdateOnEnterChckbx.Size = new System.Drawing.Size(126, 17);
            this.CTUpdateOnEnterChckbx.TabIndex = 50;
            this.CTUpdateOnEnterChckbx.Text = "Update On {ENTER}";
            this.CTUpdateOnEnterChckbx.UseVisualStyleBackColor = true;
            // 
            // SchedulerTab
            // 
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
            this.STAutoStartChckbx.AutoSize = true;
            this.STAutoStartChckbx.Checked = true;
            this.STAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.STAutoStartChckbx.Location = new System.Drawing.Point(168, 192);
            this.STAutoStartChckbx.Name = "STAutoStartChckbx";
            this.STAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.STAutoStartChckbx.TabIndex = 53;
            this.STAutoStartChckbx.Text = "Auto Start";
            this.STAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // STDestinationLbl
            // 
            this.STDestinationLbl.AutoSize = true;
            this.STDestinationLbl.Location = new System.Drawing.Point(237, 193);
            this.STDestinationLbl.Name = "STDestinationLbl";
            this.STDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.STDestinationLbl.TabIndex = 48;
            this.STDestinationLbl.Text = "Destination";
            // 
            // STCyclesLbl
            // 
            this.STCyclesLbl.AutoSize = true;
            this.STCyclesLbl.Location = new System.Drawing.Point(316, 232);
            this.STCyclesLbl.Name = "STCyclesLbl";
            this.STCyclesLbl.Size = new System.Drawing.Size(38, 13);
            this.STCyclesLbl.TabIndex = 60;
            this.STCyclesLbl.Text = "Cycles";
            // 
            // STCyclesTxt
            // 
            this.STCyclesTxt.Location = new System.Drawing.Point(319, 248);
            this.STCyclesTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.STCyclesTxt.Name = "STCyclesTxt";
            this.STCyclesTxt.Size = new System.Drawing.Size(75, 20);
            this.STCyclesTxt.TabIndex = 59;
            this.STCyclesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STIntervalLbl
            // 
            this.STIntervalLbl.AutoSize = true;
            this.STIntervalLbl.Location = new System.Drawing.Point(316, 193);
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
            this.STIntervalTxt.Location = new System.Drawing.Point(319, 209);
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
            this.STIntervalTxt.Size = new System.Drawing.Size(75, 20);
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
            this.STDestinationTxt.Location = new System.Drawing.Point(240, 208);
            this.STDestinationTxt.Name = "STDestinationTxt";
            this.STDestinationTxt.Size = new System.Drawing.Size(73, 21);
            this.STDestinationTxt.TabIndex = 47;
            // 
            // STPacketLbl
            // 
            this.STPacketLbl.AutoSize = true;
            this.STPacketLbl.Location = new System.Drawing.Point(0, 193);
            this.STPacketLbl.Name = "STPacketLbl";
            this.STPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.STPacketLbl.TabIndex = 46;
            this.STPacketLbl.Text = "Packet";
            // 
            // STPacketTxt
            // 
            this.STPacketTxt.Location = new System.Drawing.Point(3, 209);
            this.STPacketTxt.MaxLength = 2147483647;
            this.STPacketTxt.Name = "STPacketTxt";
            this.STPacketTxt.Size = new System.Drawing.Size(231, 20);
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
            this.STSchedulerVw.SelectedInterval = -1;
            this.STSchedulerVw.SelectedPacket = null;
            this.STSchedulerVw.ShowItemToolTips = true;
            this.STSchedulerVw.Size = new System.Drawing.Size(391, 183);
            this.STSchedulerVw.TabIndex = 0;
            this.STSchedulerVw.UseCompatibleStateImageBehavior = false;
            this.STSchedulerVw.View = System.Windows.Forms.View.Details;
            // 
            // STPacketCol
            // 
            this.STPacketCol.Text = "Packet";
            this.STPacketCol.Width = 155;
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
            // STStatusCol
            // 
            this.STStatusCol.Text = "Status";
            this.STStatusCol.Width = 52;
            // 
            // PrimitiveTab
            // 
            this.PrimitiveTab.Controls.Add(this.PTPacketInfoLbl);
            this.PrimitiveTab.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(303, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 22);
            this.panel1.TabIndex = 6;
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
            // ToolboxTab
            // 
            this.ToolboxTab.Controls.Add(this.TT16BitInputLbl);
            this.ToolboxTab.Controls.Add(this.TT32BitInputLbl);
            this.ToolboxTab.Controls.Add(this.TTIntInputTxt);
            this.ToolboxTab.Controls.Add(this.ToolboxTabs);
            this.ToolboxTab.Controls.Add(this.TTIntOutputTxt);
            this.ToolboxTab.Controls.Add(this.TTDecodeIntBtn);
            this.ToolboxTab.Controls.Add(this.TTDecodeUShortBtn);
            this.ToolboxTab.Controls.Add(this.TTUShortOutputTxt);
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
            // ToolboxTabs
            // 
            this.ToolboxTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.ToolboxTabs.Controls.Add(this.ProfileTab);
            this.ToolboxTabs.DisplayBoundary = true;
            this.ToolboxTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolboxTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ToolboxTabs.ItemSize = new System.Drawing.Size(50, 24);
            this.ToolboxTabs.Location = new System.Drawing.Point(0, 0);
            this.ToolboxTabs.Multiline = true;
            this.ToolboxTabs.Name = "ToolboxTabs";
            this.ToolboxTabs.SelectedIndex = 0;
            this.ToolboxTabs.Size = new System.Drawing.Size(476, 254);
            this.ToolboxTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ToolboxTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ToolboxTabs.TabIndex = 48;
            // 
            // ProfileTab
            // 
            this.ProfileTab.Location = new System.Drawing.Point(4, 4);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileTab.Size = new System.Drawing.Size(418, 246);
            this.ProfileTab.TabIndex = 0;
            this.ProfileTab.Text = "Profile";
            this.ProfileTab.UseVisualStyleBackColor = true;
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
            // ExtensionsTab
            // 
            this.ExtensionsTab.Controls.Add(this.ETUninstallExtensionBtn);
            this.ExtensionsTab.Controls.Add(this.ETExtensionVw);
            this.ExtensionsTab.Controls.Add(this.ETInstallExtensionBtn);
            this.ExtensionsTab.Location = new System.Drawing.Point(4, 28);
            this.ExtensionsTab.Name = "ExtensionsTab";
            this.ExtensionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtensionsTab.Size = new System.Drawing.Size(476, 313);
            this.ExtensionsTab.TabIndex = 1;
            this.ExtensionsTab.Text = "Extensions";
            this.ExtensionsTab.UseVisualStyleBackColor = true;
            // 
            // ETUninstallExtensionBtn
            // 
            this.ETUninstallExtensionBtn.BackColor = System.Drawing.Color.Transparent;
            this.ETUninstallExtensionBtn.Enabled = false;
            this.ETUninstallExtensionBtn.Location = new System.Drawing.Point(215, 285);
            this.ETUninstallExtensionBtn.Name = "ETUninstallExtensionBtn";
            this.ETUninstallExtensionBtn.Size = new System.Drawing.Size(123, 22);
            this.ETUninstallExtensionBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ETUninstallExtensionBtn.TabIndex = 2;
            this.ETUninstallExtensionBtn.Text = "Uninstall Extension";
            // 
            // ETExtensionVw
            // 
            this.ETExtensionVw.CheckBoxes = true;
            this.ETExtensionVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ETIdentifierCol,
            this.ETCreatorCol,
            this.ETDescriptionCol,
            this.ETVersionCol,
            this.ETStatusCol});
            this.ETExtensionVw.ContextMenuStrip = this.ETExtensionMenu;
            this.ETExtensionVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.ETExtensionVw.FullRowSelect = true;
            this.ETExtensionVw.GridLines = true;
            this.ETExtensionVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ETExtensionVw.HideSelection = false;
            this.ETExtensionVw.Location = new System.Drawing.Point(3, 3);
            this.ETExtensionVw.MultiSelect = false;
            this.ETExtensionVw.Name = "ETExtensionVw";
            this.ETExtensionVw.ShowItemToolTips = true;
            this.ETExtensionVw.Size = new System.Drawing.Size(470, 276);
            this.ETExtensionVw.TabIndex = 0;
            this.ETExtensionVw.UseCompatibleStateImageBehavior = false;
            this.ETExtensionVw.View = System.Windows.Forms.View.Details;
            // 
            // ETIdentifierCol
            // 
            this.ETIdentifierCol.Text = "Identifier";
            this.ETIdentifierCol.Width = 87;
            // 
            // ETCreatorCol
            // 
            this.ETCreatorCol.Text = "Creator";
            this.ETCreatorCol.Width = 90;
            // 
            // ETDescriptionCol
            // 
            this.ETDescriptionCol.Text = "Description";
            this.ETDescriptionCol.Width = 120;
            // 
            // ETVersionCol
            // 
            this.ETVersionCol.Text = "Version";
            this.ETVersionCol.Width = 92;
            // 
            // ETStatusCol
            // 
            this.ETStatusCol.Text = "Status";
            // 
            // ETInstallExtensionBtn
            // 
            this.ETInstallExtensionBtn.BackColor = System.Drawing.Color.Transparent;
            this.ETInstallExtensionBtn.Location = new System.Drawing.Point(344, 285);
            this.ETInstallExtensionBtn.Name = "ETInstallExtensionBtn";
            this.ETInstallExtensionBtn.Size = new System.Drawing.Size(123, 22);
            this.ETInstallExtensionBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ETInstallExtensionBtn.TabIndex = 1;
            this.ETInstallExtensionBtn.Text = "Install Extension";
            // 
            // AboutTab
            // 
            this.AboutTab.Location = new System.Drawing.Point(4, 28);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(476, 313);
            this.AboutTab.TabIndex = 5;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // InjectionMenu
            // 
            this.InjectionMenu.InputBox = null;
            this.InjectionMenu.Name = "InjectionMenu";
            this.InjectionMenu.Size = new System.Drawing.Size(174, 170);
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
            this.Icon = global::Tanji.Properties.Resources.Tanji_128;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Disconnected";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.ETExtensionMenu.ResumeLayout(false);
            this.TanjiTabs.ResumeLayout(false);
            this.ConnectionTab.ResumeLayout(false);
            this.ConnectionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoTProxyPortTxt)).EndInit();
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
            this.ToolboxTab.ResumeLayout(false);
            this.ToolboxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).EndInit();
            this.ToolboxTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).EndInit();
            this.ExtensionsTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        private System.Windows.Forms.ToolStripSeparator ETTopMenuSplitter;
        private System.Windows.Forms.ToolStripStatusLabel TanjiInfoTxt;
        private System.Windows.Forms.TabPage ExtensionsTab;
        private System.Windows.Forms.ColumnHeader ETIdentifierCol;
        private System.Windows.Forms.ColumnHeader ETCreatorCol;
        private System.Windows.Forms.ColumnHeader ETDescriptionCol;
        private System.Windows.Forms.ColumnHeader ETVersionCol;
        private System.Windows.Forms.ColumnHeader ETStatusCol;
        private System.Windows.Forms.TabPage ToolboxTab;
        private System.Windows.Forms.TabPage InjectionTab;
        private System.Windows.Forms.Label CTHeaderLbl;
        private System.Windows.Forms.Label CTAmountLbl;
        private System.Windows.Forms.ColumnHeader ICSTypeCol;
        private System.Windows.Forms.ColumnHeader ICSValueCol;
        private System.Windows.Forms.ColumnHeader ICSEncodedCol;
        private System.Windows.Forms.Label CTValueLbl;
        private System.Windows.Forms.ColumnHeader STPacketCol;
        private System.Windows.Forms.ColumnHeader STDestinationCol;
        private System.Windows.Forms.ColumnHeader STIntervalCol;
        private System.Windows.Forms.ColumnHeader STStatusCol;
        private System.Windows.Forms.ColumnHeader FTActionCol;
        private System.Windows.Forms.ColumnHeader FTHeaderCol;
        private System.Windows.Forms.ColumnHeader FTReplacementCol;
        private System.Windows.Forms.ColumnHeader FTDestinationCol;
        private System.Windows.Forms.Label FTActionLbl;
        private System.Windows.Forms.TabPage ConnectionTab;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.Label STIntervalLbl;
        private System.Windows.Forms.Label STDestinationLbl;
        private System.Windows.Forms.Label STPacketLbl;
        internal Sulakore.Components.SKoreButton ETUninstallExtensionBtn;
        internal Sulakore.Components.SKoreExtensionView ETExtensionVw;
        internal Sulakore.Components.SKoreButton ETInstallExtensionBtn;
        internal System.Windows.Forms.TextBox TTUShortOutputTxt;
        internal System.Windows.Forms.TextBox TTIntOutputTxt;
        internal Sulakore.Components.SKoreButton TTDecodeUShortBtn;
        internal Sulakore.Components.SKoreButton TTDecodeIntBtn;
        internal Sulakore.Components.SKoreButton ITSendToClientBtn;
        internal Sulakore.Components.SKoreButton ITSendToServerBtn;
        internal System.Windows.Forms.ComboBox CTValueTxt;
        internal System.Windows.Forms.TextBox CTStructureTxt;
        internal Sulakore.Components.SKoreButton CTTransferBelowBtn;
        internal Sulakore.Components.SKoreLabel CTChunkCountLbl;
        internal Sulakore.Components.SKoreConstructView CTConstructerVw;
        internal System.Windows.Forms.NumericUpDown CTAmountTxt;
        internal Sulakore.Components.SKoreButton CTRemoveBtn;
        internal Sulakore.Components.SKoreButton CTMoveDownBtn;
        internal Sulakore.Components.SKoreButton CTMoveUpBtn;
        internal Sulakore.Components.SKoreButton CTClearBtn;
        internal Sulakore.Components.SKoreButton CTWriteBooleanBtn;
        internal Sulakore.Components.SKoreButton CTWriteStringBtn;
        internal Sulakore.Components.SKoreButton CTWriteIntegerBtn;
        internal Sulakore.Components.SKoreButton STClearBtn;
        internal Sulakore.Components.SKoreButton STCreateBtn;
        internal System.Windows.Forms.NumericUpDown STIntervalTxt;
        internal System.Windows.Forms.ComboBox STDestinationTxt;
        internal System.Windows.Forms.TextBox STPacketTxt;
        internal System.Windows.Forms.CheckBox STAutoStartChckbx;
        internal Sulakore.Components.SKoreScheduleView STSchedulerVw;
        internal System.Windows.Forms.TextBox PTPacketTxt;
        internal System.Windows.Forms.ComboBox ITPacketTxt;
        internal System.Windows.Forms.ComboBox FTActionTxt;
        internal Sulakore.Components.SKoreListView FTFiltersVw;
        internal Sulakore.Components.SKoreButton CoTConnectBtn;
        internal Sulakore.Components.SKoreLabel CoTStatusTxt;
        internal System.Windows.Forms.ContextMenuStrip ETExtensionMenu;
        internal System.Windows.Forms.ToolStripMenuItem ETOpenMenuBtn;
        internal System.Windows.Forms.ToolStripMenuItem ETUninstallMenuBtn;
        internal System.Windows.Forms.ToolStripMenuItem ETInstallMenuBtn;
        internal Sulakore.Components.SKoreTabControl InjectionTabs;
        internal System.Windows.Forms.TabPage PrimitiveTab;
        internal System.Windows.Forms.ToolStripStatusLabel ExtensionsTxt;
        internal System.Windows.Forms.ToolStripStatusLabel SchedulesTxt;
        internal System.Windows.Forms.ToolStripStatusLabel TanjiVersionTxt;
        private Sulakore.Components.SKoreTabControl ToolboxTabs;
        private System.Windows.Forms.TabPage ProfileTab;
        private System.Windows.Forms.Panel CoTGlow3Pnl;
        internal Sulakore.Components.SKoreButton CoTBrowseBtn;
        internal System.Windows.Forms.TextBox CoTCustomClientTxt;
        private System.Windows.Forms.Label CoTProxyPortLbl;
        internal Sulakore.Components.SKoreButton CoTExportRootCertificateBtn;
        internal Sulakore.Components.SKoreButton CoTDestroyCertificatesBtn;
        internal System.Windows.Forms.NumericUpDown CoTProxyPortTxt;
        internal Sulakore.Components.SKoreListView CoTVariablesVw;
        private System.Windows.Forms.ColumnHeader VTVariableCol;
        private System.Windows.Forms.ColumnHeader VTValueCol;
        internal System.Windows.Forms.TextBox CoTValueTxt;
        private System.Windows.Forms.Label CoTValueLbl;
        internal System.Windows.Forms.TextBox CoTNameTxt;
        private System.Windows.Forms.Label CoTVariableLbl;
        private System.Windows.Forms.Panel CoTGlow1Pnl;
        internal Sulakore.Components.SKoreButton CoTClearVariableBtn;
        internal Sulakore.Components.SKoreButton CoTUpdateVariableBtn;
        private System.Windows.Forms.Label CoTCustomClientLbl;
        private System.Windows.Forms.Panel CoTGlow2Pnl;
        public Sulakore.Components.SKoreInjectionMenu InjectionMenu;
        internal System.Windows.Forms.TabPage FiltersTab;
        internal System.Windows.Forms.TabPage SchedulerTab;
        internal System.Windows.Forms.TabPage ConstructerTab;
        internal System.Windows.Forms.NumericUpDown TTUShortInputTxt;
        internal System.Windows.Forms.NumericUpDown TTIntInputTxt;
        private System.Windows.Forms.Label TT32BitInputLbl;
        private System.Windows.Forms.Label TT16BitInputLbl;
        internal Sulakore.Components.SKoreTabControl TanjiTabs;
        internal System.Windows.Forms.NumericUpDown CTHeaderTxt;
        private System.Windows.Forms.CheckBox CTUpdateOnEnterChckbx;
        private System.Windows.Forms.Label STCyclesLbl;
        internal System.Windows.Forms.NumericUpDown STCyclesTxt;
        private System.Windows.Forms.ColumnHeader STCyclesCol;
        internal Sulakore.Components.SKoreButton STRemoveBtn;
        internal Sulakore.Components.SKoreButton STUpdateBtn;
        private System.Windows.Forms.Label PTCorruptedLbl;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label PTCorruptedValueLbl;
        internal System.Windows.Forms.Label PTPacketInfoLbl;
        private System.Windows.Forms.Label FTReplacementLbl;
        internal System.Windows.Forms.TextBox FTReplacementTxt;
        private System.Windows.Forms.Label FTDestinationLbl;
        internal System.Windows.Forms.ComboBox FTDestinationTxt;
        internal System.Windows.Forms.NumericUpDown FTHeaderTxt;
        private System.Windows.Forms.Label FTHeaderLbl;
        internal Sulakore.Components.SKoreButton FTRemoveBtn;
        internal Sulakore.Components.SKoreButton FTCreateBtn;
        internal System.Windows.Forms.ToolStripStatusLabel FiltersTxt;
    }
}