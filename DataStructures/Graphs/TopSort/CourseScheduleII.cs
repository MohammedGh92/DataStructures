using System;
using System.Collections.Generic;

namespace DataStructures.Graphs.TopSort
{
    public class CourseScheduleII
    {
        int n;
        int[][] prerequisites;

        public CourseScheduleII()
        {
            n = 2;
            prerequisites = new int[2][];
            prerequisites[0] = new int[] { 1, 0 };
            prerequisites[1] = new int[] { 0, 1 };
        }

        public int[] solution()
        {
            HashSet<int> recHash = new HashSet<int>();
            Stack<int> stack = new Stack<int>();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            HashSet<int> visited = new HashSet<int>();

            //build graph
            for (int i = 0; i < prerequisites.Length; i++)
            {
                int from = prerequisites[i][1];
                int to = prerequisites[i][0];
                if (!dict.ContainsKey(from))
                    dict.Add(from, new List<int>());
                dict[from].Add(to);
            }

            //loop nodes, check visited
            for (int i = 0; i < n; i++)
                if (!visited.Contains(i))//4.recursion
                {
                    if (!dfsUtil(i, dict, visited, recHash, stack))
                        return new int[0];
                }

            //pop stack
            List<int> res = new List<int>();
            while (stack.Count() > 0)
                res.Add(stack.Pop());
            return res.ToArray();
        }

        private bool dfsUtil(int key, Dictionary<int, List<int>> dict, HashSet<int> visited, HashSet<int> recHash, Stack<int> stack)
        {
            if (recHash.Contains(key))
                return false;
            if (visited.Contains(key))
                return true;
            recHash.Add(key);
            visited.Add(key);
            if (dict.ContainsKey(key))//5.check naighbours
                foreach (int num in dict[key])
                    if (!dfsUtil(num, dict, visited, recHash, stack))
                        return false;
            //6.push stack
            recHash.Remove(key);
            stack.Push(key);
            return true;
        }
    }
}
