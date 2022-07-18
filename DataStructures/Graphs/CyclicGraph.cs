using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class CyclicGraph
    {
        int[][] connections;
        public CyclicGraph()
        {
            connections = new int[5][];
            connections[0] = new int[] { 1 };
            connections[1] = new int[] { 2 };
            connections[2] = new int[] { 3, 4 };
            connections[3] = new int[] { 4 };
            connections[4] = new int[] { 0 };
        }

        public CyclicGraph(int[][] connections)
        {
            this.connections = connections;
        }

        public bool isCyclic()
        {
            bool[] visited = new bool[connections.Length];
            bool[] recStack = new bool[connections.Length];
            for (int i = 0; i < connections.Length; i++)
                if (isCyclicUtil(i, visited, recStack))
                    return true;
            return false;
        }

        private bool isCyclicUtil(int i, bool[] visited, bool[] recStack)
        {
            if (recStack[i])
                return true;
            if (visited[i])
                return false;
            visited[i] = true;
            recStack[i] = true;
            int[] children = connections[i];
            foreach (int c in children)
                if (isCyclicUtil(c, visited, recStack))
                    return true;
            recStack[i] = false;
            return false;
        }
    }
}