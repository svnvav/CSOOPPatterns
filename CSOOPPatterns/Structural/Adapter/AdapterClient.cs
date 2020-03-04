using System;

namespace CSOOPPatterns.Structural.Adapter
{
    public class AdapterClient
    {
        private IAdapterInyerface _shitProvider;

        public AdapterClient()
        {
            _shitProvider = new ExistingClass();
        }

        public void DoStuff()
        {
            Console.WriteLine(_shitProvider.GetShit());
            
            var shitService = new AdapterService();
            _shitProvider = new Adapter(shitService);
            
            Console.WriteLine(_shitProvider.GetShit());
        }
    }
}