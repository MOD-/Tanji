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
            this.PTPrimitiveContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PTInsertFormatParameterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTIntegerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTStringBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTBooleanBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTLengthHeaderBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTMenuSeparatorTop = new System.Windows.Forms.ToolStripSeparator();
            this.PTCutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTCopyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTPasteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTMenuSeperatorBottom = new System.Windows.Forms.ToolStripSeparator();
            this.PTUndoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTSelectAllBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETExtensionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ETOpenMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETUninstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETTopMenuSplitter = new System.Windows.Forms.ToolStripSeparator();
            this.ETInstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETMiddleMenuSplitter = new System.Windows.Forms.ToolStripSeparator();
            this.ETGrabMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.ITSendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ITSendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.ConstructerTab = new System.Windows.Forms.TabPage();
            this.CTHeaderLbl = new System.Windows.Forms.Label();
            this.CTValueTxt = new System.Windows.Forms.ComboBox();
            this.CTCountLbl = new System.Windows.Forms.Label();
            this.CTPacketTxt = new System.Windows.Forms.TextBox();
            this.CTTransferBelowBtn = new Sulakore.Components.SKoreButton();
            this.CTChunkCountLbl = new Sulakore.Components.SKoreLabel();
            this.CTConstructerVw = new Sulakore.Components.SKoreConstructView();
            this.ICSTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.CTLiveEditingChckbx = new System.Windows.Forms.CheckBox();
            this.SchedulerTab = new System.Windows.Forms.TabPage();
            this.STIntervalLbl = new System.Windows.Forms.Label();
            this.STClearBtn = new Sulakore.Components.SKoreButton();
            this.STStopAllBtn = new Sulakore.Components.SKoreButton();
            this.STStartAllBtn = new Sulakore.Components.SKoreButton();
            this.STRemoveBtn = new Sulakore.Components.SKoreButton();
            this.STCreateBtn = new Sulakore.Components.SKoreButton();
            this.STBurstLbl = new System.Windows.Forms.Label();
            this.STBurstTxt = new System.Windows.Forms.NumericUpDown();
            this.STIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.STDestinationLbl = new System.Windows.Forms.Label();
            this.STDestinationTxt = new System.Windows.Forms.ComboBox();
            this.STPacketLbl = new System.Windows.Forms.Label();
            this.STPacketTxt = new System.Windows.Forms.TextBox();
            this.STDescriptionLbl = new System.Windows.Forms.Label();
            this.STDescriptionTxt = new System.Windows.Forms.TextBox();
            this.STAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.STSchedulerVw = new Sulakore.Components.SKoreScheduleView();
            this.STPacketCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STBurstCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STIntervalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.PTIsCorruptedLbl = new System.Windows.Forms.Label();
            this.PTPacketInfoLbl = new System.Windows.Forms.Label();
            this.PTPacketTxt = new System.Windows.Forms.TextBox();
            this.FiltersTab = new System.Windows.Forms.TabPage();
            this.IFActionLbl = new System.Windows.Forms.Label();
            this.IFActionTxt = new System.Windows.Forms.ComboBox();
            this.FTFiltersVw = new Sulakore.Components.SKoreListView();
            this.IFActionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFHeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFInvocationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ITPacketTxt = new System.Windows.Forms.ComboBox();
            this.EncoderDecoderTab = new System.Windows.Forms.TabPage();
            this.EDTIntegerInputTxt = new System.Windows.Forms.NumericUpDown();
            this.EDTShortInputTxt = new System.Windows.Forms.NumericUpDown();
            this.EDTDecodeValuesBtn = new Sulakore.Components.SKoreButton();
            this.EDTEncodedValuesLbl = new System.Windows.Forms.Label();
            this.EDTEncodedValuesTxt = new System.Windows.Forms.TextBox();
            this.EDTShortOutputTxt = new System.Windows.Forms.TextBox();
            this.EDTIntegerOutputTxt = new System.Windows.Forms.TextBox();
            this.EDTEncodeShortBtn = new Sulakore.Components.SKoreButton();
            this.EDTEncodeIntegerBtn = new Sulakore.Components.SKoreButton();
            this.EDTDecodeShortBtn = new Sulakore.Components.SKoreButton();
            this.EDTDecodeIntegerBtn = new Sulakore.Components.SKoreButton();
            this.EDTTopGlowPnl = new System.Windows.Forms.Panel();
            this.EDTDecodedVw = new Sulakore.Components.SKoreListView();
            this.EDTValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EDTEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EDTPositionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.ETExtensionAOTChckbx = new System.Windows.Forms.CheckBox();
            this.ETUninstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.ETContractorVw = new Sulakore.Components.SKoreExtensionView();
            this.ETIdentifierCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETCreatorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETInstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.IFTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IFTypeLbl = new System.Windows.Forms.Label();
            this.IFTypeTxt = new System.Windows.Forms.ComboBox();
            this.TanjiStrip.SuspendLayout();
            this.PTPrimitiveContextMenu.SuspendLayout();
            this.ETExtensionMenu.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.ConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTCountTxt)).BeginInit();
            this.SchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STIntervalTxt)).BeginInit();
            this.PrimitiveTab.SuspendLayout();
            this.FiltersTab.SuspendLayout();
            this.EncoderDecoderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDTIntegerInputTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EDTShortInputTxt)).BeginInit();
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
            this.TanjiStrip.Size = new System.Drawing.Size(481, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 5;
            this.TanjiStrip.Text = "statusStrip1";
            // 
            // TanjiVersionTxt
            // 
            this.TanjiVersionTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TanjiVersionTxt.IsLink = true;
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
            this.TanjiInfoTxt.Size = new System.Drawing.Size(168, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "GitHub | ArachisH/Tanji";
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // PTPrimitiveContextMenu
            // 
            this.PTPrimitiveContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PTInsertFormatParameterBtn,
            this.PTMenuSeparatorTop,
            this.PTCutBtn,
            this.PTCopyBtn,
            this.PTPasteBtn,
            this.PTMenuSeperatorBottom,
            this.PTUndoBtn,
            this.PTSelectAllBtn});
            this.PTPrimitiveContextMenu.Name = "ConstructMenu";
            this.PTPrimitiveContextMenu.Size = new System.Drawing.Size(204, 148);
            // 
            // PTInsertFormatParameterBtn
            // 
            this.PTInsertFormatParameterBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PTIntegerBtn,
            this.PTStringBtn,
            this.PTBooleanBtn,
            this.PTLengthHeaderBtn});
            this.PTInsertFormatParameterBtn.Name = "PTInsertFormatParameterBtn";
            this.PTInsertFormatParameterBtn.Size = new System.Drawing.Size(203, 22);
            this.PTInsertFormatParameterBtn.Text = "Insert/Format Parameter";
            // 
            // PTIntegerBtn
            // 
            this.PTIntegerBtn.Name = "PTIntegerBtn";
            this.PTIntegerBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.PTIntegerBtn.Size = new System.Drawing.Size(197, 22);
            this.PTIntegerBtn.Text = "Integer";
            // 
            // PTStringBtn
            // 
            this.PTStringBtn.Name = "PTStringBtn";
            this.PTStringBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.PTStringBtn.Size = new System.Drawing.Size(197, 22);
            this.PTStringBtn.Text = "String";
            // 
            // PTBooleanBtn
            // 
            this.PTBooleanBtn.Name = "PTBooleanBtn";
            this.PTBooleanBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.PTBooleanBtn.Size = new System.Drawing.Size(197, 22);
            this.PTBooleanBtn.Text = "Boolean";
            // 
            // PTLengthHeaderBtn
            // 
            this.PTLengthHeaderBtn.Name = "PTLengthHeaderBtn";
            this.PTLengthHeaderBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.PTLengthHeaderBtn.Size = new System.Drawing.Size(197, 22);
            this.PTLengthHeaderBtn.Text = "Length/Header";
            // 
            // PTMenuSeparatorTop
            // 
            this.PTMenuSeparatorTop.Name = "PTMenuSeparatorTop";
            this.PTMenuSeparatorTop.Size = new System.Drawing.Size(200, 6);
            // 
            // PTCutBtn
            // 
            this.PTCutBtn.Name = "PTCutBtn";
            this.PTCutBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.PTCutBtn.Size = new System.Drawing.Size(203, 22);
            this.PTCutBtn.Text = "Cut";
            // 
            // PTCopyBtn
            // 
            this.PTCopyBtn.Name = "PTCopyBtn";
            this.PTCopyBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.PTCopyBtn.Size = new System.Drawing.Size(203, 22);
            this.PTCopyBtn.Text = "Copy";
            // 
            // PTPasteBtn
            // 
            this.PTPasteBtn.Name = "PTPasteBtn";
            this.PTPasteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PTPasteBtn.Size = new System.Drawing.Size(203, 22);
            this.PTPasteBtn.Text = "Paste";
            // 
            // PTMenuSeperatorBottom
            // 
            this.PTMenuSeperatorBottom.Name = "PTMenuSeperatorBottom";
            this.PTMenuSeperatorBottom.Size = new System.Drawing.Size(200, 6);
            // 
            // PTUndoBtn
            // 
            this.PTUndoBtn.Name = "PTUndoBtn";
            this.PTUndoBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.PTUndoBtn.Size = new System.Drawing.Size(203, 22);
            this.PTUndoBtn.Text = "Undo";
            // 
            // PTSelectAllBtn
            // 
            this.PTSelectAllBtn.Name = "PTSelectAllBtn";
            this.PTSelectAllBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.PTSelectAllBtn.Size = new System.Drawing.Size(203, 22);
            this.PTSelectAllBtn.Text = "Select All";
            // 
            // ETExtensionMenu
            // 
            this.ETExtensionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ETOpenMenuBtn,
            this.ETUninstallMenuBtn,
            this.ETTopMenuSplitter,
            this.ETInstallMenuBtn,
            this.ETMiddleMenuSplitter,
            this.ETGrabMenuBtn});
            this.ETExtensionMenu.Name = "ConstructMenu";
            this.ETExtensionMenu.Size = new System.Drawing.Size(159, 104);
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
            // ETMiddleMenuSplitter
            // 
            this.ETMiddleMenuSplitter.Name = "ETMiddleMenuSplitter";
            this.ETMiddleMenuSplitter.Size = new System.Drawing.Size(155, 6);
            // 
            // ETGrabMenuBtn
            // 
            this.ETGrabMenuBtn.Name = "ETGrabMenuBtn";
            this.ETGrabMenuBtn.Size = new System.Drawing.Size(158, 22);
            this.ETGrabMenuBtn.Text = "Grab Extension";
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.EncoderDecoderTab);
            this.TanjiTabs.Controls.Add(this.ExtensionsTab);
            this.TanjiTabs.DisplayBoundary = true;
            this.TanjiTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanjiTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TanjiTabs.ItemSize = new System.Drawing.Size(159, 24);
            this.TanjiTabs.Location = new System.Drawing.Point(0, 0);
            this.TanjiTabs.Name = "TanjiTabs";
            this.TanjiTabs.SelectedIndex = 0;
            this.TanjiTabs.Size = new System.Drawing.Size(481, 345);
            this.TanjiTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TanjiTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiTabs.TabIndex = 6;
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
            this.InjectionTab.Size = new System.Drawing.Size(473, 313);
            this.InjectionTab.TabIndex = 2;
            this.InjectionTab.Text = "Injection";
            this.InjectionTab.UseVisualStyleBackColor = true;
            // 
            // ITSendToClientBtn
            // 
            this.ITSendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ITSendToClientBtn.Location = new System.Drawing.Point(261, 285);
            this.ITSendToClientBtn.Name = "ITSendToClientBtn";
            this.ITSendToClientBtn.Size = new System.Drawing.Size(100, 22);
            this.ITSendToClientBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ITSendToClientBtn.TabIndex = 7;
            this.ITSendToClientBtn.Text = "Send To Client";
            // 
            // ITSendToServerBtn
            // 
            this.ITSendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ITSendToServerBtn.Location = new System.Drawing.Point(367, 285);
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
            this.InjectionTabs.Size = new System.Drawing.Size(467, 276);
            this.InjectionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.InjectionTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InjectionTabs.TabIndex = 0;
            // 
            // ConstructerTab
            // 
            this.ConstructerTab.Controls.Add(this.CTHeaderLbl);
            this.ConstructerTab.Controls.Add(this.CTValueTxt);
            this.ConstructerTab.Controls.Add(this.CTCountLbl);
            this.ConstructerTab.Controls.Add(this.CTPacketTxt);
            this.ConstructerTab.Controls.Add(this.CTTransferBelowBtn);
            this.ConstructerTab.Controls.Add(this.CTChunkCountLbl);
            this.ConstructerTab.Controls.Add(this.CTConstructerVw);
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
            this.ConstructerTab.Controls.Add(this.CTLiveEditingChckbx);
            this.ConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.ConstructerTab.Name = "ConstructerTab";
            this.ConstructerTab.Size = new System.Drawing.Size(394, 268);
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
            // CTValueTxt
            // 
            this.CTValueTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CTValueTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CTValueTxt.IntegralHeight = false;
            this.CTValueTxt.ItemHeight = 13;
            this.CTValueTxt.Location = new System.Drawing.Point(85, 15);
            this.CTValueTxt.Name = "CTValueTxt";
            this.CTValueTxt.Size = new System.Drawing.Size(240, 21);
            this.CTValueTxt.TabIndex = 28;
            // 
            // CTCountLbl
            // 
            this.CTCountLbl.AutoSize = true;
            this.CTCountLbl.Location = new System.Drawing.Point(328, 0);
            this.CTCountLbl.Name = "CTCountLbl";
            this.CTCountLbl.Size = new System.Drawing.Size(35, 13);
            this.CTCountLbl.TabIndex = 39;
            this.CTCountLbl.Text = "Count";
            // 
            // CTPacketTxt
            // 
            this.CTPacketTxt.Location = new System.Drawing.Point(112, 217);
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
            this.CTTransferBelowBtn.Location = new System.Drawing.Point(3, 243);
            this.CTTransferBelowBtn.Name = "CTTransferBelowBtn";
            this.CTTransferBelowBtn.Size = new System.Drawing.Size(103, 22);
            this.CTTransferBelowBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTTransferBelowBtn.TabIndex = 46;
            this.CTTransferBelowBtn.Text = "Transfer Below";
            // 
            // CTChunkCountLbl
            // 
            this.CTChunkCountLbl.BorderWidth = 1;
            this.CTChunkCountLbl.DisplayBoundary = true;
            this.CTChunkCountLbl.Location = new System.Drawing.Point(3, 217);
            this.CTChunkCountLbl.Name = "CTChunkCountLbl";
            this.CTChunkCountLbl.Size = new System.Drawing.Size(103, 20);
            this.CTChunkCountLbl.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTChunkCountLbl.TabIndex = 45;
            this.CTChunkCountLbl.Text = "Chunk Count: 0";
            this.CTChunkCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CTConstructerVw
            // 
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
            this.CTConstructerVw.Size = new System.Drawing.Size(388, 141);
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
            this.ICSValueCol.Width = 137;
            // 
            // ICSEncodedCol
            // 
            this.ICSEncodedCol.Text = "Encoded";
            this.ICSEncodedCol.Width = 150;
            // 
            // CTCountTxt
            // 
            this.CTCountTxt.Location = new System.Drawing.Point(331, 16);
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
            this.CTRemoveBtn.Location = new System.Drawing.Point(112, 243);
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
            this.CTMoveDownBtn.Location = new System.Drawing.Point(302, 243);
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
            this.CTMoveUpBtn.Location = new System.Drawing.Point(207, 243);
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
            this.CTClearBtn.Size = new System.Drawing.Size(76, 22);
            this.CTClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTClearBtn.TabIndex = 35;
            this.CTClearBtn.Text = "Clear";
            // 
            // CTAppendBooleanBtn
            // 
            this.CTAppendBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTAppendBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTAppendBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTAppendBooleanBtn.Location = new System.Drawing.Point(293, 42);
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
            this.CTAppendStringBtn.Location = new System.Drawing.Point(189, 42);
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
            this.CTAppendIntegerBtn.Location = new System.Drawing.Point(85, 42);
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
            this.CTHeaderTxt.Size = new System.Drawing.Size(76, 20);
            this.CTHeaderTxt.TabIndex = 30;
            this.CTHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CTValueLbl
            // 
            this.CTValueLbl.AutoSize = true;
            this.CTValueLbl.Location = new System.Drawing.Point(82, 0);
            this.CTValueLbl.Name = "CTValueLbl";
            this.CTValueLbl.Size = new System.Drawing.Size(34, 13);
            this.CTValueLbl.TabIndex = 29;
            this.CTValueLbl.Text = "Value";
            // 
            // CTLiveEditingChckbx
            // 
            this.CTLiveEditingChckbx.AutoSize = true;
            this.CTLiveEditingChckbx.Enabled = false;
            this.CTLiveEditingChckbx.Location = new System.Drawing.Point(211, -1);
            this.CTLiveEditingChckbx.Name = "CTLiveEditingChckbx";
            this.CTLiveEditingChckbx.Size = new System.Drawing.Size(114, 17);
            this.CTLiveEditingChckbx.TabIndex = 47;
            this.CTLiveEditingChckbx.Text = "Update On {Enter}";
            this.CTLiveEditingChckbx.UseVisualStyleBackColor = true;
            // 
            // SchedulerTab
            // 
            this.SchedulerTab.Controls.Add(this.STIntervalLbl);
            this.SchedulerTab.Controls.Add(this.STClearBtn);
            this.SchedulerTab.Controls.Add(this.STStopAllBtn);
            this.SchedulerTab.Controls.Add(this.STStartAllBtn);
            this.SchedulerTab.Controls.Add(this.STRemoveBtn);
            this.SchedulerTab.Controls.Add(this.STCreateBtn);
            this.SchedulerTab.Controls.Add(this.STBurstLbl);
            this.SchedulerTab.Controls.Add(this.STBurstTxt);
            this.SchedulerTab.Controls.Add(this.STIntervalTxt);
            this.SchedulerTab.Controls.Add(this.STDestinationLbl);
            this.SchedulerTab.Controls.Add(this.STDestinationTxt);
            this.SchedulerTab.Controls.Add(this.STPacketLbl);
            this.SchedulerTab.Controls.Add(this.STPacketTxt);
            this.SchedulerTab.Controls.Add(this.STDescriptionLbl);
            this.SchedulerTab.Controls.Add(this.STDescriptionTxt);
            this.SchedulerTab.Controls.Add(this.STAutoStartChckbx);
            this.SchedulerTab.Controls.Add(this.STSchedulerVw);
            this.SchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.SchedulerTab.Name = "SchedulerTab";
            this.SchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulerTab.Size = new System.Drawing.Size(394, 268);
            this.SchedulerTab.TabIndex = 0;
            this.SchedulerTab.Text = "Scheduler";
            this.SchedulerTab.UseVisualStyleBackColor = true;
            // 
            // STIntervalLbl
            // 
            this.STIntervalLbl.AutoSize = true;
            this.STIntervalLbl.Location = new System.Drawing.Point(314, 162);
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
            this.STClearBtn.Location = new System.Drawing.Point(159, 243);
            this.STClearBtn.Name = "STClearBtn";
            this.STClearBtn.Size = new System.Drawing.Size(74, 22);
            this.STClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STClearBtn.TabIndex = 58;
            this.STClearBtn.Text = "Clear";
            // 
            // STStopAllBtn
            // 
            this.STStopAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.STStopAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STStopAllBtn.Enabled = false;
            this.STStopAllBtn.Location = new System.Drawing.Point(81, 243);
            this.STStopAllBtn.Name = "STStopAllBtn";
            this.STStopAllBtn.Size = new System.Drawing.Size(72, 22);
            this.STStopAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STStopAllBtn.TabIndex = 56;
            this.STStopAllBtn.Text = "Stop All";
            // 
            // STStartAllBtn
            // 
            this.STStartAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.STStartAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STStartAllBtn.Enabled = false;
            this.STStartAllBtn.Location = new System.Drawing.Point(3, 243);
            this.STStartAllBtn.Name = "STStartAllBtn";
            this.STStartAllBtn.Size = new System.Drawing.Size(72, 22);
            this.STStartAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STStartAllBtn.TabIndex = 57;
            this.STStartAllBtn.Text = "Start All";
            // 
            // STRemoveBtn
            // 
            this.STRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.STRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STRemoveBtn.Enabled = false;
            this.STRemoveBtn.Location = new System.Drawing.Point(239, 243);
            this.STRemoveBtn.Name = "STRemoveBtn";
            this.STRemoveBtn.Size = new System.Drawing.Size(72, 22);
            this.STRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STRemoveBtn.TabIndex = 55;
            this.STRemoveBtn.Text = "Remove";
            // 
            // STCreateBtn
            // 
            this.STCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.STCreateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.STCreateBtn.Location = new System.Drawing.Point(317, 243);
            this.STCreateBtn.Name = "STCreateBtn";
            this.STCreateBtn.Size = new System.Drawing.Size(72, 22);
            this.STCreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.STCreateBtn.TabIndex = 54;
            this.STCreateBtn.Text = "Create";
            // 
            // STBurstLbl
            // 
            this.STBurstLbl.AutoSize = true;
            this.STBurstLbl.Location = new System.Drawing.Point(314, 201);
            this.STBurstLbl.Name = "STBurstLbl";
            this.STBurstLbl.Size = new System.Drawing.Size(31, 13);
            this.STBurstLbl.TabIndex = 52;
            this.STBurstLbl.Text = "Burst";
            // 
            // STBurstTxt
            // 
            this.STBurstTxt.Location = new System.Drawing.Point(317, 217);
            this.STBurstTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.STBurstTxt.Name = "STBurstTxt";
            this.STBurstTxt.Size = new System.Drawing.Size(72, 20);
            this.STBurstTxt.TabIndex = 51;
            this.STBurstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STBurstTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // STIntervalTxt
            // 
            this.STIntervalTxt.Location = new System.Drawing.Point(317, 178);
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
            this.STIntervalTxt.Size = new System.Drawing.Size(72, 20);
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
            this.STDestinationLbl.Location = new System.Drawing.Point(236, 201);
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
            this.STDestinationTxt.Location = new System.Drawing.Point(239, 217);
            this.STDestinationTxt.Name = "STDestinationTxt";
            this.STDestinationTxt.Size = new System.Drawing.Size(72, 21);
            this.STDestinationTxt.TabIndex = 47;
            // 
            // STPacketLbl
            // 
            this.STPacketLbl.AutoSize = true;
            this.STPacketLbl.Location = new System.Drawing.Point(0, 162);
            this.STPacketLbl.Name = "STPacketLbl";
            this.STPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.STPacketLbl.TabIndex = 46;
            this.STPacketLbl.Text = "Packet";
            // 
            // STPacketTxt
            // 
            this.STPacketTxt.Location = new System.Drawing.Point(3, 178);
            this.STPacketTxt.MaxLength = 2147483647;
            this.STPacketTxt.Name = "STPacketTxt";
            this.STPacketTxt.Size = new System.Drawing.Size(308, 20);
            this.STPacketTxt.TabIndex = 45;
            // 
            // STDescriptionLbl
            // 
            this.STDescriptionLbl.AutoSize = true;
            this.STDescriptionLbl.Location = new System.Drawing.Point(0, 202);
            this.STDescriptionLbl.Name = "STDescriptionLbl";
            this.STDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.STDescriptionLbl.TabIndex = 44;
            this.STDescriptionLbl.Text = "Description";
            // 
            // STDescriptionTxt
            // 
            this.STDescriptionTxt.Location = new System.Drawing.Point(3, 218);
            this.STDescriptionTxt.Name = "STDescriptionTxt";
            this.STDescriptionTxt.ReadOnly = true;
            this.STDescriptionTxt.Size = new System.Drawing.Size(230, 20);
            this.STDescriptionTxt.TabIndex = 43;
            this.STDescriptionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STAutoStartChckbx
            // 
            this.STAutoStartChckbx.AutoSize = true;
            this.STAutoStartChckbx.Checked = true;
            this.STAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.STAutoStartChckbx.Location = new System.Drawing.Point(245, 161);
            this.STAutoStartChckbx.Name = "STAutoStartChckbx";
            this.STAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.STAutoStartChckbx.TabIndex = 53;
            this.STAutoStartChckbx.Text = "Auto Start";
            this.STAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // STSchedulerVw
            // 
            this.STSchedulerVw.CheckBoxes = true;
            this.STSchedulerVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STPacketCol,
            this.STDestinationCol,
            this.STBurstCol,
            this.STIntervalCol,
            this.STStatusCol});
            this.STSchedulerVw.FullRowSelect = true;
            this.STSchedulerVw.GridLines = true;
            this.STSchedulerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.STSchedulerVw.HideSelection = false;
            this.STSchedulerVw.Location = new System.Drawing.Point(3, 3);
            this.STSchedulerVw.MultiSelect = false;
            this.STSchedulerVw.Name = "STSchedulerVw";
            this.STSchedulerVw.ShowItemToolTips = true;
            this.STSchedulerVw.Size = new System.Drawing.Size(386, 156);
            this.STSchedulerVw.TabIndex = 0;
            this.STSchedulerVw.UseCompatibleStateImageBehavior = false;
            this.STSchedulerVw.View = System.Windows.Forms.View.Details;
            // 
            // STPacketCol
            // 
            this.STPacketCol.Text = "Packet";
            this.STPacketCol.Width = 145;
            // 
            // STDestinationCol
            // 
            this.STDestinationCol.Text = "Destination";
            this.STDestinationCol.Width = 65;
            // 
            // STBurstCol
            // 
            this.STBurstCol.Text = "Burst";
            this.STBurstCol.Width = 48;
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
            this.PrimitiveTab.Controls.Add(this.PTIsCorruptedLbl);
            this.PrimitiveTab.Controls.Add(this.PTPacketInfoLbl);
            this.PrimitiveTab.Controls.Add(this.PTPacketTxt);
            this.PrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.PrimitiveTab.Name = "PrimitiveTab";
            this.PrimitiveTab.Size = new System.Drawing.Size(394, 268);
            this.PrimitiveTab.TabIndex = 1;
            this.PrimitiveTab.Text = "Primitive";
            this.PrimitiveTab.UseVisualStyleBackColor = true;
            // 
            // PTIsCorruptedLbl
            // 
            this.PTIsCorruptedLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PTIsCorruptedLbl.AutoSize = true;
            this.PTIsCorruptedLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.PTIsCorruptedLbl.Location = new System.Drawing.Point(170, 3);
            this.PTIsCorruptedLbl.Name = "PTIsCorruptedLbl";
            this.PTIsCorruptedLbl.Size = new System.Drawing.Size(29, 13);
            this.PTIsCorruptedLbl.TabIndex = 5;
            this.PTIsCorruptedLbl.Text = "True";
            // 
            // PTPacketInfoLbl
            // 
            this.PTPacketInfoLbl.AutoSize = true;
            this.PTPacketInfoLbl.Location = new System.Drawing.Point(3, 3);
            this.PTPacketInfoLbl.Name = "PTPacketInfoLbl";
            this.PTPacketInfoLbl.Size = new System.Drawing.Size(172, 13);
            this.PTPacketInfoLbl.TabIndex = 4;
            this.PTPacketInfoLbl.Text = "Header: 0 | Length: 0 | IsCorrupted:";
            // 
            // PTPacketTxt
            // 
            this.PTPacketTxt.ContextMenuStrip = this.PTPrimitiveContextMenu;
            this.PTPacketTxt.Location = new System.Drawing.Point(3, 19);
            this.PTPacketTxt.MaxLength = 2147483647;
            this.PTPacketTxt.Multiline = true;
            this.PTPacketTxt.Name = "PTPacketTxt";
            this.PTPacketTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PTPacketTxt.Size = new System.Drawing.Size(386, 246);
            this.PTPacketTxt.TabIndex = 3;
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
            this.FiltersTab.Size = new System.Drawing.Size(394, 268);
            this.FiltersTab.TabIndex = 3;
            this.FiltersTab.Text = "Filters";
            this.FiltersTab.UseVisualStyleBackColor = true;
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
            this.FTFiltersVw.Size = new System.Drawing.Size(388, 171);
            this.FTFiltersVw.TabIndex = 0;
            this.FTFiltersVw.UseCompatibleStateImageBehavior = false;
            this.FTFiltersVw.View = System.Windows.Forms.View.Details;
            // 
            // IFActionCol
            // 
            this.IFActionCol.Text = "Action";
            this.IFActionCol.Width = 68;
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
            this.ITPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITPacketTxt.Location = new System.Drawing.Point(6, 286);
            this.ITPacketTxt.Name = "ITPacketTxt";
            this.ITPacketTxt.Size = new System.Drawing.Size(249, 21);
            this.ITPacketTxt.TabIndex = 8;
            // 
            // EncoderDecoderTab
            // 
            this.EncoderDecoderTab.Controls.Add(this.EDTIntegerInputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDTShortInputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDTDecodeValuesBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDTEncodedValuesLbl);
            this.EncoderDecoderTab.Controls.Add(this.EDTEncodedValuesTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDTShortOutputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDTIntegerOutputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDTEncodeShortBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDTEncodeIntegerBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDTDecodeShortBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDTDecodeIntegerBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDTTopGlowPnl);
            this.EncoderDecoderTab.Controls.Add(this.EDTDecodedVw);
            this.EncoderDecoderTab.Location = new System.Drawing.Point(4, 28);
            this.EncoderDecoderTab.Name = "EncoderDecoderTab";
            this.EncoderDecoderTab.Size = new System.Drawing.Size(473, 313);
            this.EncoderDecoderTab.TabIndex = 3;
            this.EncoderDecoderTab.Text = "Encoder/Decoder";
            this.EncoderDecoderTab.UseVisualStyleBackColor = true;
            // 
            // EDTIntegerInputTxt
            // 
            this.EDTIntegerInputTxt.Location = new System.Drawing.Point(107, 6);
            this.EDTIntegerInputTxt.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.EDTIntegerInputTxt.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.EDTIntegerInputTxt.Name = "EDTIntegerInputTxt";
            this.EDTIntegerInputTxt.Size = new System.Drawing.Size(126, 20);
            this.EDTIntegerInputTxt.TabIndex = 45;
            this.EDTIntegerInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDTShortInputTxt
            // 
            this.EDTShortInputTxt.Location = new System.Drawing.Point(107, 34);
            this.EDTShortInputTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.EDTShortInputTxt.Name = "EDTShortInputTxt";
            this.EDTShortInputTxt.Size = new System.Drawing.Size(126, 20);
            this.EDTShortInputTxt.TabIndex = 44;
            this.EDTShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDTDecodeValuesBtn
            // 
            this.EDTDecodeValuesBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDTDecodeValuesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDTDecodeValuesBtn.Location = new System.Drawing.Point(372, 66);
            this.EDTDecodeValuesBtn.Name = "EDTDecodeValuesBtn";
            this.EDTDecodeValuesBtn.Size = new System.Drawing.Size(98, 23);
            this.EDTDecodeValuesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDTDecodeValuesBtn.TabIndex = 42;
            this.EDTDecodeValuesBtn.Text = "Decode Value(s)";
            // 
            // EDTEncodedValuesLbl
            // 
            this.EDTEncodedValuesLbl.Location = new System.Drawing.Point(3, 69);
            this.EDTEncodedValuesLbl.Name = "EDTEncodedValuesLbl";
            this.EDTEncodedValuesLbl.Size = new System.Drawing.Size(98, 20);
            this.EDTEncodedValuesLbl.TabIndex = 40;
            this.EDTEncodedValuesLbl.Text = "Encoded Value(s):";
            this.EDTEncodedValuesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EDTEncodedValuesTxt
            // 
            this.EDTEncodedValuesTxt.Location = new System.Drawing.Point(107, 69);
            this.EDTEncodedValuesTxt.Name = "EDTEncodedValuesTxt";
            this.EDTEncodedValuesTxt.Size = new System.Drawing.Size(259, 20);
            this.EDTEncodedValuesTxt.TabIndex = 41;
            this.EDTEncodedValuesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDTShortOutputTxt
            // 
            this.EDTShortOutputTxt.Location = new System.Drawing.Point(240, 34);
            this.EDTShortOutputTxt.Name = "EDTShortOutputTxt";
            this.EDTShortOutputTxt.Size = new System.Drawing.Size(126, 20);
            this.EDTShortOutputTxt.TabIndex = 38;
            this.EDTShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDTIntegerOutputTxt
            // 
            this.EDTIntegerOutputTxt.Location = new System.Drawing.Point(240, 6);
            this.EDTIntegerOutputTxt.Name = "EDTIntegerOutputTxt";
            this.EDTIntegerOutputTxt.Size = new System.Drawing.Size(126, 20);
            this.EDTIntegerOutputTxt.TabIndex = 37;
            this.EDTIntegerOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDTEncodeShortBtn
            // 
            this.EDTEncodeShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDTEncodeShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDTEncodeShortBtn.Location = new System.Drawing.Point(3, 32);
            this.EDTEncodeShortBtn.Name = "EDTEncodeShortBtn";
            this.EDTEncodeShortBtn.Size = new System.Drawing.Size(98, 23);
            this.EDTEncodeShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDTEncodeShortBtn.TabIndex = 33;
            this.EDTEncodeShortBtn.Text = "Encode Short";
            // 
            // EDTEncodeIntegerBtn
            // 
            this.EDTEncodeIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDTEncodeIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDTEncodeIntegerBtn.Location = new System.Drawing.Point(3, 3);
            this.EDTEncodeIntegerBtn.Name = "EDTEncodeIntegerBtn";
            this.EDTEncodeIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.EDTEncodeIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDTEncodeIntegerBtn.TabIndex = 32;
            this.EDTEncodeIntegerBtn.Text = "Encode Integer";
            // 
            // EDTDecodeShortBtn
            // 
            this.EDTDecodeShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDTDecodeShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDTDecodeShortBtn.Location = new System.Drawing.Point(372, 32);
            this.EDTDecodeShortBtn.Name = "EDTDecodeShortBtn";
            this.EDTDecodeShortBtn.Size = new System.Drawing.Size(98, 23);
            this.EDTDecodeShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDTDecodeShortBtn.TabIndex = 35;
            this.EDTDecodeShortBtn.Text = "Decode Short";
            // 
            // EDTDecodeIntegerBtn
            // 
            this.EDTDecodeIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDTDecodeIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDTDecodeIntegerBtn.Location = new System.Drawing.Point(372, 3);
            this.EDTDecodeIntegerBtn.Name = "EDTDecodeIntegerBtn";
            this.EDTDecodeIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.EDTDecodeIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDTDecodeIntegerBtn.TabIndex = 34;
            this.EDTDecodeIntegerBtn.Text = "Decode Integer";
            // 
            // EDTTopGlowPnl
            // 
            this.EDTTopGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDTTopGlowPnl.Location = new System.Drawing.Point(0, 61);
            this.EDTTopGlowPnl.Name = "EDTTopGlowPnl";
            this.EDTTopGlowPnl.Size = new System.Drawing.Size(471, 1);
            this.EDTTopGlowPnl.TabIndex = 39;
            // 
            // EDTDecodedVw
            // 
            this.EDTDecodedVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EDTValueCol,
            this.EDTEncodedCol,
            this.EDTPositionCol});
            this.EDTDecodedVw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EDTDecodedVw.FullRowSelect = true;
            this.EDTDecodedVw.GridLines = true;
            this.EDTDecodedVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EDTDecodedVw.HideSelection = false;
            this.EDTDecodedVw.Location = new System.Drawing.Point(0, 95);
            this.EDTDecodedVw.MultiSelect = false;
            this.EDTDecodedVw.Name = "EDTDecodedVw";
            this.EDTDecodedVw.ShowItemToolTips = true;
            this.EDTDecodedVw.Size = new System.Drawing.Size(473, 218);
            this.EDTDecodedVw.TabIndex = 43;
            this.EDTDecodedVw.UseCompatibleStateImageBehavior = false;
            this.EDTDecodedVw.View = System.Windows.Forms.View.Details;
            // 
            // EDTValueCol
            // 
            this.EDTValueCol.Text = "Value";
            this.EDTValueCol.Width = 84;
            // 
            // EDTEncodedCol
            // 
            this.EDTEncodedCol.Text = "Encoded";
            this.EDTEncodedCol.Width = 109;
            // 
            // EDTPositionCol
            // 
            this.EDTPositionCol.Text = "Position";
            this.EDTPositionCol.Width = 80;
            // 
            // ExtensionsTab
            // 
            this.ExtensionsTab.Controls.Add(this.ETExtensionAOTChckbx);
            this.ExtensionsTab.Controls.Add(this.ETUninstallExtensionBtn);
            this.ExtensionsTab.Controls.Add(this.ETContractorVw);
            this.ExtensionsTab.Controls.Add(this.ETInstallExtensionBtn);
            this.ExtensionsTab.Location = new System.Drawing.Point(4, 28);
            this.ExtensionsTab.Name = "ExtensionsTab";
            this.ExtensionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtensionsTab.Size = new System.Drawing.Size(473, 313);
            this.ExtensionsTab.TabIndex = 1;
            this.ExtensionsTab.Text = "Extensions";
            this.ExtensionsTab.UseVisualStyleBackColor = true;
            // 
            // ETExtensionAOTChckbx
            // 
            this.ETExtensionAOTChckbx.AutoSize = true;
            this.ETExtensionAOTChckbx.Enabled = false;
            this.ETExtensionAOTChckbx.Location = new System.Drawing.Point(32, 289);
            this.ETExtensionAOTChckbx.Name = "ETExtensionAOTChckbx";
            this.ETExtensionAOTChckbx.Size = new System.Drawing.Size(147, 17);
            this.ETExtensionAOTChckbx.TabIndex = 3;
            this.ETExtensionAOTChckbx.Text = "Extension Always On Top";
            this.ETExtensionAOTChckbx.UseVisualStyleBackColor = true;
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
            // ETContractorVw
            // 
            this.ETContractorVw.AutoOpen = false;
            this.ETContractorVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ETIdentifierCol,
            this.ETCreatorCol,
            this.ETDescriptionCol,
            this.ETVersionCol,
            this.ETStatusCol});
            this.ETContractorVw.ContextMenuStrip = this.ETExtensionMenu;
            this.ETContractorVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.ETContractorVw.FullRowSelect = true;
            this.ETContractorVw.GridLines = true;
            this.ETContractorVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ETContractorVw.HideSelection = false;
            this.ETContractorVw.Location = new System.Drawing.Point(3, 3);
            this.ETContractorVw.MultiSelect = false;
            this.ETContractorVw.Name = "ETContractorVw";
            this.ETContractorVw.ShowItemToolTips = true;
            this.ETContractorVw.Size = new System.Drawing.Size(467, 276);
            this.ETContractorVw.TabIndex = 0;
            this.ETContractorVw.UseCompatibleStateImageBehavior = false;
            this.ETContractorVw.View = System.Windows.Forms.View.Details;
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
            this.ETVersionCol.Width = 87;
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
            // IFTypeCol
            // 
            this.IFTypeCol.Text = "Type";
            this.IFTypeCol.Width = 68;
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
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 369);
            this.Controls.Add(this.TanjiTabs);
            this.Controls.Add(this.TanjiStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Tanji.Properties.Resources.Tanji;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Connected[Host:Port]";
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.PTPrimitiveContextMenu.ResumeLayout(false);
            this.ETExtensionMenu.ResumeLayout(false);
            this.TanjiTabs.ResumeLayout(false);
            this.InjectionTab.ResumeLayout(false);
            this.InjectionTabs.ResumeLayout(false);
            this.ConstructerTab.ResumeLayout(false);
            this.ConstructerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTCountTxt)).EndInit();
            this.SchedulerTab.ResumeLayout(false);
            this.SchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.STBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STIntervalTxt)).EndInit();
            this.PrimitiveTab.ResumeLayout(false);
            this.PrimitiveTab.PerformLayout();
            this.FiltersTab.ResumeLayout(false);
            this.FiltersTab.PerformLayout();
            this.EncoderDecoderTab.ResumeLayout(false);
            this.EncoderDecoderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDTIntegerInputTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EDTShortInputTxt)).EndInit();
            this.ExtensionsTab.ResumeLayout(false);
            this.ExtensionsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        public System.Windows.Forms.ToolStripStatusLabel ExtensionsActiveTxt;
        private System.Windows.Forms.ToolStripSeparator ETTopMenuSplitter;
        public System.Windows.Forms.ContextMenuStrip ETExtensionMenu;
        public System.Windows.Forms.ToolStripMenuItem ETOpenMenuBtn;
        public System.Windows.Forms.ToolStripMenuItem ETUninstallMenuBtn;
        public System.Windows.Forms.ToolStripMenuItem ETInstallMenuBtn;
        private System.Windows.Forms.ContextMenuStrip PTPrimitiveContextMenu;
        private System.Windows.Forms.ToolStripMenuItem PTInsertFormatParameterBtn;
        private System.Windows.Forms.ToolStripSeparator PTMenuSeparatorTop;
        public System.Windows.Forms.ToolStripMenuItem PTIntegerBtn;
        public System.Windows.Forms.ToolStripMenuItem PTStringBtn;
        public System.Windows.Forms.ToolStripMenuItem PTBooleanBtn;
        public System.Windows.Forms.ToolStripMenuItem PTCopyBtn;
        public System.Windows.Forms.ToolStripMenuItem PTLengthHeaderBtn;
        public System.Windows.Forms.ToolStripMenuItem PTSelectAllBtn;
        public System.Windows.Forms.ToolStripMenuItem PTPasteBtn;
        public System.Windows.Forms.ToolStripMenuItem PTCutBtn;
        private System.Windows.Forms.ToolStripSeparator PTMenuSeperatorBottom;
        public System.Windows.Forms.ToolStripMenuItem PTUndoBtn;
        public System.Windows.Forms.ToolStripStatusLabel SchedulesActiveTxt;
        public System.Windows.Forms.ToolStripStatusLabel TanjiVersionTxt;
        private System.Windows.Forms.ToolStripStatusLabel TanjiInfoTxt;
        private System.Windows.Forms.ToolStripSeparator ETMiddleMenuSplitter;
        public System.Windows.Forms.ToolStripMenuItem ETGrabMenuBtn;
        private System.Windows.Forms.TabPage ExtensionsTab;
        public System.Windows.Forms.CheckBox ETExtensionAOTChckbx;
        public Sulakore.Components.SKoreButton ETUninstallExtensionBtn;
        public Sulakore.Components.SKoreExtensionView ETContractorVw;
        private System.Windows.Forms.ColumnHeader ETIdentifierCol;
        private System.Windows.Forms.ColumnHeader ETCreatorCol;
        private System.Windows.Forms.ColumnHeader ETDescriptionCol;
        private System.Windows.Forms.ColumnHeader ETVersionCol;
        private System.Windows.Forms.ColumnHeader ETStatusCol;
        public Sulakore.Components.SKoreButton ETInstallExtensionBtn;
        private System.Windows.Forms.TabPage EncoderDecoderTab;
        public System.Windows.Forms.NumericUpDown EDTIntegerInputTxt;
        public System.Windows.Forms.NumericUpDown EDTShortInputTxt;
        public Sulakore.Components.SKoreButton EDTDecodeValuesBtn;
        private System.Windows.Forms.Label EDTEncodedValuesLbl;
        public System.Windows.Forms.TextBox EDTEncodedValuesTxt;
        public System.Windows.Forms.TextBox EDTShortOutputTxt;
        public System.Windows.Forms.TextBox EDTIntegerOutputTxt;
        public Sulakore.Components.SKoreButton EDTEncodeShortBtn;
        public Sulakore.Components.SKoreButton EDTEncodeIntegerBtn;
        public Sulakore.Components.SKoreButton EDTDecodeShortBtn;
        public Sulakore.Components.SKoreButton EDTDecodeIntegerBtn;
        private System.Windows.Forms.Panel EDTTopGlowPnl;
        public Sulakore.Components.SKoreListView EDTDecodedVw;
        private System.Windows.Forms.ColumnHeader EDTValueCol;
        private System.Windows.Forms.ColumnHeader EDTEncodedCol;
        private System.Windows.Forms.ColumnHeader EDTPositionCol;
        private System.Windows.Forms.TabPage InjectionTab;
        public Sulakore.Components.SKoreButton ITSendToClientBtn;
        public Sulakore.Components.SKoreButton ITSendToServerBtn;
        public Sulakore.Components.SKoreTabControl InjectionTabs;
        private System.Windows.Forms.TabPage ConstructerTab;
        private System.Windows.Forms.Label CTHeaderLbl;
        public System.Windows.Forms.ComboBox CTValueTxt;
        private System.Windows.Forms.Label CTCountLbl;
        public System.Windows.Forms.TextBox CTPacketTxt;
        public Sulakore.Components.SKoreButton CTTransferBelowBtn;
        public Sulakore.Components.SKoreLabel CTChunkCountLbl;
        public Sulakore.Components.SKoreConstructView CTConstructerVw;
        private System.Windows.Forms.ColumnHeader ICSTypeCol;
        private System.Windows.Forms.ColumnHeader ICSValueCol;
        private System.Windows.Forms.ColumnHeader ICSEncodedCol;
        public System.Windows.Forms.NumericUpDown CTCountTxt;
        public Sulakore.Components.SKoreButton CTRemoveBtn;
        public Sulakore.Components.SKoreButton CTMoveDownBtn;
        public Sulakore.Components.SKoreButton CTMoveUpBtn;
        public Sulakore.Components.SKoreButton CTClearBtn;
        public Sulakore.Components.SKoreButton CTAppendBooleanBtn;
        public Sulakore.Components.SKoreButton CTAppendStringBtn;
        public Sulakore.Components.SKoreButton CTAppendIntegerBtn;
        public System.Windows.Forms.TextBox CTHeaderTxt;
        private System.Windows.Forms.Label CTValueLbl;
        public System.Windows.Forms.CheckBox CTLiveEditingChckbx;
        private System.Windows.Forms.TabPage SchedulerTab;
        public System.Windows.Forms.Label STIntervalLbl;
        public Sulakore.Components.SKoreButton STClearBtn;
        public Sulakore.Components.SKoreButton STStopAllBtn;
        public Sulakore.Components.SKoreButton STStartAllBtn;
        public Sulakore.Components.SKoreButton STRemoveBtn;
        public Sulakore.Components.SKoreButton STCreateBtn;
        public System.Windows.Forms.Label STBurstLbl;
        public System.Windows.Forms.NumericUpDown STBurstTxt;
        public System.Windows.Forms.NumericUpDown STIntervalTxt;
        public System.Windows.Forms.Label STDestinationLbl;
        public System.Windows.Forms.ComboBox STDestinationTxt;
        public System.Windows.Forms.Label STPacketLbl;
        public System.Windows.Forms.TextBox STPacketTxt;
        public System.Windows.Forms.Label STDescriptionLbl;
        public System.Windows.Forms.TextBox STDescriptionTxt;
        public System.Windows.Forms.CheckBox STAutoStartChckbx;
        public Sulakore.Components.SKoreScheduleView STSchedulerVw;
        private System.Windows.Forms.ColumnHeader STPacketCol;
        private System.Windows.Forms.ColumnHeader STDestinationCol;
        private System.Windows.Forms.ColumnHeader STBurstCol;
        private System.Windows.Forms.ColumnHeader STIntervalCol;
        private System.Windows.Forms.ColumnHeader STStatusCol;
        public System.Windows.Forms.TabPage PrimitiveTab;
        public System.Windows.Forms.Label PTIsCorruptedLbl;
        public System.Windows.Forms.Label PTPacketInfoLbl;
        public System.Windows.Forms.TextBox PTPacketTxt;
        public System.Windows.Forms.ComboBox ITPacketTxt;
        private Sulakore.Components.SKoreTabControl TanjiTabs;
        private System.Windows.Forms.TabPage FiltersTab;
        private System.Windows.Forms.ColumnHeader IFActionCol;
        private System.Windows.Forms.ColumnHeader IFHeaderCol;
        private System.Windows.Forms.ColumnHeader IFInvocationCol;
        public System.Windows.Forms.ComboBox IFActionTxt;
        public Sulakore.Components.SKoreListView FTFiltersVw;
        private System.Windows.Forms.ColumnHeader IFTypeCol;
        private System.Windows.Forms.Label IFTypeLbl;
        public System.Windows.Forms.ComboBox IFTypeTxt;
        private System.Windows.Forms.Label IFActionLbl;
    }
}