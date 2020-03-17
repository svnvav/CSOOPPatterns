namespace CSOOPPatterns.Behavioral.Observer
{
    public interface ISubscriber
    {
        void SetObserver(Observer observer);
        void Update();
    }
}