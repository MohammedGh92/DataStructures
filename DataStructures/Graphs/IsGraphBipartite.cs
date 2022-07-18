using System;
namespace DataStructures.Graphs
{
    public class IsGraphBipartite
    {
        int[][] graph;
        public IsGraphBipartite()
        {
            //graph = [[1, 3],[0,2],[1,3],[0,2]]
            graph = new int[4][];
            graph[0] = new int[] { 1, 3 };
            graph[1] = new int[] { 0, 2 };
            graph[2] = new int[] { 1, 3 };
            graph[3] = new int[] { 0, 2 };
        }

        public bool isGraphBipartite()
        {

            int[] colors = new int[graph.Length];

            for (int i = 0; i < graph.Length; i++)
                if (colors[i] == 0 && !isValidColor(graph, colors, 1, i))
                    return false;
            return true;
        }

        private bool isValidColor(int[][] graph, int[] colors, int color, int nodeNu)
        {

            if (colors[nodeNu] != 0)
                return colors[nodeNu] == color;

            colors[nodeNu] = color;

            for (int i = 0; i < graph[nodeNu].Length; i++)
                if (!isValidColor(graph, colors, -color, graph[nodeNu][i]))
                    return false;
            return true;

        }
    }
}
