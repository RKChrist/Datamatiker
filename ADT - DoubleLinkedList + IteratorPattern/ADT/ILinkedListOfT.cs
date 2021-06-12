namespace ADT
{
    public interface ILinkedListOfT<T>
    {
        void Append(T obj);
        void DeleteAt(int index);
        void InsertAt(int index, T obj);
        T ItemAt(int index);
        void Insert(T obj);
    }
}