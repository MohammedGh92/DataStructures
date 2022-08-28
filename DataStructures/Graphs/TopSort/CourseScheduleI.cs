using System;
using System.Collections.Generic;

namespace DataStructures.Graphs.TopSort
{
    public class CourseScheduleI
    {
        int n;
        int[][] prerequisites;

        public CourseScheduleI()
        {
            n = 2;
            prerequisites = new int[2][];
            prerequisites[0] = new int[] { 1, 0 };
            prerequisites[1] = new int[] { 0, 1 };
        }

        public bool solution()
        {
            HashSet<int> recHash = new HashSet<int>();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int from = prerequisites[i][1];
                int to = prerequisites[i][0];
                if (!dict.ContainsKey(from))
                    dict.Add(from, new List<int>());
                dict[from].Add(to);
            }
            //2.visited
            HashSet<int> visited = new HashSet<int>();
            //3.loop nodes, check visited
            for (int i = 0; i < n; i++)
                if (!visited.Contains(i))//4.recursion
                {
                    if (!dfsUtil(i, dict, visited, recHash))
                        return false;
                }
            return true;
        }

        private bool dfsUtil(int key, Dictionary<int, List<int>> dict, HashSet<int> visited, HashSet<int> recHash)
        {
            if (recHash.Contains(key))
                return false;
            if (visited.Contains(key))
                return true;
            recHash.Add(key);
            visited.Add(key);
            if (dict.ContainsKey(key))//5.check naighbours
                foreach (int num in dict[key])
                    dfsUtil(num, dict, visited, recHash);
            //6.push stack
            recHash.Remove(key);
            return true;
        }
    }
}
