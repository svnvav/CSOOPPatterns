using System;

namespace CSOOPPatterns.Builder.Unit
{
    public class BaldLeg : ILeg
    {
        public void Run()
        {
            Console.Write($"{GetType().Name}");
        }
    }
}