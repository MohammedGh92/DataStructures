using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class MinimumNumberofVertices
    {
        int n;
        int[][] edges;
        public MinimumNumberofVertices()
        {
            n = 6;
            edges = new int[6][];
            edges[0] = new int[] { 0, 1 };
            edges[1] = new int[] { 0, 2 };
            edges[2] = new int[] { 2, 5 };
            edges[3] = new int[] { 3, 4 };
            edges[4] = new int[] { 4, 2 };
            edges[5] = new int[] { 3, 0 };
        }


        public List<int> FindSmallestSetOfVertices()
        {
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < n; i++)
                hash.Add(i);

            foreach (var edge in edges)
            {
                hash.Remove(edge[1]);
            }

            return hash.ToList();
        }
    }
}
