using System;
namespace DataStructures.SortingAlgorithms
{
    internal class InsertionSort
    {
        internal static int[] Sort(int[] arr)
        {
            //{ 2, 8, 5, 3, 9, 4 }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
