using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class Queue<T>
    {
        LinkedList<T> queue;

        public Queue()
        {
            queue = new LinkedList<T>();
        }


        public bool IsEmpty()
        {
            return queue.isEmpty();
        }


        public bool Contains(T item)
        {
            return queue.Contains(item);
        }

        public int Find(T item)
        {
            return queue.Find(item);
        }


        public bool Remove(T item)
        {
            return queue.Remove(item);
        }

        public int Count()
        {
            return queue.Size;
        }

        public bool Enqueue(T item)
        {
            queue.AddLast(item);
            return true;
        }

        public bool Dequeue()
        {
            queue.RemoveFirst();
           return true;
        }

        public void Clear()
        {
            queue.clear();
        }

        public T Peeking()
        {
            T item = queue.RemoveFirst();
            return item;
        }

        public void Traverse()
        {
            queue.Traverse();
        }

    }
}
