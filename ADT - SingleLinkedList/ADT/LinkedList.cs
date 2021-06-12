using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class LinkedList<T> : ILinkedListOfT<T>
    {
        internal class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public override string ToString()
            {
                return Data.ToString();
            }
        }
        private int count = 0;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public T First { get { return Head.Data; } }

        public T Last { get { return ItemAt(Count - 1); } }

        private Node Head = new Node();

        public void InsertAt(int index, T obj)
        {
            Node currentHead = Head;
            if (Head.Data != null && index == 0)
            {
                Node newHead = new Node();
                newHead.Data = obj;
                newHead.Next = Head;
                Head = newHead;
                count++;
                return;
            }
            else if (index == 0)
            {
                Head.Data = obj;
                count++;
                return;
            }

            Node nextNode = new Node();
            nextNode.Data = obj;
            for (int i = 0; i < index - 1; i++)
            {
                currentHead = currentHead.Next;
            }
            if (currentHead.Next == null)
            {
                currentHead.Next = nextNode;
                count++;
            }
            else
            {
                nextNode.Next = currentHead.Next;
                currentHead.Next = nextNode;
                count++;
            }
        }
        public void DeleteAt(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Index skal være 0 eller højere");
            }
            if (index > this.count)
            {
                index = count - 1;
            }


            Node current = Head;
            if (index == 0)
            {
                Head = current.Next;
                count--;
                return;
            }

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;

            count--;
        }
        public T ItemAt(int index)
        {
            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public void Append(T obj)
        {

            if (Head.Data is null || Head.Data is 0 || Head.Data is 0.0M)
            {
                Head.Data = obj;
                count++;
                return;
            }
        

            Node current = Head;
            Node newNode = new Node();
            newNode.Data = obj;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            count++;
        }


        public void Insert(T obj)
        {
            if (Head.Data == null)
            {
                Head.Data = obj;
                count++;
                return;
            }
            Node newNode = new Node();
            newNode.Data = obj;
            newNode.Next = Head;

            Head = newNode;
            count++;
        }


        public override string ToString()
        {
            string returnstring = "";
            Node currentHead = Head;
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    returnstring += currentHead.Data.ToString();
                    continue;
                }
                returnstring += currentHead.Data.ToString() + "\n";
                currentHead = currentHead.Next;
            }
            return returnstring;
        }

        
    }
}

