namespace Composite
{
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    public abstract class DrawingElement
    {
        protected string _name;

        public DrawingElement(string name)
        {
            _name = name;
        }

        public abstract void Add(DrawingElement d);

        public abstract void Remove(DrawingElement d);

        public abstract void Display(int indent);
    }
}
