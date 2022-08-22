using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Find_all_Duplicate_Numbers
    {
        int[] arr;
        public Find_all_Duplicate_Numbers()
        {
            arr = new int[] { 5, 4, 7, 2, 3, 5, 3 };
        }

        public List<int> findNumbers()
        {
            List<int> list = new List<int>();

            Sort(arr);

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != i + 1)
                    list.Add(arr[i]);

            Print.PrintList(list);

            return list;
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
