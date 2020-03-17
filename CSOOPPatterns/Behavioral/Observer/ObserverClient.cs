using System.Security.Claims;

namespace CSOOPPatterns.Behavioral.Observer
{
    public class ObserverClient
    {
        public void DoStuff()
        {
            var observer = new Observer();
            observer.Subscribe(new Subscriber0());
            observer.Subscribe(new Subscriber1());
            observer.NotifySubscribers();
        }
    }
}