using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    class PriorityQueue
    {
    }



    /// <summary>
    /// Implementation of a minimun heap using linked list.
    /// </summary>
    class Heap
    {
        
        LinkedList<int> heap;

        public Heap()
        {
            heap = new LinkedList<int>();
            //Add an element at index 0 to ease operations
            heap.AddLast(0);
        }

        public void swap(int a, int indexA, int b, int indexB)
        {
            var nodeA = heap.GetNode(indexA);
            nodeA.Data = b;

            var nodeB = heap.GetNode(indexB);
            nodeB.Data = a;

        }

        public int Length()
        {
            return heap.Size;
        }

        public void traverse()
        {
            heap.Traverse();
        }

        public void Insert(int item)
        {
  
            heap.AddLast(item);

            int itemIndex = heap.Size - 1;
            int parentIndex = itemIndex /2;

            while (parentIndex >= 1)
            {
                int parent = heap.GetElement(parentIndex);

                if(item < parent)
                {
                    swap(item, itemIndex, parent, parentIndex);

                    //change the index of the item if it switches places with the parent
                    itemIndex = parentIndex;
                }

                //Checks the next parent index
                parentIndex = parentIndex / 2;

            }

        }
    }
}
