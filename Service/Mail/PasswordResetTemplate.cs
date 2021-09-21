using tickethelper.Model;

namespace tickethelper.Service.Mail
{
    class PasswordResetTemplate : Template
    {
        private PasswordResetTemplate(FriendlyUserAccount account, string password, bool sendToManager)
        {
            Subject = "Você solicitou uma nova senha";

            Body = $"<h1 style=\"font-family:verdana; text-align:center; color:green; font-weight: 100\">Você solicitou uma nova senha</h1><br><br>" +
                   $"<p style=\"font-family:verdana;\">{account.GivenName}, você solicitou uma nova senha para sua conta <i style=\"color:green\">{account.SamAccountName}</i>. Sua nova senha é:</p>" +
                   $"<h3 style=\"font-family:verdana; font-weight: 100; color:green\">{password}</h3>";

            if (sendToManager) Body += "<hr><br><i>Cópia automática encaminhada ao gestor.</i>";

        }

        public static PasswordResetTemplate Fill(FriendlyUserAccount account, string password, bool sendToManager)
        {
            return new PasswordResetTemplate(account, password, sendToManager);
        }
    }
}
