using System;
using System.DirectoryServices;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tickethelper.Model;
using tickethelper.Ui;
using tickethelper.Ui.Core;

namespace tickethelper.Service.ActiveDirectory
{
    public class AccountManager
    {
        private readonly FriendlyUserAccount _account;
        private readonly NotificationService _notify;
        private readonly PasswordResetForm _passwordResetForm;
        private readonly UpdatePhoneForm _updatePhoneForm;
        public AccountManager(FriendlyUserAccount account)
        {
            _account = account;
            _notify = new NotificationService(account);
            _passwordResetForm = new PasswordResetForm(account);
            _updatePhoneForm = new UpdatePhoneForm(account);
        }

        public void Unlock()
        {
            using (var entry = _account.Entry)
            {
                try
                {
                    entry.Properties["lockoutTime"].Value = 0;
                    entry.CommitChanges();
                    entry.Close();
                    _account.LockoutTime = 0;
                    _notify.AccountUnlocked();
                }
                catch (DirectoryServicesCOMException e)
                {
                    Log.Add($"Falha ao desbloquear conta {_account.SamAccountName}: {e.Message}", 3);
                }
            }
        }
        public void Toggle()
        {
            using (var entry = _account.Entry)
            {
                try
                {
                    var uac = _account.UserAccountControl;
                    entry.Properties["userAccountControl"].Value = _account.IsDisabled() ? uac & ~0x2 : uac | 0x2;
                    entry.CommitChanges();
                    entry.Close();
                    if (!_account.IsDisabled()) _notify.AccountDisabled();
                    else _notify.AccountEnabled();
                }
                catch (DirectoryServicesCOMException e)
                {
                    Log.Add($"Falha ao habilitar/desabilitar conta {_account.SamAccountName}: {e.Message}", 3);
                }
                catch (UnauthorizedAccessException)
                {
                    NotificationService.NotifyAccessDenied();
                }
            }
        }

        public void ResetPassword() => _passwordResetForm.ShowDialog();

        public void ChangePassword(string newPassword, bool changeNextLogon, bool selfAdmAccount = false)
        {
            using (var entry = _account.SearchResult.GetDirectoryEntry())
            {
                try
                {
                    if (selfAdmAccount) entry.Invoke("ChangePassword", EntryManager.Password, newPassword);
                    else
                    {
                        entry.Invoke("SetPassword", newPassword);
                        entry.Properties["pwdLastSet"].Value = Convert.ToInt32(!changeNextLogon); // 0 = Change next logon | !0 = Don't change
                        entry.CommitChanges();
                    }

                    if (selfAdmAccount) EntryManager.Password = newPassword;
                    
                    entry.Close();
                    _notify.PwdChanged();
                }
                catch (DirectoryServicesCOMException e)
                {
                    _notify.PwdChanged();
                    Log.Add($"Warning sobre alteração de senha de {_account.SamAccountName}: {e.Message}", 2);
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    _notify.PwdChanged();
                    Log.Add($"Warning sobre alteração de senha de {_account.SamAccountName}: {e.Message}", 2);
                }
                catch (UnauthorizedAccessException)
                {
                    NotificationService.NotifyAccessDenied();
                }
                catch (TargetInvocationException e)
                {
                    NotificationService.Notify(
                        $"Possível acesso negado ou senha dentro da lista de exceções.", "Aviso.");
                    Log.Add(e.ToString(), 2);
                }
                catch (Exception e)
                {
                    NotificationService.Notify("Talvez não tenha sido possível alterar a senha. Confirme com o usuário.", "Aviso");
                    Log.Add("Erro ao alterar senha: " + e.ToString(), 2);
                }
            }
        }
        public void AddLicense()
        {
            using (var entry = _account.Entry)
            {
                try
                {
                    entry.Properties["extensionAttribute11"].Value =
                        "ENTERPRISEPACK|RMS_S_ENTERPRISE|OFFICESUBSCRIPTION|MCOSTANDARD";
                    entry.CommitChanges();
                    entry.Close();
                    _notify.LicenseSet();
                }
                catch (DirectoryServicesCOMException)
                {
                    Log.Add($"Falha ao atribuir licença à conta {_account.SamAccountName}", 3);
                }
                catch (UnauthorizedAccessException)
                {
                    NotificationService.NotifyAccessDenied();
                }
            }
        }

        public void ChangePhone() => _updatePhoneForm.ShowDialog();
        public void UpdatePhone(string phoneNumber)
        {
            using (var entry = _account.Entry)
            {
                try
                {
                    entry.Properties["mobile"].Value = phoneNumber;
                    entry.CommitChanges();
                    entry.Close();
                    _notify.PhoneChanged();
                }
                catch (DirectoryServicesCOMException)
                {
                    Log.Add($"Falha ao alterar telefone para conta {_account.SamAccountName}", 3);
                }
                catch (UnauthorizedAccessException)
                {
                    NotificationService.NotifyAccessDenied();
                }
            }
        }
    }
}