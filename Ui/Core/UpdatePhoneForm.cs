using System.Linq;
using MetroFramework.Forms;
using tickethelper.Model;

namespace tickethelper.Ui.Core
{
    public partial class UpdatePhoneForm : MetroForm
    {
        private readonly FriendlyUserAccount _account;
        public UpdatePhoneForm(FriendlyUserAccount account)
        {
            _account = account;
            InitializeComponent();
            lbPhoneNumber.Text = _account.Mobile;
            Text = $"Alterando telefone de {_account.SamAccountName}";
        }

        private void LbPhoneNumber_TextChanged(object sender, System.EventArgs e)
        {
            btnOk.Enabled = lbPhoneNumber.Text.Length >= 8 && lbPhoneNumber.Text.TrimStart('+').All(char.IsNumber);
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            _account.Manage.UpdatePhone(lbPhoneNumber.Text);
            Close();
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
