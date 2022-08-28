using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Find_the_Missing_Number
    {
        int[] arr;
        public Find_the_Missing_Number()
        {
            arr = new int[] { 4, 0, 3, 1 };
        }

        public int findMissingNumber()
        {
            Sort(arr);

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != i)
                    return i;

            return -1;
        }

        private void Sort(int[] arr)
        {
            int cp = 0;
            while (cp < arr.Length)
            {
                int cn = arr[cp];

                if (cn == cp)
                    cp++;
                else
                {
                    if (cn < arr.Length)
                        Swap(arr, cp, cn);
                    else
                        cp++;
                }

            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
