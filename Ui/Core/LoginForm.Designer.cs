namespace tickethelper.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lbBadPwd = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUser = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnSignIn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBadPwd
            // 
            this.lbBadPwd.AutoSize = true;
            this.lbBadPwd.BackColor = System.Drawing.Color.Transparent;
            this.lbBadPwd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbBadPwd.ForeColor = System.Drawing.Color.Tomato;
            this.lbBadPwd.Location = new System.Drawing.Point(98, 217);
            this.lbBadPwd.Name = "lbBadPwd";
            this.lbBadPwd.Size = new System.Drawing.Size(181, 19);
            this.lbBadPwd.TabIndex = 7;
            this.lbBadPwd.Text = "Usuário ou senha incorretos";
            this.lbBadPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBadPwd.Visible = false;
            // 
            // lbServer
            // 
            this.lbServer.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServer.ForeColor = System.Drawing.Color.Honeydew;
            this.lbServer.Location = new System.Drawing.Point(38, 110);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(314, 21);
            this.lbServer.TabIndex = 9;
            this.lbServer.Text = "Conecte-se ao servidor LDAP://server1.com";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbUser
            // 
            // 
            // 
            // 
            this.tbUser.CustomButton.Image = null;
            this.tbUser.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.tbUser.CustomButton.Name = "";
            this.tbUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUser.CustomButton.TabIndex = 1;
            this.tbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUser.CustomButton.UseSelectable = true;
            this.tbUser.CustomButton.Visible = false;
            this.tbUser.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbUser.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbUser.Lines = new string[0];
            this.tbUser.Location = new System.Drawing.Point(79, 149);
            this.tbUser.MaxLength = 32767;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.PromptText = "Nome de usuário";
            this.tbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(218, 28);
            this.tbUser.Style = MetroFramework.MetroColorStyle.Green;
            this.tbUser.TabIndex = 11;
            this.tbUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbUser.UseSelectable = true;
            this.tbUser.UseStyleColors = true;
            this.tbUser.WaterMark = "Nome de usuário";
            this.tbUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUser.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(79, 183);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PromptText = "Senha";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(218, 28);
            this.tbPassword.Style = MetroFramework.MetroColorStyle.Green;
            this.tbPassword.TabIndex = 12;
            this.tbPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.UseStyleColors = true;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WaterMark = "Senha";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(229)))), ((int)(((byte)(164)))));
            this.btnSignIn.DisplayFocus = true;
            this.btnSignIn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSignIn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnSignIn.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Highlight = true;
            this.btnSignIn.Location = new System.Drawing.Point(102, 242);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(177, 48);
            this.btnSignIn.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "ENTRAR";
            this.btnSignIn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSignIn.UseCustomBackColor = true;
            this.btnSignIn.UseCustomForeColor = true;
            this.btnSignIn.UseSelectable = true;
            this.btnSignIn.UseStyleColors = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(376, 348);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.lbBadPwd);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBadPwd;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbUser;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroButton btnSignIn;
    }
}