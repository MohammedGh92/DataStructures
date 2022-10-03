using System;
using DataStructures.Utils;

namespace DataStructures.LeetCode.TopInterviewQuestions
{
    public class Remove_Duplicates_from_Sorted_Array
    {
        int[] nums;
        public Remove_Duplicates_from_Sorted_Array()
        {
            nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        }

        public int RemoveDuplicates()
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int count = 1;
            int p1 = 0;
            int p2 = p1 + 1;

            while (p2 < nums.Length)
            {
                if (nums[p1] == nums[p2])
                    p2++;
                else
                {
                    nums[p1 + 1] = nums[p2];
                    p1++;
                    p2++;
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}