using System;
using MetroFramework.Forms;
using tickethelper.Service.ActiveDirectory;

namespace tickethelper.View
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            lbServer.Text = $@"Conecte-se ao servidor {EntryManager.ReverseDomain}";
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void SignIn()
        {
            if (!EntryManager.ValidateCredentials(tbUser.Text, tbPassword.Text))
            {
                lbBadPwd.Visible = true;
                tbPassword.Clear();
                return;
            }
            Hide();
            new MainUiForm().Show();
        }
    }
}