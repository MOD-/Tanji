namespace Tanji.Applications.Dialogs
{
    partial class FindHeaderDialog
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
            this.HashLbl = new System.Windows.Forms.Label();
            this.HashTxt = new System.Windows.Forms.TextBox();
            this.FindBtn = new Sulakore.Components.SKoreButton();
            this.HeadersVw = new Sulakore.Components.SKoreListView();
            this.TypeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // HashLbl
            // 
            this.HashLbl.AutoSize = true;
            this.HashLbl.Location = new System.Drawing.Point(12, 17);
            this.HashLbl.Name = "HashLbl";
            this.HashLbl.Size = new System.Drawing.Size(35, 13);
            this.HashLbl.TabIndex = 0;
            this.HashLbl.Text = "Hash:";
            // 
            // HashTxt
            // 
            this.HashTxt.Location = new System.Drawing.Point(47, 14);
            this.HashTxt.Name = "HashTxt";
            this.HashTxt.Size = new System.Drawing.Size(176, 20);
            this.HashTxt.TabIndex = 1;
            this.HashTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.Transparent;
            this.FindBtn.Location = new System.Drawing.Point(229, 12);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(66, 22);
            this.FindBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.FindBtn.TabIndex = 2;
            this.FindBtn.Text = "Find";
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // HeadersVw
            // 
            this.HeadersVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeCol,
            this.HeaderCol,
            this.ClassNameCol});
            this.HeadersVw.FullRowSelect = true;
            this.HeadersVw.GridLines = true;
            this.HeadersVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.HeadersVw.HideSelection = false;
            this.HeadersVw.Location = new System.Drawing.Point(15, 40);
            this.HeadersVw.MultiSelect = false;
            this.HeadersVw.Name = "HeadersVw";
            this.HeadersVw.ShowItemToolTips = true;
            this.HeadersVw.Size = new System.Drawing.Size(280, 114);
            this.HeadersVw.TabIndex = 3;
            this.HeadersVw.UseCompatibleStateImageBehavior = false;
            this.HeadersVw.View = System.Windows.Forms.View.Details;
            // 
            // TypeCol
            // 
            this.TypeCol.Text = "Type";
            this.TypeCol.Width = 53;
            // 
            // HeaderCol
            // 
            this.HeaderCol.Text = "Header";
            this.HeaderCol.Width = 49;
            // 
            // ClassNameCol
            // 
            this.ClassNameCol.Text = "Class Name";
            this.ClassNameCol.Width = 157;
            // 
            // FindHeaderDialog
            // 
            this.AcceptButton = this.FindBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 166);
            this.Controls.Add(this.HashLbl);
            this.Controls.Add(this.HeadersVw);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.HashTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindHeaderDialog";
            this.ShowInTaskbar = false;
            this.Text = "Tanji ~ Find Header";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HashLbl;
        private Sulakore.Components.SKoreButton FindBtn;
        private Sulakore.Components.SKoreListView HeadersVw;
        private System.Windows.Forms.ColumnHeader TypeCol;
        private System.Windows.Forms.ColumnHeader HeaderCol;
        private System.Windows.Forms.ColumnHeader ClassNameCol;
        internal System.Windows.Forms.TextBox HashTxt;
    }
}