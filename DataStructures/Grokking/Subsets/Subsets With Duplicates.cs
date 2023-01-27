using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Utils;

namespace DataStructures.Grokking.Subsets
{
    public class Subsets_With_Duplicates
    {
        int[] nums;
        public Subsets_With_Duplicates()
        {
            nums = new int[] { 1, 5, 3, 3 };
            //nums = new int[] { 1, 3, 3 };
        }

        public List<List<int>> findSubsets()
        {
            Array.Sort(nums);
            List<List<int>> resList = new List<List<int>>();
            resList.Add(new List<int>());
            int startIndx, endIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                startIndx = 0;
                int cn = nums[i];
                int cs = resList.Count;
                if (i > 0 && cn == nums[i - 1])//if duplicate
                    startIndx = resList.Count - 2;
                endIndex = cs - 1;
                for (int y = startIndx; y <= endIndex; y++)
                {
                    List<int> cl = resList[y].ToList();
                    cl.Add(cn);
                    resList.Add(cl);
                }
            }

            for (int i = 0; i < resList.Count; i++)
                Print.PrintList(resList[i], true);

            return resList;
        }
    }
}
