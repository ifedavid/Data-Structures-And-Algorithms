using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class DynamicArray<T>
    {
        private T[] arr;
        private int length = 0;
        private int Capacity = 0;

        public DynamicArray()
        {
            arr = new T[16];
        }
        public DynamicArray(int capacity)
        {
         
            //Cannot initialize arry of length 0
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException ("Array can't be of size 0");
            }
            this.Capacity = capacity;
            arr = new T[capacity]; 
        }

        /// <summary>
        /// Returns the length of the array.
        /// </summary>
        /// <returns></returns>
        public int Length()
        {
            return length;
        }

        /// <summary>
        /// Checks if the array is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return length == 0 ? true : false;
        }

        /// <summary>
        /// Gets the element at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            //Check boundaries
            if (index < 0 || index >= length)
            {
                throw new IndexOutOfRangeException();
            }
            return arr[index];
        }

        /// <summary>
        /// Set the index with the specified value
        /// </summary>
        /// <param name="index"></param>
        /// <param name="elem"></param>
        public void Set(int index, T elem)
        {
            //Check boundaries
            if (index < 0 || index >= length)
            {
                throw new IndexOutOfRangeException();
            }
            arr[index] = elem;
        }

        /// <summary>
        /// Clear the array
        /// </summary>
        public void Clear()
        {
            for(int i =0; i<Capacity; i++)
            {
                arr[i] = default(T);
            }
            length = 0;
        }

        /// <summary>
        /// Adds an element at the end of the array
        /// </summary>
        /// <param name="elem"></param>
        public void Add(T elem)
        {
            //Check if the static array is full. If it is, create an array of bigger capacity and clone the static array to the new array created.
            if (length + 1 >= Capacity)
            {
                if (Capacity == 0) Capacity = 1;
                else Capacity *= 2;

                T[] new_arr = new T[Capacity];

                for (int i =0; i<length; i++)
                {
                    new_arr[i] = arr[i];
                }
                arr = new_arr;
            }

            //Add element at the end of the array
            arr[length++] = elem;
        }

        /// <summary>
        /// Adds and element at the given index.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="elem"></param>
        public void Add(int index, T elem)
        {
            //Check if the static array is full. If it is, create an array of bigger capacity and clone the static array to the new array created.
            if (length +1 >= Capacity)
            {
                if (Capacity == 0) Capacity = 1;
                else Capacity *= 2;

                T[] new_arr = new T[Capacity];

                //Add all elements from 0 to current index to new array
                for (int i = 0; i< index; i++)
                {
                    new_arr[i] = arr[i];
                }

                //Add element to specified index.
                new_arr[index] = elem;

                //Shift all remaining elements to the right index
                for ( int i =index; i< length-index; i++)
                {
                    new_arr[index + 1] = arr[index];
                }

                arr = new_arr;
            }

            //Shift all elements to the right.
            for (int i = index; i <= (length - index) ; i++)
            {
                arr[index + 1] = arr[index];
            }

            //Change element of specified index.
            arr[index] = elem;

        }

        /// <summary>
        /// Removes an element at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T RemoveAt(int index)
        {
            T data = arr[index];

            //Shift all elements to the left.
            for (int i = index; i < (length - index); i++)
            {
                arr[index] = arr[index + 1];
            }

            return data;

        }

        /// <summary>
        /// Removes the first instance of an element
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public bool Remove(object elem)
        {
            for (int i =0; i< length; i++)
            {
                if (arr[i].Equals(elem))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Checks if the array contains the specified element
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public bool contains (object elem)
        {
            for (int i = 0; i < length; i++)
            {
                if (arr[i].Equals(elem)) return true;
            }

            return false;
        }


        /// <summary>
        /// Returns the index of a particular element.
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public int Find(object elem)
        {
            for (int i=0; i< length; i++)
            {
                if (arr[i].Equals(elem)) return i;
            }

            return -1;
        }
    }
}
