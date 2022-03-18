using Iterator.Interfaces;
using System.Collections.Generic;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    public class Collection : IAbstractCollection
    {
        List<Item> items = new List<Item>();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
