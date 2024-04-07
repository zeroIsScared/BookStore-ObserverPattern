using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class OrderEventManager
    {
        private readonly List<ISubscriber> _subscribers = new List<ISubscriber>();
        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify( string message, INotificationRecieverService notificationReciever)
        {
            foreach(ISubscriber subscriber in _subscribers)
            {
                subscriber.RecieveNotification(message, notificationReciever);
            }
        }
    }
}
