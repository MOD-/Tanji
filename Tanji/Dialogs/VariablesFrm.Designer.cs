namespace Tanji.Dialogs
{
    partial class VariablesFrm
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
            this.sKoreButton1 = new Sulakore.Components.SKoreButton();
            this.sKoreTabControl1 = new Sulakore.Components.SKoreTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sKoreListView1 = new Sulakore.Components.SKoreListView();
            this.VTNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VTValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sKoreTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sKoreButton1
            // 
            this.sKoreButton1.BackColor = System.Drawing.Color.Transparent;
            this.sKoreButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sKoreButton1.Location = new System.Drawing.Point(263, 240);
            this.sKoreButton1.Name = "sKoreButton1";
            this.sKoreButton1.Size = new System.Drawing.Size(100, 22);
            this.sKoreButton1.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sKoreButton1.TabIndex = 0;
            this.sKoreButton1.Text = "Proceed";
            // 
            // sKoreTabControl1
            // 
            this.sKoreTabControl1.Controls.Add(this.tabPage1);
            this.sKoreTabControl1.Controls.Add(this.tabPage2);
            this.sKoreTabControl1.DisplayBoundary = true;
            this.sKoreTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sKoreTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.sKoreTabControl1.Location = new System.Drawing.Point(0, 0);
            this.sKoreTabControl1.Name = "sKoreTabControl1";
            this.sKoreTabControl1.SelectedIndex = 0;
            this.sKoreTabControl1.Size = new System.Drawing.Size(375, 233);
            this.sKoreTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.sKoreTabControl1.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.sKoreTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sKoreListView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Variables";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 201);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Source";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sKoreListView1
            // 
            this.sKoreListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VTNameCol,
            this.VTValueCol});
            this.sKoreListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sKoreListView1.FullRowSelect = true;
            this.sKoreListView1.GridLines = true;
            this.sKoreListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sKoreListView1.HideSelection = false;
            this.sKoreListView1.Location = new System.Drawing.Point(3, 3);
            this.sKoreListView1.MultiSelect = false;
            this.sKoreListView1.Name = "sKoreListView1";
            this.sKoreListView1.ShowItemToolTips = true;
            this.sKoreListView1.Size = new System.Drawing.Size(361, 195);
            this.sKoreListView1.TabIndex = 0;
            this.sKoreListView1.UseCompatibleStateImageBehavior = false;
            this.sKoreListView1.View = System.Windows.Forms.View.Details;
            // 
            // VTNameCol
            // 
            this.VTNameCol.Text = "Name";
            this.VTNameCol.Width = 170;
            // 
            // VTValueCol
            // 
            this.VTValueCol.Text = "Value";
            this.VTValueCol.Width = 170;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(361, 195);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // VariablesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 271);
            this.Controls.Add(this.sKoreTabControl1);
            this.Controls.Add(this.sKoreButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Tanji.Properties.Resources.Tanji;
            this.MaximizeBox = false;
            this.Name = "VariablesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Customize Variables";
            this.sKoreTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sulakore.Components.SKoreButton sKoreButton1;
        private Sulakore.Components.SKoreTabControl sKoreTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sulakore.Components.SKoreListView sKoreListView1;
        private System.Windows.Forms.ColumnHeader VTNameCol;
        private System.Windows.Forms.ColumnHeader VTValueCol;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}