using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Search_in_Rotated_Array
    {
        int[] nums;
        int key;
        public Search_in_Rotated_Array()
        {
            nums = new int[] { 4, 5, 7, 9, 10, -1, 2 };
            key = 10;
        }

        public int search()
        {
            int getRotationIndx = GetRotationIndx();
            int res = search(0, getRotationIndx - 1);
            if (res == -1)
                res = search(getRotationIndx, nums.Length - 1);
            return res;
        }

        private int search(int left, int right)
        {
            Console.WriteLine(left + "," + right);
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] > key)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
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
            Console.WriteLine("Left:" + left + "," + right);
            return -1;
        }
    }
}
