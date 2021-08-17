namespace ADT
{
    public interface IQueue<T>
    {
        int Count { get; }
        bool IsEmpty { get; set; }

        T Dequeue();
        void Enqueue(T obj);
    }
}