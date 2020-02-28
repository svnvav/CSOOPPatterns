using System;

namespace CSOOPPatterns.Prototype
{
    public class PrototypeSample : IPrototype
    {
        private int _value;
        private PrototypeProperty _property;

        public PrototypeSample(int value)
        {
            _value = value;
        }

        public void SetProperty(float f)
        {
            _property = new PrototypeProperty(f);
        }

        public void DoStuff()
        {
            Console.WriteLine($"{GetType().Name}: {_value} + property: {_property.ToString()}");
        }

        public IPrototype Clone()
        {
            var clone = new PrototypeSample(_value);
            clone._property = (PrototypeProperty)_property.Clone();
            return clone;
        }
    }
}