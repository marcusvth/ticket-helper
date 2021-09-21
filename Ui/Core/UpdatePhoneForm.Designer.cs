namespace tickethelper.Ui.Core
{
    partial class UpdatePhoneForm
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
            this.lbPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPhoneNumber
            // 
            // 
            // 
            // 
            this.lbPhoneNumber.CustomButton.Image = null;
            this.lbPhoneNumber.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.lbPhoneNumber.CustomButton.Name = "";
            this.lbPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lbPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbPhoneNumber.CustomButton.TabIndex = 1;
            this.lbPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbPhoneNumber.CustomButton.UseSelectable = true;
            this.lbPhoneNumber.CustomButton.Visible = false;
            this.lbPhoneNumber.Lines = new string[] {
        "Insira o novo nº de telefone"};
            this.lbPhoneNumber.Location = new System.Drawing.Point(132, 86);
            this.lbPhoneNumber.MaxLength = 32767;
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.PasswordChar = '\0';
            this.lbPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbPhoneNumber.SelectedText = "";
            this.lbPhoneNumber.SelectionLength = 0;
            this.lbPhoneNumber.SelectionStart = 0;
            this.lbPhoneNumber.ShortcutsEnabled = true;
            this.lbPhoneNumber.Size = new System.Drawing.Size(239, 23);
            this.lbPhoneNumber.Style = MetroFramework.MetroColorStyle.Green;
            this.lbPhoneNumber.TabIndex = 0;
            this.lbPhoneNumber.Text = "Insira o novo nº de telefone";
            this.lbPhoneNumber.UseSelectable = true;
            this.lbPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.lbPhoneNumber.TextChanged += new System.EventHandler(this.LbPhoneNumber_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCancel.Location = new System.Drawing.Point(419, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Enabled = false;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnOk.Location = new System.Drawing.Point(338, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 35);
            this.btnOk.TabIndex = 12;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // UpdatePhoneForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(522, 199);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbPhoneNumber);
            this.MaximizeBox = false;
            this.Name = "UpdatePhoneForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Atualizando telefone de MisterM20";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox lbPhoneNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}