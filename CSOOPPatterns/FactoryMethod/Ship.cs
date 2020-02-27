using System;

namespace CSOOPPatterns.FactoryMethod
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("доставляет по кораблевски");
        }
    }
}