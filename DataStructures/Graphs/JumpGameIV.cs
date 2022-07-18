using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class JumpGameIV
    {
        int[] arr;
        public JumpGameIV()
        {
            arr = new int[] { 100, -23, -23, 404, 100, 23, 23, 23, 3, 404 };
        }

        public int MinJumps()
        {
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], new List<int>());
                dict[arr[i]].Add(i);
            }

            bool[] visited = new bool[arr.Length];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(0);
            int steps = 0;
            visited[0] = true;
            while (queue.Count() > 0)
            {
                int cQuCount = queue.Count();

                for (int i = 0; i < cQuCount; i++)
                {
                    int cp = queue.Dequeue();

                    if (cp == arr.Length - 1)
                        return steps;

                    int prev = cp - 1;
                    int next = cp + 1;
                    if (next < arr.Length && !visited[next])
                    {
                        queue.Enqueue(next);
                        visited[next] = true;
                    }
                    if (prev >= 0 && !visited[prev])
                    {
                        queue.Enqueue(prev);
                        visited[prev] = true;
                    }

                    if (dict.ContainsKey(arr[cp]))
                    {
                        List<int> cpList = dict[arr[cp]];
                        for (int y = 0; y < cpList.Count; y++)
                        {
                            if (!visited[cpList[y]])
                            {
                                queue.Enqueue(cpList[y]);
                                visited[y] = true;
                            }
                        }
                        dict.Remove(arr[cp]);
                    }
                }
                steps++;
            }
            return -1;
        }
    }
}
