
namespace CSOOPPatterns.Prototype
{
    public class PrototypeProperty : IPrototype
    {
        private float _num;

        public PrototypeProperty(float num)
        {
            _num = num;
        }

        public IPrototype Clone()
        {
            return new PrototypeProperty(_num);
        }

        public string ToString()
        {
            return _num.ToString();
        }
    }
}