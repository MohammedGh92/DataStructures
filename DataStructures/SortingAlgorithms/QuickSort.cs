using System;
using DataStructures.Utils;

namespace DataStructures.SortingAlgorithms
{
    public class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            //{ 10,80,30,90,40,50,70 }

            quickSort(arr, 0, arr.Length - 1);

            return arr;
        }

        private static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);//O(Logn)
                quickSort(arr, pi + 1, high);//O(Logn)
            }
        }

        private static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap.swap(ref arr, i, j);
                }
            }
            Swap.swap(ref arr, i + 1, high);
            return i + 1;
        }
    }
}
