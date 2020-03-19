namespace CSOOPPatterns.Behavioral.Visitor
{
    public class PointB : PointBase
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}