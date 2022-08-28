using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Order_agnostic_Binary_Search
    {
        int[] nums;
        int key;
        public Order_agnostic_Binary_Search()
        {
            nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            key = 10;
        }

        public int search()
        {
            if (nums[0] < nums[1])
                return searchAesc();
            else
                return searchDesc();
        }

        private int searchAesc()
        {
            int left = 0;
            int right = nums.Length - 1;

            if (key < nums[0] || key > nums[nums.Length - 1])
                return -1;

            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] > key)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }

        private int searchDesc()
        {
            int left = 0;
            int right = nums.Length - 1;
            if (key > nums[0] || key < nums[nums.Length - 1])
                return -1;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (mid > key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
