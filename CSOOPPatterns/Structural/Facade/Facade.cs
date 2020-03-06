using System;

namespace CSOOPPatterns.Structural.Facade
{
    public class Facade
    {
        public void DoStuff()
        {
            var subsystem0 = new Subsystem0();
            var subsystem1 = new Subsystem1();
            
            subsystem0.DoStuff();
            subsystem1.DoStuff();
        }
    }
}