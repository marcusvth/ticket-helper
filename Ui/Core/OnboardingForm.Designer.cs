namespace tickethelper
{
    partial class OnboardingForm
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
            this.lbDisplayNameHeader = new System.Windows.Forms.Label();
            this.lbIdHeader = new System.Windows.Forms.Label();
            this.lbDepartmentHeader = new System.Windows.Forms.Label();
            this.lbTitleHeader = new System.Windows.Forms.Label();
            this.lbCompanyHeader = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.pbUserNotFound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNotFound)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDisplayNameHeader
            // 
            this.lbDisplayNameHeader.AutoSize = true;
            this.lbDisplayNameHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDisplayNameHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbDisplayNameHeader.Location = new System.Drawing.Point(12, 99);
            this.lbDisplayNameHeader.Name = "lbDisplayNameHeader";
            this.lbDisplayNameHeader.Size = new System.Drawing.Size(50, 19);
            this.lbDisplayNameHeader.TabIndex = 74;
            this.lbDisplayNameHeader.Text = "Nome";
            this.lbDisplayNameHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbIdHeader
            // 
            this.lbIdHeader.AutoSize = true;
            this.lbIdHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbIdHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbIdHeader.Location = new System.Drawing.Point(12, 64);
            this.lbIdHeader.Name = "lbIdHeader";
            this.lbIdHeader.Size = new System.Drawing.Size(23, 19);
            this.lbIdHeader.TabIndex = 75;
            this.lbIdHeader.Text = "ID";
            this.lbIdHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDepartmentHeader
            // 
            this.lbDepartmentHeader.AutoSize = true;
            this.lbDepartmentHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbDepartmentHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbDepartmentHeader.Location = new System.Drawing.Point(12, 169);
            this.lbDepartmentHeader.Name = "lbDepartmentHeader";
            this.lbDepartmentHeader.Size = new System.Drawing.Size(106, 19);
            this.lbDepartmentHeader.TabIndex = 77;
            this.lbDepartmentHeader.Text = "Departamento";
            this.lbDepartmentHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTitleHeader
            // 
            this.lbTitleHeader.AutoSize = true;
            this.lbTitleHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbTitleHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbTitleHeader.Location = new System.Drawing.Point(12, 134);
            this.lbTitleHeader.Name = "lbTitleHeader";
            this.lbTitleHeader.Size = new System.Drawing.Size(50, 19);
            this.lbTitleHeader.TabIndex = 76;
            this.lbTitleHeader.Text = "Cargo";
            this.lbTitleHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCompanyHeader
            // 
            this.lbCompanyHeader.AutoSize = true;
            this.lbCompanyHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCompanyHeader.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbCompanyHeader.Location = new System.Drawing.Point(12, 204);
            this.lbCompanyHeader.Name = "lbCompanyHeader";
            this.lbCompanyHeader.Size = new System.Drawing.Size(66, 19);
            this.lbCompanyHeader.TabIndex = 78;
            this.lbCompanyHeader.Text = "Empresa";
            this.lbCompanyHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbId.ForeColor = System.Drawing.Color.Honeydew;
            this.lbId.Location = new System.Drawing.Point(129, 62);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(71, 19);
            this.lbId.TabIndex = 80;
            this.lbId.Text = "MisterM20";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbId.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbDisplayName.ForeColor = System.Drawing.Color.Honeydew;
            this.lbDisplayName.Location = new System.Drawing.Point(129, 99);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(256, 19);
            this.lbDisplayName.TabIndex = 81;
            this.lbDisplayName.Text = "Marcus Vinícius Theodoro Martins da Silva";
            this.lbDisplayName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDisplayName.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbTitle.ForeColor = System.Drawing.Color.Honeydew;
            this.lbTitle.Location = new System.Drawing.Point(129, 134);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(121, 19);
            this.lbTitle.TabIndex = 82;
            this.lbTitle.Text = "Service Desk Agent";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTitle.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbDepartment.ForeColor = System.Drawing.Color.Honeydew;
            this.lbDepartment.Location = new System.Drawing.Point(129, 169);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(28, 19);
            this.lbDepartment.TabIndex = 83;
            this.lbDepartment.Text = "GIS";
            this.lbDepartment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDepartment.Click += new System.EventHandler(this.Labels_Click);
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbCompany.ForeColor = System.Drawing.Color.Honeydew;
            this.lbCompany.Location = new System.Drawing.Point(129, 204);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(64, 19);
            this.lbCompany.TabIndex = 84;
            this.lbCompany.Text = "Microsoft";
            this.lbCompany.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCompany.Click += new System.EventHandler(this.Labels_Click);
            // 
            // pbUserNotFound
            // 
            this.pbUserNotFound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbUserNotFound.Image = global::tickethelper.Properties.Resources.account_not_found;
            this.pbUserNotFound.Location = new System.Drawing.Point(148, 88);
            this.pbUserNotFound.Name = "pbUserNotFound";
            this.pbUserNotFound.Size = new System.Drawing.Size(111, 107);
            this.pbUserNotFound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserNotFound.TabIndex = 86;
            this.pbUserNotFound.TabStop = false;
            this.pbUserNotFound.Visible = false;
            // 
            // OnboardingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 237);
            this.Controls.Add(this.pbUserNotFound);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbDisplayName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbCompanyHeader);
            this.Controls.Add(this.lbDepartmentHeader);
            this.Controls.Add(this.lbTitleHeader);
            this.Controls.Add(this.lbIdHeader);
            this.Controls.Add(this.lbDisplayNameHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnboardingForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = " Painel de Onboarding";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnboardingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserNotFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDisplayNameHeader;
        private System.Windows.Forms.Label lbIdHeader;
        private System.Windows.Forms.Label lbDepartmentHeader;
        private System.Windows.Forms.Label lbTitleHeader;
        private System.Windows.Forms.Label lbCompanyHeader;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbCompany;
        private System.Windows.Forms.PictureBox pbUserNotFound;
    }
}