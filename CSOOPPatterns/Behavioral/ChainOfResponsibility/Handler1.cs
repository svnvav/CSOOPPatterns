namespace CSOOPPatterns.Behavioral.ChainOfResponsibility
{
    public class Handler1 : BaseHandler
    {
        public override string Handle(string request)
        {
            var changed = request + "1";
            return _next != null ? _next.Handle(changed) : changed;
        }
    }
}