using System;

namespace CSOOPPatterns.Structural.Composite
{
    public class CompositeClient
    {
        public void DoStuff()
        {
            var item1 = new Item(5);
            var item0 = new Item(4);
            
            var box = new Box();
            box.AddItem(item0);
            box.AddItem(item1);
            
            Console.WriteLine(box.Evaluate());
        }
    }
}