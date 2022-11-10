using Iterator.Interfaces;

namespace Iterator
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    public class Iterator : IAbstractIterator
    {
        Collection collection;
        int current = 0;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        public Item First()
        {
            current = 0;
            return collection[current] as Item;
        }

        public Item Next()
        {
            current += Step;
            if (!IsDone)
                return collection[current] as Item;
            else
                return null;
        }

        public int Step { get; set; } = 1;

        public Item CurrentItem
        {
            get { return collection[current] as Item; }
        }

        public bool IsDone
        {
            get { return current >= collection.Count; }
        }
    }
}
