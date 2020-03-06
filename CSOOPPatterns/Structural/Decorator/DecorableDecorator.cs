namespace CSOOPPatterns.Structural.Decorator
{
    public abstract class DecorableDecorator : IDecorable
    {
        protected IDecorable _decorablee;

        public DecorableDecorator(IDecorable decorablee)
        {
            _decorablee = decorablee;
        }

        public virtual string Scream()
        {
            return _decorablee.Scream();
        }
    }
}