using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App.Classes
{
    public class WindowNotificationSender : INotificationSender
    {
        public WindowNotificationSender() { }

        public void SendNotification(IMessage message)
        {
            MessageBox.Show(message.Content, message.Header);
        }
    }
}
