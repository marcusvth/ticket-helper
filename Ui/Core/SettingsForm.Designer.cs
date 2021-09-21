namespace tickethelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbPreview = new System.Windows.Forms.Label();
            this.cbbMarker = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lbHeader1
            // 
            this.lbHeader1.AutoSize = true;
            this.lbHeader1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbHeader1.ForeColor = System.Drawing.Color.Black;
            this.lbHeader1.Location = new System.Drawing.Point(25, 68);
            this.lbHeader1.Name = "lbHeader1";
            this.lbHeader1.Size = new System.Drawing.Size(74, 21);
            this.lbHeader1.TabIndex = 7;
            this.lbHeader1.Text = "Marcador";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnCancel.Location = new System.Drawing.Point(208, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnSave.Location = new System.Drawing.Point(127, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 12;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lbPreview
            // 
            this.lbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreview.Font = new System.Drawing.Font("Arial", 10F);
            this.lbPreview.Location = new System.Drawing.Point(29, 126);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(254, 178);
            this.lbPreview.TabIndex = 14;
            this.lbPreview.Text = "● Nome: Exemplo da Silva\r\n● Matrícula: P12345\r\n● ID: ExempS01\r\n● E-mail: exemplo@" +
    "heineken.com.br\r\n● OpCo: Exemplo Brewery\r\n● Departamento: Exemplo\r\n● Cargo: Exem" +
    "plo\r\n● Telefone: +55";
            this.lbPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbMarker
            // 
            this.cbbMarker.FormattingEnabled = true;
            this.cbbMarker.ItemHeight = 23;
            this.cbbMarker.Items.AddRange(new object[] {
            "",
            "->",
            "■",
            "□",
            "▪",
            "▫",
            "►",
            "○",
            "◌",
            "●",
            "◘",
            "→",
            "♦",
            "♯",
            "•"});
            this.cbbMarker.Location = new System.Drawing.Point(29, 90);
            this.cbbMarker.Name = "cbbMarker";
            this.cbbMarker.Size = new System.Drawing.Size(121, 29);
            this.cbbMarker.Style = MetroFramework.MetroColorStyle.Green;
            this.cbbMarker.TabIndex = 15;
            this.cbbMarker.UseSelectable = true;
            this.cbbMarker.SelectedValueChanged += new System.EventHandler(this.cbbMarker_SelectedValueChanged);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(309, 369);
            this.Controls.Add(this.cbbMarker);
            this.Controls.Add(this.lbPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbHeader1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHeader1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPreview;
        private MetroFramework.Controls.MetroComboBox cbbMarker;
    }
}