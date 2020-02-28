using System;

namespace CSOOPPatterns.Builder.Unit
{
    public class OpossumLeg : ILeg
    {
        public void Run()
        {
            Console.Write($"{GetType().Name}");
        }
    }
}