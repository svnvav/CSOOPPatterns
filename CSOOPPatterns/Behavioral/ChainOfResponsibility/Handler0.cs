namespace CSOOPPatterns.Behavioral.ChainOfResponsibility
{
    public class Handler0 : BaseHandler
    {
        public Handler0(IHandler next)
        {
            _next = next;
        }

        public override string Handle(string request)
        {
            var changed = request + "0";
            return _next.Handle(changed);
        }
    }
}