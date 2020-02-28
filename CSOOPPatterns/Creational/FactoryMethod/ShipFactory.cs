namespace CSOOPPatterns.FactoryMethod
{
    public class ShipFactory : TransportFactory
    {
        public override ITransport GetTransport()
        {
            return new Ship();
        }
    }
}