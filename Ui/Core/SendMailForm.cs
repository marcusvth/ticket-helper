using MetroFramework.Forms;
using tickethelper.Service;

namespace tickethelper.Ui.Core
{
    public partial class SendMailForm : MetroForm
    {
        public SendMailForm(string mail = "")
        {
            InitializeComponent();
            tbTo.Text = mail;
            tbSubject.Select();
            tbSubject.Focus();
        }

        private void TextBox_TextChanged(object sender, System.EventArgs e)
        {
            btnSend.Enabled = !string.IsNullOrWhiteSpace(tbBody.Text) && !string.IsNullOrWhiteSpace(tbSubject.Text) &&
                              !string.IsNullOrEmpty(tbTo.Text);
        }

        private void BtnSend_Click(object sender, System.EventArgs e)
        {
            SendMail();
            Close();
        }

        private void SendMail()
        {
            IpcService.SendMail(tbTo.Text, tbSubject.Text, tbBody.Text.Replace("\r\n", "<br>"));
        }
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
