using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace Class_Library
{
    public class EmailSender
    {
        private readonly string smtpServer = "smtp.gmail.com";
        private readonly int smtpPort = 587;
        private readonly string smtpUsername = "hellpyrelord@gmail.com";
        private readonly string smtpPassword = "bfyc ucoa bjdi dbxd";

        public EmailSender() { }

        public void SendEmail(string to, IMessage message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("", smtpUsername));
            mimeMessage.To.Add(new MailboxAddress("", to));
            mimeMessage.Subject = message.Header;

            mimeMessage.Body = new TextPart("plain") { Text = message.Content };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(smtpServer, smtpPort, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(smtpUsername, smtpPassword);

                client.Send(mimeMessage);
                client.Disconnect(true);
            }
        }
    }
}
