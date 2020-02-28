using System;

namespace CSOOPPatterns.Builder.Unit
{
    public class OpossumHead : IHead
    {
        public void Yell()
        {
            Console.Write($"{GetType().Name}");
        }
    }
}