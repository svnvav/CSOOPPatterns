namespace CSOOPPatterns.Structural.Proxy
{
    public class Proxy : IProxyService
    {
        private ProxyService _service;

        public Proxy(ProxyService service)
        {
            _service = service;
        }

        public string GetServiceShit()
        {
            if (Check())
            {
                return _service.GetServiceShit();
            }

            return "Access denied";
        }

        private bool Check()
        {
            return true;
        }
    }
}