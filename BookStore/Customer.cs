using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Customer : ISubscriber
    {
        public int Id { get; set; } 
        public void RecieveNotification(string message, INotificationRecieverService notificationRecieverService)
        {
            notificationRecieverService.RecieveNotification(message);
        }

    }
}
