using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class EmailNotificationSender : INotificationSender
    {
        public string ReceiverEmail { get; set; }
        private EmailSender EmailSender { get; set; } = new EmailSender();

        public EmailNotificationSender(string receiverEmail = "rudenkovladimir2003@gmail.com")
        {
            ReceiverEmail = receiverEmail;
        }

        public void SendNotification(IMessage message)
        {
            EmailSender.SendEmail(ReceiverEmail, message);
        }
    }
}
