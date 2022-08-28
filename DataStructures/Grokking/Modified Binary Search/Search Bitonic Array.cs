using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Search_Bitonic_Array
    {
        int[] nums;
        int key;
        public Search_Bitonic_Array()
        {
            nums = new int[] { 1, 4, 8, 5, 3 };
            key = 4;
        }

        public int search()
        {
            int getMax = GetMaxNum();
            int searchRes = search(0, getMax);
            if (searchRes == -1)
                searchRes = search(getMax, nums.Length - 1);
            Console.WriteLine(searchRes);
            return searchRes;

        }

        private int search(int left, int right)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }

        private int GetMaxNum()
        {
            int left = 0;
            int right = nums.Length - 1;
            int max = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (max == -1 || nums[mid] > nums[max])
                    max = mid;
                if ((mid - 1) >= 0 && nums[mid - 1] > nums[mid])
                {
                    right = mid - 1;
                    if (max == -1 || nums[right] > nums[max])
                        max = right;
                }
                else if ((mid + 1) < nums.Length && nums[mid + 1] > nums[mid])
                {
                    left = mid + 1;
                    if (max == -1 || nums[left] > nums[max])
                        max = left;
                }
                else
                    return max;
            }
            return max;
        }
    }
}
