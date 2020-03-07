using System;

namespace CSOOPPatterns.Structural.Proxy
{
    public class ProxyClient
    {
        public void DoStuff()
        {
            var service = new ProxyService();
            var proxy = new Proxy(service);
            
            Console.WriteLine(proxy.GetServiceShit());
        }
    }
}