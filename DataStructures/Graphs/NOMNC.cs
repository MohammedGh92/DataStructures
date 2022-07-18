using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class NOMNC
    {
        //Number of Operations to Make Network Connected
        int n;
        int[][] connections;
        public NOMNC()
        {
            //[[0,1],[0,2],[0,3],[1,2],[1,3]]
            n = 6;
            connections = new int[5][];
            connections[0] = new int[] { 0, 1 };
            connections[1] = new int[] { 0, 2 };
            connections[2] = new int[] { 0, 3 };
            connections[3] = new int[] { 1, 2 };
            connections[4] = new int[] { 1, 3 };
        }

        public int MakeConnected()
        {

            if (connections.Length < n - 1)
            {
                return -1;
            }

            Dictionary<int, List<int>> connectionsAsMap = BuildMapFromArray(connections);
            bool[] visited = new bool[n];
            int count = -1;

            for (int visitedIndex = 0; visitedIndex < n; visitedIndex++)
            {
                if (!visited[visitedIndex])
                {
                    DFS(visitedIndex, connectionsAsMap, visited);
                    count++;
                }
            }

            return count;
        }

        private void DFS(int source, Dictionary<int, List<int>> connectionsAsMap, bool[] visited)
        {

            visited[source] = true;

            List<int> connectionAdjacents = connectionsAsMap.ContainsKey(source) ? connectionsAsMap[source] : new List<int>();

            foreach (int connectionAdjacent in connectionAdjacents)
            {

                if (!visited[connectionAdjacent])
                {
                    DFS(connectionAdjacent, connectionsAsMap, visited);
                }
            }
        }

        private Dictionary<int, List<int>> BuildMapFromArray(int[][] connections)
        {

            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

            foreach (int[] connection in connections)
            {

                if (!result.ContainsKey(connection[0]))
                {
                    result.Add(connection[0], new List<int>());
                }

                if (!result.ContainsKey(connection[1]))
                {
                    result.Add(connection[1], new List<int>());
                }

                result[connection[0]].Add(connection[1]);
                result[connection[1]].Add(connection[0]);
            }

            return result;
        }
    }
}
