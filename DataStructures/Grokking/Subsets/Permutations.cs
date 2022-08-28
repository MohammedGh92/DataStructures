using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Utils;

namespace DataStructures.Grokking.Subsets
{
    public class Permutations
    {
        int[] nums;
        public Permutations()
        {
            //nums = new int[] { 1, 3, 5 };
            nums = new int[] { 1 };
        }

        public List<List<int>> findPermutations()
        {
            Console.WriteLine("------20-----");
            List<List<int>> resList = new List<List<int>>();
            List<List<int>> finResList = new List<List<int>>();
            resList.Add(new List<int>() { nums[0] });
            finResList.Add(new List<int>() { nums[0] });
            for (int i = 1; i < nums.Length; i++)
            {
                int newN = nums[i];
                int cs = resList.Count;
                for (int y = 0; y < cs; y++)
                {
                    List<int> cl = resList[y].ToList();
                    for (int z = 0; z < cl.Count; z++)
                    {
                        List<int> newList = cl.ToList();
                        newList.Insert(z, newN);
                        resList.Add(newList);
                        if (newList.Count == nums.Length)
                            finResList.Add(newList);
                    }
                    cl.Add(newN);
                    resList.Add(cl);
                    if (cl.Count == nums.Length)
                        finResList.Add(cl);
                }
            }

            for (int i = 0; i < finResList.Count; i++)
                Print.PrintList(finResList[i], true);

            return finResList;
        }
    }
}
