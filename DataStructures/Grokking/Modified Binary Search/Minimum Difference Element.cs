using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Minimum_Difference_Element
    {
        int[] nums;
        int key;
        public Minimum_Difference_Element()
        {
            nums = new int[] { 4, 5, 8, 10 };
            key = 7;
        }

        public int searchMinDiffElement()
        {

            int left = 0;
            int right = nums.Length - 1;
            int minDiffIndx = -1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (minDiffIndx == -1 || Math.Abs(nums[mid] - key) < Math.Abs(nums[minDiffIndx] - key))
                {
                    minDiffIndx = mid;
                    if (nums[mid] == 7)
                    {
                        Console.WriteLine(nums[minDiffIndx]);
                        return key;
                    }
                }
                else if (nums[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            Console.WriteLine(nums[minDiffIndx]);
            return nums[minDiffIndx];
        }
    }
}
