using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    internal class EmailSender
    {
        private readonly string smtpServer;
        private readonly int smtpPort;
        private readonly string senderEmail;
        private readonly string senderPassword;

        public EmailSender(
            string smtpServer,
            int smtpPort,
            string senderEmail,
            string senderPassword
        )
        {
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.senderEmail = senderEmail;
            this.senderPassword = senderPassword;
        }

        public void SendEmail(string recipientEmail, string subject, string body)
        {
            using (var mail = new MailMessage(senderEmail, recipientEmail))
            using (var smtpClient = new SmtpClient(smtpServer))
            {
                mail.Subject = subject;
                mail.Body = body;

                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(mail);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error sending email: `{body}`", ex);
                }
            }
        }
    }
}
