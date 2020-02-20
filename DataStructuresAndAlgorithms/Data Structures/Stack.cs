using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
   internal class Stack
    {
       
       LinkedList<object> stack;
        public Stack()
        {
            stack = new LinkedList<object>();
        }

        public int Count()
        {
            return stack.Size;
        }

        public object Peek()
        {
            if (stack.isEmpty())
            {
                throw new ArgumentNullException("stack is empty");
            }
            return stack.Head;
        }

        public bool Contains(object item)
        {
           return stack.Find(item) >= 0;
        }
        public void Clear()
        {
            stack.clear();
        }

        public void Push(object item)
        {
            stack.AddFirst(item);
        }

        public object Pop()
        {
            if (stack.isEmpty())
            {
                throw new ArgumentNullException("stack is empty");
            }
            return stack.RemoveFirst();
        }

        public  void Traverse()
        {
            stack.Traverse();
        }
    }
}
