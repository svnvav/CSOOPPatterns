namespace CSOOPPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(PointA point);
        void Visit(PointB point);
    }
}