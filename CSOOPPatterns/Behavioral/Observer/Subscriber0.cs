using System;

namespace CSOOPPatterns.Behavioral.Observer
{
    public class Subscriber0 : ISubscriber
    {
        private Observer _observer;

        public void SetObserver(Observer observer)
        {
            _observer = observer;
        }

        public void Update()
        {
            Console.WriteLine($"I'm a {GetType().Name} of {_observer.GetType().Name}");
        }
    }
}