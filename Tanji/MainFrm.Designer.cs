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
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.IPacketTxt = new System.Windows.Forms.TextBox();
            this.ISendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ISendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.ConstructerTab = new System.Windows.Forms.TabPage();
            this.ICConstructerLstvw = new Sulakore.Components.SKoreConstructView();
            this.ICSTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICSEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICConstructMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ICCopyPacketBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTransferToBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICSchedulerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICPrimitiveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICTransferSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ICInjectionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ICChunksRightGlowPnl = new System.Windows.Forms.Panel();
            this.ICChunksLeftGlowPnl = new System.Windows.Forms.Panel();
            this.ICChunkCountLbl = new System.Windows.Forms.Label();
            this.ICCountTxt = new System.Windows.Forms.NumericUpDown();
            this.ICCountLbl = new System.Windows.Forms.Label();
            this.ICRemoveBtn = new Sulakore.Components.SKoreButton();
            this.ICMoveDownBtn = new Sulakore.Components.SKoreButton();
            this.ICMoveUpBtn = new Sulakore.Components.SKoreButton();
            this.ICClearBtn = new Sulakore.Components.SKoreButton();
            this.ICAppendBooleanBtn = new Sulakore.Components.SKoreButton();
            this.ICAppendStringBtn = new Sulakore.Components.SKoreButton();
            this.ICAppendIntegerBtn = new Sulakore.Components.SKoreButton();
            this.ICHeaderLbl = new System.Windows.Forms.Label();
            this.ICHeaderTxt = new System.Windows.Forms.TextBox();
            this.ICValueLbl = new System.Windows.Forms.Label();
            this.ICValueTxt = new System.Windows.Forms.TextBox();
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.IPInsertBooleanBtn = new Sulakore.Components.SKoreButton();
            this.IPInsertStringBtn = new Sulakore.Components.SKoreButton();
            this.IPInsertIntegerBtn = new Sulakore.Components.SKoreButton();
            this.IPInserHeaderBtn = new Sulakore.Components.SKoreButton();
            this.IPIsCorruptedLbl = new System.Windows.Forms.Label();
            this.IPPacketInfoLbl = new System.Windows.Forms.Label();
            this.IPPrimitiveTxt = new System.Windows.Forms.TextBox();
            this.SchedulerTab = new System.Windows.Forms.TabPage();
            this.ISClearBtn = new Sulakore.Components.SKoreButton();
            this.ISStopAllBtn = new Sulakore.Components.SKoreButton();
            this.ISStartAllBtn = new Sulakore.Components.SKoreButton();
            this.ISRemoveBtn = new Sulakore.Components.SKoreButton();
            this.ISCreateBtn = new Sulakore.Components.SKoreButton();
            this.ISAutoStartChckbx = new System.Windows.Forms.CheckBox();
            this.ISBurstLbl = new System.Windows.Forms.Label();
            this.ISBurstTxt = new System.Windows.Forms.NumericUpDown();
            this.ISIntervalLbl = new System.Windows.Forms.Label();
            this.ISIntervalTxt = new System.Windows.Forms.NumericUpDown();
            this.ISDestinationLbl = new System.Windows.Forms.Label();
            this.ISDestinationTxt = new System.Windows.Forms.ComboBox();
            this.ISPacketLbl = new System.Windows.Forms.Label();
            this.ISPacketTxt = new System.Windows.Forms.TextBox();
            this.ISDescriptionLbl = new System.Windows.Forms.Label();
            this.ISDescriptionTxt = new System.Windows.Forms.TextBox();
            this.ISSchedulerVw = new Sulakore.Components.SKoreScheduleView();
            this.STPacketCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDestinationCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STBurstCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STIntervalCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncoderDecoderTab = new System.Windows.Forms.TabPage();
            this.EDExtracterLstvw = new Sulakore.Components.SKoreListView();
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EDExtractValuesBtn = new Sulakore.Components.SKoreButton();
            this.EDEncodedBlocksLbl = new System.Windows.Forms.Label();
            this.EDEncodedBlocksTxt = new System.Windows.Forms.TextBox();
            this.EDMiddleGlowPnl = new System.Windows.Forms.Panel();
            this.EDShortOutputTxt = new System.Windows.Forms.TextBox();
            this.EDIntegerOutputTxt = new System.Windows.Forms.TextBox();
            this.EDShortInputTxt = new System.Windows.Forms.TextBox();
            this.EDEncodeShortBtn = new Sulakore.Components.SKoreButton();
            this.EDEncodeIntegerBtn = new Sulakore.Components.SKoreButton();
            this.EDDecodeShortBtn = new Sulakore.Components.SKoreButton();
            this.EDDecodeIntegerBtn = new Sulakore.Components.SKoreButton();
            this.EDIntegerInputTxt = new System.Windows.Forms.TextBox();
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.ETExtensionAOTChckbx = new System.Windows.Forms.CheckBox();
            this.ETUninstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.ContractorVw = new Sulakore.Components.SKoreExtensionView();
            this.ETIdentifierCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETCreatorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETDescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETVersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETStatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETExtensionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ETOpenMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETUninstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETMenuSplitter = new System.Windows.Forms.ToolStripSeparator();
            this.ETInstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETInstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.ICTypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICEncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TanjiStrip.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.ConstructerTab.SuspendLayout();
            this.ICConstructMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).BeginInit();
            this.PrimitiveTab.SuspendLayout();
            this.SchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).BeginInit();
            this.EncoderDecoderTab.SuspendLayout();
            this.ExtensionsTab.SuspendLayout();
            this.ETExtensionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanjiVersionTxt,
            this.toolStripStatusLabel1,
            this.ExtensionsActiveTxt,
            this.TanjiInfoTxt});
            this.TanjiStrip.Location = new System.Drawing.Point(0, 345);
            this.TanjiStrip.Name = "TanjiStrip";
            this.TanjiStrip.Size = new System.Drawing.Size(479, 24);
            this.TanjiStrip.SizingGrip = false;
            this.TanjiStrip.TabIndex = 5;
            this.TanjiStrip.Text = "statusStrip1";
            // 
            // TanjiVersionTxt
            // 
            this.TanjiVersionTxt.ActiveLinkColor = System.Drawing.Color.Firebrick;
            this.TanjiVersionTxt.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TanjiVersionTxt.IsLink = true;
            this.TanjiVersionTxt.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.TanjiVersionTxt.Name = "TanjiVersionTxt";
            this.TanjiVersionTxt.Size = new System.Drawing.Size(50, 19);
            this.TanjiVersionTxt.Text = "v0.0.0.0";
            this.TanjiVersionTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiVersionTxt.Click += new System.EventHandler(this.TanjiVersionTxt_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 19);
            this.toolStripStatusLabel1.Text = "Schedules Active: 0/0";
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
            this.TanjiInfoTxt.Size = new System.Drawing.Size(166, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "GitHub | ArachisH/Tanji";
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.Controls.Add(this.InjectionTab);
            this.TanjiTabs.Controls.Add(this.EncoderDecoderTab);
            this.TanjiTabs.Controls.Add(this.ExtensionsTab);
            this.TanjiTabs.DisplayBoundary = true;
            this.TanjiTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TanjiTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TanjiTabs.Location = new System.Drawing.Point(0, 0);
            this.TanjiTabs.Name = "TanjiTabs";
            this.TanjiTabs.SelectedIndex = 0;
            this.TanjiTabs.Size = new System.Drawing.Size(479, 345);
            this.TanjiTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TanjiTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiTabs.TabIndex = 6;
            // 
            // InjectionTab
            // 
            this.InjectionTab.Controls.Add(this.IPacketTxt);
            this.InjectionTab.Controls.Add(this.ISendToClientBtn);
            this.InjectionTab.Controls.Add(this.ISendToServerBtn);
            this.InjectionTab.Controls.Add(this.InjectionTabs);
            this.InjectionTab.Location = new System.Drawing.Point(4, 28);
            this.InjectionTab.Name = "InjectionTab";
            this.InjectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.InjectionTab.Size = new System.Drawing.Size(471, 313);
            this.InjectionTab.TabIndex = 2;
            this.InjectionTab.Text = "Injection";
            this.InjectionTab.UseVisualStyleBackColor = true;
            // 
            // IPacketTxt
            // 
            this.IPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPacketTxt.Location = new System.Drawing.Point(6, 286);
            this.IPacketTxt.MaxLength = 2147483647;
            this.IPacketTxt.Name = "IPacketTxt";
            this.IPacketTxt.Size = new System.Drawing.Size(247, 20);
            this.IPacketTxt.TabIndex = 8;
            // 
            // ISendToClientBtn
            // 
            this.ISendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISendToClientBtn.Location = new System.Drawing.Point(259, 285);
            this.ISendToClientBtn.Name = "ISendToClientBtn";
            this.ISendToClientBtn.Size = new System.Drawing.Size(100, 22);
            this.ISendToClientBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISendToClientBtn.TabIndex = 7;
            this.ISendToClientBtn.Text = "Send To Client";
            this.ISendToClientBtn.Click += new System.EventHandler(this.ISendToClientBtn_Click);
            // 
            // ISendToServerBtn
            // 
            this.ISendToServerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ISendToServerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISendToServerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISendToServerBtn.Location = new System.Drawing.Point(365, 285);
            this.ISendToServerBtn.Name = "ISendToServerBtn";
            this.ISendToServerBtn.Size = new System.Drawing.Size(100, 22);
            this.ISendToServerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISendToServerBtn.TabIndex = 6;
            this.ISendToServerBtn.Text = "Send To Server";
            this.ISendToServerBtn.Click += new System.EventHandler(this.ISendToServerBtn_Click);
            // 
            // InjectionTabs
            // 
            this.InjectionTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.InjectionTabs.Controls.Add(this.ConstructerTab);
            this.InjectionTabs.Controls.Add(this.PrimitiveTab);
            this.InjectionTabs.Controls.Add(this.SchedulerTab);
            this.InjectionTabs.DisplayBoundary = true;
            this.InjectionTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.InjectionTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.InjectionTabs.ItemSize = new System.Drawing.Size(65, 24);
            this.InjectionTabs.Location = new System.Drawing.Point(3, 3);
            this.InjectionTabs.Multiline = true;
            this.InjectionTabs.Name = "InjectionTabs";
            this.InjectionTabs.SelectedIndex = 0;
            this.InjectionTabs.Size = new System.Drawing.Size(465, 276);
            this.InjectionTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.InjectionTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.InjectionTabs.TabIndex = 0;
            this.InjectionTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.InjectionTabs_Selected);
            // 
            // ConstructerTab
            // 
            this.ConstructerTab.Controls.Add(this.ICConstructerLstvw);
            this.ConstructerTab.Controls.Add(this.ICChunksRightGlowPnl);
            this.ConstructerTab.Controls.Add(this.ICChunksLeftGlowPnl);
            this.ConstructerTab.Controls.Add(this.ICChunkCountLbl);
            this.ConstructerTab.Controls.Add(this.ICCountTxt);
            this.ConstructerTab.Controls.Add(this.ICCountLbl);
            this.ConstructerTab.Controls.Add(this.ICRemoveBtn);
            this.ConstructerTab.Controls.Add(this.ICMoveDownBtn);
            this.ConstructerTab.Controls.Add(this.ICMoveUpBtn);
            this.ConstructerTab.Controls.Add(this.ICClearBtn);
            this.ConstructerTab.Controls.Add(this.ICAppendBooleanBtn);
            this.ConstructerTab.Controls.Add(this.ICAppendStringBtn);
            this.ConstructerTab.Controls.Add(this.ICAppendIntegerBtn);
            this.ConstructerTab.Controls.Add(this.ICHeaderLbl);
            this.ConstructerTab.Controls.Add(this.ICHeaderTxt);
            this.ConstructerTab.Controls.Add(this.ICValueLbl);
            this.ConstructerTab.Controls.Add(this.ICValueTxt);
            this.ConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.ConstructerTab.Name = "ConstructerTab";
            this.ConstructerTab.Size = new System.Drawing.Size(392, 268);
            this.ConstructerTab.TabIndex = 2;
            this.ConstructerTab.Text = "Constructer";
            this.ConstructerTab.UseVisualStyleBackColor = true;
            // 
            // ICConstructerLstvw
            // 
            this.ICConstructerLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ICSTypeCol,
            this.ICSValueCol,
            this.ICSEncodedCol});
            this.ICConstructerLstvw.ContextMenuStrip = this.ICConstructMenu;
            this.ICConstructerLstvw.FullRowSelect = true;
            this.ICConstructerLstvw.GridLines = true;
            this.ICConstructerLstvw.Header = ((ushort)(0));
            this.ICConstructerLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ICConstructerLstvw.HideSelection = false;
            this.ICConstructerLstvw.Location = new System.Drawing.Point(9, 75);
            this.ICConstructerLstvw.MultiSelect = false;
            this.ICConstructerLstvw.Name = "ICConstructerLstvw";
            this.ICConstructerLstvw.ShowItemToolTips = true;
            this.ICConstructerLstvw.Size = new System.Drawing.Size(379, 161);
            this.ICConstructerLstvw.TabIndex = 44;
            this.ICConstructerLstvw.UseCompatibleStateImageBehavior = false;
            this.ICConstructerLstvw.View = System.Windows.Forms.View.Details;
            this.ICConstructerLstvw.ItemSelected += new System.EventHandler<System.Windows.Forms.ListViewItemSelectionChangedEventArgs>(this.ICConstructerLstvw_ItemSelected);
            this.ICConstructerLstvw.ItemsDeselected += new System.EventHandler(this.ICConstructerLstvw_ItemsDeselected);
            this.ICConstructerLstvw.ItemActivate += new System.EventHandler(this.ICConstructerLstvw_ItemActivate);
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
            // ICConstructMenu
            // 
            this.ICConstructMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICCopyPacketBtn,
            this.ICTransferToBtn});
            this.ICConstructMenu.Name = "ConstructMenu";
            this.ICConstructMenu.Size = new System.Drawing.Size(141, 48);
            // 
            // ICCopyPacketBtn
            // 
            this.ICCopyPacketBtn.Name = "ICCopyPacketBtn";
            this.ICCopyPacketBtn.Size = new System.Drawing.Size(140, 22);
            this.ICCopyPacketBtn.Text = "Copy Packet";
            this.ICCopyPacketBtn.Click += new System.EventHandler(this.ICCopyPacketBtn_Click);
            // 
            // ICTransferToBtn
            // 
            this.ICTransferToBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ICSchedulerBtn,
            this.ICPrimitiveBtn,
            this.ICTransferSeparator,
            this.ICInjectionBtn});
            this.ICTransferToBtn.Name = "ICTransferToBtn";
            this.ICTransferToBtn.Size = new System.Drawing.Size(140, 22);
            this.ICTransferToBtn.Text = "Transfer To";
            // 
            // ICSchedulerBtn
            // 
            this.ICSchedulerBtn.Name = "ICSchedulerBtn";
            this.ICSchedulerBtn.Size = new System.Drawing.Size(163, 22);
            this.ICSchedulerBtn.Text = "Scheduler";
            this.ICSchedulerBtn.Click += new System.EventHandler(this.ICSchedulerBtn_Click);
            // 
            // ICPrimitiveBtn
            // 
            this.ICPrimitiveBtn.Name = "ICPrimitiveBtn";
            this.ICPrimitiveBtn.Size = new System.Drawing.Size(163, 22);
            this.ICPrimitiveBtn.Text = "Primitive";
            this.ICPrimitiveBtn.Click += new System.EventHandler(this.ICPrimitiveBtn_Click);
            // 
            // ICTransferSeparator
            // 
            this.ICTransferSeparator.Name = "ICTransferSeparator";
            this.ICTransferSeparator.Size = new System.Drawing.Size(160, 6);
            // 
            // ICInjectionBtn
            // 
            this.ICInjectionBtn.Name = "ICInjectionBtn";
            this.ICInjectionBtn.Size = new System.Drawing.Size(163, 22);
            this.ICInjectionBtn.Text = "Injection (Below)";
            this.ICInjectionBtn.Click += new System.EventHandler(this.ICInjectionBtn_Click);
            // 
            // ICChunksRightGlowPnl
            // 
            this.ICChunksRightGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICChunksRightGlowPnl.Location = new System.Drawing.Point(387, 242);
            this.ICChunksRightGlowPnl.Name = "ICChunksRightGlowPnl";
            this.ICChunksRightGlowPnl.Size = new System.Drawing.Size(1, 22);
            this.ICChunksRightGlowPnl.TabIndex = 43;
            // 
            // ICChunksLeftGlowPnl
            // 
            this.ICChunksLeftGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICChunksLeftGlowPnl.Location = new System.Drawing.Point(272, 242);
            this.ICChunksLeftGlowPnl.Name = "ICChunksLeftGlowPnl";
            this.ICChunksLeftGlowPnl.Size = new System.Drawing.Size(1, 22);
            this.ICChunksLeftGlowPnl.TabIndex = 42;
            // 
            // ICChunkCountLbl
            // 
            this.ICChunkCountLbl.Location = new System.Drawing.Point(275, 242);
            this.ICChunkCountLbl.Name = "ICChunkCountLbl";
            this.ICChunkCountLbl.Size = new System.Drawing.Size(110, 22);
            this.ICChunkCountLbl.TabIndex = 41;
            this.ICChunkCountLbl.Text = "Chunk Count: 0";
            this.ICChunkCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ICCountTxt
            // 
            this.ICCountTxt.Location = new System.Drawing.Point(328, 21);
            this.ICCountTxt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ICCountTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ICCountTxt.Name = "ICCountTxt";
            this.ICCountTxt.Size = new System.Drawing.Size(60, 20);
            this.ICCountTxt.TabIndex = 40;
            this.ICCountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICCountTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ICCountLbl
            // 
            this.ICCountLbl.AutoSize = true;
            this.ICCountLbl.Location = new System.Drawing.Point(326, 5);
            this.ICCountLbl.Name = "ICCountLbl";
            this.ICCountLbl.Size = new System.Drawing.Size(35, 13);
            this.ICCountLbl.TabIndex = 39;
            this.ICCountLbl.Text = "Count";
            // 
            // ICRemoveBtn
            // 
            this.ICRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICRemoveBtn.Enabled = false;
            this.ICRemoveBtn.Location = new System.Drawing.Point(8, 242);
            this.ICRemoveBtn.Name = "ICRemoveBtn";
            this.ICRemoveBtn.Size = new System.Drawing.Size(82, 22);
            this.ICRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICRemoveBtn.TabIndex = 38;
            this.ICRemoveBtn.Text = "Remove";
            this.ICRemoveBtn.Click += new System.EventHandler(this.ICRemoveBtn_Click);
            // 
            // ICMoveDownBtn
            // 
            this.ICMoveDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveDownBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveDownBtn.Enabled = false;
            this.ICMoveDownBtn.Location = new System.Drawing.Point(184, 242);
            this.ICMoveDownBtn.Name = "ICMoveDownBtn";
            this.ICMoveDownBtn.Size = new System.Drawing.Size(82, 22);
            this.ICMoveDownBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICMoveDownBtn.TabIndex = 37;
            this.ICMoveDownBtn.Text = "Move Down";
            this.ICMoveDownBtn.Click += new System.EventHandler(this.ICMoveDownBtn_Click);
            // 
            // ICMoveUpBtn
            // 
            this.ICMoveUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICMoveUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICMoveUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICMoveUpBtn.Enabled = false;
            this.ICMoveUpBtn.Location = new System.Drawing.Point(96, 242);
            this.ICMoveUpBtn.Name = "ICMoveUpBtn";
            this.ICMoveUpBtn.Size = new System.Drawing.Size(82, 22);
            this.ICMoveUpBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICMoveUpBtn.TabIndex = 36;
            this.ICMoveUpBtn.Text = "Move Up";
            this.ICMoveUpBtn.Click += new System.EventHandler(this.ICMoveUpBtn_Click);
            // 
            // ICClearBtn
            // 
            this.ICClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICClearBtn.Location = new System.Drawing.Point(9, 47);
            this.ICClearBtn.Name = "ICClearBtn";
            this.ICClearBtn.Size = new System.Drawing.Size(67, 22);
            this.ICClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICClearBtn.TabIndex = 35;
            this.ICClearBtn.Text = "Clear";
            this.ICClearBtn.Click += new System.EventHandler(this.ICClearBtn_Click);
            // 
            // ICAppendBooleanBtn
            // 
            this.ICAppendBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendBooleanBtn.Location = new System.Drawing.Point(290, 47);
            this.ICAppendBooleanBtn.Name = "ICAppendBooleanBtn";
            this.ICAppendBooleanBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendBooleanBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICAppendBooleanBtn.TabIndex = 34;
            this.ICAppendBooleanBtn.Text = "Append Boolean";
            this.ICAppendBooleanBtn.Click += new System.EventHandler(this.ICAppendBtn_Click);
            // 
            // ICAppendStringBtn
            // 
            this.ICAppendStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendStringBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendStringBtn.Location = new System.Drawing.Point(186, 47);
            this.ICAppendStringBtn.Name = "ICAppendStringBtn";
            this.ICAppendStringBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendStringBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICAppendStringBtn.TabIndex = 33;
            this.ICAppendStringBtn.Text = "Append String";
            this.ICAppendStringBtn.Click += new System.EventHandler(this.ICAppendBtn_Click);
            // 
            // ICAppendIntegerBtn
            // 
            this.ICAppendIntegerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ICAppendIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ICAppendIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ICAppendIntegerBtn.Location = new System.Drawing.Point(82, 47);
            this.ICAppendIntegerBtn.Name = "ICAppendIntegerBtn";
            this.ICAppendIntegerBtn.Size = new System.Drawing.Size(98, 22);
            this.ICAppendIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ICAppendIntegerBtn.TabIndex = 32;
            this.ICAppendIntegerBtn.Text = "Append Integer";
            this.ICAppendIntegerBtn.Click += new System.EventHandler(this.ICAppendBtn_Click);
            // 
            // ICHeaderLbl
            // 
            this.ICHeaderLbl.AutoSize = true;
            this.ICHeaderLbl.Location = new System.Drawing.Point(5, 5);
            this.ICHeaderLbl.Name = "ICHeaderLbl";
            this.ICHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.ICHeaderLbl.TabIndex = 31;
            this.ICHeaderLbl.Text = "Header";
            // 
            // ICHeaderTxt
            // 
            this.ICHeaderTxt.Location = new System.Drawing.Point(8, 21);
            this.ICHeaderTxt.MaxLength = 4;
            this.ICHeaderTxt.Name = "ICHeaderTxt";
            this.ICHeaderTxt.Size = new System.Drawing.Size(67, 20);
            this.ICHeaderTxt.TabIndex = 30;
            this.ICHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICHeaderTxt.TextChanged += new System.EventHandler(this.ICHeaderTxt_TextChanged);
            // 
            // ICValueLbl
            // 
            this.ICValueLbl.AutoSize = true;
            this.ICValueLbl.Location = new System.Drawing.Point(78, 5);
            this.ICValueLbl.Name = "ICValueLbl";
            this.ICValueLbl.Size = new System.Drawing.Size(34, 13);
            this.ICValueLbl.TabIndex = 29;
            this.ICValueLbl.Text = "Value";
            // 
            // ICValueTxt
            // 
            this.ICValueTxt.Location = new System.Drawing.Point(81, 21);
            this.ICValueTxt.Name = "ICValueTxt";
            this.ICValueTxt.Size = new System.Drawing.Size(241, 20);
            this.ICValueTxt.TabIndex = 28;
            this.ICValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ICValueTxt.TextChanged += new System.EventHandler(this.ICValueTxt_TextChanged);
            // 
            // PrimitiveTab
            // 
            this.PrimitiveTab.Controls.Add(this.IPInsertBooleanBtn);
            this.PrimitiveTab.Controls.Add(this.IPInsertStringBtn);
            this.PrimitiveTab.Controls.Add(this.IPInsertIntegerBtn);
            this.PrimitiveTab.Controls.Add(this.IPInserHeaderBtn);
            this.PrimitiveTab.Controls.Add(this.IPIsCorruptedLbl);
            this.PrimitiveTab.Controls.Add(this.IPPacketInfoLbl);
            this.PrimitiveTab.Controls.Add(this.IPPrimitiveTxt);
            this.PrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.PrimitiveTab.Name = "PrimitiveTab";
            this.PrimitiveTab.Size = new System.Drawing.Size(392, 268);
            this.PrimitiveTab.TabIndex = 1;
            this.PrimitiveTab.Text = "Primitive";
            this.PrimitiveTab.UseVisualStyleBackColor = true;
            // 
            // IPInsertBooleanBtn
            // 
            this.IPInsertBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPInsertBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.IPInsertBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IPInsertBooleanBtn.Location = new System.Drawing.Point(309, 21);
            this.IPInsertBooleanBtn.Name = "IPInsertBooleanBtn";
            this.IPInsertBooleanBtn.Size = new System.Drawing.Size(77, 22);
            this.IPInsertBooleanBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IPInsertBooleanBtn.TabIndex = 12;
            this.IPInsertBooleanBtn.Text = "+ Boolean";
            this.IPInsertBooleanBtn.Click += new System.EventHandler(this.IPInsertBooleanBtn_Click);
            // 
            // IPInsertStringBtn
            // 
            this.IPInsertStringBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPInsertStringBtn.BackColor = System.Drawing.Color.Transparent;
            this.IPInsertStringBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IPInsertStringBtn.Location = new System.Drawing.Point(228, 21);
            this.IPInsertStringBtn.Name = "IPInsertStringBtn";
            this.IPInsertStringBtn.Size = new System.Drawing.Size(75, 22);
            this.IPInsertStringBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IPInsertStringBtn.TabIndex = 11;
            this.IPInsertStringBtn.Text = "+ String";
            this.IPInsertStringBtn.Click += new System.EventHandler(this.IPInsertStringBtn_Click);
            // 
            // IPInsertIntegerBtn
            // 
            this.IPInsertIntegerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPInsertIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.IPInsertIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IPInsertIntegerBtn.Location = new System.Drawing.Point(147, 21);
            this.IPInsertIntegerBtn.Name = "IPInsertIntegerBtn";
            this.IPInsertIntegerBtn.Size = new System.Drawing.Size(75, 22);
            this.IPInsertIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IPInsertIntegerBtn.TabIndex = 10;
            this.IPInsertIntegerBtn.Text = "+ Integer";
            this.IPInsertIntegerBtn.Click += new System.EventHandler(this.IPInsertIntegerBtn_Click);
            // 
            // IPInserHeaderBtn
            // 
            this.IPInserHeaderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IPInserHeaderBtn.BackColor = System.Drawing.Color.Transparent;
            this.IPInserHeaderBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.IPInserHeaderBtn.Location = new System.Drawing.Point(10, 21);
            this.IPInserHeaderBtn.Name = "IPInserHeaderBtn";
            this.IPInserHeaderBtn.Size = new System.Drawing.Size(131, 22);
            this.IPInserHeaderBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.IPInserHeaderBtn.TabIndex = 9;
            this.IPInserHeaderBtn.Text = "Insert Length & Header";
            this.IPInserHeaderBtn.Click += new System.EventHandler(this.IPInserHeaderBtn_Click);
            // 
            // IPIsCorruptedLbl
            // 
            this.IPIsCorruptedLbl.AutoSize = true;
            this.IPIsCorruptedLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.IPIsCorruptedLbl.Location = new System.Drawing.Point(166, 5);
            this.IPIsCorruptedLbl.Name = "IPIsCorruptedLbl";
            this.IPIsCorruptedLbl.Size = new System.Drawing.Size(29, 13);
            this.IPIsCorruptedLbl.TabIndex = 5;
            this.IPIsCorruptedLbl.Text = "True";
            // 
            // IPPacketInfoLbl
            // 
            this.IPPacketInfoLbl.AutoSize = true;
            this.IPPacketInfoLbl.Location = new System.Drawing.Point(7, 5);
            this.IPPacketInfoLbl.Name = "IPPacketInfoLbl";
            this.IPPacketInfoLbl.Size = new System.Drawing.Size(164, 13);
            this.IPPacketInfoLbl.TabIndex = 4;
            this.IPPacketInfoLbl.Text = "Header: 0 | Length: 0 | Corrupted:";
            // 
            // IPPrimitiveTxt
            // 
            this.IPPrimitiveTxt.Location = new System.Drawing.Point(7, 48);
            this.IPPrimitiveTxt.MaxLength = 2147483647;
            this.IPPrimitiveTxt.Multiline = true;
            this.IPPrimitiveTxt.Name = "IPPrimitiveTxt";
            this.IPPrimitiveTxt.Size = new System.Drawing.Size(379, 216);
            this.IPPrimitiveTxt.TabIndex = 3;
            this.IPPrimitiveTxt.TextChanged += new System.EventHandler(this.IPPrimitiveTxt_TextChanged);
            this.IPPrimitiveTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPPrimitiveTxt_KeyDown);
            // 
            // SchedulerTab
            // 
            this.SchedulerTab.Controls.Add(this.ISClearBtn);
            this.SchedulerTab.Controls.Add(this.ISStopAllBtn);
            this.SchedulerTab.Controls.Add(this.ISStartAllBtn);
            this.SchedulerTab.Controls.Add(this.ISRemoveBtn);
            this.SchedulerTab.Controls.Add(this.ISCreateBtn);
            this.SchedulerTab.Controls.Add(this.ISAutoStartChckbx);
            this.SchedulerTab.Controls.Add(this.ISBurstLbl);
            this.SchedulerTab.Controls.Add(this.ISBurstTxt);
            this.SchedulerTab.Controls.Add(this.ISIntervalLbl);
            this.SchedulerTab.Controls.Add(this.ISIntervalTxt);
            this.SchedulerTab.Controls.Add(this.ISDestinationLbl);
            this.SchedulerTab.Controls.Add(this.ISDestinationTxt);
            this.SchedulerTab.Controls.Add(this.ISPacketLbl);
            this.SchedulerTab.Controls.Add(this.ISPacketTxt);
            this.SchedulerTab.Controls.Add(this.ISDescriptionLbl);
            this.SchedulerTab.Controls.Add(this.ISDescriptionTxt);
            this.SchedulerTab.Controls.Add(this.ISSchedulerVw);
            this.SchedulerTab.Location = new System.Drawing.Point(4, 4);
            this.SchedulerTab.Name = "SchedulerTab";
            this.SchedulerTab.Padding = new System.Windows.Forms.Padding(3);
            this.SchedulerTab.Size = new System.Drawing.Size(392, 268);
            this.SchedulerTab.TabIndex = 0;
            this.SchedulerTab.Text = "Scheduler";
            this.SchedulerTab.UseVisualStyleBackColor = true;
            // 
            // ISClearBtn
            // 
            this.ISClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISClearBtn.Enabled = false;
            this.ISClearBtn.Location = new System.Drawing.Point(158, 240);
            this.ISClearBtn.Name = "ISClearBtn";
            this.ISClearBtn.Size = new System.Drawing.Size(76, 22);
            this.ISClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISClearBtn.TabIndex = 58;
            this.ISClearBtn.Text = "Clear";
            // 
            // ISStopAllBtn
            // 
            this.ISStopAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISStopAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISStopAllBtn.Enabled = false;
            this.ISStopAllBtn.Location = new System.Drawing.Point(82, 240);
            this.ISStopAllBtn.Name = "ISStopAllBtn";
            this.ISStopAllBtn.Size = new System.Drawing.Size(70, 22);
            this.ISStopAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISStopAllBtn.TabIndex = 56;
            this.ISStopAllBtn.Text = "Stop All";
            // 
            // ISStartAllBtn
            // 
            this.ISStartAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISStartAllBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISStartAllBtn.Enabled = false;
            this.ISStartAllBtn.Location = new System.Drawing.Point(6, 240);
            this.ISStartAllBtn.Name = "ISStartAllBtn";
            this.ISStartAllBtn.Size = new System.Drawing.Size(70, 22);
            this.ISStartAllBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISStartAllBtn.TabIndex = 57;
            this.ISStartAllBtn.Text = "Start All";
            // 
            // ISRemoveBtn
            // 
            this.ISRemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISRemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISRemoveBtn.Enabled = false;
            this.ISRemoveBtn.Location = new System.Drawing.Point(240, 240);
            this.ISRemoveBtn.Name = "ISRemoveBtn";
            this.ISRemoveBtn.Size = new System.Drawing.Size(70, 22);
            this.ISRemoveBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISRemoveBtn.TabIndex = 55;
            this.ISRemoveBtn.Text = "Remove";
            // 
            // ISCreateBtn
            // 
            this.ISCreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.ISCreateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ISCreateBtn.Location = new System.Drawing.Point(316, 240);
            this.ISCreateBtn.Name = "ISCreateBtn";
            this.ISCreateBtn.Size = new System.Drawing.Size(70, 22);
            this.ISCreateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ISCreateBtn.TabIndex = 54;
            this.ISCreateBtn.Text = "Create";
            // 
            // ISAutoStartChckbx
            // 
            this.ISAutoStartChckbx.AutoSize = true;
            this.ISAutoStartChckbx.Checked = true;
            this.ISAutoStartChckbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ISAutoStartChckbx.Location = new System.Drawing.Point(244, 158);
            this.ISAutoStartChckbx.Name = "ISAutoStartChckbx";
            this.ISAutoStartChckbx.Size = new System.Drawing.Size(73, 17);
            this.ISAutoStartChckbx.TabIndex = 53;
            this.ISAutoStartChckbx.Text = "Auto Start";
            this.ISAutoStartChckbx.UseVisualStyleBackColor = true;
            // 
            // ISBurstLbl
            // 
            this.ISBurstLbl.AutoSize = true;
            this.ISBurstLbl.Location = new System.Drawing.Point(313, 198);
            this.ISBurstLbl.Name = "ISBurstLbl";
            this.ISBurstLbl.Size = new System.Drawing.Size(31, 13);
            this.ISBurstLbl.TabIndex = 52;
            this.ISBurstLbl.Text = "Burst";
            // 
            // ISBurstTxt
            // 
            this.ISBurstTxt.Location = new System.Drawing.Point(316, 214);
            this.ISBurstTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ISBurstTxt.Name = "ISBurstTxt";
            this.ISBurstTxt.Size = new System.Drawing.Size(70, 20);
            this.ISBurstTxt.TabIndex = 51;
            this.ISBurstTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISBurstTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ISIntervalLbl
            // 
            this.ISIntervalLbl.AutoSize = true;
            this.ISIntervalLbl.Location = new System.Drawing.Point(313, 159);
            this.ISIntervalLbl.Name = "ISIntervalLbl";
            this.ISIntervalLbl.Size = new System.Drawing.Size(64, 13);
            this.ISIntervalLbl.TabIndex = 50;
            this.ISIntervalLbl.Text = "Interval (ms)";
            // 
            // ISIntervalTxt
            // 
            this.ISIntervalTxt.Location = new System.Drawing.Point(316, 175);
            this.ISIntervalTxt.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.ISIntervalTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ISIntervalTxt.Name = "ISIntervalTxt";
            this.ISIntervalTxt.Size = new System.Drawing.Size(70, 20);
            this.ISIntervalTxt.TabIndex = 49;
            this.ISIntervalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ISIntervalTxt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ISDestinationLbl
            // 
            this.ISDestinationLbl.AutoSize = true;
            this.ISDestinationLbl.Location = new System.Drawing.Point(237, 197);
            this.ISDestinationLbl.Name = "ISDestinationLbl";
            this.ISDestinationLbl.Size = new System.Drawing.Size(60, 13);
            this.ISDestinationLbl.TabIndex = 48;
            this.ISDestinationLbl.Text = "Destination";
            // 
            // ISDestinationTxt
            // 
            this.ISDestinationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ISDestinationTxt.FormattingEnabled = true;
            this.ISDestinationTxt.Items.AddRange(new object[] {
            "Client",
            "Server"});
            this.ISDestinationTxt.Location = new System.Drawing.Point(240, 213);
            this.ISDestinationTxt.Name = "ISDestinationTxt";
            this.ISDestinationTxt.Size = new System.Drawing.Size(70, 21);
            this.ISDestinationTxt.TabIndex = 47;
            // 
            // ISPacketLbl
            // 
            this.ISPacketLbl.AutoSize = true;
            this.ISPacketLbl.Location = new System.Drawing.Point(3, 159);
            this.ISPacketLbl.Name = "ISPacketLbl";
            this.ISPacketLbl.Size = new System.Drawing.Size(41, 13);
            this.ISPacketLbl.TabIndex = 46;
            this.ISPacketLbl.Text = "Packet";
            // 
            // ISPacketTxt
            // 
            this.ISPacketTxt.Location = new System.Drawing.Point(6, 175);
            this.ISPacketTxt.MaxLength = 2147483647;
            this.ISPacketTxt.Name = "ISPacketTxt";
            this.ISPacketTxt.Size = new System.Drawing.Size(304, 20);
            this.ISPacketTxt.TabIndex = 45;
            // 
            // ISDescriptionLbl
            // 
            this.ISDescriptionLbl.AutoSize = true;
            this.ISDescriptionLbl.Location = new System.Drawing.Point(3, 198);
            this.ISDescriptionLbl.Name = "ISDescriptionLbl";
            this.ISDescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.ISDescriptionLbl.TabIndex = 44;
            this.ISDescriptionLbl.Text = "Description";
            // 
            // ISDescriptionTxt
            // 
            this.ISDescriptionTxt.Location = new System.Drawing.Point(6, 214);
            this.ISDescriptionTxt.Name = "ISDescriptionTxt";
            this.ISDescriptionTxt.Size = new System.Drawing.Size(228, 20);
            this.ISDescriptionTxt.TabIndex = 43;
            // 
            // ISSchedulerVw
            // 
            this.ISSchedulerVw.CheckBoxes = true;
            this.ISSchedulerVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STPacketCol,
            this.STDestinationCol,
            this.STBurstCol,
            this.STIntervalCol,
            this.STStatusCol});
            this.ISSchedulerVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.ISSchedulerVw.FullRowSelect = true;
            this.ISSchedulerVw.GridLines = true;
            this.ISSchedulerVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ISSchedulerVw.HideSelection = false;
            this.ISSchedulerVw.Location = new System.Drawing.Point(3, 3);
            this.ISSchedulerVw.MultiSelect = false;
            this.ISSchedulerVw.Name = "ISSchedulerVw";
            this.ISSchedulerVw.ShowItemToolTips = true;
            this.ISSchedulerVw.Size = new System.Drawing.Size(386, 153);
            this.ISSchedulerVw.TabIndex = 0;
            this.ISSchedulerVw.UseCompatibleStateImageBehavior = false;
            this.ISSchedulerVw.View = System.Windows.Forms.View.Details;
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
            this.STStatusCol.Width = 52;
            // 
            // EncoderDecoderTab
            // 
            this.EncoderDecoderTab.Controls.Add(this.EDExtracterLstvw);
            this.EncoderDecoderTab.Controls.Add(this.EDExtractValuesBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodedBlocksLbl);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodedBlocksTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDMiddleGlowPnl);
            this.EncoderDecoderTab.Controls.Add(this.EDShortOutputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDIntegerOutputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDShortInputTxt);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodeShortBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDEncodeIntegerBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDDecodeShortBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDDecodeIntegerBtn);
            this.EncoderDecoderTab.Controls.Add(this.EDIntegerInputTxt);
            this.EncoderDecoderTab.Location = new System.Drawing.Point(4, 28);
            this.EncoderDecoderTab.Name = "EncoderDecoderTab";
            this.EncoderDecoderTab.Size = new System.Drawing.Size(471, 313);
            this.EncoderDecoderTab.TabIndex = 3;
            this.EncoderDecoderTab.Text = "Encoder/Decoder";
            this.EncoderDecoderTab.UseVisualStyleBackColor = true;
            // 
            // EDExtracterLstvw
            // 
            this.EDExtracterLstvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ValueCol,
            this.EncodedCol,
            this.PositionCol});
            this.EDExtracterLstvw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EDExtracterLstvw.Enabled = false;
            this.EDExtracterLstvw.FullRowSelect = true;
            this.EDExtracterLstvw.GridLines = true;
            this.EDExtracterLstvw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EDExtracterLstvw.HideSelection = false;
            this.EDExtracterLstvw.Location = new System.Drawing.Point(0, 102);
            this.EDExtracterLstvw.MultiSelect = false;
            this.EDExtracterLstvw.Name = "EDExtracterLstvw";
            this.EDExtracterLstvw.ShowItemToolTips = true;
            this.EDExtracterLstvw.Size = new System.Drawing.Size(471, 211);
            this.EDExtracterLstvw.TabIndex = 43;
            this.EDExtracterLstvw.UseCompatibleStateImageBehavior = false;
            this.EDExtracterLstvw.View = System.Windows.Forms.View.Details;
            // 
            // ValueCol
            // 
            this.ValueCol.Text = "Value";
            this.ValueCol.Width = 84;
            // 
            // EncodedCol
            // 
            this.EncodedCol.Text = "Encoded";
            this.EncodedCol.Width = 109;
            // 
            // PositionCol
            // 
            this.PositionCol.Text = "Position";
            this.PositionCol.Width = 71;
            // 
            // EDExtractValuesBtn
            // 
            this.EDExtractValuesBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDExtractValuesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDExtractValuesBtn.Enabled = false;
            this.EDExtractValuesBtn.Location = new System.Drawing.Point(365, 68);
            this.EDExtractValuesBtn.Name = "EDExtractValuesBtn";
            this.EDExtractValuesBtn.Size = new System.Drawing.Size(100, 22);
            this.EDExtractValuesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDExtractValuesBtn.TabIndex = 42;
            this.EDExtractValuesBtn.Text = "Extract Values";
            // 
            // EDEncodedBlocksLbl
            // 
            this.EDEncodedBlocksLbl.AutoSize = true;
            this.EDEncodedBlocksLbl.Location = new System.Drawing.Point(4, 72);
            this.EDEncodedBlocksLbl.Name = "EDEncodedBlocksLbl";
            this.EDEncodedBlocksLbl.Size = new System.Drawing.Size(94, 13);
            this.EDEncodedBlocksLbl.TabIndex = 40;
            this.EDEncodedBlocksLbl.Text = "Encoded Block(s):";
            // 
            // EDEncodedBlocksTxt
            // 
            this.EDEncodedBlocksTxt.Enabled = false;
            this.EDEncodedBlocksTxt.Location = new System.Drawing.Point(98, 69);
            this.EDEncodedBlocksTxt.Name = "EDEncodedBlocksTxt";
            this.EDEncodedBlocksTxt.Size = new System.Drawing.Size(261, 20);
            this.EDEncodedBlocksTxt.TabIndex = 41;
            this.EDEncodedBlocksTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDMiddleGlowPnl
            // 
            this.EDMiddleGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDMiddleGlowPnl.Location = new System.Drawing.Point(6, 61);
            this.EDMiddleGlowPnl.Name = "EDMiddleGlowPnl";
            this.EDMiddleGlowPnl.Size = new System.Drawing.Size(459, 1);
            this.EDMiddleGlowPnl.TabIndex = 39;
            // 
            // EDShortOutputTxt
            // 
            this.EDShortOutputTxt.Location = new System.Drawing.Point(239, 33);
            this.EDShortOutputTxt.Name = "EDShortOutputTxt";
            this.EDShortOutputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDShortOutputTxt.TabIndex = 38;
            this.EDShortOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDIntegerOutputTxt
            // 
            this.EDIntegerOutputTxt.Location = new System.Drawing.Point(239, 5);
            this.EDIntegerOutputTxt.Name = "EDIntegerOutputTxt";
            this.EDIntegerOutputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDIntegerOutputTxt.TabIndex = 37;
            this.EDIntegerOutputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDShortInputTxt
            // 
            this.EDShortInputTxt.Location = new System.Drawing.Point(110, 33);
            this.EDShortInputTxt.Name = "EDShortInputTxt";
            this.EDShortInputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDShortInputTxt.TabIndex = 36;
            this.EDShortInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EDEncodeShortBtn
            // 
            this.EDEncodeShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDEncodeShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDEncodeShortBtn.Location = new System.Drawing.Point(6, 32);
            this.EDEncodeShortBtn.Name = "EDEncodeShortBtn";
            this.EDEncodeShortBtn.Size = new System.Drawing.Size(98, 23);
            this.EDEncodeShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDEncodeShortBtn.TabIndex = 33;
            this.EDEncodeShortBtn.Text = "Encode Short";
            this.EDEncodeShortBtn.Click += new System.EventHandler(this.EDEncodeShortBtn_Click);
            // 
            // EDEncodeIntegerBtn
            // 
            this.EDEncodeIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDEncodeIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDEncodeIntegerBtn.Location = new System.Drawing.Point(6, 3);
            this.EDEncodeIntegerBtn.Name = "EDEncodeIntegerBtn";
            this.EDEncodeIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.EDEncodeIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDEncodeIntegerBtn.TabIndex = 32;
            this.EDEncodeIntegerBtn.Text = "Encode Integer";
            this.EDEncodeIntegerBtn.Click += new System.EventHandler(this.EDEncodeIntegerBtn_Click);
            // 
            // EDDecodeShortBtn
            // 
            this.EDDecodeShortBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDDecodeShortBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDDecodeShortBtn.Location = new System.Drawing.Point(367, 32);
            this.EDDecodeShortBtn.Name = "EDDecodeShortBtn";
            this.EDDecodeShortBtn.Size = new System.Drawing.Size(98, 23);
            this.EDDecodeShortBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDDecodeShortBtn.TabIndex = 35;
            this.EDDecodeShortBtn.Text = "Decode Short";
            this.EDDecodeShortBtn.Click += new System.EventHandler(this.EDDecodeShortBtn_Click);
            // 
            // EDDecodeIntegerBtn
            // 
            this.EDDecodeIntegerBtn.BackColor = System.Drawing.Color.Transparent;
            this.EDDecodeIntegerBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EDDecodeIntegerBtn.Location = new System.Drawing.Point(367, 3);
            this.EDDecodeIntegerBtn.Name = "EDDecodeIntegerBtn";
            this.EDDecodeIntegerBtn.Size = new System.Drawing.Size(98, 23);
            this.EDDecodeIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.EDDecodeIntegerBtn.TabIndex = 34;
            this.EDDecodeIntegerBtn.Text = "Decode Integer";
            this.EDDecodeIntegerBtn.Click += new System.EventHandler(this.EDDecodeIntegerBtn_Click);
            // 
            // EDIntegerInputTxt
            // 
            this.EDIntegerInputTxt.Location = new System.Drawing.Point(110, 5);
            this.EDIntegerInputTxt.Name = "EDIntegerInputTxt";
            this.EDIntegerInputTxt.Size = new System.Drawing.Size(122, 20);
            this.EDIntegerInputTxt.TabIndex = 31;
            this.EDIntegerInputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExtensionsTab
            // 
            this.ExtensionsTab.Controls.Add(this.ETExtensionAOTChckbx);
            this.ExtensionsTab.Controls.Add(this.ETUninstallExtensionBtn);
            this.ExtensionsTab.Controls.Add(this.ContractorVw);
            this.ExtensionsTab.Controls.Add(this.ETInstallExtensionBtn);
            this.ExtensionsTab.Location = new System.Drawing.Point(4, 28);
            this.ExtensionsTab.Name = "ExtensionsTab";
            this.ExtensionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExtensionsTab.Size = new System.Drawing.Size(471, 313);
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
            this.ETUninstallExtensionBtn.Location = new System.Drawing.Point(213, 285);
            this.ETUninstallExtensionBtn.Name = "ETUninstallExtensionBtn";
            this.ETUninstallExtensionBtn.Size = new System.Drawing.Size(123, 22);
            this.ETUninstallExtensionBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ETUninstallExtensionBtn.TabIndex = 2;
            this.ETUninstallExtensionBtn.Text = "Uninstall Extension";
            // 
            // ContractorVw
            // 
            this.ContractorVw.AutoOpen = false;
            this.ContractorVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ETIdentifierCol,
            this.ETCreatorCol,
            this.ETDescriptionCol,
            this.ETVersionCol,
            this.ETStatusCol});
            this.ContractorVw.ContextMenuStrip = this.ETExtensionMenu;
            this.ContractorVw.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContractorVw.FullRowSelect = true;
            this.ContractorVw.GridLines = true;
            this.ContractorVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ContractorVw.HideSelection = false;
            this.ContractorVw.Location = new System.Drawing.Point(3, 3);
            this.ContractorVw.MultiSelect = false;
            this.ContractorVw.Name = "ContractorVw";
            this.ContractorVw.ShowItemToolTips = true;
            this.ContractorVw.Size = new System.Drawing.Size(465, 276);
            this.ContractorVw.TabIndex = 0;
            this.ContractorVw.UseCompatibleStateImageBehavior = false;
            this.ContractorVw.View = System.Windows.Forms.View.Details;
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
            // ETExtensionMenu
            // 
            this.ETExtensionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ETOpenMenuBtn,
            this.ETUninstallMenuBtn,
            this.ETMenuSplitter,
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
            // ETMenuSplitter
            // 
            this.ETMenuSplitter.Name = "ETMenuSplitter";
            this.ETMenuSplitter.Size = new System.Drawing.Size(155, 6);
            // 
            // ETInstallMenuBtn
            // 
            this.ETInstallMenuBtn.Name = "ETInstallMenuBtn";
            this.ETInstallMenuBtn.Size = new System.Drawing.Size(158, 22);
            this.ETInstallMenuBtn.Text = "Install Extension";
            // 
            // ETInstallExtensionBtn
            // 
            this.ETInstallExtensionBtn.BackColor = System.Drawing.Color.Transparent;
            this.ETInstallExtensionBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ETInstallExtensionBtn.Location = new System.Drawing.Point(342, 285);
            this.ETInstallExtensionBtn.Name = "ETInstallExtensionBtn";
            this.ETInstallExtensionBtn.Size = new System.Drawing.Size(123, 22);
            this.ETInstallExtensionBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ETInstallExtensionBtn.TabIndex = 1;
            this.ETInstallExtensionBtn.Text = "Install Extension";
            // 
            // ICTypeCol
            // 
            this.ICTypeCol.Text = "Type";
            this.ICTypeCol.Width = 72;
            // 
            // ICValueCol
            // 
            this.ICValueCol.Text = "Value";
            this.ICValueCol.Width = 137;
            // 
            // ICEncodedCol
            // 
            this.ICEncodedCol.Text = "Encoded";
            this.ICEncodedCol.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Encoded";
            this.columnHeader3.Width = 150;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 369);
            this.Controls.Add(this.TanjiTabs);
            this.Controls.Add(this.TanjiStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Connected[Host:Port]";
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.TanjiTabs.ResumeLayout(false);
            this.InjectionTab.ResumeLayout(false);
            this.InjectionTab.PerformLayout();
            this.InjectionTabs.ResumeLayout(false);
            this.ConstructerTab.ResumeLayout(false);
            this.ConstructerTab.PerformLayout();
            this.ICConstructMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICCountTxt)).EndInit();
            this.PrimitiveTab.ResumeLayout(false);
            this.PrimitiveTab.PerformLayout();
            this.SchedulerTab.ResumeLayout(false);
            this.SchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).EndInit();
            this.EncoderDecoderTab.ResumeLayout(false);
            this.EncoderDecoderTab.PerformLayout();
            this.ExtensionsTab.ResumeLayout(false);
            this.ExtensionsTab.PerformLayout();
            this.ETExtensionMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip TanjiStrip;
        private System.Windows.Forms.ToolStripStatusLabel TanjiInfoTxt;
        private Sulakore.Components.SKoreTabControl TanjiTabs;
        private System.Windows.Forms.TabPage ExtensionsTab;
        private System.Windows.Forms.ColumnHeader ETIdentifierCol;
        private System.Windows.Forms.ColumnHeader ETCreatorCol;
        private System.Windows.Forms.ColumnHeader ETDescriptionCol;
        private System.Windows.Forms.ColumnHeader ETVersionCol;
        private System.Windows.Forms.ColumnHeader ETStatusCol;
        public Sulakore.Components.SKoreButton ETInstallExtensionBtn;
        public Sulakore.Components.SKoreExtensionView ContractorVw;
        public System.Windows.Forms.ToolStripStatusLabel ExtensionsActiveTxt;
        public System.Windows.Forms.ToolStripStatusLabel TanjiVersionTxt;
        public Sulakore.Components.SKoreButton ETUninstallExtensionBtn;
        public System.Windows.Forms.CheckBox ETExtensionAOTChckbx;
        private System.Windows.Forms.ToolStripSeparator ETMenuSplitter;
        public System.Windows.Forms.ContextMenuStrip ETExtensionMenu;
        public System.Windows.Forms.ToolStripMenuItem ETOpenMenuBtn;
        public System.Windows.Forms.ToolStripMenuItem ETUninstallMenuBtn;
        public System.Windows.Forms.ToolStripMenuItem ETInstallMenuBtn;
        private System.Windows.Forms.TabPage InjectionTab;
        private Sulakore.Components.SKoreTabControl InjectionTabs;
        private System.Windows.Forms.TabPage SchedulerTab;
        private System.Windows.Forms.ColumnHeader STPacketCol;
        private System.Windows.Forms.ColumnHeader STDestinationCol;
        private System.Windows.Forms.ColumnHeader STBurstCol;
        private System.Windows.Forms.ColumnHeader STIntervalCol;
        private System.Windows.Forms.ColumnHeader STStatusCol;
        public Sulakore.Components.SKoreScheduleView ISSchedulerVw;
        public System.Windows.Forms.CheckBox ISAutoStartChckbx;
        public System.Windows.Forms.Label ISBurstLbl;
        public System.Windows.Forms.NumericUpDown ISBurstTxt;
        public System.Windows.Forms.Label ISIntervalLbl;
        public System.Windows.Forms.NumericUpDown ISIntervalTxt;
        public System.Windows.Forms.Label ISDestinationLbl;
        public System.Windows.Forms.ComboBox ISDestinationTxt;
        public System.Windows.Forms.Label ISPacketLbl;
        public System.Windows.Forms.TextBox ISPacketTxt;
        public System.Windows.Forms.Label ISDescriptionLbl;
        public System.Windows.Forms.TextBox ISDescriptionTxt;
        public System.Windows.Forms.TextBox IPacketTxt;
        public Sulakore.Components.SKoreButton ISendToClientBtn;
        public Sulakore.Components.SKoreButton ISendToServerBtn;
        public Sulakore.Components.SKoreButton ISClearBtn;
        public Sulakore.Components.SKoreButton ISStopAllBtn;
        public Sulakore.Components.SKoreButton ISStartAllBtn;
        public Sulakore.Components.SKoreButton ISRemoveBtn;
        public Sulakore.Components.SKoreButton ISCreateBtn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage PrimitiveTab;
        public Sulakore.Components.SKoreButton IPInsertBooleanBtn;
        public Sulakore.Components.SKoreButton IPInsertStringBtn;
        public Sulakore.Components.SKoreButton IPInsertIntegerBtn;
        public Sulakore.Components.SKoreButton IPInserHeaderBtn;
        private System.Windows.Forms.Label IPIsCorruptedLbl;
        private System.Windows.Forms.Label IPPacketInfoLbl;
        private System.Windows.Forms.TextBox IPPrimitiveTxt;
        private System.Windows.Forms.TabPage ConstructerTab;
        private System.Windows.Forms.Panel ICChunksRightGlowPnl;
        private System.Windows.Forms.Panel ICChunksLeftGlowPnl;
        private System.Windows.Forms.Label ICChunkCountLbl;
        private System.Windows.Forms.NumericUpDown ICCountTxt;
        private System.Windows.Forms.Label ICCountLbl;
        private Sulakore.Components.SKoreButton ICRemoveBtn;
        private Sulakore.Components.SKoreButton ICMoveDownBtn;
        private Sulakore.Components.SKoreButton ICMoveUpBtn;
        private Sulakore.Components.SKoreButton ICClearBtn;
        private Sulakore.Components.SKoreButton ICAppendBooleanBtn;
        private Sulakore.Components.SKoreButton ICAppendStringBtn;
        private Sulakore.Components.SKoreButton ICAppendIntegerBtn;
        private System.Windows.Forms.Label ICHeaderLbl;
        private System.Windows.Forms.TextBox ICHeaderTxt;
        private System.Windows.Forms.Label ICValueLbl;
        private System.Windows.Forms.TextBox ICValueTxt;
        private System.Windows.Forms.TabPage EncoderDecoderTab;
        private System.Windows.Forms.ColumnHeader ICTypeCol;
        private System.Windows.Forms.ColumnHeader ICValueCol;
        private System.Windows.Forms.ColumnHeader ICEncodedCol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Sulakore.Components.SKoreListView EDExtracterLstvw;
        private System.Windows.Forms.ColumnHeader ValueCol;
        private System.Windows.Forms.ColumnHeader EncodedCol;
        private System.Windows.Forms.ColumnHeader PositionCol;
        private Sulakore.Components.SKoreButton EDExtractValuesBtn;
        private System.Windows.Forms.Label EDEncodedBlocksLbl;
        private System.Windows.Forms.TextBox EDEncodedBlocksTxt;
        private System.Windows.Forms.Panel EDMiddleGlowPnl;
        private System.Windows.Forms.TextBox EDShortOutputTxt;
        private System.Windows.Forms.TextBox EDIntegerOutputTxt;
        private System.Windows.Forms.TextBox EDShortInputTxt;
        private Sulakore.Components.SKoreButton EDEncodeShortBtn;
        private Sulakore.Components.SKoreButton EDEncodeIntegerBtn;
        private Sulakore.Components.SKoreButton EDDecodeShortBtn;
        private Sulakore.Components.SKoreButton EDDecodeIntegerBtn;
        private System.Windows.Forms.TextBox EDIntegerInputTxt;
        private Sulakore.Components.SKoreConstructView ICConstructerLstvw;
        private System.Windows.Forms.ColumnHeader ICSTypeCol;
        private System.Windows.Forms.ColumnHeader ICSValueCol;
        private System.Windows.Forms.ColumnHeader ICSEncodedCol;
        private System.Windows.Forms.ContextMenuStrip ICConstructMenu;
        private System.Windows.Forms.ToolStripMenuItem ICCopyPacketBtn;
        private System.Windows.Forms.ToolStripMenuItem ICTransferToBtn;
        private System.Windows.Forms.ToolStripMenuItem ICSchedulerBtn;
        private System.Windows.Forms.ToolStripMenuItem ICPrimitiveBtn;
        private System.Windows.Forms.ToolStripSeparator ICTransferSeparator;
        private System.Windows.Forms.ToolStripMenuItem ICInjectionBtn;
    }
}