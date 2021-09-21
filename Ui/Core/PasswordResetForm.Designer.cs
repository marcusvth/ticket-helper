namespace tickethelper.Ui
{
    partial class PasswordResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.cbTemporary = new MetroFramework.Controls.MetroCheckBox();
            this.btnSendViaMail = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cbCcManager = new MetroFramework.Controls.MetroCheckBox();
            this.spnLoading = new MetroFramework.Controls.MetroProgressSpinner();
            this.lbDateDiff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnOk.Location = new System.Drawing.Point(202, 158);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 10;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCancel.Location = new System.Drawing.Point(283, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(28, 87);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PromptText = "Insira uma nova senha...";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(229, 28);
            this.tbPassword.Style = MetroFramework.MetroColorStyle.Green;
            this.tbPassword.TabIndex = 14;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMark = "Insira uma nova senha...";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.TextChanged += new System.EventHandler(this.TbPassword_TextChanged);
            // 
            // cbTemporary
            // 
            this.cbTemporary.AutoSize = true;
            this.cbTemporary.BackColor = System.Drawing.SystemColors.Control;
            this.cbTemporary.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbTemporary.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.cbTemporary.Location = new System.Drawing.Point(28, 121);
            this.cbTemporary.Name = "cbTemporary";
            this.cbTemporary.Size = new System.Drawing.Size(176, 19);
            this.cbTemporary.Style = MetroFramework.MetroColorStyle.Green;
            this.cbTemporary.TabIndex = 15;
            this.cbTemporary.Text = "Alterar no próximo logon";
            this.cbTemporary.UseCustomForeColor = true;
            this.cbTemporary.UseSelectable = true;
            this.cbTemporary.UseStyleColors = true;
            // 
            // btnSendViaMail
            // 
            this.btnSendViaMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendViaMail.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSendViaMail.FlatAppearance.BorderSize = 0;
            this.btnSendViaMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSendViaMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSendViaMail.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.btnSendViaMail.Image = global::tickethelper.Properties.Resources.send_mail;
            this.btnSendViaMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendViaMail.Location = new System.Drawing.Point(27, 156);
            this.btnSendViaMail.Name = "btnSendViaMail";
            this.btnSendViaMail.Size = new System.Drawing.Size(159, 39);
            this.btnSendViaMail.TabIndex = 17;
            this.btnSendViaMail.TabStop = false;
            this.btnSendViaMail.Text = "Encaminhar por e-mail";
            this.btnSendViaMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendViaMail.UseVisualStyleBackColor = true;
            this.btnSendViaMail.Click += new System.EventHandler(this.BtnSendViaMail_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRandom.FlatAppearance.BorderSize = 0;
            this.btnRandom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRandom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnRandom.Image = ((System.Drawing.Image)(resources.GetObject("btnRandom.Image")));
            this.btnRandom.Location = new System.Drawing.Point(271, 80);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(51, 39);
            this.btnRandom.TabIndex = 13;
            this.btnRandom.TabStop = false;
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // cbCcManager
            // 
            this.cbCcManager.AutoSize = true;
            this.cbCcManager.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbCcManager.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.cbCcManager.Location = new System.Drawing.Point(28, 202);
            this.cbCcManager.Name = "cbCcManager";
            this.cbCcManager.Size = new System.Drawing.Size(132, 19);
            this.cbCcManager.Style = MetroFramework.MetroColorStyle.Green;
            this.cbCcManager.TabIndex = 18;
            this.cbCcManager.TabStop = false;
            this.cbCcManager.Text = "Cópia para gestor";
            this.cbCcManager.UseSelectable = true;
            // 
            // spnLoading
            // 
            this.spnLoading.Location = new System.Drawing.Point(167, 51);
            this.spnLoading.Maximum = 100;
            this.spnLoading.Name = "spnLoading";
            this.spnLoading.Size = new System.Drawing.Size(32, 32);
            this.spnLoading.Style = MetroFramework.MetroColorStyle.Green;
            this.spnLoading.TabIndex = 19;
            this.spnLoading.UseSelectable = true;
            this.spnLoading.Visible = false;
            // 
            // lbDateDiff
            // 
            this.lbDateDiff.BackColor = System.Drawing.Color.Transparent;
            this.lbDateDiff.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDiff.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbDateDiff.Location = new System.Drawing.Point(1, 119);
            this.lbDateDiff.Name = "lbDateDiff";
            this.lbDateDiff.Size = new System.Drawing.Size(366, 30);
            this.lbDateDiff.TabIndex = 20;
            this.lbDateDiff.Text = "Senha atual: zRdHJm9!tD9VF8\r\nPróximo reset em 10 horas, 20 minutos e 40 segundos";
            this.lbDateDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDateDiff.Visible = false;
            // 
            // PasswordResetForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(367, 204);
            this.Controls.Add(this.lbDateDiff);
            this.Controls.Add(this.spnLoading);
            this.Controls.Add(this.cbCcManager);
            this.Controls.Add(this.btnSendViaMail);
            this.Controls.Add(this.cbTemporary);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordResetForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Alterar senha de MisterM20";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.PasswordResetForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRandom;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroCheckBox cbTemporary;
        private System.Windows.Forms.Button btnSendViaMail;
        private MetroFramework.Controls.MetroCheckBox cbCcManager;
        private MetroFramework.Controls.MetroProgressSpinner spnLoading;
        private System.Windows.Forms.Label lbDateDiff;
    }
}