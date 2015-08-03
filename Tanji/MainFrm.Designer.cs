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
            this.ExtensionsTab = new System.Windows.Forms.TabPage();
            this.ETExtensionAOTChckbx = new System.Windows.Forms.CheckBox();
            this.ETUninstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.ContractorVw = new Sulakore.Components.SKoreExtensionView();
            this.IdentifierCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ETExtensionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ETOpenMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETUninstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETMenuSplitter = new System.Windows.Forms.ToolStripSeparator();
            this.ETInstallMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ETInstallExtensionBtn = new Sulakore.Components.SKoreButton();
            this.TanjiStrip.SuspendLayout();
            this.TanjiTabs.SuspendLayout();
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
            this.IdentifierCol,
            this.CreatorCol,
            this.DescriptionCol,
            this.VersionCol,
            this.StatusCol});
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
            // IdentifierCol
            // 
            this.IdentifierCol.Text = "Identifier";
            this.IdentifierCol.Width = 87;
            // 
            // CreatorCol
            // 
            this.CreatorCol.Text = "Creator";
            this.CreatorCol.Width = 90;
            // 
            // DescriptionCol
            // 
            this.DescriptionCol.Text = "Description";
            this.DescriptionCol.Width = 120;
            // 
            // VersionCol
            // 
            this.VersionCol.Text = "Version";
            this.VersionCol.Width = 87;
            // 
            // StatusCol
            // 
            this.StatusCol.Text = "Status";
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
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.TanjiStrip.ResumeLayout(false);
            this.TanjiStrip.PerformLayout();
            this.TanjiTabs.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader IdentifierCol;
        private System.Windows.Forms.ColumnHeader CreatorCol;
        private System.Windows.Forms.ColumnHeader DescriptionCol;
        private System.Windows.Forms.ColumnHeader VersionCol;
        private System.Windows.Forms.ColumnHeader StatusCol;
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
    }
}