namespace CSOOPPatterns.Behavioral.Visitor
{
    public abstract class PointBase : IPoint
    {
        public abstract void Accept(IVisitor visitor);
    }
}