using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Notification
    {
        public delegate void Notify(IMessage message);

        private Notify notify;

        public Notification(Notify notify)
        {
            this.notify = notify;
        }

        public void AddNotify(Notify notify)
        {
            this.notify += notify;
        }

        public void SendNotification(IMessage message)
        {
            notify.Invoke(message);
        }
    }
}
