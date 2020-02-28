using System;

namespace CSOOPPatterns.AbstractFactory
{
    public class HumanInfantry : IWarrior
    {
        public void MakeWar()
        {
            Console.WriteLine($"{GetType().Name}: *воюет как человек*");
        }
    }
}