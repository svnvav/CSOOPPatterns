namespace CSOOPPatterns.Behavioral.Visitor
{
    public class PointA : PointBase
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}