using System;
using System.Collections.Generic;

namespace DataStructures.Graphs.TopSort
{
    public class CityAndRoads
    {
        int n;
        int[][] roads;
        public CityAndRoads()
        {
            n = 10;
            roads = new int[10][];
            roads[0] = new int[] { 7, 9 };
            roads[1] = new int[] { 1, 7 };
            roads[2] = new int[] { 1, 3 };
            roads[3] = new int[] { 3, 4 };
            roads[4] = new int[] { 4, 6 };
            roads[5] = new int[] { 2, 9 };
            roads[6] = new int[] { 9, 10 };
            roads[7] = new int[] { 3, 8 };
            roads[8] = new int[] { 3, 9 };
            roads[9] = new int[] { 5, 10 };
        }

        HashSet<int> visited;
        public void solution()
        {
            //1.visited
            visited = new HashSet<int>();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < roads.Length; i++)
            {
                int from = roads[i][0];
                int to = roads[i][1];
                if (!dict.ContainsKey(from))
                    dict.Add(from, new List<int>());
                dict[from].Add(to);

                if (!dict.ContainsKey(to))
                    dict.Add(to, new List<int>());
                dict[to].Add(from);
            }

            int counter = 0;
            //3.loop nodes, check visited
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                if (!visited.Contains(i))
                {
                    counter++;
                    if (dict.ContainsKey(i))
                        dfsUtil(i, dict);
                }
            }
            Console.WriteLine(counter - 1);
        }

        private void dfsUtil(int key, Dictionary<int, List<int>> dict)
        {
            visited.Add(key);
            for (int i = 0; i < dict[key].Count; i++)
            {
                if (!visited.Contains(dict[key][i]))
                    dfsUtil(dict[key][i], dict);
            }
        }
    }
}