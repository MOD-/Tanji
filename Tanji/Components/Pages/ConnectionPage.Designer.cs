namespace Tanji.Components.Pages
{
    partial class ConnectionPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectBtn = new Sulakore.Components.SKoreButton();
            this.ProxyPortTxt = new Sulakore.Components.SKoreLabelBox();
            this.VariableTxt = new Sulakore.Components.SKoreLabelBox();
            this.ValueTxt = new Sulakore.Components.SKoreLabelBox();
            this.CustomClientTxt = new Sulakore.Components.SKoreLabelBox();
            this.BrowseBtn = new Sulakore.Components.SKoreButton();
            this.ExportRootCertificateBtn = new Sulakore.Components.SKoreButton();
            this.DestroyCertificatesBtn = new Sulakore.Components.SKoreButton();
            this.ResetVariableBtn = new Sulakore.Components.SKoreButton();
            this.SetVariableBtn = new Sulakore.Components.SKoreButton();
            this.StatusTxt = new Sulakore.Components.SKoreLabel();
            this.VariablesVw = new Sulakore.Components.SKoreListView();
            this.VariableCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrowseClientDlg = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConnectBtn.Location = new System.Drawing.Point(367, 284);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 20);
            this.ConnectBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ConnectBtn.TabIndex = 2;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ProxyPortTxt
            // 
            this.ProxyPortTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ProxyPortTxt.Location = new System.Drawing.Point(367, 225);
            this.ProxyPortTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ProxyPortTxt.Name = "ProxyPortTxt";
            this.ProxyPortTxt.Size = new System.Drawing.Size(100, 20);
            this.ProxyPortTxt.TabIndex = 119;
            this.ProxyPortTxt.Text = "Proxy Port";
            this.ProxyPortTxt.Value = "0";
            this.ProxyPortTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProxyPortTxt.ValueReadOnly = true;
            // 
            // VariableTxt
            // 
            this.VariableTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.VariableTxt.Location = new System.Drawing.Point(3, 192);
            this.VariableTxt.Name = "VariableTxt";
            this.VariableTxt.Size = new System.Drawing.Size(340, 20);
            this.VariableTxt.TabIndex = 118;
            this.VariableTxt.Text = "Variable";
            this.VariableTxt.Value = "";
            this.VariableTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VariableTxt.ValueReadOnly = true;
            // 
            // ValueTxt
            // 
            this.ValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ValueTxt.Location = new System.Drawing.Point(3, 166);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(340, 20);
            this.ValueTxt.TabIndex = 117;
            this.ValueTxt.Text = "Value";
            this.ValueTxt.Value = "";
            this.ValueTxt.ValueAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomClientTxt
            // 
            this.CustomClientTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CustomClientTxt.Location = new System.Drawing.Point(3, 251);
            this.CustomClientTxt.Name = "CustomClientTxt";
            this.CustomClientTxt.Size = new System.Drawing.Size(358, 20);
            this.CustomClientTxt.TabIndex = 116;
            this.CustomClientTxt.Text = "Custom Client";
            this.CustomClientTxt.Value = "";
            this.CustomClientTxt.ValueReadOnly = true;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBtn.Location = new System.Drawing.Point(367, 251);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(100, 20);
            this.BrowseBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.BrowseBtn.TabIndex = 109;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ExportRootCertificateBtn
            // 
            this.ExportRootCertificateBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExportRootCertificateBtn.Location = new System.Drawing.Point(185, 225);
            this.ExportRootCertificateBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ExportRootCertificateBtn.Name = "ExportRootCertificateBtn";
            this.ExportRootCertificateBtn.Size = new System.Drawing.Size(176, 20);
            this.ExportRootCertificateBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ExportRootCertificateBtn.TabIndex = 112;
            this.ExportRootCertificateBtn.Text = "Export Root Certificate";
            this.ExportRootCertificateBtn.Click += new System.EventHandler(this.ExportRootCertificateBtn_Click);
            // 
            // DestroyCertificatesBtn
            // 
            this.DestroyCertificatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.DestroyCertificatesBtn.Location = new System.Drawing.Point(3, 225);
            this.DestroyCertificatesBtn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.DestroyCertificatesBtn.Name = "DestroyCertificatesBtn";
            this.DestroyCertificatesBtn.Size = new System.Drawing.Size(176, 20);
            this.DestroyCertificatesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DestroyCertificatesBtn.TabIndex = 110;
            this.DestroyCertificatesBtn.Text = "Destroy Certificate(s)";
            this.DestroyCertificatesBtn.Click += new System.EventHandler(this.DestroyCertificatesBtn_Click);
            // 
            // ResetVariableBtn
            // 
            this.ResetVariableBtn.BackColor = System.Drawing.Color.Transparent;
            this.ResetVariableBtn.Enabled = false;
            this.ResetVariableBtn.Location = new System.Drawing.Point(349, 192);
            this.ResetVariableBtn.Name = "ResetVariableBtn";
            this.ResetVariableBtn.Size = new System.Drawing.Size(118, 20);
            this.ResetVariableBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ResetVariableBtn.TabIndex = 114;
            this.ResetVariableBtn.Text = "Reset Variable";
            this.ResetVariableBtn.Click += new System.EventHandler(this.ResetVariableBtn_Click);
            // 
            // SetVariableBtn
            // 
            this.SetVariableBtn.BackColor = System.Drawing.Color.Transparent;
            this.SetVariableBtn.Enabled = false;
            this.SetVariableBtn.Location = new System.Drawing.Point(349, 166);
            this.SetVariableBtn.Name = "SetVariableBtn";
            this.SetVariableBtn.Size = new System.Drawing.Size(118, 20);
            this.SetVariableBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SetVariableBtn.TabIndex = 113;
            this.SetVariableBtn.Text = "Set Variable";
            this.SetVariableBtn.Click += new System.EventHandler(this.SetVariableBtn_Click);
            // 
            // StatusTxt
            // 
            this.StatusTxt.Interval = 500D;
            this.StatusTxt.Location = new System.Drawing.Point(3, 284);
            this.StatusTxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(358, 20);
            this.StatusTxt.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusTxt.TabIndex = 111;
            this.StatusTxt.Text = "Standing By...";
            // 
            // VariablesVw
            // 
            this.VariablesVw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VariablesVw.CheckBoxes = true;
            this.VariablesVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VariableCol,
            this.ValueCol});
            this.VariablesVw.FullRowSelect = true;
            this.VariablesVw.GridLines = true;
            this.VariablesVw.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.VariablesVw.HideSelection = false;
            this.VariablesVw.Location = new System.Drawing.Point(3, 3);
            this.VariablesVw.MultiSelect = false;
            this.VariablesVw.Name = "VariablesVw";
            this.VariablesVw.ShowItemToolTips = true;
            this.VariablesVw.Size = new System.Drawing.Size(464, 157);
            this.VariablesVw.TabIndex = 115;
            this.VariablesVw.UseCompatibleStateImageBehavior = false;
            this.VariablesVw.View = System.Windows.Forms.View.Details;
            this.VariablesVw.ItemSelectionStateChanged += new System.EventHandler(this.VariablesVw_ItemSelectionStateChanged);
            this.VariablesVw.ItemSelected += new System.EventHandler(this.VariablesVw_ItemSelected);
            this.VariablesVw.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.VariablesVw_ItemCheck);
            this.VariablesVw.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.VariablesVw_ItemChecked);
            // 
            // VariableCol
            // 
            this.VariableCol.Text = "Variable";
            this.VariableCol.Width = 221;
            // 
            // ValueCol
            // 
            this.ValueCol.Text = "Value";
            this.ValueCol.Width = 222;
            // 
            // BrowseClientDlg
            // 
            this.BrowseClientDlg.DefaultExt = "swf";
            this.BrowseClientDlg.Filter = "Shockwave Flash File (*.swf)|*.swf";
            this.BrowseClientDlg.Title = "Tanji ~ Custom Client";
            // 
            // ConnectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProxyPortTxt);
            this.Controls.Add(this.VariableTxt);
            this.Controls.Add(this.ValueTxt);
            this.Controls.Add(this.CustomClientTxt);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.ExportRootCertificateBtn);
            this.Controls.Add(this.DestroyCertificatesBtn);
            this.Controls.Add(this.ResetVariableBtn);
            this.Controls.Add(this.SetVariableBtn);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.VariablesVw);
            this.Controls.Add(this.ConnectBtn);
            this.Name = "ConnectionPage";
            this.Size = new System.Drawing.Size(470, 307);
            this.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.ConnectionPage_PropertyChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader VariableCol;
        private System.Windows.Forms.ColumnHeader ValueCol;
        private Sulakore.Components.SKoreButton ConnectBtn;
        private Sulakore.Components.SKoreLabelBox ProxyPortTxt;
        private Sulakore.Components.SKoreLabelBox VariableTxt;
        private Sulakore.Components.SKoreLabelBox ValueTxt;
        private Sulakore.Components.SKoreLabelBox CustomClientTxt;
        private Sulakore.Components.SKoreButton BrowseBtn;
        private Sulakore.Components.SKoreButton ExportRootCertificateBtn;
        private Sulakore.Components.SKoreButton DestroyCertificatesBtn;
        private Sulakore.Components.SKoreButton ResetVariableBtn;
        private Sulakore.Components.SKoreButton SetVariableBtn;
        private Sulakore.Components.SKoreLabel StatusTxt;
        private Sulakore.Components.SKoreListView VariablesVw;
        private System.Windows.Forms.OpenFileDialog BrowseClientDlg;
    }
}
