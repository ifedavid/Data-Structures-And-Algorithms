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
         
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException ("Array can't be of size 0");
            }
            this.Capacity = capacity;
            arr = new T[capacity]; 
        }

        public int Length()
        {
            Console.WriteLine("The length is " + length);
            return length;
        }

        public bool IsEmpty()
        {
            return length == 0 ? true : false;
        }

        public T Get(int index)
        {
            if (index < 0 || index > length)
            {
                throw new IndexOutOfRangeException();
            }
            return arr[index];
        }

        public void Set(int index, T elem)
        {
            if (index < 0 || index > length)
            {
                throw new IndexOutOfRangeException();
            }
            arr[index] = elem;
        }

        public void Clear()
        {
            for(int i =0; i<Capacity; i++)
            {
                arr[i] = default(T);
            }
            length = 0;
        }

        public void Add(T elem)
        {
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

            arr[length++] = elem;
        }

        public void Add(int index, int elem)
        {

        }

        public void Remove()
        {

        }
    }
}
