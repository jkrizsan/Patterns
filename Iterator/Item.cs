namespace Iterator
{
    /// <summary>
    /// A collection item
    /// </summary>
    public class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
