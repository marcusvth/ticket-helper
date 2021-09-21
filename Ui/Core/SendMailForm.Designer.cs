namespace tickethelper.Ui.Core
{
    partial class SendMailForm
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
            this.tbTo = new MetroFramework.Controls.MetroTextBox();
            this.tbSubject = new MetroFramework.Controls.MetroTextBox();
            this.tbBody = new MetroFramework.Controls.MetroTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTo
            // 
            // 
            // 
            // 
            this.tbTo.CustomButton.Image = null;
            this.tbTo.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.tbTo.CustomButton.Name = "";
            this.tbTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTo.CustomButton.TabIndex = 1;
            this.tbTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTo.CustomButton.UseSelectable = true;
            this.tbTo.CustomButton.Visible = false;
            this.tbTo.Lines = new string[0];
            this.tbTo.Location = new System.Drawing.Point(27, 63);
            this.tbTo.MaxLength = 32767;
            this.tbTo.Name = "tbTo";
            this.tbTo.PasswordChar = '\0';
            this.tbTo.PromptText = "Para...";
            this.tbTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTo.SelectedText = "";
            this.tbTo.SelectionLength = 0;
            this.tbTo.SelectionStart = 0;
            this.tbTo.ShortcutsEnabled = true;
            this.tbTo.Size = new System.Drawing.Size(350, 23);
            this.tbTo.Style = MetroFramework.MetroColorStyle.Green;
            this.tbTo.TabIndex = 0;
            this.tbTo.UseSelectable = true;
            this.tbTo.UseStyleColors = true;
            this.tbTo.WaterMark = "Para...";
            this.tbTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTo.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // tbSubject
            // 
            // 
            // 
            // 
            this.tbSubject.CustomButton.Image = null;
            this.tbSubject.CustomButton.Location = new System.Drawing.Point(328, 1);
            this.tbSubject.CustomButton.Name = "";
            this.tbSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSubject.CustomButton.TabIndex = 1;
            this.tbSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSubject.CustomButton.UseSelectable = true;
            this.tbSubject.CustomButton.Visible = false;
            this.tbSubject.Lines = new string[0];
            this.tbSubject.Location = new System.Drawing.Point(27, 92);
            this.tbSubject.MaxLength = 32767;
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.PasswordChar = '\0';
            this.tbSubject.PromptText = "Assunto";
            this.tbSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSubject.SelectedText = "";
            this.tbSubject.SelectionLength = 0;
            this.tbSubject.SelectionStart = 0;
            this.tbSubject.ShortcutsEnabled = true;
            this.tbSubject.Size = new System.Drawing.Size(350, 23);
            this.tbSubject.Style = MetroFramework.MetroColorStyle.Green;
            this.tbSubject.TabIndex = 2;
            this.tbSubject.UseSelectable = true;
            this.tbSubject.UseStyleColors = true;
            this.tbSubject.WaterMark = "Assunto";
            this.tbSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSubject.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // tbBody
            // 
            // 
            // 
            // 
            this.tbBody.CustomButton.Image = null;
            this.tbBody.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.tbBody.CustomButton.Name = "";
            this.tbBody.CustomButton.Size = new System.Drawing.Size(287, 287);
            this.tbBody.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBody.CustomButton.TabIndex = 1;
            this.tbBody.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBody.CustomButton.UseSelectable = true;
            this.tbBody.CustomButton.Visible = false;
            this.tbBody.Lines = new string[0];
            this.tbBody.Location = new System.Drawing.Point(27, 121);
            this.tbBody.MaxLength = 32767;
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.PasswordChar = '\0';
            this.tbBody.PromptText = "Mensagem";
            this.tbBody.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBody.SelectedText = "";
            this.tbBody.SelectionLength = 0;
            this.tbBody.SelectionStart = 0;
            this.tbBody.ShortcutsEnabled = true;
            this.tbBody.Size = new System.Drawing.Size(350, 289);
            this.tbBody.Style = MetroFramework.MetroColorStyle.Green;
            this.tbBody.TabIndex = 3;
            this.tbBody.UseSelectable = true;
            this.tbBody.UseStyleColors = true;
            this.tbBody.WaterMark = "Mensagem";
            this.tbBody.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBody.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbBody.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(221, 431);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 471);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbTo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendMailForm";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Enviar e-mail";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbTo;
        private MetroFramework.Controls.MetroTextBox tbSubject;
        private MetroFramework.Controls.MetroTextBox tbBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
    }
}