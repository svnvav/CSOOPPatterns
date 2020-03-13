namespace CSOOPPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _next;
        
        public void SetNext(IHandler next)
        {
            _next = next;
        }

        public virtual string Handle(string request)
        {
            return _next.Handle(request);
        }
    }
}