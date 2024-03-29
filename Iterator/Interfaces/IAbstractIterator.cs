﻿namespace Iterator.Interfaces
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    public interface IAbstractIterator
    {
        Item First();

        Item Next();

        bool IsDone { get; }

        Item CurrentItem { get; }
    }
}
