using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class NonGenericQueue
    {
        NonGenericLinkedList queue = new NonGenericLinkedList();

        public int Count { get; private set; } = 0;

        public bool IsEmpty { get; set; } = true;

        public void Enqueue(object obj)
        {
            queue.Append(obj);
            IsEmpty = false;
            Count++;
        }

        public object Dequeue()
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

