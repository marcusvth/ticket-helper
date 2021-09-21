using tickethelper.Model;

namespace tickethelper.Service
{
    internal class NotificationService
    {
        private readonly FriendlyUserAccount _account;
        public NotificationService(FriendlyUserAccount account)
        {
            _account = account;
        }
        public static void Notify(string message, string title)
        {
            MainUiForm.Notifier.BalloonTipTitle = title;
            MainUiForm.Notifier.BalloonTipText = message;
            MainUiForm.Notifier.ShowBalloonTip(3000);
        }

        public void PwdChanged()
        {
            Notify($"A senha da conta {_account.SamAccountName} foi alterada.", "Alteração de senha");
        }

        public void AccountUnlocked()
        {
            Notify($"A conta {_account.SamAccountName} foi desbloqueada automaticamente.", "Desbloqueio");
        }

        public void AccountEnabled()
        {
            Notify($"A conta {_account.SamAccountName} foi habilitada", "Habilitar conta");
        }

        public void AccountDisabled()
        {
            Notify($"A conta {_account.SamAccountName} foi desabilitada", "Desabilitar conta");
        }

        public void LicenseSet()
        {
            Notify($"Licença padrão atribuída à conta {_account.SamAccountName}", "Atribuir licença padrão");
        }

        public static void NotifyAccessDenied()
        {
            Notify("Acesso negado. Verifique se a conta está em sua OU", "Erro");
        }

        public void PhoneChanged()
        {
            Notify($"O telefone para a conta {_account.SamAccountName} foi alterado.", "Alterar telefone");
        }
    }
}