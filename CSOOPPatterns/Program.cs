using System;
using CSOOPPatterns.FactoryMethod;

namespace CSOOPPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.SingletonScream();

            var shipFactory = new ShipFactory();
            var fabricMethodClient = new FabricMethodClient(shipFactory);
            fabricMethodClient.Deliver();
            
            var cargoFactory = new CargoFactory();
            fabricMethodClient.SetTransportFactory(cargoFactory);
            fabricMethodClient.Deliver();
        }
    }
}