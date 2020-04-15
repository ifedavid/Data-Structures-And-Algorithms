using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms
{
    class SearchingAlgorithms
    {
        public int BinarySearch(int[] arr, int elem, int min = 0, int max = 0)
        {

            if (max == 0)
            {
                max = arr.Length;
            }

            int midPointIndex = (max + min) / 2;

            if (arr[midPointIndex] == elem) return midPointIndex;

            if (elem > arr[midPointIndex])
            {
                min = midPointIndex + 1;
                int solution = BinarySearch(arr, elem, min, max);
                return solution;
            }

            if (elem < arr[midPointIndex])
            {
                max = midPointIndex - 1;
                int solution = BinarySearch(arr, elem, min, max);
                return solution;
            }

            return -1;

        }

    }
}
