using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class SMSNotificationService : INotificationRecieverService
    {
        public void RecieveNotification(string message)
        {
            Console.WriteLine($"This message was recieved via sms notificationservice - {message}");
        }
    }
}
