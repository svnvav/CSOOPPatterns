namespace CSOOPPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(BaseComponent sender);
    }
}