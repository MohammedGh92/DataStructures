using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Utils;

namespace DataStructures.Grokking.Subsets
{
    public class Subsets
    {
        int[] nums;
        public Subsets()
        {
            nums = new int[] { 1, 3 };
        }

        public List<List<int>> findSubsets()
        {

            Console.WriteLine("----6-----");
            List<List<int>> result = new List<List<int>>();
            result.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                int currentCount = result.Count;
                int num = nums[i];
                for (int y = 0; y < currentCount; y++)
                {
                    List<int> subset = result[y].ToList();
                    subset.Add(num);
                    result.Add(subset);
                }
            }
            return result;
        }
    }
}