using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Data_Structures
{
    /// <summary>
    /// Doubly LinkedList Node. Contains the Data and pointers to the Next and Previous Node.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedListNode<T>
    {
       internal T Data { get; set; }
       internal LinkedListNode<T> Next { get; set; }
       internal LinkedListNode<T> Prev { get; set; }

        internal LinkedListNode(T data, LinkedListNode<T> prev, LinkedListNode<T> next)
        {
            Data = data;
            Next = next;
            Prev = prev;
        }
    }

    /// <summary>
    /// Doubly LinkedList class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList<T> 
    {
         internal int Size = 0;
         internal LinkedListNode<T> Head = null;
         internal LinkedListNode<T> Tail = null;


        /// <summary>
        /// Clears the Doubly LinkedList
        /// </summary>
        public void clear()
        {
            LinkedListNode<T> trav = Head;

            while(trav != null)
            {
                LinkedListNode<T> Next = Head.Next;
                trav.Prev = trav.Next = null;
                trav.Data = default;
                trav = Next;
            }

            Head = Tail = trav = null;
            Size = 0;
        }

        /// <summary>
        /// Checks if the LinkedList is empty. Returns true or false.
        /// </summary>
        /// <returns></returns>
        public bool isEmpty()
        {
            return Size == 0;
        }

        /// <summary>
        /// Creates a node for the item and adds it to the end of the LinkedList.
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(T item)
        {
            if (isEmpty())
            {
                Head = Tail = new LinkedListNode<T>(item, null, null);
            }
            else
            {
                Tail.Next = new LinkedListNode<T>(item, Tail, null);
                Tail = Tail.Next;
            }
            Size++;
        }

        /// <summary>
        /// Adds a node to the end of the LinkedList.
        /// </summary>
        /// <param name="newNode"></param>
        public void AddLast(LinkedListNode<T> newNode)
        {
            if (isEmpty())
            {
                newNode.Prev = null;
                newNode.Next = null;
                Head = Tail = newNode;
            }
            else
            {
                newNode.Prev = Tail;
                newNode.Next = null;
                Tail.Next = newNode;
                Tail = Tail.Next;
            }
            Size++;
        }


        /// <summary>
        /// Creates a node for the item and adds it to the beginning of the LinkedList.
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(T item)
        {
            if (isEmpty())
            {
                Head = Tail = new LinkedListNode<T>(item, null, null);
            }
            else
            {
                Head.Prev = new LinkedListNode<T>(item, null, Head);
                Head = Head.Prev;
            }

            Size++;
        }

        /// <summary>
        /// Adds a node to the beginning of the LinkedList.
        /// </summary>
        /// <param name="newNode"></param>
        public void AddFirst(LinkedListNode<T> newNode)
        {
            if (isEmpty())
            {
                newNode.Prev = null;
                newNode.Next = null;
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                newNode.Prev = null;
                Head.Prev = newNode;
                Head = Head.Prev;
            }

            Size++;
        }

        /// <summary>
        /// Returns the first Node in the LinkedList.
        /// </summary>
        /// <returns></returns>
        public LinkedListNode<T> FirstNode()
        {
            if (isEmpty()) throw new NullReferenceException("List is empty");
            else return Head;
        }

        /// <summary>
        /// Returns the last Node in the LinkedList.
        /// </summary>
        /// <returns></returns>
        public LinkedListNode<T> LastNode()
        {
            if (isEmpty()) throw new NullReferenceException("List is empty");
            else return Tail;
        }

        /// <summary>
        /// Removes the first Node in the LinkedList.
        /// </summary>
        public void RemoveFirst()
        {
            if (isEmpty())
            {
                throw new NullReferenceException("Can't remove a node from a null list");
            }
            else
            {
                LinkedListNode<T> newHead = Head.Next;
                newHead.Prev = null;
                Head = newHead;
            }
            Size--;
        }

        /// <summary>
        /// Removes the Last Node in the LinkedList.
        /// </summary>
        public void RemoveLast()
        {
            if (isEmpty())
            {
                throw new NullReferenceException("Can't remove a node from a null list");
            }
            else
            {
                LinkedListNode<T> newTail = Tail.Prev;
                newTail.Next = null;
                Tail = newTail;
            }
            Size--;
        }

        /// <summary>
        /// Searches the LinkedList for a particular Node and returns the Index
        /// </summary>
        /// <param name="nodeItem"></param>
        /// <returns></returns>
        public int Find(LinkedListNode<T> nodeItem)
        {
            if (Head == nodeItem)
            {
                return 0;
            }
            if (Tail == nodeItem)
            {
                return Size - 1;
            }

            LinkedListNode<T> trav = Head;
            int index = 0;
            while (trav != null)
            {
                if (trav == nodeItem)
                {
                    return index;
                }
                index++;
                trav = trav.Next;
            }

            return -1;
        }

        /// <summary>
        /// Returns every node data in the LinkedList and their Index.
        /// </summary>
        public void Traverse()
        {
            LinkedListNode<T> trav = Head;

            T[] arr = new T[Size];

            int index = 0;
            while (trav != null)
            {
                arr[index] = trav.Data;
                trav = trav.Next;
                index++;
            }

            for(int i =0; i<arr.Length; i++)
            {
                Console.WriteLine("Item " + i + " in the list has value " + arr[i]);
            }
        }


        /// <summary>
        /// Searches the LinkedList and adds a NewNode before the Selected Node.
        /// </summary>
        /// <param name="SelectNode"></param>
        /// <param name="NewNode"></param>
        /// <returns></returns>
        public bool AddBefore(LinkedListNode<T> SelectNode, LinkedListNode<T> NewNode)
        {
            if (SelectNode == Head) { AddFirst(NewNode); Size++; return true; }

            LinkedListNode<T> trav = Head;

            while (trav != null)
            {
                if (trav == SelectNode)
                {
                    LinkedListNode<T> previousNode = SelectNode.Prev;
                    NewNode.Next = SelectNode;
                    NewNode.Prev = previousNode;
                    previousNode.Next = NewNode;
                    SelectNode.Prev = NewNode;
                    Size++;
                    return true;
                }
                trav = trav.Next;
            }
            return false;
        }

        /// <summary>
        /// Searches the LinkedList and adds a NewNode after the Selected Node
        /// </summary>
        /// <param name="SelectNode"></param>
        /// <param name="NewNode"></param>
        /// <returns></returns>
        public bool AddAfter(LinkedListNode<T> SelectNode, LinkedListNode<T> NewNode)
        {
            if (SelectNode == Tail) { AddLast(NewNode); Size++; return true; }

            LinkedListNode<T> trav = Head;

            while (trav != null)
            {
                if (trav == SelectNode)
                {
                    LinkedListNode<T> nextNode = SelectNode.Next;
                    NewNode.Next = nextNode;
                    NewNode.Prev = SelectNode;
                    SelectNode.Next = NewNode;
                    nextNode.Prev = NewNode;
                    Size++;
                    return true;
                }
                trav = trav.Next;
            }
            return false;
        }

        /// <summary>
        /// Searches the LinkedList and Removes the Selected Node. Checks the Head and Tails nodes first and then searches the LinkedList.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool Remove(LinkedListNode<T> SelectNode)
        {
            if (SelectNode == Head) return true;
            if (SelectNode == Tail) return true;

            LinkedListNode<T> trav = Head.Next;

            while (trav != null)
            {
                if (trav == SelectNode)
                {
                    return true;
                }
                trav = trav.Next;
            }
            return false;
        }

        /// <summary>
        /// Removes the Node before the Selected Node.
        /// </summary>
        /// <param name="SelectNode"></param>
        /// <returns></returns>
        public bool RemoveBefore(LinkedListNode<T> SelectNode)
        {
            if (SelectNode == Head) { throw new IndexOutOfRangeException("There is no node before the Head node");}

            LinkedListNode<T> trav = Head.Next;

            while (trav != null)
            {
                if (trav == SelectNode)
                {
                    LinkedListNode<T> nodeToRemove = SelectNode.Prev;
                    LinkedListNode<T> previousNode = nodeToRemove.Prev;

                    previousNode.Next = SelectNode;
                    SelectNode.Prev = previousNode;
                    
                    Size--;
                    return true;
                }
                trav = trav.Next;
            }
            return false;
        }

        /// <summary>
        /// Removes the Node after the Selected Node.
        /// </summary>
        /// <param name="SelectNode"></param>
        /// <returns></returns>
        public bool RemoveAfter(LinkedListNode<T> SelectNode)
        {
            if (SelectNode == Tail) { throw new IndexOutOfRangeException("There is no node after the Tail node"); }

            LinkedListNode<T> trav = Head;

            while (trav != null)
            {
                if (trav == SelectNode)
                {
                    LinkedListNode<T> nodeToRemove = SelectNode.Next;
                    LinkedListNode<T> nextNode = nodeToRemove.Next;

                    SelectNode.Next = nextNode;
                    nextNode.Prev = SelectNode;

                    Size--;
                    return true;
                }
                trav = trav.Next;
            }
            return false;
        }




    }
}
