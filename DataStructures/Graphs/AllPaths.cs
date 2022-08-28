using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class AllPaths
    {
        int[][] graph;
        public AllPaths()
        {
            //graph = [[4, 3, 1],[3,2,4],[3],[4],[]]
            graph = new int[5][];
            graph[0] = new int[] { 4, 3, 1 };
            graph[1] = new int[] { 3, 2, 4 };
            graph[2] = new int[] { 3 };
            graph[3] = new int[] { 4 };
            graph[4] = new int[] { };
        }
        IList<IList<int>> resList;
        public IList<IList<int>> AllPathsSourceTarget()
        {
            resList = new List<IList<int>>();
            for (int i = 0; i < graph[0].Length; i++)
                dfs(graph[0][i], "0");
            return resList;
        }

        private void dfs(int curNode, string curPath)
        {
            curPath += "," + curNode;
            if (curNode == graph.Length - 1)
            {

                string[] curPathStr = curPath.Split(',');
                List<int> newList = new List<int>();
                for (int i = 0; i < curPathStr.Length; i++)
                    newList.Add(int.Parse(curPathStr[i]));
                resList.Add(newList);
            }
            else
            {
                for (int i = 0; i < graph[curNode].Length; i++)
                    dfs(graph[curNode][i], curPath);
            }
        }
    }
}
