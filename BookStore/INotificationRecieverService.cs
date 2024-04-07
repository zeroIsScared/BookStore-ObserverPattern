using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface INotificationRecieverService
    {
        public void RecieveNotification(string message);
    }
}
