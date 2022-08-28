using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Bitonic_Array_Maximum
    {
        int[] nums;
        public Bitonic_Array_Maximum()
        {
            nums = new int[] { 10, 9, 8 };
        }

        public int findMax()
        {

            int left = 0;
            int right = nums.Length - 1;
            int max = int.MinValue;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                max = Math.Max(max, nums[mid]);
                if ((mid - 1) >= 0 && nums[mid - 1] > nums[mid])
                {
                    right = mid - 1;
                    max = Math.Max(max, nums[right]);
                }
                else if ((mid + 1) < nums.Length && nums[mid + 1] > nums[mid])
                {
                    left = mid + 1;
                    max = Math.Max(max, nums[left]);
                }
                else
                    return max;
            }
            return max;
        }
    }
}
