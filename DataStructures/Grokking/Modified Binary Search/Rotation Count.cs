using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Rotation_Count
    {
        int[] nums;
        public Rotation_Count()
        {
            nums = new int[] { 1, 3, 8, 10 };
        }

        public int countRotations()
        {
            return GetRotationIndx();
        }

        private int GetRotationIndx()
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > nums[right])
                    left = mid + 1;
                else if (nums[mid] > nums[left])
                    right = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
