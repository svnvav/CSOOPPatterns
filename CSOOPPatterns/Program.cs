using CSOOPPatterns.AbstractFactory;
using CSOOPPatterns.Behavioral.ChainOfResponsibility;
using CSOOPPatterns.Behavioral.Command;
using CSOOPPatterns.Behavioral.Iterator;
using CSOOPPatterns.Behavioral.Mediator;
using CSOOPPatterns.Behavioral.Memento;
using CSOOPPatterns.Behavioral.Observer;
using CSOOPPatterns.Builder;
using CSOOPPatterns.FactoryMethod;
using CSOOPPatterns.Prototype;
using CSOOPPatterns.Structural.Adapter;
using CSOOPPatterns.Structural.Bridge;
using CSOOPPatterns.Structural.Composite;
using CSOOPPatterns.Structural.Decorator;
using CSOOPPatterns.Structural.Facade;
using CSOOPPatterns.Structural.Flyweight;
using CSOOPPatterns.Structural.Proxy;

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
            
            //Builder
            var opossumBuilder = new OpossumBuilder();
            var director = new Director(opossumBuilder);
            var sectionalUnit = director.GetUnit();
            sectionalUnit.DoStuff();
            
            var baldBuilder = new BaldBuilder();
            director.SetBuilder(baldBuilder);
            sectionalUnit = director.GetUnit();
            sectionalUnit.DoStuff();

            //Prototype
            var prototype = new PrototypeSample(2);
            prototype.SetProperty(1.0f);
            prototype.DoStuff();
            var clone = (PrototypeSample)prototype.Clone();
            clone.DoStuff();
            
            //Singleton
            Singleton.Instance.SingletonScream();
            
            //Adapter
            var adapterClient = new AdapterClient();
            adapterClient.DoStuff();
            
            //Bridge
            var bridgeClient = new BridgeClient();
            bridgeClient.DoStuff();
            
            //Composite
            var compositeClient = new CompositeClient();
            compositeClient.DoStuff();
            
            //Decorator
            var decoratorClient = new DecoratorClient();
            decoratorClient.DoStuff();
            
            //Facade
            var facadeClient = new Facade();
            facadeClient.DoStuff();
            
            //Flyweight
            var flyweightClient = new FlyweightClient();
            flyweightClient.DoStuff();
            
            //Proxy
            var proxyClient = new ProxyClient();
            proxyClient.DoStuff();
            
            //CoR
            var corClient = new CoRClient();
            corClient.DoStuff();
            
            //Command
            var commandClient = new CommandClient();
            commandClient.DoStuff();
            
            //Iterator
            var iteratorClient = new IteratorClient();
            iteratorClient.DoStuff();
            
            //Mediator
            var mediatorClient = new MediatorClient();
            mediatorClient.DoStuff();
            
            //Memento
            var mementoClient = new MementoClient();
            mementoClient.DoStuff();
            
            //Observer
            var ObserverClient = new ObserverClient();
            ObserverClient.DoStuff();
        }
    }
}