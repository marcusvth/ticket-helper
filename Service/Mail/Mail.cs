using tickethelper.Model;

namespace tickethelper.Service.Mail
{
    internal class Mail
    {
        public Mail(User user, Template template = null)
        {
            To = user.Mail;
            if (template is null) return;
            Subject = template.Subject;
            Body = template.Body;
        }

        public string To { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public void Send()
        {
            if ((To is null && Cc is null) || Subject is null || Body is null) return;
            IpcService.SendMail(To, Subject, Body, Cc);
        }
    }
}