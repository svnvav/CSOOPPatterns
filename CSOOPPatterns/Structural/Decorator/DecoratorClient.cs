using System;

namespace CSOOPPatterns.Structural.Decorator
{
    public class DecoratorClient
    {
        public void DoStuff()
        {
            var shit = new DecorableShit();
            var goldenShit = new GoldFoilDecorator(shit);
            Console.WriteLine(goldenShit.Scream());
        }
    }
}