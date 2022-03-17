namespace Decorator.Abstracts
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem _libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
