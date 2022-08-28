using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Find_the_Smallest_Missing_Positive_Number
    {
        int[] arr;
        public Find_the_Smallest_Missing_Positive_Number()
        {
            arr = new int[] { -3, 1, 5, 4, 2 };
        }

        public int findNumber()
        {

            Sort(arr);
            int StartIndx = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    StartIndx = i;
                    break;
                }
            }
            int cn = 1;
            for (int i = StartIndx; i < arr.Length; i++)
            {
                if (arr[i] != cn)
                    return cn;
                cn++;
            }
            return arr[arr.Length - 1] + 1;
        }

        private void Sort(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] > 0 && arr[i] <= arr.Length && arr[i] != arr[arr[i] - 1])
                    swap(arr, i, arr[i] - 1);
                else
                    i++;
            }
        }

        private void swap(int[] arr, int v1, int v2)
        {
            int temp = arr[v1];
            arr[v1] = arr[v2];
            arr[v2] = temp;
        }
    }
}
