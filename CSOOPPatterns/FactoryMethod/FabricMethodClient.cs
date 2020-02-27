namespace CSOOPPatterns.FactoryMethod
{
    public class FabricMethodClient
    {
        private TransportFactory _transportFactory;

        public void SetTransportFactory(TransportFactory transportFactory)
        {
            _transportFactory = transportFactory;
        }

        public FabricMethodClient(TransportFactory transportFactory)
        {
            _transportFactory = transportFactory;
        }

        public void Deliver()
        {
            var transport = _transportFactory.GetTransport();
            transport.Deliver();
        }
    }
}