using System;
using DataStructures.Utils;

namespace DataStructures.SortingAlgorithms
{
    internal class RadixSort
    {
        internal static int[] Sort(int[] arr)
        {
            //{ 53, 89, 150, 36, 633, 233 }
            int MaxNu = getMax(arr);

            for (int i = 0; i < MaxNu.ToString().Length; i++)
            {
                arr = countSort(arr, i);
                Print.PrintArr(arr);
            }

            return arr;
        }

        private static int[] countSort(int[] arr, int digitNu)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int cMinIndx = i;
                for (int y = i + 1; y < arr.Length; y++)
                {
                    if (getDigit(arr[cMinIndx], digitNu) > getDigit(arr[y], digitNu))
                    {
                        cMinIndx = y;
                    }
                }
                if (i != cMinIndx)
                    Swap.swap(ref arr, i, cMinIndx);
            }
            return arr;
        }
        //0,10,40,70,80,90,100
        
        private static int getDigit(int nu, int digitNu)
        {
            string nuStr = nu.ToString();
            if (digitNu >= nuStr.Length)
                return 0;
            else
                return int.Parse("" + nuStr[nuStr.Length - 1 - digitNu]);
        }

        private static int getMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
    }
}
