using System;
using System.Collections.Generic;

namespace CSOOPPatterns.Behavioral.Memento
{
    public class MementoClient
    {
        public void DoStuff()
        {
            var hero = new Hero();
            var saves = new List<Hero.Memento>();
            
            saves.Add(hero.Save());
            hero.DoStuff();
            hero.Move();
            hero.DoStuff();
            hero.Restore(saves[0]);
            hero.DoStuff();
        }
    }
}