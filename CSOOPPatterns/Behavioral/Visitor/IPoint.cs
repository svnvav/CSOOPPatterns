namespace CSOOPPatterns.Behavioral.Visitor
{
    public interface IPoint
    {
        void Accept(IVisitor visitor);
    }
}