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
            this.GitBody = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // GitBody
            // 
            this.GitBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.GitBody.Location = new System.Drawing.Point(0, 0);
            this.GitBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.GitBody.Name = "GitBody";
            this.GitBody.ScriptErrorsSuppressed = true;
            this.GitBody.Size = new System.Drawing.Size(471, 318);
            this.GitBody.TabIndex = 0;
            // 
            // UpdateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(471, 390);
            this.Controls.Add(this.GitBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Updater";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser GitBody;
    }
}