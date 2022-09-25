using System;
namespace DataStructures.Grokking.SlidingWindow
{
    public class Maximum_Sum_Subarray_of_Size_K
    {
        int k;
        int[] arr;
        public Maximum_Sum_Subarray_of_Size_K()
        {
            arr = new int[] { 2, 1, 5, 1, 3, 2 };
            k = 3;
        }

        public int findMaxSumSubArray()
        {
            int left = 0;
            int right = 1;
            int cSum = 0;
            int max = 0;

            while (right < arr.Length)
            {
                cSum += arr[right];
                if (right >= k - 1)
                {
                    max = Math.Max(max, cSum);
                    cSum -= arr[left];
                    left++;
                }
                right++;
            }


            return max;
        }

    }
}

