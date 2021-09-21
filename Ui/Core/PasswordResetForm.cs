using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Humanizer;
using MetroFramework.Forms;
using tickethelper.Model;
using tickethelper.Properties;
using tickethelper.Service;
using tickethelper.Service.ActiveDirectory;
using tickethelper.Service.Mail;

namespace tickethelper.Ui
{
    internal partial class PasswordResetForm : MetroForm
    {
        private readonly FriendlyUserAccount _account;
        private const int AdmPwdMinLength = 14;
        private const int AdmPwdMinStrength = 4;
        private const int PwdMinLenght = 8;
        private const int PwdMinStrength = 3;

        public PasswordResetForm(FriendlyUserAccount account)
        {
            _account = account;
            InitializeComponent();
            StartupRoutine();
        }

        private async void BtnOk_Click(object sender, EventArgs e)
        {
            Loading(true);
            await ChangePassword();
            Loading(false);
            Close();
        }

        private void Loading(bool isLoading)
        {
            spnLoading.Visible = isLoading;
            tbPassword.Enabled = !isLoading;
            btnOk.Enabled = !isLoading;
            btnCancel.Enabled = !isLoading;
            cbTemporary.Enabled = !isLoading;
            btnRandom.Enabled = !isLoading;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private Task ChangePassword()
        {
           return Task.Run(() => _account.Manage.ChangePassword(tbPassword.Text, cbTemporary.Checked, IsSelfAdmAccount()));
        }

        private void ValidatePassword(int minLength, int minStrength)
        {
            var password = tbPassword.Text;
            var strength = 0;

            if (password.Any(char.IsLower)) strength++;
            if (password.Any(char.IsUpper)) strength++;
            if (password.Any(char.IsDigit)) strength++;
            if (!password.All(char.IsLetterOrDigit)) strength++;

            btnOk.Enabled = password.Length >= minLength && strength >= minStrength;
            tbPassword.WithError = !btnOk.Enabled;
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            if (IsSelfAdmAccount())
                ValidatePassword(AdmPwdMinLength, AdmPwdMinStrength);
            else ValidatePassword(PwdMinLenght, PwdMinStrength);
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            GetRandomPwd();
        }

        private void StartupRoutine()
        {
            DisableMailFeature();
            GetRandomPwd();
            if (IsSelfAdmAccount())
                SelfPwdResetMode();
            Text = $@"Alterar senha de {_account.SamAccountName}";
        }

        private void CountdownNextPwd() 
        {
            var timer = new Timer();
            var endTime = _account.PwdLastSet?.AddHours(24);
            timer.Interval = 1000;
            
            timer.Tick += (s, e) =>
            {
                var timeSpan = endTime?.Subtract(DateTime.UtcNow);
                lbDateDiff.Text = $"Senha atual: {EntryManager.Password}\nPróximo reset em {timeSpan?.Humanize(3)}";
            };

            timer.Start();
        }
        private void GetRandomPwd()
        {
            var random = new Random();
            tbPassword.Text = IsSelfAdmAccount() ? Membership.GeneratePassword(14, 2) : @"Brasil" + random.Next(10, 9999);
        }
        private void BtnSendViaMail_Click(object sender, EventArgs e)
        {
            SendPasswordViaEmail();
            btnSendViaMail.Image = Resources.mail_sent;
            NotificationService.Notify($"E-mail aberto no Outlook", "Outlook");
        }

        private void PasswordResetForm_Shown(object sender, EventArgs e)
        {
            return;
            var isEmp = "EMP".Equals(SearchEngine.CurrentUser.EmployeeType, StringComparison.OrdinalIgnoreCase);
            if (!IsAbleToReceiveMail())
            {
                DisableMailFeature();
                return;
            }
            if (SearchEngine.CurrentUser.Mail is null || !isEmp)
                ManagerOnlyMode();
        }

        private void SelfPwdResetMode()
        {
            cbTemporary.Visible = false;
            if (_account.PwdLastSet?.AddHours(24) < DateTime.UtcNow) return;
            btnOk.Enabled = false;
            lbDateDiff.Visible = true;
            tbPassword.Enabled = false;
            btnRandom.Enabled = false;
            CountdownNextPwd();
        }

        private bool IsSelfAdmAccount() 
        {
            var isAdm = _account.SamAccountName.StartsWith("ADM", StringComparison.OrdinalIgnoreCase);
            var isSelf = _account.SamAccountName.Equals(EntryManager.UserName, StringComparison.OrdinalIgnoreCase);
            
            return isAdm && isSelf;
        }
        private void SendPasswordViaEmail()
        {
            var mail = new Mail(SearchEngine.CurrentUser,
                PasswordResetTemplate.Fill(_account, tbPassword.Text, cbCcManager.Checked))
            {
                Cc = cbCcManager.Checked ? SearchEngine.CurrentUser.Manager?.Mail : null
            };

            mail.Send();
        }

        private bool IsAbleToReceiveMail()
        {
            var canSendToManager = SearchEngine.CurrentUser.Manager?.Mail != null;
            var canSendToUser = SearchEngine.CurrentUser.Mail != null;

            return canSendToUser || canSendToManager;
        }

        private void DisableMailFeature()
        {
            btnSendViaMail.Visible = false;
            cbCcManager.Visible = false;
            Height = 204;
        }

        private void ManagerOnlyMode()
        {
            cbCcManager.Checked = true;
            cbCcManager.Enabled = false;
        }

        private string GetMailBody()
        {
            var mailBody =
                $"<h1 style=\"font-family:verdana; text-align:center; color:green; font-weight: 100\">Você solicitou uma nova senha</h1><br><br>" +
                $"<p style=\"font-family:verdana;\">{_account.GivenName}, você solicitou uma nova senha para sua conta <i style=\"color:green\">{_account.SamAccountName}</i>. Sua nova senha é:</p>" +
                $"<br><h3 style=\"font-family:verdana; font-weight: 100; color:green\">{tbPassword.Text}</h3>";

            if (cbCcManager.Checked) mailBody += "<hr><br><i>Cópia automática encaminhada ao gestor.</i>";

            return mailBody;
        }
    }
}