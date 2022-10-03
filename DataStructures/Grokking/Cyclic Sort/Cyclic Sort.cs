using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Cyclic_Sort
    {
        int[] arr;
        public Cyclic_Sort()
        {
            arr = new int[] { 3, 1, 5, 4, 2 };
        }
        
        public void Sort()
        {
            int cp = 0;
            while (cp < arr.Length)
            {
                int cn = arr[cp];
                if (cn == cp + 1)
                    cp++;
                else
                    Swap(arr, cp, cn - 1);
            }
            Print.PrintArr(arr);
        }

        public void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
