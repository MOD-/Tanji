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
            this.SchedulesActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExtensionsActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.ITSendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ITSendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
            this.ConstructerTab = new System.Windows.Forms.TabPage();
            this.CTLiveEditingChckbx = new System.Windows.Forms.CheckBox();
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
            this.CTHeaderLbl = new System.Windows.Forms.Label();
            this.CTHeaderTxt = new System.Windows.Forms.TextBox();
            this.CTValueLbl = new System.Windows.Forms.Label();
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
            this.PrimitiveTab = new System.Windows.Forms.TabPage();
            this.PTIsCorruptedLbl = new System.Windows.Forms.Label();
            this.PTPacketInfoLbl = new System.Windows.Forms.Label();
            this.PTPacketTxt = new System.Windows.Forms.TextBox();
            this.PTPrimitiveMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PTInsertParameterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTIntegerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTStringBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTBooleanBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTLengthHeaderBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTMenuSeparatorTop = new System.Windows.Forms.ToolStripSeparator();
            this.PTCutBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTCopyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTPasteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PTSelectAllBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ITPacketTxt = new System.Windows.Forms.ComboBox();
            this.EncoderDecoderTab = new System.Windows.Forms.TabPage();
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
            this.EDExtracterLstvw = new Sulakore.Components.SKoreListView();
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncodedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.PTMenuSeperatorBottom = new System.Windows.Forms.ToolStripSeparator();
            this.PTUndoBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TanjiStrip.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.ConstructerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTCountTxt)).BeginInit();
            this.SchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).BeginInit();
            this.PrimitiveTab.SuspendLayout();
            this.PTPrimitiveMenu.SuspendLayout();
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
            this.SchedulesActiveTxt,
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
            this.InjectionTab.Controls.Add(this.ITSendToClientBtn);
            this.InjectionTab.Controls.Add(this.ITSendToServerBtn);
            this.InjectionTab.Controls.Add(this.InjectionTabs);
            this.InjectionTab.Controls.Add(this.ITPacketTxt);
            this.InjectionTab.Location = new System.Drawing.Point(4, 28);
            this.InjectionTab.Name = "InjectionTab";
            this.InjectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.InjectionTab.Size = new System.Drawing.Size(471, 313);
            this.InjectionTab.TabIndex = 2;
            this.InjectionTab.Text = "Injection";
            this.InjectionTab.UseVisualStyleBackColor = true;
            // 
            // ITSendToClientBtn
            // 
            this.ITSendToClientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ITSendToClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.ITSendToClientBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ITSendToClientBtn.Location = new System.Drawing.Point(259, 285);
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
            this.ITSendToServerBtn.Location = new System.Drawing.Point(365, 285);
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
            // 
            // ConstructerTab
            // 
            this.ConstructerTab.Controls.Add(this.CTLiveEditingChckbx);
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
            this.ConstructerTab.Controls.Add(this.CTHeaderLbl);
            this.ConstructerTab.Controls.Add(this.CTHeaderTxt);
            this.ConstructerTab.Controls.Add(this.CTValueLbl);
            this.ConstructerTab.Location = new System.Drawing.Point(4, 4);
            this.ConstructerTab.Name = "ConstructerTab";
            this.ConstructerTab.Size = new System.Drawing.Size(392, 268);
            this.ConstructerTab.TabIndex = 2;
            this.ConstructerTab.Text = "Constructer";
            this.ConstructerTab.UseVisualStyleBackColor = true;
            // 
            // CTLiveEditingChckbx
            // 
            this.CTLiveEditingChckbx.AutoSize = true;
            this.CTLiveEditingChckbx.Enabled = false;
            this.CTLiveEditingChckbx.Location = new System.Drawing.Point(213, 2);
            this.CTLiveEditingChckbx.Name = "CTLiveEditingChckbx";
            this.CTLiveEditingChckbx.Size = new System.Drawing.Size(114, 17);
            this.CTLiveEditingChckbx.TabIndex = 47;
            this.CTLiveEditingChckbx.Text = "Update On {Enter}";
            this.CTLiveEditingChckbx.UseVisualStyleBackColor = true;
            // 
            // CTValueTxt
            // 
            this.CTValueTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CTValueTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CTValueTxt.IntegralHeight = false;
            this.CTValueTxt.ItemHeight = 13;
            this.CTValueTxt.Location = new System.Drawing.Point(80, 19);
            this.CTValueTxt.Name = "CTValueTxt";
            this.CTValueTxt.Size = new System.Drawing.Size(240, 21);
            this.CTValueTxt.TabIndex = 28;
            // 
            // CTCountLbl
            // 
            this.CTCountLbl.AutoSize = true;
            this.CTCountLbl.Location = new System.Drawing.Point(324, 3);
            this.CTCountLbl.Name = "CTCountLbl";
            this.CTCountLbl.Size = new System.Drawing.Size(35, 13);
            this.CTCountLbl.TabIndex = 39;
            this.CTCountLbl.Text = "Count";
            // 
            // CTPacketTxt
            // 
            this.CTPacketTxt.Location = new System.Drawing.Point(128, 217);
            this.CTPacketTxt.Name = "CTPacketTxt";
            this.CTPacketTxt.ReadOnly = true;
            this.CTPacketTxt.Size = new System.Drawing.Size(258, 20);
            this.CTPacketTxt.TabIndex = 48;
            // 
            // CTTransferBelowBtn
            // 
            this.CTTransferBelowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTTransferBelowBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTTransferBelowBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTTransferBelowBtn.Location = new System.Drawing.Point(6, 243);
            this.CTTransferBelowBtn.Name = "CTTransferBelowBtn";
            this.CTTransferBelowBtn.Size = new System.Drawing.Size(116, 22);
            this.CTTransferBelowBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTTransferBelowBtn.TabIndex = 46;
            this.CTTransferBelowBtn.Text = "Transfer Below";
            // 
            // CTChunkCountLbl
            // 
            this.CTChunkCountLbl.BorderWidth = 1;
            this.CTChunkCountLbl.DisplayBoundary = true;
            this.CTChunkCountLbl.Location = new System.Drawing.Point(6, 217);
            this.CTChunkCountLbl.Name = "CTChunkCountLbl";
            this.CTChunkCountLbl.Size = new System.Drawing.Size(116, 20);
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
            this.CTConstructerVw.Location = new System.Drawing.Point(6, 73);
            this.CTConstructerVw.MultiSelect = false;
            this.CTConstructerVw.Name = "CTConstructerVw";
            this.CTConstructerVw.ShowItemToolTips = true;
            this.CTConstructerVw.Size = new System.Drawing.Size(380, 136);
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
            this.CTCountTxt.Location = new System.Drawing.Point(326, 19);
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
            this.CTRemoveBtn.Location = new System.Drawing.Point(128, 243);
            this.CTRemoveBtn.Name = "CTRemoveBtn";
            this.CTRemoveBtn.Size = new System.Drawing.Size(82, 22);
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
            this.CTMoveDownBtn.Location = new System.Drawing.Point(304, 243);
            this.CTMoveDownBtn.Name = "CTMoveDownBtn";
            this.CTMoveDownBtn.Size = new System.Drawing.Size(82, 22);
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
            this.CTMoveUpBtn.Location = new System.Drawing.Point(216, 243);
            this.CTMoveUpBtn.Name = "CTMoveUpBtn";
            this.CTMoveUpBtn.Size = new System.Drawing.Size(82, 22);
            this.CTMoveUpBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTMoveUpBtn.TabIndex = 36;
            this.CTMoveUpBtn.Text = "Move Up";
            // 
            // CTClearBtn
            // 
            this.CTClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTClearBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTClearBtn.Location = new System.Drawing.Point(6, 45);
            this.CTClearBtn.Name = "CTClearBtn";
            this.CTClearBtn.Size = new System.Drawing.Size(68, 22);
            this.CTClearBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTClearBtn.TabIndex = 35;
            this.CTClearBtn.Text = "Clear";
            // 
            // CTAppendBooleanBtn
            // 
            this.CTAppendBooleanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTAppendBooleanBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTAppendBooleanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTAppendBooleanBtn.Location = new System.Drawing.Point(288, 45);
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
            this.CTAppendStringBtn.Location = new System.Drawing.Point(184, 45);
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
            this.CTAppendIntegerBtn.Location = new System.Drawing.Point(80, 45);
            this.CTAppendIntegerBtn.Name = "CTAppendIntegerBtn";
            this.CTAppendIntegerBtn.Size = new System.Drawing.Size(98, 22);
            this.CTAppendIntegerBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTAppendIntegerBtn.TabIndex = 32;
            this.CTAppendIntegerBtn.Text = "Append Integer";
            // 
            // CTHeaderLbl
            // 
            this.CTHeaderLbl.AutoSize = true;
            this.CTHeaderLbl.Location = new System.Drawing.Point(3, 3);
            this.CTHeaderLbl.Name = "CTHeaderLbl";
            this.CTHeaderLbl.Size = new System.Drawing.Size(42, 13);
            this.CTHeaderLbl.TabIndex = 31;
            this.CTHeaderLbl.Text = "Header";
            // 
            // CTHeaderTxt
            // 
            this.CTHeaderTxt.Location = new System.Drawing.Point(6, 19);
            this.CTHeaderTxt.MaxLength = 4;
            this.CTHeaderTxt.Name = "CTHeaderTxt";
            this.CTHeaderTxt.Size = new System.Drawing.Size(68, 20);
            this.CTHeaderTxt.TabIndex = 30;
            this.CTHeaderTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CTValueLbl
            // 
            this.CTValueLbl.AutoSize = true;
            this.CTValueLbl.Location = new System.Drawing.Point(78, 3);
            this.CTValueLbl.Name = "CTValueLbl";
            this.CTValueLbl.Size = new System.Drawing.Size(34, 13);
            this.CTValueLbl.TabIndex = 29;
            this.CTValueLbl.Text = "Value";
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
            // PrimitiveTab
            // 
            this.PrimitiveTab.Controls.Add(this.PTIsCorruptedLbl);
            this.PrimitiveTab.Controls.Add(this.PTPacketInfoLbl);
            this.PrimitiveTab.Controls.Add(this.PTPacketTxt);
            this.PrimitiveTab.Location = new System.Drawing.Point(4, 4);
            this.PrimitiveTab.Name = "PrimitiveTab";
            this.PrimitiveTab.Size = new System.Drawing.Size(392, 268);
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
            this.PTPacketTxt.ContextMenuStrip = this.PTPrimitiveMenu;
            this.PTPacketTxt.Location = new System.Drawing.Point(3, 19);
            this.PTPacketTxt.MaxLength = 2147483647;
            this.PTPacketTxt.Multiline = true;
            this.PTPacketTxt.Name = "PTPacketTxt";
            this.PTPacketTxt.Size = new System.Drawing.Size(386, 246);
            this.PTPacketTxt.TabIndex = 3;
            // 
            // PTPrimitiveMenu
            // 
            this.PTPrimitiveMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PTInsertParameterBtn,
            this.PTMenuSeparatorTop,
            this.PTCutBtn,
            this.PTCopyBtn,
            this.PTPasteBtn,
            this.PTMenuSeperatorBottom,
            this.PTUndoBtn,
            this.PTSelectAllBtn});
            this.PTPrimitiveMenu.Name = "ConstructMenu";
            this.PTPrimitiveMenu.Size = new System.Drawing.Size(165, 148);
            // 
            // PTInsertParameterBtn
            // 
            this.PTInsertParameterBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PTIntegerBtn,
            this.PTStringBtn,
            this.PTBooleanBtn,
            this.PTLengthHeaderBtn});
            this.PTInsertParameterBtn.Name = "PTInsertParameterBtn";
            this.PTInsertParameterBtn.Size = new System.Drawing.Size(164, 22);
            this.PTInsertParameterBtn.Text = "Insert Parameter";
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
            this.PTMenuSeparatorTop.Size = new System.Drawing.Size(161, 6);
            // 
            // PTCutBtn
            // 
            this.PTCutBtn.Name = "PTCutBtn";
            this.PTCutBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.PTCutBtn.Size = new System.Drawing.Size(164, 22);
            this.PTCutBtn.Text = "Cut";
            // 
            // PTCopyBtn
            // 
            this.PTCopyBtn.Name = "PTCopyBtn";
            this.PTCopyBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.PTCopyBtn.Size = new System.Drawing.Size(164, 22);
            this.PTCopyBtn.Text = "Copy";
            // 
            // PTPasteBtn
            // 
            this.PTPasteBtn.Name = "PTPasteBtn";
            this.PTPasteBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PTPasteBtn.Size = new System.Drawing.Size(164, 22);
            this.PTPasteBtn.Text = "Paste";
            // 
            // PTSelectAllBtn
            // 
            this.PTSelectAllBtn.Name = "PTSelectAllBtn";
            this.PTSelectAllBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.PTSelectAllBtn.Size = new System.Drawing.Size(164, 22);
            this.PTSelectAllBtn.Text = "Select All";
            // 
            // ITPacketTxt
            // 
            this.ITPacketTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ITPacketTxt.Location = new System.Drawing.Point(6, 286);
            this.ITPacketTxt.MaxLength = 2147483647;
            this.ITPacketTxt.Name = "ITPacketTxt";
            this.ITPacketTxt.Size = new System.Drawing.Size(247, 21);
            this.ITPacketTxt.TabIndex = 8;
            // 
            // EncoderDecoderTab
            // 
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
            this.EncoderDecoderTab.Controls.Add(this.EDExtracterLstvw);
            this.EncoderDecoderTab.Location = new System.Drawing.Point(4, 28);
            this.EncoderDecoderTab.Name = "EncoderDecoderTab";
            this.EncoderDecoderTab.Size = new System.Drawing.Size(471, 313);
            this.EncoderDecoderTab.TabIndex = 3;
            this.EncoderDecoderTab.Text = "Encoder/Decoder";
            this.EncoderDecoderTab.UseVisualStyleBackColor = true;
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
            this.EDExtracterLstvw.Location = new System.Drawing.Point(0, 96);
            this.EDExtracterLstvw.MultiSelect = false;
            this.EDExtracterLstvw.Name = "EDExtracterLstvw";
            this.EDExtracterLstvw.ShowItemToolTips = true;
            this.EDExtracterLstvw.Size = new System.Drawing.Size(471, 217);
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
            // PTMenuSeperatorBottom
            // 
            this.PTMenuSeperatorBottom.Name = "PTMenuSeperatorBottom";
            this.PTMenuSeperatorBottom.Size = new System.Drawing.Size(161, 6);
            // 
            // PTUndoBtn
            // 
            this.PTUndoBtn.Name = "PTUndoBtn";
            this.PTUndoBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.PTUndoBtn.Size = new System.Drawing.Size(164, 22);
            this.PTUndoBtn.Text = "Undo";
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
            this.InjectionTabs.ResumeLayout(false);
            this.ConstructerTab.ResumeLayout(false);
            this.ConstructerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTCountTxt)).EndInit();
            this.SchedulerTab.ResumeLayout(false);
            this.SchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).EndInit();
            this.PrimitiveTab.ResumeLayout(false);
            this.PrimitiveTab.PerformLayout();
            this.PTPrimitiveMenu.ResumeLayout(false);
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
        public System.Windows.Forms.ComboBox ITPacketTxt;
        public Sulakore.Components.SKoreButton ITSendToClientBtn;
        public Sulakore.Components.SKoreButton ITSendToServerBtn;
        public Sulakore.Components.SKoreButton ISClearBtn;
        public Sulakore.Components.SKoreButton ISStopAllBtn;
        public Sulakore.Components.SKoreButton ISStartAllBtn;
        public Sulakore.Components.SKoreButton ISRemoveBtn;
        public Sulakore.Components.SKoreButton ISCreateBtn;
        private System.Windows.Forms.ToolStripStatusLabel SchedulesActiveTxt;
        private System.Windows.Forms.TabPage ConstructerTab;
        private System.Windows.Forms.Label CTCountLbl;
        private System.Windows.Forms.Label CTHeaderLbl;
        private System.Windows.Forms.Label CTValueLbl;
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
        private System.Windows.Forms.ColumnHeader ICSTypeCol;
        private System.Windows.Forms.ColumnHeader ICSValueCol;
        private System.Windows.Forms.ColumnHeader ICSEncodedCol;
        private System.Windows.Forms.ContextMenuStrip PTPrimitiveMenu;
        public Sulakore.Components.SKoreTabControl InjectionTabs;
        public System.Windows.Forms.NumericUpDown CTCountTxt;
        public Sulakore.Components.SKoreButton CTRemoveBtn;
        public Sulakore.Components.SKoreButton CTMoveDownBtn;
        public Sulakore.Components.SKoreButton CTMoveUpBtn;
        public Sulakore.Components.SKoreButton CTClearBtn;
        public Sulakore.Components.SKoreButton CTAppendBooleanBtn;
        public Sulakore.Components.SKoreButton CTAppendStringBtn;
        public Sulakore.Components.SKoreButton CTAppendIntegerBtn;
        public System.Windows.Forms.TextBox CTHeaderTxt;
        public System.Windows.Forms.ComboBox CTValueTxt;
        public Sulakore.Components.SKoreConstructView CTConstructerVw;
        public Sulakore.Components.SKoreLabel CTChunkCountLbl;
        public Sulakore.Components.SKoreButton CTTransferBelowBtn;
        public System.Windows.Forms.TextBox CTPacketTxt;
        public System.Windows.Forms.CheckBox CTLiveEditingChckbx;
        public System.Windows.Forms.Label PTIsCorruptedLbl;
        public System.Windows.Forms.Label PTPacketInfoLbl;
        public System.Windows.Forms.TextBox PTPacketTxt;
        private System.Windows.Forms.ToolStripMenuItem PTInsertParameterBtn;
        private System.Windows.Forms.ToolStripSeparator PTMenuSeparatorTop;
        public System.Windows.Forms.TabPage PrimitiveTab;
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
    }
}