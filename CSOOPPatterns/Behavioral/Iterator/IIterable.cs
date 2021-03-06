﻿namespace CSOOPPatterns.Behavioral.Iterator
{
    public interface IIterable<T>
    {
        IIterator<T> GetIterator();
    }
}