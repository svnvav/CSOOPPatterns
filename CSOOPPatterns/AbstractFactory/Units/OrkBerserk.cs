using System;

namespace CSOOPPatterns.AbstractFactory
{
    public class OrkBerserk : IWarrior
    {
        public void MakeWar()
        {
            Console.WriteLine($"{GetType().Name}: *воюет как орк*");
        }
    }
}