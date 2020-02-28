using System;

namespace CSOOPPatterns.AbstractFactory
{
    public class HumanTrembling : ISiege
    {
        public void Beseige()
        {
            Console.WriteLine($"{GetType().Name}: *стреляет человеческими снарядами*");
        }
    }
}