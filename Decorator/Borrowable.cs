using System;
using Decorator.Abstracts;
using System.Collections.Generic;

namespace Decorator
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    public class Borrowable : Abstracts.Decorator
    {
        protected readonly List<string> _borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            _libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            _libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in _borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
