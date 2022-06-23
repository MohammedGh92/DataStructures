using System;
namespace DataStructures.SortingAlgorithms
{
    public class BubbleSort
    {
        public static int[] Sort(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int y = 0; y < arr.Length - 1; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        int temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
