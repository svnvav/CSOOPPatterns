namespace CSOOPPatterns.Behavioral.Visitor
{
    public class VisitorClient
    {
        public void DoStuff()
        {
            var visitor = new Visitor();
            visitor.Visit(new PointA());
            visitor.Visit(new PointB());
        }
    }
}