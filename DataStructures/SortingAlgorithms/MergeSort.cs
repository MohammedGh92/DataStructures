using System;
using DataStructures.Utils;

namespace DataStructures.SortingAlgorithms
{
    internal class MergeSort
    {
        internal static int[] Sort(int[] arr)
        {
            return mergeSort(arr);
        }

        private static int[] mergeSort(int[] arr)
        {
            if (arr.Length == 1)
                return arr;

            int[] arr1 = new int[arr.Length / 2];

            int[] arr2 = new int[arr.Length / 2];
            if (isOddArr(arr))
                arr2 = new int[(arr.Length / 2) + 1];

            int arr2Leng = arr2.Length;

            if (isOddArr(arr))
                arr2Leng -= 1;

            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = arr[i];
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = arr[arr2Leng + i];

            arr1 = mergeSort(arr1);
            arr2 = mergeSort(arr2);

            return merge(arr1, arr2);

        }

        private static bool isOddArr(int[] arr)
        {
            return arr.Length % 2 != 0;
        }

        private static int[] merge(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;

            while (p1 < arr1.Length && p2 < arr2.Length)
            {

                if (arr1[p1] < arr2[p2])
                {
                    arr3[p3] = arr1[p1];
                    p1++;
                }
                else
                {
                    arr3[p3] = arr2[p2];
                    p2++;
                }
                p3++;
            }

            while (p1 < arr1.Length)
            {
                arr3[p3] = arr1[p1];
                p1++;
                p3++;
            }

            while (p2 < arr2.Length)
            {
                arr3[p3] = arr2[p2];
                p2++;
                p3++;
            }

            return arr3;

        }
    }
}
