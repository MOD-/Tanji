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
            this.ExtensionsActiveTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiInfoTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.TanjiTabs = new Sulakore.Components.SKoreTabControl();
            this.InjectionTab = new System.Windows.Forms.TabPage();
            this.IPacketTxt = new System.Windows.Forms.TextBox();
            this.ISendToClientBtn = new Sulakore.Components.SKoreButton();
            this.ISendToServerBtn = new Sulakore.Components.SKoreButton();
            this.InjectionTabs = new Sulakore.Components.SKoreTabControl();
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
            this.TanjiStrip.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
            this.InjectionTab.SuspendLayout();
            this.InjectionTabs.SuspendLayout();
            this.SchedulerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).BeginInit();
            this.ExtensionsTab.SuspendLayout();
            this.ETExtensionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TanjiStrip
            // 
            this.TanjiStrip.BackColor = System.Drawing.Color.White;
            this.TanjiStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TanjiVersionTxt,
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
            this.TanjiInfoTxt.Size = new System.Drawing.Size(289, 19);
            this.TanjiInfoTxt.Spring = true;
            this.TanjiInfoTxt.Text = "GitHub.com/ArachisH/Tanji";
            this.TanjiInfoTxt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TanjiInfoTxt.Click += new System.EventHandler(this.TanjiInfoTxt_Click);
            // 
            // TanjiTabs
            // 
            this.TanjiTabs.Controls.Add(this.InjectionTab);
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
            // 
            // InjectionTabs
            // 
            this.InjectionTabs.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.InjectionTabs.Controls.Add(this.SchedulerTab);
            this.InjectionTabs.DisplayBoundary = true;
            this.InjectionTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.InjectionTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.InjectionTabs.Enabled = false;
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
            this.SchedulerTab.ResumeLayout(false);
            this.SchedulerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISBurstTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ISIntervalTxt)).EndInit();
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
    }
}