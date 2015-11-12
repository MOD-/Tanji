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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectFrm));
            this.CTGamePortsLbl = new System.Windows.Forms.Label();
            this.CTGameHostLbl = new System.Windows.Forms.Label();
            this.ChooseClientDlg = new System.Windows.Forms.OpenFileDialog();
            this.StatusTxt = new Sulakore.Components.SKoreLabel();
            this.ConnectBtn = new Sulakore.Components.SKoreButton();
            this.CTGameHostTxt = new System.Windows.Forms.TextBox();
            this.CTGamePortsTxt = new System.Windows.Forms.TextBox();
            this.ConnectTabs = new Sulakore.Components.SKoreTabControl();
            this.ConnectionTab = new System.Windows.Forms.TabPage();
            this.CTCustomClientGrpbx = new System.Windows.Forms.GroupBox();
            this.CTBrowseBtn = new Sulakore.Components.SKoreButton();
            this.CTCustomClientTxt = new System.Windows.Forms.TextBox();
            this.CTLocalProxySettingsGrpbx = new System.Windows.Forms.GroupBox();
            this.CTProxyPortLbl = new System.Windows.Forms.Label();
            this.CTProxyPortTxt = new System.Windows.Forms.NumericUpDown();
            this.CTRemoteProxyLbl = new System.Windows.Forms.Label();
            this.CTDestroyCertificatesBtn = new Sulakore.Components.SKoreButton();
            this.CTRemoteProxyTxt = new System.Windows.Forms.TextBox();
            this.CTExportRootCertificateAuthorityBtn = new Sulakore.Components.SKoreButton();
            this.HandshakeTab = new System.Windows.Forms.TabPage();
            this.HTPrivateExponentGrpbx = new System.Windows.Forms.GroupBox();
            this.HTPrivateExponentTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HTPublicExponentGrpbx = new System.Windows.Forms.GroupBox();
            this.HTPublicExponentTxt = new System.Windows.Forms.TextBox();
            this.HTPublicModulusGrpbx = new System.Windows.Forms.GroupBox();
            this.HTPublicModulusTxt = new System.Windows.Forms.TextBox();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ATReleasesBtn = new Sulakore.Components.SKoreButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ATDownloadsLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ATRagezoneBtn = new Sulakore.Components.SKoreButton();
            this.ATDonationsBtn = new Sulakore.Components.SKoreButton();
            this.ATDarkboxBtn = new Sulakore.Components.SKoreButton();
            this.ATVerticalGlowPnl = new System.Windows.Forms.Panel();
            this.ATMakeCertBtn = new Sulakore.Components.SKoreButton();
            this.ATIconLogoBtn = new Sulakore.Components.SKoreButton();
            this.ATSulakoreBtn = new Sulakore.Components.SKoreButton();
            this.ATTanjiBtn = new Sulakore.Components.SKoreButton();
            this.ATHorizontalGlowPnl = new System.Windows.Forms.Panel();
            this.ATTwitterBtn = new Sulakore.Components.SKoreButton();
            this.ATGitHubBtn = new Sulakore.Components.SKoreButton();
            this.ATTONMLbl = new System.Windows.Forms.Label();
            this.ATCopyrightLbl = new System.Windows.Forms.Label();
            this.ATVersionLbl = new System.Windows.Forms.Label();
            this.ATTanjiLbl = new System.Windows.Forms.Label();
            this.ATLogoPctbx = new System.Windows.Forms.PictureBox();
            this.ConnectTabs.SuspendLayout();
            this.ConnectionTab.SuspendLayout();
            this.CTCustomClientGrpbx.SuspendLayout();
            this.CTLocalProxySettingsGrpbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTProxyPortTxt)).BeginInit();
            this.HandshakeTab.SuspendLayout();
            this.HTPrivateExponentGrpbx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.HTPublicExponentGrpbx.SuspendLayout();
            this.HTPublicModulusGrpbx.SuspendLayout();
            this.AboutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATLogoPctbx)).BeginInit();
            this.SuspendLayout();
            // 
            // CTGamePortsLbl
            // 
            this.CTGamePortsLbl.AutoSize = true;
            this.CTGamePortsLbl.Location = new System.Drawing.Point(188, 7);
            this.CTGamePortsLbl.Name = "CTGamePortsLbl";
            this.CTGamePortsLbl.Size = new System.Drawing.Size(68, 13);
            this.CTGamePortsLbl.TabIndex = 68;
            this.CTGamePortsLbl.Text = "Game Port(s)";
            // 
            // CTGameHostLbl
            // 
            this.CTGameHostLbl.AutoSize = true;
            this.CTGameHostLbl.Location = new System.Drawing.Point(6, 7);
            this.CTGameHostLbl.Name = "CTGameHostLbl";
            this.CTGameHostLbl.Size = new System.Drawing.Size(60, 13);
            this.CTGameHostLbl.TabIndex = 67;
            this.CTGameHostLbl.Text = "Game Host";
            // 
            // ChooseClientDlg
            // 
            this.ChooseClientDlg.DefaultExt = "swf";
            this.ChooseClientDlg.Filter = "Shockwave Flash File (*.swf)|*.swf";
            this.ChooseClientDlg.Title = "Tanji ~ Choose Custom Client";
            // 
            // StatusTxt
            // 
            this.StatusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTxt.AnimationInterval = 500;
            this.StatusTxt.DisplayBoundary = true;
            this.StatusTxt.Location = new System.Drawing.Point(6, 225);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(271, 23);
            this.StatusTxt.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusTxt.TabIndex = 75;
            this.StatusTxt.Text = "Standing By...";
            this.StatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBtn.BackColor = System.Drawing.Color.Transparent;
            this.ConnectBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ConnectBtn.Location = new System.Drawing.Point(283, 225);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(93, 23);
            this.ConnectBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ConnectBtn.TabIndex = 72;
            this.ConnectBtn.TabStop = false;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // CTGameHostTxt
            // 
            this.CTGameHostTxt.Location = new System.Drawing.Point(6, 23);
            this.CTGameHostTxt.Name = "CTGameHostTxt";
            this.CTGameHostTxt.Size = new System.Drawing.Size(175, 20);
            this.CTGameHostTxt.TabIndex = 77;
            this.CTGameHostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CTGamePortsTxt
            // 
            this.CTGamePortsTxt.Location = new System.Drawing.Point(187, 23);
            this.CTGamePortsTxt.Name = "CTGamePortsTxt";
            this.CTGamePortsTxt.Size = new System.Drawing.Size(175, 20);
            this.CTGamePortsTxt.TabIndex = 78;
            this.CTGamePortsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConnectTabs
            // 
            this.ConnectTabs.Controls.Add(this.ConnectionTab);
            this.ConnectTabs.Controls.Add(this.HandshakeTab);
            this.ConnectTabs.Controls.Add(this.AboutTab);
            this.ConnectTabs.DisplayBoundary = true;
            this.ConnectTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConnectTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ConnectTabs.ItemSize = new System.Drawing.Size(124, 24);
            this.ConnectTabs.Location = new System.Drawing.Point(3, 3);
            this.ConnectTabs.Name = "ConnectTabs";
            this.ConnectTabs.SelectedIndex = 0;
            this.ConnectTabs.Size = new System.Drawing.Size(376, 215);
            this.ConnectTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ConnectTabs.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ConnectTabs.TabIndex = 79;
            // 
            // ConnectionTab
            // 
            this.ConnectionTab.Controls.Add(this.CTCustomClientGrpbx);
            this.ConnectionTab.Controls.Add(this.CTLocalProxySettingsGrpbx);
            this.ConnectionTab.Controls.Add(this.CTGamePortsTxt);
            this.ConnectionTab.Controls.Add(this.CTGameHostLbl);
            this.ConnectionTab.Controls.Add(this.CTGameHostTxt);
            this.ConnectionTab.Controls.Add(this.CTGamePortsLbl);
            this.ConnectionTab.Location = new System.Drawing.Point(4, 28);
            this.ConnectionTab.Name = "ConnectionTab";
            this.ConnectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionTab.Size = new System.Drawing.Size(368, 183);
            this.ConnectionTab.TabIndex = 0;
            this.ConnectionTab.Text = "Connection";
            this.ConnectionTab.UseVisualStyleBackColor = true;
            // 
            // CTCustomClientGrpbx
            // 
            this.CTCustomClientGrpbx.Controls.Add(this.CTBrowseBtn);
            this.CTCustomClientGrpbx.Controls.Add(this.CTCustomClientTxt);
            this.CTCustomClientGrpbx.Location = new System.Drawing.Point(6, 130);
            this.CTCustomClientGrpbx.Name = "CTCustomClientGrpbx";
            this.CTCustomClientGrpbx.Size = new System.Drawing.Size(356, 47);
            this.CTCustomClientGrpbx.TabIndex = 85;
            this.CTCustomClientGrpbx.TabStop = false;
            this.CTCustomClientGrpbx.Text = "Custom Client";
            // 
            // CTBrowseBtn
            // 
            this.CTBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTBrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTBrowseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTBrowseBtn.Location = new System.Drawing.Point(264, 19);
            this.CTBrowseBtn.Name = "CTBrowseBtn";
            this.CTBrowseBtn.Size = new System.Drawing.Size(86, 22);
            this.CTBrowseBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTBrowseBtn.TabIndex = 2;
            this.CTBrowseBtn.TabStop = false;
            this.CTBrowseBtn.Text = "Browse";
            this.CTBrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // CTCustomClientTxt
            // 
            this.CTCustomClientTxt.Location = new System.Drawing.Point(6, 21);
            this.CTCustomClientTxt.Name = "CTCustomClientTxt";
            this.CTCustomClientTxt.ReadOnly = true;
            this.CTCustomClientTxt.Size = new System.Drawing.Size(252, 20);
            this.CTCustomClientTxt.TabIndex = 0;
            this.CTCustomClientTxt.TabStop = false;
            // 
            // CTLocalProxySettingsGrpbx
            // 
            this.CTLocalProxySettingsGrpbx.Controls.Add(this.CTProxyPortLbl);
            this.CTLocalProxySettingsGrpbx.Controls.Add(this.CTProxyPortTxt);
            this.CTLocalProxySettingsGrpbx.Controls.Add(this.CTRemoteProxyLbl);
            this.CTLocalProxySettingsGrpbx.Controls.Add(this.CTDestroyCertificatesBtn);
            this.CTLocalProxySettingsGrpbx.Controls.Add(this.CTRemoteProxyTxt);
            this.CTLocalProxySettingsGrpbx.Controls.Add(this.CTExportRootCertificateAuthorityBtn);
            this.CTLocalProxySettingsGrpbx.Location = new System.Drawing.Point(6, 49);
            this.CTLocalProxySettingsGrpbx.Name = "CTLocalProxySettingsGrpbx";
            this.CTLocalProxySettingsGrpbx.Size = new System.Drawing.Size(356, 75);
            this.CTLocalProxySettingsGrpbx.TabIndex = 84;
            this.CTLocalProxySettingsGrpbx.TabStop = false;
            this.CTLocalProxySettingsGrpbx.Text = "Local Proxy Settings";
            // 
            // CTProxyPortLbl
            // 
            this.CTProxyPortLbl.AutoSize = true;
            this.CTProxyPortLbl.Location = new System.Drawing.Point(3, 50);
            this.CTProxyPortLbl.Name = "CTProxyPortLbl";
            this.CTProxyPortLbl.Size = new System.Drawing.Size(58, 13);
            this.CTProxyPortLbl.TabIndex = 86;
            this.CTProxyPortLbl.Text = "Proxy Port:";
            // 
            // CTProxyPortTxt
            // 
            this.CTProxyPortTxt.Location = new System.Drawing.Point(61, 48);
            this.CTProxyPortTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.CTProxyPortTxt.Name = "CTProxyPortTxt";
            this.CTProxyPortTxt.Size = new System.Drawing.Size(71, 20);
            this.CTProxyPortTxt.TabIndex = 87;
            this.CTProxyPortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CTProxyPortTxt.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // CTRemoteProxyLbl
            // 
            this.CTRemoteProxyLbl.AutoSize = true;
            this.CTRemoteProxyLbl.Location = new System.Drawing.Point(135, 50);
            this.CTRemoteProxyLbl.Name = "CTRemoteProxyLbl";
            this.CTRemoteProxyLbl.Size = new System.Drawing.Size(76, 13);
            this.CTRemoteProxyLbl.TabIndex = 90;
            this.CTRemoteProxyLbl.Text = "Remote Proxy:";
            // 
            // CTDestroyCertificatesBtn
            // 
            this.CTDestroyCertificatesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTDestroyCertificatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTDestroyCertificatesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTDestroyCertificatesBtn.Location = new System.Drawing.Point(6, 19);
            this.CTDestroyCertificatesBtn.Name = "CTDestroyCertificatesBtn";
            this.CTDestroyCertificatesBtn.Size = new System.Drawing.Size(126, 22);
            this.CTDestroyCertificatesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTDestroyCertificatesBtn.TabIndex = 88;
            this.CTDestroyCertificatesBtn.TabStop = false;
            this.CTDestroyCertificatesBtn.Text = "Destroy Certificates";
            this.CTDestroyCertificatesBtn.Click += new System.EventHandler(this.CTDestroyCertificatesBtn_Click);
            // 
            // CTRemoteProxyTxt
            // 
            this.CTRemoteProxyTxt.Location = new System.Drawing.Point(211, 47);
            this.CTRemoteProxyTxt.Name = "CTRemoteProxyTxt";
            this.CTRemoteProxyTxt.ReadOnly = true;
            this.CTRemoteProxyTxt.Size = new System.Drawing.Size(139, 20);
            this.CTRemoteProxyTxt.TabIndex = 89;
            this.CTRemoteProxyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CTExportRootCertificateAuthorityBtn
            // 
            this.CTExportRootCertificateAuthorityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CTExportRootCertificateAuthorityBtn.BackColor = System.Drawing.Color.Transparent;
            this.CTExportRootCertificateAuthorityBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CTExportRootCertificateAuthorityBtn.Location = new System.Drawing.Point(138, 19);
            this.CTExportRootCertificateAuthorityBtn.Name = "CTExportRootCertificateAuthorityBtn";
            this.CTExportRootCertificateAuthorityBtn.Size = new System.Drawing.Size(212, 22);
            this.CTExportRootCertificateAuthorityBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CTExportRootCertificateAuthorityBtn.TabIndex = 85;
            this.CTExportRootCertificateAuthorityBtn.TabStop = false;
            this.CTExportRootCertificateAuthorityBtn.Text = "Export Root Certificate Authority";
            this.CTExportRootCertificateAuthorityBtn.Click += new System.EventHandler(this.CTExportRootCertificateAuthorityBtn_Click);
            // 
            // HandshakeTab
            // 
            this.HandshakeTab.Controls.Add(this.HTPrivateExponentGrpbx);
            this.HandshakeTab.Controls.Add(this.groupBox1);
            this.HandshakeTab.Controls.Add(this.HTPublicExponentGrpbx);
            this.HandshakeTab.Controls.Add(this.HTPublicModulusGrpbx);
            this.HandshakeTab.Location = new System.Drawing.Point(4, 28);
            this.HandshakeTab.Name = "HandshakeTab";
            this.HandshakeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HandshakeTab.Size = new System.Drawing.Size(368, 183);
            this.HandshakeTab.TabIndex = 1;
            this.HandshakeTab.Text = "Handshake";
            this.HandshakeTab.UseVisualStyleBackColor = true;
            // 
            // HTPrivateExponentGrpbx
            // 
            this.HTPrivateExponentGrpbx.Controls.Add(this.HTPrivateExponentTxt);
            this.HTPrivateExponentGrpbx.Location = new System.Drawing.Point(6, 57);
            this.HTPrivateExponentGrpbx.Name = "HTPrivateExponentGrpbx";
            this.HTPrivateExponentGrpbx.Size = new System.Drawing.Size(356, 45);
            this.HTPrivateExponentGrpbx.TabIndex = 83;
            this.HTPrivateExponentGrpbx.TabStop = false;
            this.HTPrivateExponentGrpbx.Text = "Private Exponent (Optional)";
            // 
            // HTPrivateExponentTxt
            // 
            this.HTPrivateExponentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HTPrivateExponentTxt.Location = new System.Drawing.Point(6, 19);
            this.HTPrivateExponentTxt.Name = "HTPrivateExponentTxt";
            this.HTPrivateExponentTxt.Size = new System.Drawing.Size(344, 20);
            this.HTPrivateExponentTxt.TabIndex = 0;
            this.HTPrivateExponentTxt.TabStop = false;
            this.HTPrivateExponentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 71);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSA Replacement Keys";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "D:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "N:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(326, 20);
            this.textBox3.TabIndex = 87;
            this.textBox3.TabStop = false;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "E:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 20);
            this.textBox2.TabIndex = 85;
            this.textBox2.TabStop = false;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "3";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HTPublicExponentGrpbx
            // 
            this.HTPublicExponentGrpbx.Controls.Add(this.HTPublicExponentTxt);
            this.HTPublicExponentGrpbx.Location = new System.Drawing.Point(255, 6);
            this.HTPublicExponentGrpbx.Name = "HTPublicExponentGrpbx";
            this.HTPublicExponentGrpbx.Size = new System.Drawing.Size(107, 45);
            this.HTPublicExponentGrpbx.TabIndex = 81;
            this.HTPublicExponentGrpbx.TabStop = false;
            this.HTPublicExponentGrpbx.Text = "Public Exponent";
            // 
            // HTPublicExponentTxt
            // 
            this.HTPublicExponentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HTPublicExponentTxt.Location = new System.Drawing.Point(6, 19);
            this.HTPublicExponentTxt.Name = "HTPublicExponentTxt";
            this.HTPublicExponentTxt.Size = new System.Drawing.Size(95, 20);
            this.HTPublicExponentTxt.TabIndex = 0;
            this.HTPublicExponentTxt.TabStop = false;
            this.HTPublicExponentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HTPublicModulusGrpbx
            // 
            this.HTPublicModulusGrpbx.Controls.Add(this.HTPublicModulusTxt);
            this.HTPublicModulusGrpbx.Location = new System.Drawing.Point(6, 6);
            this.HTPublicModulusGrpbx.Name = "HTPublicModulusGrpbx";
            this.HTPublicModulusGrpbx.Size = new System.Drawing.Size(243, 45);
            this.HTPublicModulusGrpbx.TabIndex = 82;
            this.HTPublicModulusGrpbx.TabStop = false;
            this.HTPublicModulusGrpbx.Text = "Public Modulus";
            // 
            // HTPublicModulusTxt
            // 
            this.HTPublicModulusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HTPublicModulusTxt.Location = new System.Drawing.Point(6, 19);
            this.HTPublicModulusTxt.Name = "HTPublicModulusTxt";
            this.HTPublicModulusTxt.Size = new System.Drawing.Size(231, 20);
            this.HTPublicModulusTxt.TabIndex = 0;
            this.HTPublicModulusTxt.TabStop = false;
            this.HTPublicModulusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.panel3);
            this.AboutTab.Controls.Add(this.ATReleasesBtn);
            this.AboutTab.Controls.Add(this.panel2);
            this.AboutTab.Controls.Add(this.ATDownloadsLbl);
            this.AboutTab.Controls.Add(this.panel1);
            this.AboutTab.Controls.Add(this.ATRagezoneBtn);
            this.AboutTab.Controls.Add(this.ATDonationsBtn);
            this.AboutTab.Controls.Add(this.ATDarkboxBtn);
            this.AboutTab.Controls.Add(this.ATVerticalGlowPnl);
            this.AboutTab.Controls.Add(this.ATMakeCertBtn);
            this.AboutTab.Controls.Add(this.ATIconLogoBtn);
            this.AboutTab.Controls.Add(this.ATSulakoreBtn);
            this.AboutTab.Controls.Add(this.ATTanjiBtn);
            this.AboutTab.Controls.Add(this.ATHorizontalGlowPnl);
            this.AboutTab.Controls.Add(this.ATTwitterBtn);
            this.AboutTab.Controls.Add(this.ATGitHubBtn);
            this.AboutTab.Controls.Add(this.ATTONMLbl);
            this.AboutTab.Controls.Add(this.ATCopyrightLbl);
            this.AboutTab.Controls.Add(this.ATVersionLbl);
            this.AboutTab.Controls.Add(this.ATTanjiLbl);
            this.AboutTab.Controls.Add(this.ATLogoPctbx);
            this.AboutTab.Location = new System.Drawing.Point(4, 28);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(368, 183);
            this.AboutTab.TabIndex = 3;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel3.Location = new System.Drawing.Point(218, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 63);
            this.panel3.TabIndex = 9;
            // 
            // ATReleasesBtn
            // 
            this.ATReleasesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATReleasesBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATReleasesBtn.Location = new System.Drawing.Point(6, 75);
            this.ATReleasesBtn.Name = "ATReleasesBtn";
            this.ATReleasesBtn.Size = new System.Drawing.Size(100, 22);
            this.ATReleasesBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATReleasesBtn.TabIndex = 19;
            this.ATReleasesBtn.Text = "Releases: 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel2.Location = new System.Drawing.Point(6, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 1);
            this.panel2.TabIndex = 18;
            // 
            // ATDownloadsLbl
            // 
            this.ATDownloadsLbl.Location = new System.Drawing.Point(112, 75);
            this.ATDownloadsLbl.Name = "ATDownloadsLbl";
            this.ATDownloadsLbl.Size = new System.Drawing.Size(100, 22);
            this.ATDownloadsLbl.TabIndex = 17;
            this.ATDownloadsLbl.Text = "Downloads: 0";
            this.ATDownloadsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(225, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 1);
            this.panel1.TabIndex = 8;
            // 
            // ATRagezoneBtn
            // 
            this.ATRagezoneBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATRagezoneBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATRagezoneBtn.Location = new System.Drawing.Point(225, 38);
            this.ATRagezoneBtn.Name = "ATRagezoneBtn";
            this.ATRagezoneBtn.Size = new System.Drawing.Size(137, 22);
            this.ATRagezoneBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ATRagezoneBtn.TabIndex = 16;
            this.ATRagezoneBtn.Text = "RaGEZONE";
            // 
            // ATDonationsBtn
            // 
            this.ATDonationsBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATDonationsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATDonationsBtn.Location = new System.Drawing.Point(225, 75);
            this.ATDonationsBtn.Name = "ATDonationsBtn";
            this.ATDonationsBtn.Size = new System.Drawing.Size(137, 22);
            this.ATDonationsBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(126)))), ((int)(((byte)(178)))));
            this.ATDonationsBtn.TabIndex = 15;
            this.ATDonationsBtn.Text = "Donations";
            // 
            // ATDarkboxBtn
            // 
            this.ATDarkboxBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATDarkboxBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATDarkboxBtn.Location = new System.Drawing.Point(225, 10);
            this.ATDarkboxBtn.Name = "ATDarkboxBtn";
            this.ATDarkboxBtn.Size = new System.Drawing.Size(137, 22);
            this.ATDarkboxBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ATDarkboxBtn.TabIndex = 14;
            this.ATDarkboxBtn.Text = "Darkbox";
            // 
            // ATVerticalGlowPnl
            // 
            this.ATVerticalGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATVerticalGlowPnl.Location = new System.Drawing.Point(218, 6);
            this.ATVerticalGlowPnl.Name = "ATVerticalGlowPnl";
            this.ATVerticalGlowPnl.Size = new System.Drawing.Size(1, 94);
            this.ATVerticalGlowPnl.TabIndex = 8;
            // 
            // ATMakeCertBtn
            // 
            this.ATMakeCertBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATMakeCertBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATMakeCertBtn.Location = new System.Drawing.Point(6, 38);
            this.ATMakeCertBtn.Name = "ATMakeCertBtn";
            this.ATMakeCertBtn.Size = new System.Drawing.Size(100, 22);
            this.ATMakeCertBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATMakeCertBtn.TabIndex = 13;
            this.ATMakeCertBtn.Text = "MakeCert";
            // 
            // ATIconLogoBtn
            // 
            this.ATIconLogoBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATIconLogoBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATIconLogoBtn.Location = new System.Drawing.Point(112, 38);
            this.ATIconLogoBtn.Name = "ATIconLogoBtn";
            this.ATIconLogoBtn.Size = new System.Drawing.Size(100, 22);
            this.ATIconLogoBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATIconLogoBtn.TabIndex = 12;
            this.ATIconLogoBtn.Text = "Icon(Logo)";
            // 
            // ATSulakoreBtn
            // 
            this.ATSulakoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATSulakoreBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATSulakoreBtn.Location = new System.Drawing.Point(112, 10);
            this.ATSulakoreBtn.Name = "ATSulakoreBtn";
            this.ATSulakoreBtn.Size = new System.Drawing.Size(100, 22);
            this.ATSulakoreBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATSulakoreBtn.TabIndex = 11;
            this.ATSulakoreBtn.Text = "Sulakore";
            // 
            // ATTanjiBtn
            // 
            this.ATTanjiBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATTanjiBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATTanjiBtn.Location = new System.Drawing.Point(6, 10);
            this.ATTanjiBtn.Name = "ATTanjiBtn";
            this.ATTanjiBtn.Size = new System.Drawing.Size(100, 22);
            this.ATTanjiBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATTanjiBtn.TabIndex = 8;
            this.ATTanjiBtn.Text = "Tanji";
            // 
            // ATHorizontalGlowPnl
            // 
            this.ATHorizontalGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATHorizontalGlowPnl.Location = new System.Drawing.Point(1, 106);
            this.ATHorizontalGlowPnl.Name = "ATHorizontalGlowPnl";
            this.ATHorizontalGlowPnl.Size = new System.Drawing.Size(366, 1);
            this.ATHorizontalGlowPnl.TabIndex = 7;
            // 
            // ATTwitterBtn
            // 
            this.ATTwitterBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATTwitterBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATTwitterBtn.Location = new System.Drawing.Point(230, 122);
            this.ATTwitterBtn.Name = "ATTwitterBtn";
            this.ATTwitterBtn.Size = new System.Drawing.Size(132, 22);
            this.ATTwitterBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATTwitterBtn.TabIndex = 6;
            this.ATTwitterBtn.Text = "Twitter";
            // 
            // ATGitHubBtn
            // 
            this.ATGitHubBtn.BackColor = System.Drawing.Color.Transparent;
            this.ATGitHubBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ATGitHubBtn.Location = new System.Drawing.Point(230, 150);
            this.ATGitHubBtn.Name = "ATGitHubBtn";
            this.ATGitHubBtn.Size = new System.Drawing.Size(132, 22);
            this.ATGitHubBtn.Skin = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ATGitHubBtn.TabIndex = 5;
            this.ATGitHubBtn.Text = "GitHub";
            // 
            // ATTONMLbl
            // 
            this.ATTONMLbl.AutoSize = true;
            this.ATTONMLbl.Location = new System.Drawing.Point(76, 147);
            this.ATTONMLbl.Name = "ATTONMLbl";
            this.ATTONMLbl.Size = new System.Drawing.Size(89, 13);
            this.ATTONMLbl.TabIndex = 4;
            this.ATTONMLbl.Text = "The Old Nut Man";
            // 
            // ATCopyrightLbl
            // 
            this.ATCopyrightLbl.AutoSize = true;
            this.ATCopyrightLbl.Location = new System.Drawing.Point(76, 164);
            this.ATCopyrightLbl.Name = "ATCopyrightLbl";
            this.ATCopyrightLbl.Size = new System.Drawing.Size(136, 13);
            this.ATCopyrightLbl.TabIndex = 3;
            this.ATCopyrightLbl.Text = "Copyright © ArachisH 2015";
            // 
            // ATVersionLbl
            // 
            this.ATVersionLbl.AutoSize = true;
            this.ATVersionLbl.Location = new System.Drawing.Point(76, 130);
            this.ATVersionLbl.Name = "ATVersionLbl";
            this.ATVersionLbl.Size = new System.Drawing.Size(46, 13);
            this.ATVersionLbl.TabIndex = 2;
            this.ATVersionLbl.Text = "v0.0.0.0";
            // 
            // ATTanjiLbl
            // 
            this.ATTanjiLbl.AutoSize = true;
            this.ATTanjiLbl.Location = new System.Drawing.Point(76, 113);
            this.ATTanjiLbl.Name = "ATTanjiLbl";
            this.ATTanjiLbl.Size = new System.Drawing.Size(30, 13);
            this.ATTanjiLbl.TabIndex = 1;
            this.ATTanjiLbl.Text = "Tanji";
            // 
            // ATLogoPctbx
            // 
            this.ATLogoPctbx.ErrorImage = null;
            this.ATLogoPctbx.Image = global::Tanji.Properties.Resources.Tanji64;
            this.ATLogoPctbx.InitialImage = null;
            this.ATLogoPctbx.Location = new System.Drawing.Point(6, 113);
            this.ATLogoPctbx.Name = "ATLogoPctbx";
            this.ATLogoPctbx.Size = new System.Drawing.Size(64, 64);
            this.ATLogoPctbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ATLogoPctbx.TabIndex = 0;
            this.ATLogoPctbx.TabStop = false;
            // 
            // ConnectFrm
            // 
            this.AcceptButton = this.ConnectBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 254);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.ConnectTabs);
            this.Controls.Add(this.ConnectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::Tanji.Properties.Resources.Tanji;
            this.MaximizeBox = false;
            this.Name = "ConnectFrm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Hotel Connect";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectFrm_FormClosed);
            this.Shown += new System.EventHandler(this.ConnectFrm_Shown);
            this.ConnectTabs.ResumeLayout(false);
            this.ConnectionTab.ResumeLayout(false);
            this.ConnectionTab.PerformLayout();
            this.CTCustomClientGrpbx.ResumeLayout(false);
            this.CTCustomClientGrpbx.PerformLayout();
            this.CTLocalProxySettingsGrpbx.ResumeLayout(false);
            this.CTLocalProxySettingsGrpbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTProxyPortTxt)).EndInit();
            this.HandshakeTab.ResumeLayout(false);
            this.HTPrivateExponentGrpbx.ResumeLayout(false);
            this.HTPrivateExponentGrpbx.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HTPublicExponentGrpbx.ResumeLayout(false);
            this.HTPublicExponentGrpbx.PerformLayout();
            this.HTPublicModulusGrpbx.ResumeLayout(false);
            this.HTPublicModulusGrpbx.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ATLogoPctbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CTGamePortsLbl;
        private System.Windows.Forms.Label CTGameHostLbl;
        private Sulakore.Components.SKoreLabel StatusTxt;
        private Sulakore.Components.SKoreButton ConnectBtn;
        private System.Windows.Forms.OpenFileDialog ChooseClientDlg;
        private Sulakore.Components.SKoreTabControl ConnectTabs;
        private System.Windows.Forms.TabPage ConnectionTab;
        private System.Windows.Forms.TabPage HandshakeTab;
        private System.Windows.Forms.TabPage AboutTab;
        private Sulakore.Components.SKoreButton CTBrowseBtn;
        private System.Windows.Forms.TextBox CTCustomClientTxt;
        private System.Windows.Forms.GroupBox HTPublicExponentGrpbx;
        public System.Windows.Forms.TextBox HTPublicExponentTxt;
        private System.Windows.Forms.GroupBox HTPublicModulusGrpbx;
        public System.Windows.Forms.TextBox HTPublicModulusTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox HTPrivateExponentGrpbx;
        public System.Windows.Forms.TextBox HTPrivateExponentTxt;
        private System.Windows.Forms.PictureBox ATLogoPctbx;
        private System.Windows.Forms.Label ATTanjiLbl;
        private System.Windows.Forms.Panel ATHorizontalGlowPnl;
        private System.Windows.Forms.Panel ATVerticalGlowPnl;
        public System.Windows.Forms.Label ATVersionLbl;
        public Sulakore.Components.SKoreButton ATGitHubBtn;
        public Sulakore.Components.SKoreButton ATTwitterBtn;
        public Sulakore.Components.SKoreButton ATTanjiBtn;
        public Sulakore.Components.SKoreButton ATIconLogoBtn;
        public Sulakore.Components.SKoreButton ATSulakoreBtn;
        public Sulakore.Components.SKoreButton ATMakeCertBtn;
        public Sulakore.Components.SKoreButton ATRagezoneBtn;
        public Sulakore.Components.SKoreButton ATDonationsBtn;
        public Sulakore.Components.SKoreButton ATDarkboxBtn;
        private System.Windows.Forms.Label ATCopyrightLbl;
        private System.Windows.Forms.Label ATTONMLbl;
        private System.Windows.Forms.GroupBox CTLocalProxySettingsGrpbx;
        private System.Windows.Forms.Label CTProxyPortLbl;
        private Sulakore.Components.SKoreButton CTExportRootCertificateAuthorityBtn;
        private Sulakore.Components.SKoreButton CTDestroyCertificatesBtn;
        private System.Windows.Forms.Label CTRemoteProxyLbl;
        private System.Windows.Forms.GroupBox CTCustomClientGrpbx;
        public System.Windows.Forms.TextBox CTGameHostTxt;
        public System.Windows.Forms.TextBox CTGamePortsTxt;
        public System.Windows.Forms.NumericUpDown CTProxyPortTxt;
        public System.Windows.Forms.TextBox CTRemoteProxyTxt;
        private System.Windows.Forms.Panel panel1;
        public Sulakore.Components.SKoreButton ATReleasesBtn;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label ATDownloadsLbl;
        private System.Windows.Forms.Panel panel3;
    }
}