using System;
namespace DataStructures.Grokking.TwoPointers
{
    public class Pair_with_Target_Sum
    {
        int[] arr;
        int target;
        public Pair_with_Target_Sum()
        {
            arr = new int[] { 1, 2, 3, 4, 6 };
            target = 6;
        }

        public int[] search()
        {
            int[] resArr = new int[2];

            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];

                if (sum == target)
                {
                    resArr[0] = left;
                    resArr[1] = right;
                    break;
                }
                else if (sum > target)
                    right--;
                else
                    left++;
            }

            return resArr;
        }
    }
}
