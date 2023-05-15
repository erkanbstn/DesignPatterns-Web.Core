namespace Iterator.IteratorPattern
{
    public interface IMover<T>
    {
        IIterator<T> CreateIterator();
    }
}
