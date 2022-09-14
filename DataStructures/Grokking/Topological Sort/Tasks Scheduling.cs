using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.TopologicalSort
{
    public class Tasks_Scheduling
    {

        int tasks;
        int[][] prerequisites;
        public Tasks_Scheduling()
        {
            tasks = 3;
            prerequisites = new int[2][];
            prerequisites[0] = new int[] { 0, 1 };
            prerequisites[1] = new int[] { 1, 0 };
            //prerequisites[2] = new int[] { 2, 3 };
        }

        public bool isSchedulingPossible()
        {
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
            HashSet<int> visited = new HashSet<int>();
            for (int i = 0; i < tasks; i++)
            {
                if (visited.Contains(i))
                    continue;
                if (!isSchedulingPossibleUtil(i, recHash, dict, visited))
                    return false;
            }
            return true;
        }

        private bool isSchedulingPossibleUtil(int i, HashSet<int> recHash, Dictionary<int, List<int>> dict, HashSet<int> visited)
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
                    if (!isSchedulingPossibleUtil(dict[i][y], recHash, dict, visited))
                        return false;
            }
            recHash.Remove(i);
            return true;
        }
    }
}