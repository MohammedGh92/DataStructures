using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.TwoPointers
{
    public class Dutch_National_Flag_Problem
    {
        int[] arr;
        public Dutch_National_Flag_Problem()
        {
            arr = new int[] { 1, 0, 2, 1, 0 };
        }

        public void sort()
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {

                if (arr[left] == 0)
                    left++;
                else if (arr[right] != 0)
                    right--;
                else
                {
                    int temp = arr[left];
                    arr[left] = 0;
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }

            left = 0;
            right = arr.Length - 1;

            while (left < right)
            {

                if (arr[left] != 2)
                    left++;
                else if (arr[right] != 1)
                    right--;
                else
                {
                    arr[left] = 1;
                    arr[right] = 2;
                    left++;
                    right--;
                }
            }

            Print.PrintArr(arr);
        }
    }
}
