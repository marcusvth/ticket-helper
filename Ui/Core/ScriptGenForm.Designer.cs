namespace tickethelper.Ui.Core
{
    partial class ScriptGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptGenForm));
            this.lbAccount = new MetroFramework.Controls.MetroLabel();
            this.cbbDirectory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rbSchinAccount = new MetroFramework.Controls.MetroRadioButton();
            this.rbHeiwayAccount = new MetroFramework.Controls.MetroRadioButton();
            this.cbPwd = new MetroFramework.Controls.MetroCheckBox();
            this.tbScript = new MetroFramework.Controls.MetroTextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbDescription = new MetroFramework.Controls.MetroLabel();
            this.cbbScript = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbRemoveOldMapping = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(23, 139);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(123, 19);
            this.lbAccount.TabIndex = 0;
            this.lbAccount.Text = "Escolha o diretório ";
            // 
            // cbbDirectory
            // 
            this.cbbDirectory.FormattingEnabled = true;
            this.cbbDirectory.ItemHeight = 23;
            this.cbbDirectory.Items.AddRange(new object[] {
            "L:",
            "W:",
            "M:",
            "T:"});
            this.cbbDirectory.Location = new System.Drawing.Point(28, 161);
            this.cbbDirectory.Name = "cbbDirectory";
            this.cbbDirectory.Size = new System.Drawing.Size(133, 29);
            this.cbbDirectory.Style = MetroFramework.MetroColorStyle.Green;
            this.cbbDirectory.TabIndex = 1;
            this.cbbDirectory.TabStop = false;
            this.cbbDirectory.UseSelectable = true;
            this.cbbDirectory.SelectedIndexChanged += new System.EventHandler(this.CbbDirectory_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(222, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(265, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Com qual conta o diretório será mapeado?";
            // 
            // rbSchinAccount
            // 
            this.rbSchinAccount.AutoSize = true;
            this.rbSchinAccount.Checked = true;
            this.rbSchinAccount.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbSchinAccount.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbSchinAccount.Location = new System.Drawing.Point(227, 169);
            this.rbSchinAccount.Name = "rbSchinAccount";
            this.rbSchinAccount.Size = new System.Drawing.Size(87, 19);
            this.rbSchinAccount.Style = MetroFramework.MetroColorStyle.Green;
            this.rbSchinAccount.TabIndex = 3;
            this.rbSchinAccount.TabStop = true;
            this.rbSchinAccount.Text = "Schincariol";
            this.rbSchinAccount.UseSelectable = true;
            this.rbSchinAccount.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // rbHeiwayAccount
            // 
            this.rbHeiwayAccount.AutoSize = true;
            this.rbHeiwayAccount.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rbHeiwayAccount.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rbHeiwayAccount.Location = new System.Drawing.Point(320, 169);
            this.rbHeiwayAccount.Name = "rbHeiwayAccount";
            this.rbHeiwayAccount.Size = new System.Drawing.Size(66, 19);
            this.rbHeiwayAccount.Style = MetroFramework.MetroColorStyle.Green;
            this.rbHeiwayAccount.TabIndex = 4;
            this.rbHeiwayAccount.Text = "Heiway";
            this.rbHeiwayAccount.UseSelectable = true;
            this.rbHeiwayAccount.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // cbPwd
            // 
            this.cbPwd.AutoSize = true;
            this.cbPwd.Checked = true;
            this.cbPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPwd.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbPwd.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.cbPwd.Location = new System.Drawing.Point(596, 144);
            this.cbPwd.Name = "cbPwd";
            this.cbPwd.Size = new System.Drawing.Size(216, 19);
            this.cbPwd.Style = MetroFramework.MetroColorStyle.Green;
            this.cbPwd.TabIndex = 5;
            this.cbPwd.TabStop = false;
            this.cbPwd.Text = "O usuário deverá digitar a senha";
            this.cbPwd.UseSelectable = true;
            this.cbPwd.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // tbScript
            // 
            // 
            // 
            // 
            this.tbScript.CustomButton.Image = null;
            this.tbScript.CustomButton.Location = new System.Drawing.Point(726, 1);
            this.tbScript.CustomButton.Name = "";
            this.tbScript.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.tbScript.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbScript.CustomButton.TabIndex = 1;
            this.tbScript.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbScript.CustomButton.UseSelectable = true;
            this.tbScript.CustomButton.Visible = false;
            this.tbScript.Enabled = false;
            this.tbScript.Lines = new string[0];
            this.tbScript.Location = new System.Drawing.Point(28, 211);
            this.tbScript.MaxLength = 32767;
            this.tbScript.Multiline = true;
            this.tbScript.Name = "tbScript";
            this.tbScript.PasswordChar = '\0';
            this.tbScript.ReadOnly = true;
            this.tbScript.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbScript.SelectedText = "";
            this.tbScript.SelectionLength = 0;
            this.tbScript.SelectionStart = 0;
            this.tbScript.ShortcutsEnabled = true;
            this.tbScript.Size = new System.Drawing.Size(784, 59);
            this.tbScript.TabIndex = 6;
            this.tbScript.UseSelectable = true;
            this.tbScript.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbScript.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCopy.Enabled = false;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(744, 276);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(68, 32);
            this.btnCopy.TabIndex = 90;
            this.btnCopy.TabStop = false;
            this.btnCopy.Text = "Copiar";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.Location = new System.Drawing.Point(23, 57);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(786, 65);
            this.lbDescription.TabIndex = 91;
            this.lbDescription.Text = resources.GetString("lbDescription.Text");
            this.lbDescription.WrapToLine = true;
            // 
            // cbbScript
            // 
            this.cbbScript.Enabled = false;
            this.cbbScript.FormattingEnabled = true;
            this.cbbScript.ItemHeight = 23;
            this.cbbScript.Items.AddRange(new object[] {
            "Script 1 (\\\\server1)",
            "Script 2 (\\\\server1@schincariol.com.br)",
            "Script 3 (\\\\192.168.0.1)",
            "Script 4 (\\\\192.168.0.2)"});
            this.cbbScript.Location = new System.Drawing.Point(28, 311);
            this.cbbScript.Name = "cbbScript";
            this.cbbScript.Size = new System.Drawing.Size(262, 29);
            this.cbbScript.Style = MetroFramework.MetroColorStyle.Green;
            this.cbbScript.TabIndex = 92;
            this.cbbScript.TabStop = false;
            this.cbbScript.UseSelectable = true;
            this.cbbScript.SelectedIndexChanged += new System.EventHandler(this.CbbDirectory_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.Location = new System.Drawing.Point(23, 289);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(127, 19);
            this.metroLabel3.TabIndex = 93;
            this.metroLabel3.Text = "Selecionar um script";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(66, 356);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(737, 37);
            this.metroLabel2.TabIndex = 94;
            this.metroLabel2.Text = "Dica: após mapear um diretório, o subsequente não precisará de senha (se utilizad" +
    "o o mesmo script). Portanto, desmarque a opção \"O usuário deverá digitar a senha" +
    "\".";
            this.metroLabel2.WrapToLine = true;
            // 
            // cbRemoveOldMapping
            // 
            this.cbRemoveOldMapping.AutoSize = true;
            this.cbRemoveOldMapping.Checked = true;
            this.cbRemoveOldMapping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOldMapping.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cbRemoveOldMapping.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.cbRemoveOldMapping.Location = new System.Drawing.Point(596, 169);
            this.cbRemoveOldMapping.Name = "cbRemoveOldMapping";
            this.cbRemoveOldMapping.Size = new System.Drawing.Size(202, 19);
            this.cbRemoveOldMapping.Style = MetroFramework.MetroColorStyle.Green;
            this.cbRemoveOldMapping.TabIndex = 95;
            this.cbRemoveOldMapping.TabStop = false;
            this.cbRemoveOldMapping.Text = "Remover mapeamento antigo";
            this.cbRemoveOldMapping.UseSelectable = true;
            this.cbRemoveOldMapping.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // ScriptGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbRemoveOldMapping);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbbScript);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbScript);
            this.Controls.Add(this.cbPwd);
            this.Controls.Add(this.rbHeiwayAccount);
            this.Controls.Add(this.rbSchinAccount);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbbDirectory);
            this.Controls.Add(this.lbAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScriptGenForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gerar scripts de mapeamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbAccount;
        private MetroFramework.Controls.MetroComboBox cbbDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rbSchinAccount;
        private MetroFramework.Controls.MetroRadioButton rbHeiwayAccount;
        private MetroFramework.Controls.MetroCheckBox cbPwd;
        private MetroFramework.Controls.MetroTextBox tbScript;
        private System.Windows.Forms.Button btnCopy;
        private MetroFramework.Controls.MetroLabel lbDescription;
        private MetroFramework.Controls.MetroComboBox cbbScript;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox cbRemoveOldMapping;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}