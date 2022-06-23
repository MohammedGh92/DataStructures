using System;
namespace DataStructures.SortingAlgorithms
{
    public class SelectionSort
    {
        public static int[] Sort(int[] arr)
        {
            //{ 2, 8, 5, 3, 9, 1, 1 }

            for (int i = 0; i < arr.Length - 1; i++)
            {

                int yMinIndx = i + 1;
                for (int y = i + 1; y < arr.Length; y++)
                {
                    if (arr[y] < arr[yMinIndx])
                        yMinIndx = y;
                }

                if (i != yMinIndx)
                {
                    int temp = arr[i];
                    arr[i] = arr[yMinIndx];
                    arr[yMinIndx] = temp;
                }

            }

            return arr;
        }
    }
}
