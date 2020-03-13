namespace CSOOPPatterns.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        bool Finished { get; }
        T Current { get; }

        void MoveNext();
    }
}