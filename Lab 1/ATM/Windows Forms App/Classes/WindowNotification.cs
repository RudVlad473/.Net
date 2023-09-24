using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App.Classes
{
    public class WindowNotification : INotification
    {
        public void SendNotification(IMessage message)
        {
            MessageBox.Show(message.Message, message.Header);
        }
    }
}
