namespace CSOOPPatterns.Structural.Composite
{
    public class Item : IEvaluatable
    {
        private int _value;

        public Item(int value)
        {
            _value = value;
        }

        public int Evaluate()
        {
            return _value;
        }
    }
}