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
            this.SchedulesActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.CoTVariablesVw = new Sulakore.Components.SKoreListView();
            this.VTVariableCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VTValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CoTProxyPortTxt = new System.Windows.Forms.NumericUpDown();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.ITSendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ITSendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.ConstructerTab = new System.Windows.Forms.TabPage();
            this.CTHeaderLbl = new System.Windows.Forms.Label();
            this.CTCountLbl = new System.Windows.Forms.Label();
            this.CTPacketTxt = new System.Windows.Forms.TextBox();
            this.CTTransferBelowBtn = new Sulakore.Components.SKoreButton();
            this.CTChunkCountLbl = new Sulakore.Components.SKoreLabel();
            this.CTCountTxt = new System.Windows.Forms.NumericUpDown();
            this.CTRemoveBtn = new Sulakore.Components.SKoreButton();
            this.CTMoveDownBtn = new Sulakore.Components.SKoreButton();
            this.CTMoveUpBtn = new Sulakore.Components.SKoreButton();
            this.CTClearBtn = new Sulakore.Components.SKoreButton();
            this.CTAppendBooleanBtn = new Sulakore.Components.SKoreButton();
            this.CTAppendStringBtn = new Sulakore.Components.SKoreButton();
            this.CTAppendIntegerBtn = new Sulakore.Components.SKoreButton();
            this.CTHeaderTxt = new System.Windows.Forms.TextBox();
            this.CTValueLbl = new System.Windows.Forms.Label();
            this.CTValueTxt = new System.Windows.Forms.ComboBox();
            this.CTConstructerVw = new Sulakore.Components.SKoreConstructView();
            this.ICSTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchedulerTab = new System.Windows.Forms.TabPage();
            this.STAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.STIntervalLbl = new System.Windows.Forms.Label();
            this.STClearBtn = new Sulakore.Components.SKoreButton();
            this.STStopAllBtn = new Sulakore.Components.SKoreButton();
            this.STStartAllBtn = new Sulakore.Components.SKoreButton();
            this.STRemoveBtn = new Sulakore.Components.SKoreButton();
            this.STCreateBtn = new Sulakore.Components.SKoreButton();
            this.STIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.STDestinationLbl = new System.Windows.Forms.Label();
            this.STDestinationTxt = new System.Windows.Forms.ComboBox();
            this.STPacketLbl = new System.Windows.Forms.Label();
            this.STPacketTxt = new System.Windows.Forms.TextBox();
            this.STSchedulerVw = new Sulakore.Components.SKoreScheduleView();
            this.STPacketCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STIntervalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.PTPrimitiveTxt = new System.Windows.Forms.TextBox();
            this.PTInjectionMenu = new Sulakore.Components.SKoreInjectionMenu(this.components);
            this.FiltersTab = new System.Windows.Forms.TabPage();
            this.IFTypeLbl = new System.Windows.Forms.Label();
            this.IFTypeTxt = new System.Windows.Forms.ComboBox();
            this.IFActionLbl = new System.Windows.Forms.Label();
            this.IFActionTxt = new System.Windows.Forms.ComboBox();
            this.FTFiltersVw = new Sulakore.Components.SKoreListView();
            this.IFActionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFHeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFInvocationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITPacketTxt = new System.Windows.Forms.ComboBox();
            this.ToolboxTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TTIntInputLbl = new System.Windows.Forms.Label();
            this.TTUShortInputTxt = new System.Windows.Forms.NumericUpDown();
            this.TTIntInputTxt = new System.Windows.Forms.NumericUpDown();
            this.ToolboxTabs = new Sulakore.Components.SKoreTabControl();
            this.ProfileTab = new System.Windows.Forms.TabPage();
            this.TTUShortOutputTxt = new System.Windows.Forms.TextBox();
            this.TTIntOutputTxt = new System.Windows.Forms.TextBox();
            this.TTDecodeUShortBtn = new Sulakore.Components.SKoreButton();
            this.TTDecodeIntBtn = new Sulakore.Components.SKoreButton();
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
            this.TanjiStrip.SuspendLayout();
            this.ETExtensionMenu.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.ConnectionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoTProxyPortTxt)).BeginInit();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.ConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTCountTxt)).BeginInit();
            this.SchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STIntervalTxt)).BeginInit();
            this.PrimitiveTab.SuspendLayout();
            this.FiltersTab.SuspendLayout();
            this.ToolboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).BeginInit();
            this.ToolboxTabs.SuspendLayout();
            this.ExtensionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanjiVersionTxt,
            this.SchedulesActiveTxt,
            this.ExtensionsActiveTxt,
            this.TanjiInfoTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(484, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 5;
            this.TanjiStrip.Text = "statusStrip1";
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
            // SchedulesActiveTxt
            // 
            this.SchedulesActiveTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.SchedulesActiveTxt.Name = "SchedulesActiveTxt";
            this.SchedulesActiveTxt.Size = new System.Drawing.Size(123, 19);
            this.SchedulesActiveTxt.Text = "Schedules Active: 0/0";
            // 
            // ExtensionsActiveTxt
            // 
            this.ExtensionsActiveTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ExtensionsActiveTxt.Name = "ExtensionsActiveTxt";
            this.ExtensionsActiveTxt.Size = new System.Drawing.Size(125, 19);
            this.ExtensionsActiveTxt.Text = "Extensions Active: 0/0";
            // 
            // TanjiInfoTxt
            // 
            this.TanjiInfoTxt.IsLink = true;
            this.TanjiInfoTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiInfoTxt.Name = "TanjiInfoTxt";
            this.TanjiInfoTxt.Size = new System.Drawing.Size(171, 19);
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
            this.ConnectionTab.Controls.Add(this.CoTVariablesVw);
            this.ConnectionTab.Controls.Add(this.CoTProxyPortTxt);
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
            this.CoTBrowseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CoTProxyPortLbl.Location = new System.Drawing.Point(0, 229);
            this.CoTProxyPortLbl.Name = "CoTProxyPortLbl";
            this.CoTProxyPortLbl.Size = new System.Drawing.Size(58, 13);
            this.CoTProxyPortLbl.TabIndex = 91;
            this.CoTProxyPortLbl.Text = "Proxy Port:";
            // 
            // CoTExportRootCertificateBtn
            // 
            this.CoTExportRootCertificateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTExportRootCertificateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CoTExportRootCertificateBtn.Location = new System.Drawing.Point(313, 225);
            this.CoTExportRootCertificateBtn.Name = "CoTExportRootCertificateBtn";
            this.CoTExportRootCertificateBtn.Size = new System.Drawing.Size(160, 22);
            this.CoTExportRootCertificateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CoTExportRootCertificateBtn.TabIndex = 3;
            this.CoTExportRootCertificateBtn.Text = "Export Root Certificate";
            // 
            // CoTDestroyCertificatesBtn
            // 
            this.CoTDestroyCertificatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoTDestroyCertificatesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CoTDestroyCertificatesBtn.Location = new System.Drawing.Point(153, 225);
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
            this.CoTClearVariableBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CoTUpdateVariableBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CoTConnectBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CoTCustomClientTxt.Text = "\r\n";
            // 
            // CoTNameTxt
            // 
            this.CoTNameTxt.Location = new System.Drawing.Point(3, 153);
            this.CoTNameTxt.Name = "CoTNameTxt";
            this.CoTNameTxt.ReadOnly = true;
            this.CoTNameTxt.Size = new System.Drawing.Size(312, 20);
            this.CoTNameTxt.TabIndex = 98;
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
            // CoTProxyPortTxt
            // 
            this.CoTProxyPortTxt.Location = new System.Drawing.Point(58, 227);
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
            this.ITSendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.ITSendToServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.ConstructerTab.Controls.Add(this.CTHeaderLbl);
            this.ConstructerTab.Controls.Add(this.CTCountLbl);
            this.ConstructerTab.Controls.Add(this.CTPacketTxt);
            this.ConstructerTab.Controls.Add(this.CTTransferBelowBtn);
            this.ConstructerTab.Controls.Add(this.CTChunkCountLbl);
            this.ConstructerTab.Controls.Add(this.CTCountTxt);
            this.ConstructerTab.Controls.Add(this.CTRemoveBtn);
            this.ConstructerTab.Controls.Add(this.CTMoveDownBtn);
            this.ConstructerTab.Controls.Add(this.CTMoveUpBtn);
            this.ConstructerTab.Controls.Add(this.CTClearBtn);
            this.ConstructerTab.Controls.Add(this.CTAppendBooleanBtn);
            this.ConstructerTab.Controls.Add(this.CTAppendStringBtn);
            this.ConstructerTab.Controls.Add(this.CTAppendIntegerBtn);
            this.ConstructerTab.Controls.Add(this.CTHeaderTxt);
            this.ConstructerTab.Controls.Add(this.CTValueLbl);
            this.ConstructerTab.Controls.Add(this.CTValueTxt);
            this.ConstructerTab.Controls.Add(this.CTConstructerVw);
            this.ConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.ConstructerTab.Name = "ConstructerTab";
            this.ConstructerTab.Size = new System.Drawing.Size(397, 271);
            this.ConstructerTab.TabIndex = 2;
            this.ConstructerTab.Text = "Constructer";
            this.ConstructerTab.UseVisualStyleBackColor = true;
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
            // CTCountLbl
            // 
            this.CTCountLbl.AutoSize = true;
            this.CTCountLbl.Location = new System.Drawing.Point(331, 0);
            this.CTCountLbl.Name = "CTCountLbl";
            this.CTCountLbl.Size = new System.Drawing.Size(35, 13);
            this.CTCountLbl.TabIndex = 39;
            this.CTCountLbl.Text = "Count";
            // 
            // CTPacketTxt
            // 
            this.CTPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CTPacketTxt.Location = new System.Drawing.Point(115, 220);
            this.CTPacketTxt.Name = "CTPacketTxt";
            this.CTPacketTxt.ReadOnly = true;
            this.CTPacketTxt.Size = new System.Drawing.Size(279, 20);
            this.CTPacketTxt.TabIndex = 48;
            // 
            // CTTransferBelowBtn
            // 
            this.CTTransferBelowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTTransferBelowBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTTransferBelowBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            // CTCountTxt
            // 
            this.CTCountTxt.Location = new System.Drawing.Point(334, 16);
            this.CTCountTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CTCountTxt.Name = "CTCountTxt";
            this.CTCountTxt.Size = new System.Drawing.Size(60, 20);
            this.CTCountTxt.TabIndex = 40;
            this.CTCountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CTCountTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CTRemoveBtn
            // 
            this.CTRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CTMoveDownBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CTMoveUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.CTClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTClearBtn.Location = new System.Drawing.Point(3, 42);
            this.CTClearBtn.Name = "CTClearBtn";
            this.CTClearBtn.Size = new System.Drawing.Size(79, 22);
            this.CTClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTClearBtn.TabIndex = 35;
            this.CTClearBtn.Text = "Clear";
            // 
            // CTAppendBooleanBtn
            // 
            this.CTAppendBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTAppendBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTAppendBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTAppendBooleanBtn.Location = new System.Drawing.Point(296, 42);
            this.CTAppendBooleanBtn.Name = "CTAppendBooleanBtn";
            this.CTAppendBooleanBtn.Size = new System.Drawing.Size(98, 22);
            this.CTAppendBooleanBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTAppendBooleanBtn.TabIndex = 34;
            this.CTAppendBooleanBtn.Text = "Append Boolean";
            // 
            // CTAppendStringBtn
            // 
            this.CTAppendStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTAppendStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTAppendStringBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTAppendStringBtn.Location = new System.Drawing.Point(192, 42);
            this.CTAppendStringBtn.Name = "CTAppendStringBtn";
            this.CTAppendStringBtn.Size = new System.Drawing.Size(98, 22);
            this.CTAppendStringBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTAppendStringBtn.TabIndex = 33;
            this.CTAppendStringBtn.Text = "Append String";
            // 
            // CTAppendIntegerBtn
            // 
            this.CTAppendIntegerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTAppendIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTAppendIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTAppendIntegerBtn.Location = new System.Drawing.Point(88, 42);
            this.CTAppendIntegerBtn.Name = "CTAppendIntegerBtn";
            this.CTAppendIntegerBtn.Size = new System.Drawing.Size(98, 22);
            this.CTAppendIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTAppendIntegerBtn.TabIndex = 32;
            this.CTAppendIntegerBtn.Text = "Append Integer";
            // 
            // CTHeaderTxt
            // 
            this.CTHeaderTxt.Location = new System.Drawing.Point(3, 16);
            this.CTHeaderTxt.MaxLength = 4;
            this.CTHeaderTxt.Name = "CTHeaderTxt";
            this.CTHeaderTxt.Size = new System.Drawing.Size(79, 20);
            this.CTHeaderTxt.TabIndex = 30;
            this.CTHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.CTConstructerVw.Header = ((ushort)(0));
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
            // SchedulerTab
            // 
            this.SchedulerTab.Controls.Add(this.STAutoStartChckbx);
            this.SchedulerTab.Controls.Add(this.STIntervalLbl);
            this.SchedulerTab.Controls.Add(this.STClearBtn);
            this.SchedulerTab.Controls.Add(this.STStopAllBtn);
            this.SchedulerTab.Controls.Add(this.STStartAllBtn);
            this.SchedulerTab.Controls.Add(this.STRemoveBtn);
            this.SchedulerTab.Controls.Add(this.STCreateBtn);
            this.SchedulerTab.Controls.Add(this.STIntervalTxt);
            this.SchedulerTab.Controls.Add(this.STDestinationLbl);
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
            // STAutoStartChckbx
            // 
            this.STAutoStartChckbx.AutoSize = true;
            this.STAutoStartChckbx.Checked = true;
            this.STAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.STAutoStartChckbx.Location = new System.Drawing.Point(168, 202);
            this.STAutoStartChckbx.Name = "STAutoStartChckbx";
            this.STAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.STAutoStartChckbx.TabIndex = 53;
            this.STAutoStartChckbx.Text = "Auto Start";
            this.STAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // STIntervalLbl
            // 
            this.STIntervalLbl.AutoSize = true;
            this.STIntervalLbl.Location = new System.Drawing.Point(316, 204);
            this.STIntervalLbl.Name = "STIntervalLbl";
            this.STIntervalLbl.Size = new System.Drawing.Size(64, 13);
            this.STIntervalLbl.TabIndex = 50;
            this.STIntervalLbl.Text = "Interval (ms)";
            // 
            // STClearBtn
            // 
            this.STClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.STClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STClearBtn.Enabled = false;
            this.STClearBtn.Location = new System.Drawing.Point(161, 246);
            this.STClearBtn.Name = "STClearBtn";
            this.STClearBtn.Size = new System.Drawing.Size(73, 22);
            this.STClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STClearBtn.TabIndex = 58;
            this.STClearBtn.Text = "Clear";
            // 
            // STStopAllBtn
            // 
            this.STStopAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.STStopAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STStopAllBtn.Enabled = false;
            this.STStopAllBtn.Location = new System.Drawing.Point(82, 246);
            this.STStopAllBtn.Name = "STStopAllBtn";
            this.STStopAllBtn.Size = new System.Drawing.Size(73, 22);
            this.STStopAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STStopAllBtn.TabIndex = 56;
            this.STStopAllBtn.Text = "Stop All";
            // 
            // STStartAllBtn
            // 
            this.STStartAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.STStartAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STStartAllBtn.Enabled = false;
            this.STStartAllBtn.Location = new System.Drawing.Point(3, 246);
            this.STStartAllBtn.Name = "STStartAllBtn";
            this.STStartAllBtn.Size = new System.Drawing.Size(73, 22);
            this.STStartAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STStartAllBtn.TabIndex = 57;
            this.STStartAllBtn.Text = "Start All";
            // 
            // STRemoveBtn
            // 
            this.STRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.STRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STRemoveBtn.Enabled = false;
            this.STRemoveBtn.Location = new System.Drawing.Point(240, 246);
            this.STRemoveBtn.Name = "STRemoveBtn";
            this.STRemoveBtn.Size = new System.Drawing.Size(73, 22);
            this.STRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STRemoveBtn.TabIndex = 55;
            this.STRemoveBtn.Text = "Remove";
            // 
            // STCreateBtn
            // 
            this.STCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.STCreateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STCreateBtn.Location = new System.Drawing.Point(319, 246);
            this.STCreateBtn.Name = "STCreateBtn";
            this.STCreateBtn.Size = new System.Drawing.Size(75, 22);
            this.STCreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STCreateBtn.TabIndex = 54;
            this.STCreateBtn.Text = "Create";
            // 
            // STIntervalTxt
            // 
            this.STIntervalTxt.Location = new System.Drawing.Point(319, 220);
            this.STIntervalTxt.Maximum = new decimal(new int[] {
            -1,
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
            // STDestinationLbl
            // 
            this.STDestinationLbl.AutoSize = true;
            this.STDestinationLbl.Location = new System.Drawing.Point(237, 203);
            this.STDestinationLbl.Name = "STDestinationLbl";
            this.STDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.STDestinationLbl.TabIndex = 48;
            this.STDestinationLbl.Text = "Destination";
            // 
            // STDestinationTxt
            // 
            this.STDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STDestinationTxt.FormattingEnabled = true;
            this.STDestinationTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.STDestinationTxt.Location = new System.Drawing.Point(240, 219);
            this.STDestinationTxt.Name = "STDestinationTxt";
            this.STDestinationTxt.Size = new System.Drawing.Size(73, 21);
            this.STDestinationTxt.TabIndex = 47;
            // 
            // STPacketLbl
            // 
            this.STPacketLbl.AutoSize = true;
            this.STPacketLbl.Location = new System.Drawing.Point(1, 203);
            this.STPacketLbl.Name = "STPacketLbl";
            this.STPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.STPacketLbl.TabIndex = 46;
            this.STPacketLbl.Text = "Packet";
            // 
            // STPacketTxt
            // 
            this.STPacketTxt.Location = new System.Drawing.Point(3, 219);
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
            this.STStatusCol});
            this.STSchedulerVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.STSchedulerVw.FullRowSelect = true;
            this.STSchedulerVw.GridLines = true;
            this.STSchedulerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.STSchedulerVw.HideSelection = false;
            this.STSchedulerVw.Location = new System.Drawing.Point(3, 3);
            this.STSchedulerVw.MultiSelect = false;
            this.STSchedulerVw.Name = "STSchedulerVw";
            this.STSchedulerVw.ShowItemToolTips = true;
            this.STSchedulerVw.Size = new System.Drawing.Size(391, 193);
            this.STSchedulerVw.TabIndex = 0;
            this.STSchedulerVw.UseCompatibleStateImageBehavior = false;
            this.STSchedulerVw.View = System.Windows.Forms.View.Details;
            // 
            // STPacketCol
            // 
            this.STPacketCol.Text = "Packet";
            this.STPacketCol.Width = 198;
            // 
            // STDestinationCol
            // 
            this.STDestinationCol.Text = "Destination";
            this.STDestinationCol.Width = 65;
            // 
            // STIntervalCol
            // 
            this.STIntervalCol.Text = "Interval";
            this.STIntervalCol.Width = 48;
            // 
            // STStatusCol
            // 
            this.STStatusCol.Text = "Status";
            this.STStatusCol.Width = 59;
            // 
            // PrimitiveTab
            // 
            this.PrimitiveTab.Controls.Add(this.PTPrimitiveTxt);
            this.PrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.PrimitiveTab.Name = "PrimitiveTab";
            this.PrimitiveTab.Size = new System.Drawing.Size(397, 271);
            this.PrimitiveTab.TabIndex = 1;
            this.PrimitiveTab.Text = "Primitive";
            this.PrimitiveTab.UseVisualStyleBackColor = true;
            // 
            // PTPrimitiveTxt
            // 
            this.PTPrimitiveTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PTPrimitiveTxt.ContextMenuStrip = this.PTInjectionMenu;
            this.PTPrimitiveTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PTPrimitiveTxt.Location = new System.Drawing.Point(0, 0);
            this.PTPrimitiveTxt.MaxLength = 2147483647;
            this.PTPrimitiveTxt.Multiline = true;
            this.PTPrimitiveTxt.Name = "PTPrimitiveTxt";
            this.PTPrimitiveTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PTPrimitiveTxt.Size = new System.Drawing.Size(397, 271);
            this.PTPrimitiveTxt.TabIndex = 3;
            // 
            // PTInjectionMenu
            // 
            this.PTInjectionMenu.InputBox = null;
            this.PTInjectionMenu.Name = "sKoreInjectionMenu1";
            this.PTInjectionMenu.Size = new System.Drawing.Size(174, 170);
            // 
            // FiltersTab
            // 
            this.FiltersTab.Controls.Add(this.IFTypeLbl);
            this.FiltersTab.Controls.Add(this.IFTypeTxt);
            this.FiltersTab.Controls.Add(this.IFActionLbl);
            this.FiltersTab.Controls.Add(this.IFActionTxt);
            this.FiltersTab.Controls.Add(this.FTFiltersVw);
            this.FiltersTab.Location = new System.Drawing.Point(4, 4);
            this.FiltersTab.Name = "FiltersTab";
            this.FiltersTab.Padding = new System.Windows.Forms.Padding(3);
            this.FiltersTab.Size = new System.Drawing.Size(397, 271);
            this.FiltersTab.TabIndex = 3;
            this.FiltersTab.Text = "Filters";
            this.FiltersTab.UseVisualStyleBackColor = true;
            // 
            // IFTypeLbl
            // 
            this.IFTypeLbl.AutoSize = true;
            this.IFTypeLbl.Location = new System.Drawing.Point(98, 177);
            this.IFTypeLbl.Name = "IFTypeLbl";
            this.IFTypeLbl.Size = new System.Drawing.Size(31, 13);
            this.IFTypeLbl.TabIndex = 4;
            this.IFTypeLbl.Text = "Type";
            // 
            // IFTypeTxt
            // 
            this.IFTypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFTypeTxt.FormattingEnabled = true;
            this.IFTypeTxt.Items.AddRange(new object[] {
            "Incoming",
            "Outgoing"});
            this.IFTypeTxt.Location = new System.Drawing.Point(101, 193);
            this.IFTypeTxt.Name = "IFTypeTxt";
            this.IFTypeTxt.Size = new System.Drawing.Size(89, 21);
            this.IFTypeTxt.TabIndex = 3;
            // 
            // IFActionLbl
            // 
            this.IFActionLbl.AutoSize = true;
            this.IFActionLbl.Location = new System.Drawing.Point(3, 177);
            this.IFActionLbl.Name = "IFActionLbl";
            this.IFActionLbl.Size = new System.Drawing.Size(37, 13);
            this.IFActionLbl.TabIndex = 2;
            this.IFActionLbl.Text = "Action";
            // 
            // IFActionTxt
            // 
            this.IFActionTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IFActionTxt.FormattingEnabled = true;
            this.IFActionTxt.Items.AddRange(new object[] {
            "Block",
            "Replace",
            "Execute"});
            this.IFActionTxt.Location = new System.Drawing.Point(6, 193);
            this.IFActionTxt.Name = "IFActionTxt";
            this.IFActionTxt.Size = new System.Drawing.Size(89, 21);
            this.IFActionTxt.TabIndex = 1;
            // 
            // FTFiltersVw
            // 
            this.FTFiltersVw.CheckBoxes = true;
            this.FTFiltersVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IFActionCol,
            this.IFTypeCol,
            this.IFHeaderCol,
            this.IFInvocationCol});
            this.FTFiltersVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.FTFiltersVw.FullRowSelect = true;
            this.FTFiltersVw.GridLines = true;
            this.FTFiltersVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FTFiltersVw.HideSelection = false;
            this.FTFiltersVw.Location = new System.Drawing.Point(3, 3);
            this.FTFiltersVw.MultiSelect = false;
            this.FTFiltersVw.Name = "FTFiltersVw";
            this.FTFiltersVw.ShowItemToolTips = true;
            this.FTFiltersVw.Size = new System.Drawing.Size(391, 171);
            this.FTFiltersVw.TabIndex = 0;
            this.FTFiltersVw.UseCompatibleStateImageBehavior = false;
            this.FTFiltersVw.View = System.Windows.Forms.View.Details;
            // 
            // IFActionCol
            // 
            this.IFActionCol.Text = "Action";
            this.IFActionCol.Width = 68;
            // 
            // IFTypeCol
            // 
            this.IFTypeCol.Text = "Type";
            this.IFTypeCol.Width = 68;
            // 
            // IFHeaderCol
            // 
            this.IFHeaderCol.Text = "Header";
            this.IFHeaderCol.Width = 55;
            // 
            // IFInvocationCol
            // 
            this.IFInvocationCol.Text = "Invocation";
            this.IFInvocationCol.Width = 176;
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
            this.ToolboxTab.Controls.Add(this.label1);
            this.ToolboxTab.Controls.Add(this.TTIntInputLbl);
            this.ToolboxTab.Controls.Add(this.TTUShortInputTxt);
            this.ToolboxTab.Controls.Add(this.TTIntInputTxt);
            this.ToolboxTab.Controls.Add(this.ToolboxTabs);
            this.ToolboxTab.Controls.Add(this.TTUShortOutputTxt);
            this.ToolboxTab.Controls.Add(this.TTIntOutputTxt);
            this.ToolboxTab.Controls.Add(this.TTDecodeUShortBtn);
            this.ToolboxTab.Controls.Add(this.TTDecodeIntBtn);
            this.ToolboxTab.Location = new System.Drawing.Point(4, 28);
            this.ToolboxTab.Name = "ToolboxTab";
            this.ToolboxTab.Size = new System.Drawing.Size(476, 313);
            this.ToolboxTab.TabIndex = 3;
            this.ToolboxTab.Text = "Toolbox";
            this.ToolboxTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "UShort(UInt16) Input:";
            // 
            // TTIntInputLbl
            // 
            this.TTIntInputLbl.AutoSize = true;
            this.TTIntInputLbl.Location = new System.Drawing.Point(8, 263);
            this.TTIntInputLbl.Name = "TTIntInputLbl";
            this.TTIntInputLbl.Size = new System.Drawing.Size(100, 13);
            this.TTIntInputLbl.TabIndex = 0;
            this.TTIntInputLbl.Text = "Integer(Int32) Input:";
            // 
            // TTUShortInputTxt
            // 
            this.TTUShortInputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TTUShortInputTxt.Location = new System.Drawing.Point(111, 288);
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
            // TTIntInputTxt
            // 
            this.TTIntInputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TTIntInputTxt.Location = new System.Drawing.Point(111, 260);
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
            // TTUShortOutputTxt
            // 
            this.TTUShortOutputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTUShortOutputTxt.Location = new System.Drawing.Point(243, 288);
            this.TTUShortOutputTxt.Name = "TTUShortOutputTxt";
            this.TTUShortOutputTxt.Size = new System.Drawing.Size(126, 22);
            this.TTUShortOutputTxt.TabIndex = 38;
            this.TTUShortOutputTxt.Text = "[0][0]";
            this.TTUShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTIntOutputTxt
            // 
            this.TTIntOutputTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.TTIntOutputTxt.Location = new System.Drawing.Point(243, 260);
            this.TTIntOutputTxt.Name = "TTIntOutputTxt";
            this.TTIntOutputTxt.Size = new System.Drawing.Size(126, 22);
            this.TTIntOutputTxt.TabIndex = 37;
            this.TTIntOutputTxt.Text = "[0][0][0][0]";
            this.TTIntOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TTDecodeUShortBtn
            // 
            this.TTDecodeUShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.TTDecodeUShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TTDecodeUShortBtn.Location = new System.Drawing.Point(375, 288);
            this.TTDecodeUShortBtn.Name = "TTDecodeUShortBtn";
            this.TTDecodeUShortBtn.Size = new System.Drawing.Size(98, 22);
            this.TTDecodeUShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TTDecodeUShortBtn.TabIndex = 35;
            this.TTDecodeUShortBtn.Text = "Decode UShort";
            // 
            // TTDecodeIntBtn
            // 
            this.TTDecodeIntBtn.BackColor = System.Drawing.Color.Transparent;
            this.TTDecodeIntBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TTDecodeIntBtn.Location = new System.Drawing.Point(375, 260);
            this.TTDecodeIntBtn.Name = "TTDecodeIntBtn";
            this.TTDecodeIntBtn.Size = new System.Drawing.Size(98, 22);
            this.TTDecodeIntBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TTDecodeIntBtn.TabIndex = 34;
            this.TTDecodeIntBtn.Text = "Decode Integer";
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
            this.ETUninstallExtensionBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.ETInstallExtensionBtn.DialogResult = System.Windows.Forms.DialogResult.None;
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
            this.Text = "Tanji ~ Status: Disconnected";
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
            ((System.ComponentModel.ISupportInitialize)(this.CTCountTxt)).EndInit();
            this.SchedulerTab.ResumeLayout(false);
            this.SchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STIntervalTxt)).EndInit();
            this.PrimitiveTab.ResumeLayout(false);
            this.PrimitiveTab.PerformLayout();
            this.FiltersTab.ResumeLayout(false);
            this.FiltersTab.PerformLayout();
            this.ToolboxTab.ResumeLayout(false);
            this.ToolboxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TTUShortInputTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTIntInputTxt)).EndInit();
            this.ToolboxTabs.ResumeLayout(false);
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
        private System.Windows.Forms.Label CTCountLbl;
        private System.Windows.Forms.ColumnHeader ICSTypeCol;
        private System.Windows.Forms.ColumnHeader ICSValueCol;
        private System.Windows.Forms.ColumnHeader ICSEncodedCol;
        private System.Windows.Forms.Label CTValueLbl;
        private System.Windows.Forms.ColumnHeader STPacketCol;
        private System.Windows.Forms.ColumnHeader STDestinationCol;
        private System.Windows.Forms.ColumnHeader STIntervalCol;
        private System.Windows.Forms.ColumnHeader STStatusCol;
        private Sulakore.Components.SKoreTabControl TanjiTabs;
        private System.Windows.Forms.ColumnHeader IFActionCol;
        private System.Windows.Forms.ColumnHeader IFHeaderCol;
        private System.Windows.Forms.ColumnHeader IFInvocationCol;
        private System.Windows.Forms.ColumnHeader IFTypeCol;
        private System.Windows.Forms.Label IFTypeLbl;
        private System.Windows.Forms.Label IFActionLbl;
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
        internal System.Windows.Forms.TextBox CTPacketTxt;
        internal Sulakore.Components.SKoreButton CTTransferBelowBtn;
        internal Sulakore.Components.SKoreLabel CTChunkCountLbl;
        internal Sulakore.Components.SKoreConstructView CTConstructerVw;
        internal System.Windows.Forms.NumericUpDown CTCountTxt;
        internal Sulakore.Components.SKoreButton CTRemoveBtn;
        internal Sulakore.Components.SKoreButton CTMoveDownBtn;
        internal Sulakore.Components.SKoreButton CTMoveUpBtn;
        internal Sulakore.Components.SKoreButton CTClearBtn;
        internal Sulakore.Components.SKoreButton CTAppendBooleanBtn;
        internal Sulakore.Components.SKoreButton CTAppendStringBtn;
        internal Sulakore.Components.SKoreButton CTAppendIntegerBtn;
        internal System.Windows.Forms.TextBox CTHeaderTxt;
        internal Sulakore.Components.SKoreButton STClearBtn;
        internal Sulakore.Components.SKoreButton STStopAllBtn;
        internal Sulakore.Components.SKoreButton STStartAllBtn;
        internal Sulakore.Components.SKoreButton STRemoveBtn;
        internal Sulakore.Components.SKoreButton STCreateBtn;
        internal System.Windows.Forms.NumericUpDown STIntervalTxt;
        internal System.Windows.Forms.ComboBox STDestinationTxt;
        internal System.Windows.Forms.TextBox STPacketTxt;
        internal System.Windows.Forms.CheckBox STAutoStartChckbx;
        internal Sulakore.Components.SKoreScheduleView STSchedulerVw;
        internal System.Windows.Forms.TextBox PTPrimitiveTxt;
        internal System.Windows.Forms.ComboBox ITPacketTxt;
        internal System.Windows.Forms.ComboBox IFActionTxt;
        internal Sulakore.Components.SKoreListView FTFiltersVw;
        internal System.Windows.Forms.ComboBox IFTypeTxt;
        internal Sulakore.Components.SKoreButton CoTConnectBtn;
        internal Sulakore.Components.SKoreLabel CoTStatusTxt;
        internal System.Windows.Forms.ContextMenuStrip ETExtensionMenu;
        internal System.Windows.Forms.ToolStripMenuItem ETOpenMenuBtn;
        internal System.Windows.Forms.ToolStripMenuItem ETUninstallMenuBtn;
        internal System.Windows.Forms.ToolStripMenuItem ETInstallMenuBtn;
        internal Sulakore.Components.SKoreTabControl InjectionTabs;
        internal System.Windows.Forms.TabPage PrimitiveTab;
        internal System.Windows.Forms.ToolStripStatusLabel ExtensionsActiveTxt;
        internal System.Windows.Forms.ToolStripStatusLabel SchedulesActiveTxt;
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
        public Sulakore.Components.SKoreInjectionMenu PTInjectionMenu;
        internal System.Windows.Forms.TabPage FiltersTab;
        internal System.Windows.Forms.TabPage SchedulerTab;
        internal System.Windows.Forms.TabPage ConstructerTab;
        internal System.Windows.Forms.NumericUpDown TTUShortInputTxt;
        internal System.Windows.Forms.NumericUpDown TTIntInputTxt;
        private System.Windows.Forms.Label TTIntInputLbl;
        private System.Windows.Forms.Label label1;
    }
}