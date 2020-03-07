using System;

namespace CSOOPPatterns.Structural.Flyweight
{
    public class FlyweightContext
    {
        private Flyweight _flyweight;
        private int _uniqueState;

        public FlyweightContext(string repeatingState, int uniqueState)
        {
            _flyweight = Flyweight.Get(repeatingState);
            _uniqueState = uniqueState;
        }
        
        public void DoStuff()
        {
            _flyweight.DoStuff();
            Console.WriteLine($"Context: {_uniqueState} ");
        }
    }
}