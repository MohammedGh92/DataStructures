using System;
namespace DataStructures.Grokking.TwoPointers
{
    public class Squaring_a_Sorted_Array
    {
        int[] arr;
        public Squaring_a_Sorted_Array()
        {
            arr = new int[] { -2, -1, 0, 2, 3 };
        }

        public int[] makeSquares()
        {
            int[] resArr = new int[arr.Length];

            int addPointer = arr.Length - 1;

            int left = 0;
            int right = addPointer;

            while (addPointer > 0)
            {

                if (arr[left] * arr[left] > arr[right] * arr[right])
                {
                    resArr[addPointer] = arr[left] * arr[left];
                    left++;
                }
                else
                {
                    resArr[addPointer] = arr[right] * arr[right];
                    right--;
                }
                addPointer--;
            }

            return resArr;
        }
    }
}
