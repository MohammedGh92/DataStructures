using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Find_the_Corrupt_Pair
    {
        int[] arr;
        public Find_the_Corrupt_Pair()
        {
            arr = new int[] { 3, 1, 2, 3, 6, 4 };
        }

        public int[] findNumbers()
        {
            int[] res = new int[] { -1, -1 };

            Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    Console.WriteLine(arr[i] + "," + (i + 1));
                    return new int[] { arr[i], i + 1 };
                }
            }


            return res;
        }

        private void Sort(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] != arr[arr[i] - 1])
                    swap(arr, i, arr[i] - 1);
                else
                    i++;
            }
        }

        private void swap(int[] arr, int i, int v)
        {
            int temp = arr[i];
            arr[i] = arr[v];
            arr[v] = temp;
        }
    }
}
