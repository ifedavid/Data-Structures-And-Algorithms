using System;
using System.Collections.Generic;
using System.Collections;
using DataStructuresAndAlgorithms.Data_Structures;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Dynamic arrays.
            /* DynamicArray<string> dynamicArray = new DynamicArray<string>();

             for (int i = 0; i <= 10; i++)
             {
                 dynamicArray.Add("My name is " + i);
             }

             dynamicArray.Add("I'm different tho", 6);


             for (int i = 0; i < dynamicArray.Length(); i++)
             {
                 Console.WriteLine("The element at index " + i + " is " + dynamicArray.Get(i));
             }
             */


            /*  Data_Structures.LinkedList<int> linkedList = new Data_Structures.LinkedList<int>();

                linkedList.AddLast(5);
                linkedList.AddLast(10);
                linkedList.AddFirst(30);

                linkedList.Traverse();

                Data_Structures.LinkedListNode<int> linkedList1 = new Data_Structures.LinkedListNode<int>(25, null, null);

                Data_Structures.LinkedListNode<int> linkedList2 = new Data_Structures.LinkedListNode<int>(245, null, null);

                Data_Structures.LinkedListNode<int> linkedList3 = new Data_Structures.LinkedListNode<int>(2805, null, null);


                linkedList.AddLast(linkedList1);

                linkedList.AddLast(1990);

                linkedList.AddBefore(linkedList1, linkedList2);
                linkedList.RemoveBefore(linkedList2);
                linkedList.AddAfter(linkedList2, linkedList3);
                linkedList.AddLast(7675);
                linkedList.Remove(3);

                Console.WriteLine("");
                Console.WriteLine("");


                linkedList.Traverse(); */
            System.Collections.Stack stack = new System.Collections.Stack();
            Data_Structures.Stack myStack = new Data_Structures.Stack();

            stack.Push("Happy");
            stack.Push(334);
           
           var stuff = stack.Pop();

            Console.WriteLine(stuff);

            myStack.Push("Happy");
            myStack.Push(2334);
            myStack.Traverse();



        }
    }


}