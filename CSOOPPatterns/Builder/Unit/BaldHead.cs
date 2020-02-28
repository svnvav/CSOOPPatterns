using System;

namespace CSOOPPatterns.Builder.Unit
{
    public class BaldHead : IHead
    {
        public void Yell()
        {
            Console.Write($"{GetType().Name}");
        }
    }
}