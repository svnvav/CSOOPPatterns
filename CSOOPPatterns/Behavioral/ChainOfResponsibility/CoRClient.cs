using System;

namespace CSOOPPatterns.Behavioral.ChainOfResponsibility
{
    public class CoRClient
    {
        public void DoStuff()
        {
            var handler1 = new Handler1();
            var handler0 = new Handler0(handler1);
            
            Console.WriteLine($"CoR: {handler0.Handle("req")}");
        }
    }
}