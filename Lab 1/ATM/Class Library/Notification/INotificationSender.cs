﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public interface INotificationSender
    {
        public void SendNotification(IMessage message);
    }
}