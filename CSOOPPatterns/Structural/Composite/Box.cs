using System.Collections.Generic;
using System.Linq;

namespace CSOOPPatterns.Structural.Composite
{
    public class Box : IEvaluatable
    {
        private List<Item> _items;

        public Box()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public int Evaluate()
        {
            return _items.Aggregate(0, (sum, item) => sum + item.Evaluate());
        }
    }
}