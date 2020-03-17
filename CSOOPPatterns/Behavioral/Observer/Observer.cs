using System.Collections.Generic;

namespace CSOOPPatterns.Behavioral.Observer
{
    public class Observer
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            subscriber.SetObserver(this);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
            subscriber.SetObserver(null);
        }

        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }
    }
}