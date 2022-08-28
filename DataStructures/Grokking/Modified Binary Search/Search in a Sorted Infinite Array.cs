using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Search_in_a_Sorted_Infinite_Array
    {
        int[] nums;
        int key;
        public Search_in_a_Sorted_Infinite_Array()
        {
            nums = new int[] { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 };
            key = 30;
        }

        public int search()
        {

            int start = 1;
            int end = 2;

            if (nums[0] == key)
                return 0;


            while (end < nums.Length && key > nums[end])//here should be a reader instead
            {
                start++;
                end = start * 2;
            }

            if (end >= nums.Length)//here should be a reader instead
                end = nums.Length - 1;

            int left = start;
            int right = end;

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

    }
}
