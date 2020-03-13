namespace CSOOPPatterns.Behavioral.ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        string Handle(string request);
    }
}