using System;

namespace CSOOPPatterns.Behavioral.Visitor
{
    public class Visitor : IVisitor
    {
        public void Visit(PointA point)
        {
            Console.WriteLine("PointA");
        }

        public void Visit(PointB point)
        {
            Console.WriteLine("PointB");
        }
    }
}