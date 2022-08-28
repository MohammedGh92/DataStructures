using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Find_the_Duplicate_Number
    {
        int[] arr;
        public Find_the_Duplicate_Number()
        {
            arr = new int[] { 1, 4, 4, 3, 2 };
        }

        public int findNumber()
        {

            int i = 0;

            while (i < arr.Length)
            {
                if (arr[i] != i + 1)
                {
                    if (arr[i] != arr[arr[i] - 1])
                        swap(arr, i, arr[i] - 1);
                    else
                        return arr[i];
                }
                else
                    i++;
            }

            return -1;
        }

        private void swap(int[] arr, int i, int v)
        {
            int temp = arr[i];
            arr[i] = arr[v];
            arr[v] = temp;
        }

        public int TwoPointersSol()
        {
            int cp = 0;
            while (cp < arr.Length)
            {
                int np = arr[cp];
                if (cp == arr[np])
                    return cp;
                else
                    cp = np;
            }
            return -1;
        }
    }
}
