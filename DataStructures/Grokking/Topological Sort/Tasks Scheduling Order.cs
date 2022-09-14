using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.TopologicalSort
{
    public class Tasks_Scheduling_Order
    {
        int tasks;
        int[][] prerequisites;
        public Tasks_Scheduling_Order()
        {
            tasks = 6;
            prerequisites = new int[6][];
            //[2, 5], [0, 5], [0, 4], [1, 4], [3, 2], [1, 3]
            prerequisites[0] = new int[] { 2, 5 };
            prerequisites[1] = new int[] { 0, 5 };
            prerequisites[2] = new int[] { 0, 4 };
            prerequisites[3] = new int[] { 1, 4 };
            prerequisites[4] = new int[] { 3, 2 };
            prerequisites[5] = new int[] { 1, 3 };
        }

        public List<int> isSchedulingPossible()
        {
            //construct Graph by dict
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int from = prerequisites[i][1];
                int to = prerequisites[i][0];
                if (!dict.ContainsKey(from))
                    dict.Add(from, new List<int>());
                dict[from].Add(to);
            }
            HashSet<int> recHash = new HashSet<int>();
            List<int> resList = new List<int>();
            HashSet<int> visited = new HashSet<int>();
            for (int i = 0; i < tasks; i++)
            {
                if (!topologicalSortUtil(i, dict, recHash, resList, visited))
                    return new List<int>();
            }
            return resList;
        }

        private bool topologicalSortUtil(int i, Dictionary<int, List<int>> dict, HashSet<int> recHash, List<int> resList, HashSet<int> visited)
        {
            if (recHash.Contains(i))
                return false;
            if (visited.Contains(i))
                return true;
            recHash.Add(i);
            visited.Add(i);
            if (dict.ContainsKey(i))
            {
                for (int y = 0; y < dict[i].Count; y++)
                {
                    if (!topologicalSortUtil(dict[i][y], dict, recHash, resList, visited))
                        return false;
                }
            }
            resList.Add(i);
            recHash.Remove(i);
            return true;
        }
    }
}