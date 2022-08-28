using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class FindCenter
    {
        int[][] edges;
        public FindCenter()
        {
            //edges = [[1, 2],[2,3],[4,2]]
            edges = new int[3][];
            edges[0] = new int[] { 1, 2 };
            edges[1] = new int[] { 2, 3 };
            edges[2] = new int[] { 4, 2 };
        }

        public int FindTheCenter()
        {

            if (edges[0][0] == edges[1][0])
                return edges[0][0];
            if (edges[0][0] == edges[1][1])
                return edges[0][0];
            if (edges[0][1] == edges[1][0])
                return edges[0][1];
            if (edges[0][1] == edges[1][1])
                return edges[0][1];
            return 0;
        }
    }
}
