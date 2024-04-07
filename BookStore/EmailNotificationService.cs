using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class EmailNotificationService : INotificationRecieverService
    {
        public void RecieveNotification(string message)
        {
            Console.WriteLine($"This message was recieved via email notificationservice - {message}");
        }
    }
}
