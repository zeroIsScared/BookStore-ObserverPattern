using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Order
    {
       public int Id { get; set; }       

       public OrderEventManager  EventManager = new OrderEventManager();

       public void PlaceOrder (INotificationRecieverService notificationRecieverService)
        {
            string message = $"The order with id {Id} was placed";
            EventManager.Notify(message, notificationRecieverService);
        }

        public void GetOrderReadyForShipping(INotificationRecieverService notificationRecieverService)
        {
            string message = $"The order with id {Id} is ready for shipping";
            EventManager.Notify(message, notificationRecieverService);
        }
    }
}
