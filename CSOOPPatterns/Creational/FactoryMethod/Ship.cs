using System;

namespace CSOOPPatterns.FactoryMethod
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine($"{GetType().Name}: *доставляет по кораблевски*");
        }
    }
}