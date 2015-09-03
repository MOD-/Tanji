namespace Tanji.Dialogs
{
    partial class UpdateFrm
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
            this.ReleasesTxt = new System.Windows.Forms.ComboBox();
            this.TanjiReleaseLbl = new System.Windows.Forms.Label();
            this.ReleaseNotesLbl = new System.Windows.Forms.LinkLabel();
            this.DownloadBtn = new Sulakore.Components.SKoreButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TanjiDirectoryDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.StatusLbl = new Sulakore.Components.SKoreLabel();
            this.SuspendLayout();
            // 
            // ReleasesTxt
            // 
            this.ReleasesTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReleasesTxt.FormattingEnabled = true;
            this.ReleasesTxt.Items.AddRange(new object[] {
            "v1.2.5.0",
            "v1.2.4.0",
            "v1.2.3.0",
            "v1.1.2.0",
            "v1.0.2.28577"});
            this.ReleasesTxt.Location = new System.Drawing.Point(87, 12);
            this.ReleasesTxt.Name = "ReleasesTxt";
            this.ReleasesTxt.Size = new System.Drawing.Size(105, 21);
            this.ReleasesTxt.TabIndex = 1;
            this.ReleasesTxt.SelectedIndexChanged += new System.EventHandler(this.ReleasesTxt_SelectedIndexChanged);
            // 
            // TanjiReleaseLbl
            // 
            this.TanjiReleaseLbl.AutoSize = true;
            this.TanjiReleaseLbl.Location = new System.Drawing.Point(12, 15);
            this.TanjiReleaseLbl.Name = "TanjiReleaseLbl";
            this.TanjiReleaseLbl.Size = new System.Drawing.Size(75, 13);
            this.TanjiReleaseLbl.TabIndex = 2;
            this.TanjiReleaseLbl.Text = "Tanji Release:";
            // 
            // ReleaseNotesLbl
            // 
            this.ReleaseNotesLbl.AutoSize = true;
            this.ReleaseNotesLbl.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.ReleaseNotesLbl.Location = new System.Drawing.Point(198, 15);
            this.ReleaseNotesLbl.Name = "ReleaseNotesLbl";
            this.ReleaseNotesLbl.Size = new System.Drawing.Size(77, 13);
            this.ReleaseNotesLbl.TabIndex = 3;
            this.ReleaseNotesLbl.TabStop = true;
            this.ReleaseNotesLbl.Text = "Release Notes";
            this.ReleaseNotesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReleaseNotesLbl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ReleaseNotesLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReleaseNotesLbl_LinkClicked);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DownloadBtn.Location = new System.Drawing.Point(161, 46);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(114, 22);
            this.DownloadBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DownloadBtn.TabIndex = 4;
            this.DownloadBtn.Text = "Download(0 KB)";
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 1);
            this.panel1.TabIndex = 6;
            // 
            // TanjiDirectoryDlg
            // 
            this.TanjiDirectoryDlg.Description = "Choose where to extract Tanji and its dependencies.";
            // 
            // StatusLbl
            // 
            this.StatusLbl.DisplayBoundary = true;
            this.StatusLbl.Location = new System.Drawing.Point(12, 46);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(143, 22);
            this.StatusLbl.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusLbl.TabIndex = 7;
            this.StatusLbl.Text = "Standing By...";
            this.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 77);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.ReleaseNotesLbl);
            this.Controls.Add(this.TanjiReleaseLbl);
            this.Controls.Add(this.ReleasesTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Tanji.Properties.Resources.Tanji;
            this.MaximizeBox = false;
            this.Name = "UpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Update Found!";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFrm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ReleasesTxt;
        private System.Windows.Forms.Label TanjiReleaseLbl;
        private System.Windows.Forms.LinkLabel ReleaseNotesLbl;
        private Sulakore.Components.SKoreButton DownloadBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog TanjiDirectoryDlg;
        private Sulakore.Components.SKoreLabel StatusLbl;
    }
}