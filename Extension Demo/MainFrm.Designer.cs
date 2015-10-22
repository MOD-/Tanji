namespace Extension_Demo
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
            this.ToClientBtn = new System.Windows.Forms.Button();
            this.ToServerBtn = new System.Windows.Forms.Button();
            this.PacketTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToClientBtn
            // 
            this.ToClientBtn.Location = new System.Drawing.Point(162, 38);
            this.ToClientBtn.Name = "ToClientBtn";
            this.ToClientBtn.Size = new System.Drawing.Size(109, 23);
            this.ToClientBtn.TabIndex = 0;
            this.ToClientBtn.Text = "Send To Client";
            this.ToClientBtn.UseVisualStyleBackColor = true;
            this.ToClientBtn.Click += new System.EventHandler(this.ToClientBtn_Click);
            // 
            // ToServerBtn
            // 
            this.ToServerBtn.Location = new System.Drawing.Point(277, 38);
            this.ToServerBtn.Name = "ToServerBtn";
            this.ToServerBtn.Size = new System.Drawing.Size(109, 23);
            this.ToServerBtn.TabIndex = 1;
            this.ToServerBtn.Text = "Send To Server";
            this.ToServerBtn.UseVisualStyleBackColor = true;
            this.ToServerBtn.Click += new System.EventHandler(this.ToServerBtn_Click);
            // 
            // PacketTxt
            // 
            this.PacketTxt.Location = new System.Drawing.Point(12, 12);
            this.PacketTxt.Name = "PacketTxt";
            this.PacketTxt.Size = new System.Drawing.Size(374, 20);
            this.PacketTxt.TabIndex = 2;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 254);
            this.Controls.Add(this.PacketTxt);
            this.Controls.Add(this.ToServerBtn);
            this.Controls.Add(this.ToClientBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extension Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToClientBtn;
        private System.Windows.Forms.Button ToServerBtn;
        private System.Windows.Forms.TextBox PacketTxt;
    }
}

