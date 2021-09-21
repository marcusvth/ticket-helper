namespace tickethelper.Ui.Core
{
    partial class AccountDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetailsForm));
            this.listGroups = new System.Windows.Forms.ListBox();
            this.contextGroups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarGrupoSelecionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarTodosOsGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbGroupsHeader = new System.Windows.Forms.Label();
            this.lbO365LicenseHeader = new System.Windows.Forms.Label();
            this.lbEmployeeTypeHeader = new System.Windows.Forms.Label();
            this.lbDescriptionHeader = new System.Windows.Forms.Label();
            this.lbInfoHeader = new System.Windows.Forms.Label();
            this.lbO365License = new System.Windows.Forms.Label();
            this.lbEmployeeType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbVpnAccessHeader = new System.Windows.Forms.Label();
            this.lbProxy = new System.Windows.Forms.Label();
            this.lbAzure = new System.Windows.Forms.Label();
            this.pbAzure = new System.Windows.Forms.PictureBox();
            this.pbProxy = new System.Windows.Forms.PictureBox();
            this.pbVpn = new System.Windows.Forms.PictureBox();
            this.btnLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listGroups
            // 
            this.listGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGroups.ContextMenuStrip = this.contextGroups;
            this.listGroups.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listGroups.ForeColor = System.Drawing.Color.Black;
            this.listGroups.FormattingEnabled = true;
            this.listGroups.ItemHeight = 20;
            this.listGroups.Location = new System.Drawing.Point(27, 268);
            this.listGroups.Name = "listGroups";
            this.listGroups.Size = new System.Drawing.Size(399, 182);
            this.listGroups.TabIndex = 0;
            // 
            // contextGroups
            // 
            this.contextGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarGrupoSelecionadoToolStripMenuItem,
            this.copiarTodosOsGruposToolStripMenuItem});
            this.contextGroups.Name = "contextHeiwayGroups";
            this.contextGroups.Size = new System.Drawing.Size(211, 48);
            // 
            // copiarGrupoSelecionadoToolStripMenuItem
            // 
            this.copiarGrupoSelecionadoToolStripMenuItem.Name = "copiarGrupoSelecionadoToolStripMenuItem";
            this.copiarGrupoSelecionadoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.copiarGrupoSelecionadoToolStripMenuItem.Text = "Copiar grupo selecionado";
            this.copiarGrupoSelecionadoToolStripMenuItem.Click += new System.EventHandler(this.CopySelectedGroupItem_Click);
            // 
            // copiarTodosOsGruposToolStripMenuItem
            // 
            this.copiarTodosOsGruposToolStripMenuItem.Name = "copiarTodosOsGruposToolStripMenuItem";
            this.copiarTodosOsGruposToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.copiarTodosOsGruposToolStripMenuItem.Text = "Copiar todos os grupos";
            this.copiarTodosOsGruposToolStripMenuItem.Click += new System.EventHandler(this.CopyAllGroupsItem_Click);
            // 
            // lbGroupsHeader
            // 
            this.lbGroupsHeader.AutoSize = true;
            this.lbGroupsHeader.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbGroupsHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbGroupsHeader.Location = new System.Drawing.Point(185, 240);
            this.lbGroupsHeader.Name = "lbGroupsHeader";
            this.lbGroupsHeader.Size = new System.Drawing.Size(73, 25);
            this.lbGroupsHeader.TabIndex = 69;
            this.lbGroupsHeader.Text = "Grupos";
            this.lbGroupsHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbO365LicenseHeader
            // 
            this.lbO365LicenseHeader.AutoSize = true;
            this.lbO365LicenseHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbO365LicenseHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbO365LicenseHeader.Location = new System.Drawing.Point(24, 197);
            this.lbO365LicenseHeader.Name = "lbO365LicenseHeader";
            this.lbO365LicenseHeader.Size = new System.Drawing.Size(175, 17);
            this.lbO365LicenseHeader.TabIndex = 73;
            this.lbO365LicenseHeader.Text = "Licença do Office365/Intune";
            // 
            // lbEmployeeTypeHeader
            // 
            this.lbEmployeeTypeHeader.AutoSize = true;
            this.lbEmployeeTypeHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeTypeHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbEmployeeTypeHeader.Location = new System.Drawing.Point(24, 157);
            this.lbEmployeeTypeHeader.Name = "lbEmployeeTypeHeader";
            this.lbEmployeeTypeHeader.Size = new System.Drawing.Size(95, 17);
            this.lbEmployeeTypeHeader.TabIndex = 74;
            this.lbEmployeeTypeHeader.Text = "EmployeeType";
            // 
            // lbDescriptionHeader
            // 
            this.lbDescriptionHeader.AutoSize = true;
            this.lbDescriptionHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptionHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbDescriptionHeader.Location = new System.Drawing.Point(23, 71);
            this.lbDescriptionHeader.Name = "lbDescriptionHeader";
            this.lbDescriptionHeader.Size = new System.Drawing.Size(65, 17);
            this.lbDescriptionHeader.TabIndex = 75;
            this.lbDescriptionHeader.Text = "Descrição";
            // 
            // lbInfoHeader
            // 
            this.lbInfoHeader.AutoSize = true;
            this.lbInfoHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbInfoHeader.Location = new System.Drawing.Point(23, 114);
            this.lbInfoHeader.Name = "lbInfoHeader";
            this.lbInfoHeader.Size = new System.Drawing.Size(72, 17);
            this.lbInfoHeader.TabIndex = 76;
            this.lbInfoHeader.Text = "Anotações";
            // 
            // lbO365License
            // 
            this.lbO365License.AutoSize = true;
            this.lbO365License.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbO365License.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbO365License.Location = new System.Drawing.Point(23, 216);
            this.lbO365License.Name = "lbO365License";
            this.lbO365License.Size = new System.Drawing.Size(413, 19);
            this.lbO365License.TabIndex = 77;
            this.lbO365License.Text = "ENTERPRISEPACK|RMS_S_ENTERPRISE|OFFICESUBSCRIPTION|MC...";
            this.lbO365License.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbEmployeeType
            // 
            this.lbEmployeeType.AutoSize = true;
            this.lbEmployeeType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbEmployeeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbEmployeeType.Location = new System.Drawing.Point(23, 174);
            this.lbEmployeeType.Name = "lbEmployeeType";
            this.lbEmployeeType.Size = new System.Drawing.Size(38, 19);
            this.lbEmployeeType.TabIndex = 78;
            this.lbEmployeeType.Text = "FOO";
            this.lbEmployeeType.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbDescription.Location = new System.Drawing.Point(23, 88);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(215, 19);
            this.lbDescription.TabIndex = 79;
            this.lbDescription.Text = "Disabled by HeiDM - 29/02/2020";
            this.lbDescription.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbInfo.Location = new System.Drawing.Point(22, 131);
            this.lbInfo.MaximumSize = new System.Drawing.Size(0, 19);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(323, 19);
            this.lbInfo.TabIndex = 80;
            this.lbInfo.Text = "SCTASK0000009 - Prorrogação de data de validade";
            this.lbInfo.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbVpnAccessHeader
            // 
            this.lbVpnAccessHeader.AutoSize = true;
            this.lbVpnAccessHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbVpnAccessHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbVpnAccessHeader.Location = new System.Drawing.Point(48, 464);
            this.lbVpnAccessHeader.Name = "lbVpnAccessHeader";
            this.lbVpnAccessHeader.Size = new System.Drawing.Size(89, 17);
            this.lbVpnAccessHeader.TabIndex = 81;
            this.lbVpnAccessHeader.Text = "Acesso à VPN";
            // 
            // lbProxy
            // 
            this.lbProxy.AutoSize = true;
            this.lbProxy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbProxy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbProxy.Location = new System.Drawing.Point(48, 514);
            this.lbProxy.Name = "lbProxy";
            this.lbProxy.Size = new System.Drawing.Size(182, 17);
            this.lbProxy.TabIndex = 82;
            this.lbProxy.Text = "BR1-ProxyServiceStandard-US";
            this.lbProxy.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbAzure
            // 
            this.lbAzure.AutoSize = true;
            this.lbAzure.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbAzure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbAzure.Location = new System.Drawing.Point(48, 489);
            this.lbAzure.Name = "lbAzure";
            this.lbAzure.Size = new System.Drawing.Size(106, 17);
            this.lbAzure.TabIndex = 83;
            this.lbAzure.Text = "BR1-AzureAD-US";
            this.lbAzure.Click += new System.EventHandler(this.Labels_Click);
            // 
            // pbAzure
            // 
            this.pbAzure.Image = ((System.Drawing.Image)(resources.GetObject("pbAzure.Image")));
            this.pbAzure.Location = new System.Drawing.Point(27, 490);
            this.pbAzure.Name = "pbAzure";
            this.pbAzure.Size = new System.Drawing.Size(16, 16);
            this.pbAzure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAzure.TabIndex = 86;
            this.pbAzure.TabStop = false;
            // 
            // pbProxy
            // 
            this.pbProxy.Image = ((System.Drawing.Image)(resources.GetObject("pbProxy.Image")));
            this.pbProxy.Location = new System.Drawing.Point(27, 515);
            this.pbProxy.Name = "pbProxy";
            this.pbProxy.Size = new System.Drawing.Size(16, 16);
            this.pbProxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProxy.TabIndex = 85;
            this.pbProxy.TabStop = false;
            // 
            // pbVpn
            // 
            this.pbVpn.Image = ((System.Drawing.Image)(resources.GetObject("pbVpn.Image")));
            this.pbVpn.Location = new System.Drawing.Point(27, 465);
            this.pbVpn.Name = "pbVpn";
            this.pbVpn.Size = new System.Drawing.Size(16, 16);
            this.pbVpn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVpn.TabIndex = 84;
            this.pbVpn.TabStop = false;
            // 
            // btnLicense
            // 
            this.btnLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLicense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btnLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLicense.ForeColor = System.Drawing.Color.Black;
            this.btnLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnLicense.Image")));
            this.btnLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLicense.Location = new System.Drawing.Point(61, 549);
            this.btnLicense.Name = "btnLicense";
            this.btnLicense.Size = new System.Drawing.Size(329, 33);
            this.btnLicense.TabIndex = 71;
            this.btnLicense.TabStop = false;
            this.btnLicense.Text = "Atribuir licença padrão do Intune / Office 365";
            this.btnLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLicense.UseVisualStyleBackColor = false;
            this.btnLicense.Click += new System.EventHandler(this.BtnLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // AccountDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbAzure);
            this.Controls.Add(this.pbProxy);
            this.Controls.Add(this.pbVpn);
            this.Controls.Add(this.lbAzure);
            this.Controls.Add(this.lbProxy);
            this.Controls.Add(this.lbVpnAccessHeader);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbEmployeeType);
            this.Controls.Add(this.lbO365License);
            this.Controls.Add(this.lbInfoHeader);
            this.Controls.Add(this.lbDescriptionHeader);
            this.Controls.Add(this.lbEmployeeTypeHeader);
            this.Controls.Add(this.lbO365LicenseHeader);
            this.Controls.Add(this.btnLicense);
            this.Controls.Add(this.lbGroupsHeader);
            this.Controls.Add(this.listGroups);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountDetailsForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "    Detalhes da conta MisterM20";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.CompactUiDetails_Shown);
            this.contextGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listGroups;
        private System.Windows.Forms.ContextMenuStrip contextGroups;
        private System.Windows.Forms.ToolStripMenuItem copiarGrupoSelecionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarTodosOsGruposToolStripMenuItem;
        private System.Windows.Forms.Label lbGroupsHeader;
        private System.Windows.Forms.Button btnLicense;
        private System.Windows.Forms.Label lbO365LicenseHeader;
        private System.Windows.Forms.Label lbEmployeeTypeHeader;
        private System.Windows.Forms.Label lbDescriptionHeader;
        private System.Windows.Forms.Label lbInfoHeader;
        private System.Windows.Forms.Label lbO365License;
        private System.Windows.Forms.Label lbEmployeeType;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbVpnAccessHeader;
        private System.Windows.Forms.Label lbProxy;
        private System.Windows.Forms.Label lbAzure;
        private System.Windows.Forms.PictureBox pbVpn;
        private System.Windows.Forms.PictureBox pbProxy;
        private System.Windows.Forms.PictureBox pbAzure;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}