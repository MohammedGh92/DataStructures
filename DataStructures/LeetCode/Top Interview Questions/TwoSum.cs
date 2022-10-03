using System;
using System.Collections.Generic;

namespace DataStructures.LeetCode
{
    public class TwoSum
    {

        int[] nums;
        int target;
        public TwoSum()
        {
            nums = new int[] { 2, 15, 11, 7 };
            target = 9;
        }

        public int[] TwoSums()
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    Console.WriteLine(i + "," + dict[target - nums[i]] + "," + nums[i] + "," + nums[dict[target - nums[i]]]);
                    return new int[] { i, dict[target - nums[i]] };
                }
                else
                    dict.Add(nums[i], i);
            }

            return null;
        }

    }
}
