namespace CSOOPPatterns.Structural.Decorator
{
    public class GoldFoilDecorator : DecorableDecorator
    {
        public GoldFoilDecorator(IDecorable decorablee) : base(decorablee)
        {
        }

        public override string Scream()
        {
            var baseScream = base.Scream();
            return "Gold " + baseScream;
        }
    }
}