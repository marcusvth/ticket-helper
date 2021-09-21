using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace tickethelper.Service
{
    internal class IpcService
    {
        public const string TH_SEND_MAIL = "TH_SEND_MAIL";
        public const string TH_MAIL_PKG = "TH_MAIL_PKG";
        public const string TH_MAIL_ADDR = "TH_MAIL_ADDR";
        public const string TH_MAIL_BODY = "TH_MAIL_BODY";
        public const string TH_MAIL_SUBJ = "TH_MAIL_SUBJ";
        public const string TH_MAIL_CC = "TH_MAIL_CC";
        public const string TH_REQUEST_COMPLETE = "TH_REQUEST_COMPLETE";
        public const int TH_TIMEOUT = 5000;

        public static void SendMail(string mailAddr, string subj, string body, string cc = null)
        {
            Clipboard.SetText(TH_SEND_MAIL);
            Thread.Sleep(1500);
            var mail = new IpcPackage(TH_MAIL_PKG);
            mail.AddData(TH_MAIL_ADDR, mailAddr);
            mail.AddData(TH_MAIL_BODY, body);
            mail.AddData(TH_MAIL_CC, cc);
            mail.AddData(TH_MAIL_SUBJ, subj);
            mail.Send();
        }
        private static bool TimeOut()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            while (stopWatch.ElapsedMilliseconds < TH_TIMEOUT && Clipboard.GetText() != TH_REQUEST_COMPLETE)
            {
            }
            stopWatch.Stop();
            return stopWatch.ElapsedMilliseconds >= 5000;
        }

    }
}
