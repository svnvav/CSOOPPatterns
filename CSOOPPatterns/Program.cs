using CSOOPPatterns.AbstractFactory;
using CSOOPPatterns.FactoryMethod;

namespace CSOOPPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactoryMethod
            var shipFactory = new ShipFactory();
            var fabricMethodClient = new FabricMethodClient(shipFactory);
            fabricMethodClient.Deliver();
            
            var cargoFactory = new CargoFactory();
            fabricMethodClient.SetTransportFactory(cargoFactory);
            fabricMethodClient.Deliver();
            
            //AbstractFactory

            var humanFactory = new HumanUnitFactory();
            var abstractFactoryClient = new AbstractFactoryClient(humanFactory);
            abstractFactoryClient.DoSquad();
            
            var orkFactory = new OrkUnitFactory();
            abstractFactoryClient.SetUnitFactory(orkFactory);
            abstractFactoryClient.DoSquad();
            
            //Singleton
            Singleton.Instance.SingletonScream();
        }
    }
}