using System;
using System.Collections.Generic;

namespace CSOOPPatterns.Behavioral.Mediator
{
    public class MediatorClient : IMediator
    {
        public void DoStuff()
        {
            var components = new List<BaseComponent>();
            components.Add(new ComponentA(this));
            components.Add(new ComponentB(this));

            foreach (var component in components)
            {
                component.DoStuff();
            }
        }

        public void Notify(BaseComponent sender)
        {
            switch (sender)
            {
                case ComponentA componentA:
                    Console.WriteLine(componentA.GetType());
                    break;
                case ComponentB componentB:
                    Console.WriteLine(componentB.GetType());
                    break;
            }
        }
    }
}