using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class Queue<T> : IQueue<T>
    {
        LinkedList<T> queue = new LinkedList<T>();

        public int Count { get; private set; } = 0;

        public bool IsEmpty { get; set; } = true;

        public void Enqueue(T obj)
        {
            queue.Append(obj);
            Count++;
            IsEmpty = false;

        }

        public T Dequeue()
        {
            var obj = queue.ItemAt(0);
            queue.DeleteAt(0);
            Count--;
            if (Count == 0)
            {
                IsEmpty = true;
            }
            return (obj);
        }
    }
}
