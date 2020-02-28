using System;

namespace CSOOPPatterns.AbstractFactory
{
    public class OrcCatapult : ISiege
    {
        public void Beseige()
        {
            Console.WriteLine($"{GetType().Name}: *стреляет оркскими снарядами*");
        }
    }
}