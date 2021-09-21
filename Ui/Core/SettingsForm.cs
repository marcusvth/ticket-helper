using System;
using System.Text;
using MetroFramework.Forms;
using tickethelper.Properties;

namespace tickethelper
{
    public partial class SettingsForm : MetroForm
    {
      public SettingsForm()
        {
            InitializeComponent();
            cbbMarker.SelectedItem = Settings.Default.Marker;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Close();
        }

        private void SaveSettings()
        {
            Settings.Default.Marker = cbbMarker.Text;
            Settings.Default.Save();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbMarker_SelectedValueChanged(object sender, EventArgs e)
        {
            SetPreview();
        }

        private void SetPreview()
        {
            var marker = cbbMarker.Text;
            var userData = new StringBuilder()
                .AppendLine($"{marker} Nome: Exemplo da Silva")
                .AppendLine($"{marker} Matrícula: P12345")
                .AppendLine($"{marker} ID: ExempS01")
                .AppendLine($"{marker} E-mail: exemplo@heineken.com.br")
                .AppendLine($"{marker} OpCo: Exemplo Brewery")
                .AppendLine($"{marker} Departamento: Exemplo")
                .AppendLine($"{marker} Cargo: Exemplo");
            userData.Append($"{marker} Telefone: +55");
            lbPreview.Text = userData.ToString();
        }
    }
}