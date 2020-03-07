using System;

namespace CSOOPPatterns.Structural.Flyweight
{
    public class FlyweightClient
    {
        public void DoStuff()
        {
            var flyweightContexts = new FlyweightContext[50];

            for (int i = 0; i < flyweightContexts.Length; i++)
            {
                flyweightContexts[i] = new FlyweightContext((i % 5).ToString(), i);
                flyweightContexts[i].DoStuff();
            }
        }
    }
}