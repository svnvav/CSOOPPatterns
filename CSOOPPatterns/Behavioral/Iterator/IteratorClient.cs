using System;

namespace CSOOPPatterns.Behavioral.Iterator
{
    public class IteratorClient
    {
        public void DoStuff()
        {
            var stack = new IterableLinkedStack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Push("d");

            var iterator = stack.GetIterator();
            while (!iterator.Finished)
            {
                Console.Write(iterator.Current);
                iterator.MoveNext();
            }
            
            Console.WriteLine();
        }
    }
}