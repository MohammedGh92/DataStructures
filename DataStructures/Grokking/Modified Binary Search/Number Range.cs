using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Number_Range
    {
        int[] nums;
        int key;
        public Number_Range()
        {
            nums = new int[] { 1, 3, 8, 10, 15 };
            key = 12;
        }

        public int[] findRange()
        {
            Console.WriteLine(findNum(true) + "," + findNum(false));
            return new int[] { findNum(true), findNum(false) };
        }

        private int findNum(bool min = false)
        {
            int left = 0;
            int right = nums.Length - 1;
            int resNum = -1;
            while (left <= right)
            {

                int mid = (right + left) / 2;

                if (nums[mid] == key)
                {
                    resNum = mid;
                    if (min)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else if (nums[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return resNum;
        }
    }
}
