namespace Tanji.Applications
{
    partial class PacketLoggerFrm
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
            this.LoggerTxt = new System.Windows.Forms.RichTextBox();
            this.PacketLoggerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PLCMCopyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PacketLoggerMenu = new System.Windows.Forms.MenuStrip();
            this.OptionsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewOutgoingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewIncomingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsSep = new System.Windows.Forms.ToolStripSeparator();
            this.SaveLogBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.EmptyLogBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayFiltersBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplacedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplaySplitterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayPacketStructureBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.AlwaysOnTopBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.PacketLoggerStrip = new System.Windows.Forms.StatusStrip();
            this.CaptureOutgoingLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.CaptureIncomingLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.PacketLoggerContextMenu.SuspendLayout();
            this.PacketLoggerMenu.SuspendLayout();
            this.PacketLoggerStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoggerTxt
            // 
            this.LoggerTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LoggerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoggerTxt.ContextMenuStrip = this.PacketLoggerContextMenu;
            this.LoggerTxt.DetectUrls = false;
            this.LoggerTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoggerTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoggerTxt.ForeColor = System.Drawing.Color.White;
            this.LoggerTxt.Location = new System.Drawing.Point(0, 24);
            this.LoggerTxt.Name = "LoggerTxt";
            this.LoggerTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.LoggerTxt.ShowSelectionMargin = true;
            this.LoggerTxt.Size = new System.Drawing.Size(710, 473);
            this.LoggerTxt.TabIndex = 0;
            this.LoggerTxt.Text = "";
            // 
            // PacketLoggerContextMenu
            // 
            this.PacketLoggerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PLCMCopyBtn});
            this.PacketLoggerContextMenu.Name = "ConstructMenu";
            this.PacketLoggerContextMenu.Size = new System.Drawing.Size(145, 26);
            // 
            // PLCMCopyBtn
            // 
            this.PLCMCopyBtn.Name = "PLCMCopyBtn";
            this.PLCMCopyBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.PLCMCopyBtn.Size = new System.Drawing.Size(144, 22);
            this.PLCMCopyBtn.Text = "Copy";
            this.PLCMCopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // PacketLoggerMenu
            // 
            this.PacketLoggerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsBtn,
            this.SettingsBtn});
            this.PacketLoggerMenu.Location = new System.Drawing.Point(0, 0);
            this.PacketLoggerMenu.Name = "PacketLoggerMenu";
            this.PacketLoggerMenu.Size = new System.Drawing.Size(710, 24);
            this.PacketLoggerMenu.TabIndex = 7;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewOutgoingBtn,
            this.ViewIncomingBtn,
            this.OptionsSep,
            this.SaveLogBtn,
            this.EmptyLogBtn});
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(61, 20);
            this.OptionsBtn.Text = "Options";
            // 
            // ViewOutgoingBtn
            // 
            this.ViewOutgoingBtn.Checked = true;
            this.ViewOutgoingBtn.CheckOnClick = true;
            this.ViewOutgoingBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewOutgoingBtn.Name = "ViewOutgoingBtn";
            this.ViewOutgoingBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ViewOutgoingBtn.Size = new System.Drawing.Size(196, 22);
            this.ViewOutgoingBtn.Text = "View Outgoing";
            this.ViewOutgoingBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // ViewIncomingBtn
            // 
            this.ViewIncomingBtn.Checked = true;
            this.ViewIncomingBtn.CheckOnClick = true;
            this.ViewIncomingBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewIncomingBtn.Name = "ViewIncomingBtn";
            this.ViewIncomingBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ViewIncomingBtn.Size = new System.Drawing.Size(196, 22);
            this.ViewIncomingBtn.Text = "View Incoming";
            this.ViewIncomingBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // OptionsSep
            // 
            this.OptionsSep.Name = "OptionsSep";
            this.OptionsSep.Size = new System.Drawing.Size(193, 6);
            // 
            // SaveLogBtn
            // 
            this.SaveLogBtn.Enabled = false;
            this.SaveLogBtn.Name = "SaveLogBtn";
            this.SaveLogBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveLogBtn.Size = new System.Drawing.Size(196, 22);
            this.SaveLogBtn.Text = "Save Log";
            this.SaveLogBtn.Click += new System.EventHandler(this.SaveLogBtn_Click);
            // 
            // EmptyLogBtn
            // 
            this.EmptyLogBtn.Name = "EmptyLogBtn";
            this.EmptyLogBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EmptyLogBtn.Size = new System.Drawing.Size(196, 22);
            this.EmptyLogBtn.Text = "Empty Log";
            this.EmptyLogBtn.Click += new System.EventHandler(this.EmptyLogBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayFiltersBtn,
            this.DisplaySplitterBtn,
            this.DisplayPacketStructureBtn,
            this.SettingsSeperator,
            this.AlwaysOnTopBtn});
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(61, 20);
            this.SettingsBtn.Text = "Settings";
            // 
            // DisplayFiltersBtn
            // 
            this.DisplayFiltersBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlockedBtn,
            this.ReplacedBtn});
            this.DisplayFiltersBtn.Name = "DisplayFiltersBtn";
            this.DisplayFiltersBtn.Size = new System.Drawing.Size(201, 22);
            this.DisplayFiltersBtn.Text = "Display Filters";
            // 
            // BlockedBtn
            // 
            this.BlockedBtn.Checked = true;
            this.BlockedBtn.CheckOnClick = true;
            this.BlockedBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BlockedBtn.Name = "BlockedBtn";
            this.BlockedBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BlockedBtn.Size = new System.Drawing.Size(163, 22);
            this.BlockedBtn.Text = "Blocked";
            this.BlockedBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // ReplacedBtn
            // 
            this.ReplacedBtn.Checked = true;
            this.ReplacedBtn.CheckOnClick = true;
            this.ReplacedBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplacedBtn.Name = "ReplacedBtn";
            this.ReplacedBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReplacedBtn.Size = new System.Drawing.Size(163, 22);
            this.ReplacedBtn.Text = "Replaced";
            this.ReplacedBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // DisplaySplitterBtn
            // 
            this.DisplaySplitterBtn.Checked = true;
            this.DisplaySplitterBtn.CheckOnClick = true;
            this.DisplaySplitterBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplaySplitterBtn.Name = "DisplaySplitterBtn";
            this.DisplaySplitterBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.DisplaySplitterBtn.Size = new System.Drawing.Size(201, 22);
            this.DisplaySplitterBtn.Text = "Display Splitter";
            this.DisplaySplitterBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // DisplayPacketStructureBtn
            // 
            this.DisplayPacketStructureBtn.CheckOnClick = true;
            this.DisplayPacketStructureBtn.Name = "DisplayPacketStructureBtn";
            this.DisplayPacketStructureBtn.Size = new System.Drawing.Size(201, 22);
            this.DisplayPacketStructureBtn.Text = "Display Packet Structure";
            this.DisplayPacketStructureBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // SettingsSeperator
            // 
            this.SettingsSeperator.Name = "SettingsSeperator";
            this.SettingsSeperator.Size = new System.Drawing.Size(198, 6);
            // 
            // AlwaysOnTopBtn
            // 
            this.AlwaysOnTopBtn.CheckOnClick = true;
            this.AlwaysOnTopBtn.Name = "AlwaysOnTopBtn";
            this.AlwaysOnTopBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.AlwaysOnTopBtn.Size = new System.Drawing.Size(201, 22);
            this.AlwaysOnTopBtn.Text = "Always On Top";
            this.AlwaysOnTopBtn.CheckedChanged += new System.EventHandler(this.ItemChecked);
            // 
            // PacketLoggerStrip
            // 
            this.PacketLoggerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureOutgoingLbl,
            this.CaptureIncomingLbl});
            this.PacketLoggerStrip.Location = new System.Drawing.Point(0, 497);
            this.PacketLoggerStrip.Name = "PacketLoggerStrip";
            this.PacketLoggerStrip.Size = new System.Drawing.Size(710, 24);
            this.PacketLoggerStrip.TabIndex = 8;
            // 
            // CaptureOutgoingLbl
            // 
            this.CaptureOutgoingLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CaptureOutgoingLbl.Name = "CaptureOutgoingLbl";
            this.CaptureOutgoingLbl.Size = new System.Drawing.Size(136, 19);
            this.CaptureOutgoingLbl.Text = "Capture Outgoing: True";
            // 
            // CaptureIncomingLbl
            // 
            this.CaptureIncomingLbl.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.CaptureIncomingLbl.Name = "CaptureIncomingLbl";
            this.CaptureIncomingLbl.Size = new System.Drawing.Size(136, 19);
            this.CaptureIncomingLbl.Text = "Capture Incoming: True";
            // 
            // PacketLoggerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 521);
            this.Controls.Add(this.LoggerTxt);
            this.Controls.Add(this.PacketLoggerStrip);
            this.Controls.Add(this.PacketLoggerMenu);
            this.Icon = global::Tanji.Properties.Resources.Tanji;
            this.Name = "PacketLoggerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ PacketLogger";
            this.PacketLoggerContextMenu.ResumeLayout(false);
            this.PacketLoggerMenu.ResumeLayout(false);
            this.PacketLoggerMenu.PerformLayout();
            this.PacketLoggerStrip.ResumeLayout(false);
            this.PacketLoggerStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LoggerTxt;
        private System.Windows.Forms.MenuStrip PacketLoggerMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsBtn;
        private System.Windows.Forms.ToolStripMenuItem ViewOutgoingBtn;
        private System.Windows.Forms.ToolStripMenuItem ViewIncomingBtn;
        private System.Windows.Forms.ToolStripSeparator OptionsSep;
        private System.Windows.Forms.ToolStripMenuItem SaveLogBtn;
        private System.Windows.Forms.ToolStripMenuItem EmptyLogBtn;
        private System.Windows.Forms.ToolStripMenuItem SettingsBtn;
        private System.Windows.Forms.ToolStripMenuItem DisplayFiltersBtn;
        private System.Windows.Forms.ToolStripMenuItem BlockedBtn;
        private System.Windows.Forms.ToolStripMenuItem ReplacedBtn;
        private System.Windows.Forms.ToolStripMenuItem DisplaySplitterBtn;
        private System.Windows.Forms.ToolStripSeparator SettingsSeperator;
        private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopBtn;
        private System.Windows.Forms.StatusStrip PacketLoggerStrip;
        private System.Windows.Forms.ToolStripStatusLabel CaptureOutgoingLbl;
        private System.Windows.Forms.ToolStripStatusLabel CaptureIncomingLbl;
        private System.Windows.Forms.ToolStripMenuItem DisplayPacketStructureBtn;
        private System.Windows.Forms.ContextMenuStrip PacketLoggerContextMenu;
        public System.Windows.Forms.ToolStripMenuItem PLCMCopyBtn;
    }
}