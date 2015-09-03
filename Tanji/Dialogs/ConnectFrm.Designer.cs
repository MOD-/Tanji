namespace Tanji.Dialogs
{
    partial class ConnectFrm
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
            this.MiddleGlowPnl = new System.Windows.Forms.Panel();
            this.GamePortLbl = new System.Windows.Forms.Label();
            this.GameHostLbl = new System.Windows.Forms.Label();
            this.TopGlowPnl = new System.Windows.Forms.Panel();
            this.ExponentTxt = new System.Windows.Forms.TextBox();
            this.ExponentGrpbx = new System.Windows.Forms.GroupBox();
            this.CustomClientTxt = new System.Windows.Forms.TextBox();
            this.CustomClientGrpbx = new System.Windows.Forms.GroupBox();
            this.BrowseBtn = new Sulakore.Components.SKoreButton();
            this.ModulusTxt = new System.Windows.Forms.TextBox();
            this.ModulusGrpbx = new System.Windows.Forms.GroupBox();
            this.ChooseClientDlg = new System.Windows.Forms.OpenFileDialog();
            this.StatusTxt = new Sulakore.Components.SKoreLabel();
            this.ConnectBtn = new Sulakore.Components.SKoreButton();
            this.GameHostTxt = new System.Windows.Forms.TextBox();
            this.GamePortTxt = new System.Windows.Forms.TextBox();
            this.ModePnl = new Tanji.Components.TanjiModePanel();
            this.ExponentGrpbx.SuspendLayout();
            this.CustomClientGrpbx.SuspendLayout();
            this.ModulusGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiddleGlowPnl
            // 
            this.MiddleGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MiddleGlowPnl.Location = new System.Drawing.Point(0, 192);
            this.MiddleGlowPnl.Name = "MiddleGlowPnl";
            this.MiddleGlowPnl.Size = new System.Drawing.Size(330, 1);
            this.MiddleGlowPnl.TabIndex = 65;
            // 
            // GamePortLbl
            // 
            this.GamePortLbl.AutoSize = true;
            this.GamePortLbl.Location = new System.Drawing.Point(165, 41);
            this.GamePortLbl.Name = "GamePortLbl";
            this.GamePortLbl.Size = new System.Drawing.Size(57, 13);
            this.GamePortLbl.TabIndex = 68;
            this.GamePortLbl.Text = "Game Port";
            // 
            // GameHostLbl
            // 
            this.GameHostLbl.AutoSize = true;
            this.GameHostLbl.Location = new System.Drawing.Point(9, 41);
            this.GameHostLbl.Name = "GameHostLbl";
            this.GameHostLbl.Size = new System.Drawing.Size(60, 13);
            this.GameHostLbl.TabIndex = 67;
            this.GameHostLbl.Text = "Game Host";
            // 
            // TopGlowPnl
            // 
            this.TopGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TopGlowPnl.Location = new System.Drawing.Point(0, 83);
            this.TopGlowPnl.Name = "TopGlowPnl";
            this.TopGlowPnl.Size = new System.Drawing.Size(330, 1);
            this.TopGlowPnl.TabIndex = 66;
            // 
            // ExponentTxt
            // 
            this.ExponentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExponentTxt.Location = new System.Drawing.Point(6, 19);
            this.ExponentTxt.Name = "ExponentTxt";
            this.ExponentTxt.Size = new System.Drawing.Size(77, 20);
            this.ExponentTxt.TabIndex = 0;
            this.ExponentTxt.TabStop = false;
            this.ExponentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExponentGrpbx
            // 
            this.ExponentGrpbx.Controls.Add(this.ExponentTxt);
            this.ExponentGrpbx.Location = new System.Drawing.Point(12, 90);
            this.ExponentGrpbx.Name = "ExponentGrpbx";
            this.ExponentGrpbx.Size = new System.Drawing.Size(89, 45);
            this.ExponentGrpbx.TabIndex = 69;
            this.ExponentGrpbx.TabStop = false;
            this.ExponentGrpbx.Text = "Exponent";
            // 
            // CustomClientTxt
            // 
            this.CustomClientTxt.Location = new System.Drawing.Point(6, 17);
            this.CustomClientTxt.Name = "CustomClientTxt";
            this.CustomClientTxt.ReadOnly = true;
            this.CustomClientTxt.Size = new System.Drawing.Size(220, 20);
            this.CustomClientTxt.TabIndex = 0;
            this.CustomClientTxt.TabStop = false;
            // 
            // CustomClientGrpbx
            // 
            this.CustomClientGrpbx.Controls.Add(this.BrowseBtn);
            this.CustomClientGrpbx.Controls.Add(this.CustomClientTxt);
            this.CustomClientGrpbx.Location = new System.Drawing.Point(12, 141);
            this.CustomClientGrpbx.Name = "CustomClientGrpbx";
            this.CustomClientGrpbx.Size = new System.Drawing.Size(306, 45);
            this.CustomClientGrpbx.TabIndex = 71;
            this.CustomClientGrpbx.TabStop = false;
            this.CustomClientGrpbx.Text = "Custom Client";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BrowseBtn.Location = new System.Drawing.Point(232, 17);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(68, 20);
            this.BrowseBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.TabStop = false;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ModulusTxt
            // 
            this.ModulusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulusTxt.Location = new System.Drawing.Point(6, 19);
            this.ModulusTxt.Name = "ModulusTxt";
            this.ModulusTxt.Size = new System.Drawing.Size(199, 20);
            this.ModulusTxt.TabIndex = 0;
            this.ModulusTxt.TabStop = false;
            this.ModulusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModulusGrpbx
            // 
            this.ModulusGrpbx.Controls.Add(this.ModulusTxt);
            this.ModulusGrpbx.Location = new System.Drawing.Point(107, 90);
            this.ModulusGrpbx.Name = "ModulusGrpbx";
            this.ModulusGrpbx.Size = new System.Drawing.Size(211, 45);
            this.ModulusGrpbx.TabIndex = 70;
            this.ModulusGrpbx.TabStop = false;
            this.ModulusGrpbx.Text = "Modulus";
            // 
            // ChooseClientDlg
            // 
            this.ChooseClientDlg.DefaultExt = "swf";
            this.ChooseClientDlg.Filter = "Shockwave Flash File (*.swf)|*.swf";
            this.ChooseClientDlg.Title = "Tanji ~ Choose Custom Client";
            // 
            // StatusTxt
            // 
            this.StatusTxt.AnimationInterval = 500;
            this.StatusTxt.DisplayBoundary = true;
            this.StatusTxt.Location = new System.Drawing.Point(12, 202);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(207, 23);
            this.StatusTxt.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusTxt.TabIndex = 75;
            this.StatusTxt.Text = "Standing By...";
            this.StatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConnectBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConnectBtn.Location = new System.Drawing.Point(225, 202);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(93, 23);
            this.ConnectBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ConnectBtn.TabIndex = 72;
            this.ConnectBtn.TabStop = false;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // GameHostTxt
            // 
            this.GameHostTxt.Location = new System.Drawing.Point(12, 57);
            this.GameHostTxt.Name = "GameHostTxt";
            this.GameHostTxt.ReadOnly = true;
            this.GameHostTxt.Size = new System.Drawing.Size(150, 20);
            this.GameHostTxt.TabIndex = 77;
            this.GameHostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GamePortTxt
            // 
            this.GamePortTxt.Location = new System.Drawing.Point(168, 57);
            this.GamePortTxt.Name = "GamePortTxt";
            this.GamePortTxt.ReadOnly = true;
            this.GamePortTxt.Size = new System.Drawing.Size(150, 20);
            this.GamePortTxt.TabIndex = 78;
            this.GamePortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModePnl
            // 
            this.ModePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ModePnl.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ModePnl.Location = new System.Drawing.Point(0, 0);
            this.ModePnl.Name = "ModePnl";
            this.ModePnl.Size = new System.Drawing.Size(330, 33);
            this.ModePnl.TabIndex = 76;
            this.ModePnl.ModeChanged += new System.EventHandler(this.ModeChanged);
            // 
            // ConnectFrm
            // 
            this.AcceptButton = this.ConnectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 234);
            this.Controls.Add(this.GamePortTxt);
            this.Controls.Add(this.GameHostTxt);
            this.Controls.Add(this.MiddleGlowPnl);
            this.Controls.Add(this.GamePortLbl);
            this.Controls.Add(this.GameHostLbl);
            this.Controls.Add(this.TopGlowPnl);
            this.Controls.Add(this.ExponentGrpbx);
            this.Controls.Add(this.CustomClientGrpbx);
            this.Controls.Add(this.ModePnl);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.ModulusGrpbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Tanji.Properties.Resources.Tanji;
            this.MaximizeBox = false;
            this.Name = "ConnectFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Connection Setup";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectFrm_FormClosed);
            this.Shown += new System.EventHandler(this.ConnectFrm_Shown);
            this.ExponentGrpbx.ResumeLayout(false);
            this.ExponentGrpbx.PerformLayout();
            this.CustomClientGrpbx.ResumeLayout(false);
            this.CustomClientGrpbx.PerformLayout();
            this.ModulusGrpbx.ResumeLayout(false);
            this.ModulusGrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MiddleGlowPnl;
        private System.Windows.Forms.Label GamePortLbl;
        private System.Windows.Forms.Label GameHostLbl;
        private System.Windows.Forms.Panel TopGlowPnl;
        public System.Windows.Forms.TextBox ExponentTxt;
        private System.Windows.Forms.GroupBox ExponentGrpbx;
        private System.Windows.Forms.TextBox CustomClientTxt;
        private System.Windows.Forms.GroupBox CustomClientGrpbx;
        private Sulakore.Components.SKoreButton BrowseBtn;
        public System.Windows.Forms.TextBox ModulusTxt;
        private Components.TanjiModePanel ModePnl;
        private Sulakore.Components.SKoreLabel StatusTxt;
        private Sulakore.Components.SKoreButton ConnectBtn;
        private System.Windows.Forms.GroupBox ModulusGrpbx;
        private System.Windows.Forms.OpenFileDialog ChooseClientDlg;
        private System.Windows.Forms.TextBox GameHostTxt;
        private System.Windows.Forms.TextBox GamePortTxt;

    }
}