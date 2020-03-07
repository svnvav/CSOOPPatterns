using System;
using System.Collections.Generic;

namespace CSOOPPatterns.Structural.Flyweight
{
    public partial class FlyweightContext
    {
        private static List<Flyweight> _flyweights = new List<Flyweight>();

        private static Flyweight GetFlyweight(string repeatingState)
        {
            var flyweight = _flyweights.Find(f => f._repeatingState.Equals(repeatingState));
            if (flyweight == null)
            {
                flyweight = new Flyweight(repeatingState);
                _flyweights.Add(flyweight);
            }

            return flyweight;
        }

        private class Flyweight
        {
            internal string _repeatingState;

            public Flyweight(string repeatingState)
            {
                _repeatingState = repeatingState;
            }

            public void DoStuff()
            {
                Console.Write($"Flyweights count: {_flyweights.Count} ");
            }
        }
    }
}