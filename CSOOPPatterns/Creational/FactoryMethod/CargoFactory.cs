namespace CSOOPPatterns.FactoryMethod
{
    public class CargoFactory : TransportFactory
    {
        public override ITransport GetTransport()
        {
            return new Cargo();
        }
    }
}