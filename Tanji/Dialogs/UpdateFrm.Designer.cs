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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFrm));
            this.GitBodyWb = new System.Windows.Forms.WebBrowser();
            this.MoreInformationBtn = new Sulakore.Components.SKoreButton();
            this.SuspendLayout();
            // 
            // GitBodyWb
            // 
            this.GitBodyWb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GitBodyWb.Location = new System.Drawing.Point(0, 0);
            this.GitBodyWb.MinimumSize = new System.Drawing.Size(20, 20);
            this.GitBodyWb.Name = "GitBodyWb";
            this.GitBodyWb.ScriptErrorsSuppressed = true;
            this.GitBodyWb.Size = new System.Drawing.Size(479, 351);
            this.GitBodyWb.TabIndex = 0;
            // 
            // MoreInformationBtn
            // 
            this.MoreInformationBtn.BackColor = System.Drawing.Color.Transparent;
            this.MoreInformationBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MoreInformationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MoreInformationBtn.Location = new System.Drawing.Point(0, 351);
            this.MoreInformationBtn.Name = "MoreInformationBtn";
            this.MoreInformationBtn.Size = new System.Drawing.Size(479, 22);
            this.MoreInformationBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MoreInformationBtn.TabIndex = 1;
            this.MoreInformationBtn.Text = "More Information";
            this.MoreInformationBtn.Click += new System.EventHandler(this.MoreInformationBtn_Click);
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(479, 373);
            this.Controls.Add(this.GitBodyWb);
            this.Controls.Add(this.MoreInformationBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(352, 325);
            this.Name = "UpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Update Found! | {0}({1})";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser GitBodyWb;
        private Sulakore.Components.SKoreButton MoreInformationBtn;
    }
}