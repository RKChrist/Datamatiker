using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class NonGenericStack
    {
        NonGenericLinkedList stack = new NonGenericLinkedList();

        public int Count { get; private set; } = 0;

        public bool IsEmpty { get; private set; } = true;

        public void Push(object obj)
        {
            stack.Insert(obj);
            Count++;
            IsEmpty = false;
        }
        public object Peek()
        {
            if (IsEmpty == false)
            {
                return stack.ItemAt(0);
            }
            return null;
        }
        public object Pop()
        {
            var obj = stack.ItemAt(0);
            stack.DeleteAt(0);
            return obj;

        }
    }
}
