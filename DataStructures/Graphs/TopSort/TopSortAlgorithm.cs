using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class TopSortAlgorithm
    {
        Graph graph;
        /*  
        *      1
        *     2 3
        *   4 5 6 7
        */
        public TopSortAlgorithm()
        {
            //1 3 7 6 2 5 4
            graph = new Graph();
            graph.SampleTree();
        }

        public void topologicalSort()
        {
            //1.stack
            Stack<int> stack = new Stack<int>();
            //2.visited
            HashSet<int> visited = new HashSet<int>();
            //3.loop nodes, check visited
            for (int i = 0; i < graph.nodes.Length; i++)
                if (!visited.Contains(i))//4.recursion
                    topologicalSortUtil(graph.nodes[i], visited, stack);



            //7.poping stack
            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        private void topologicalSortUtil(GraphNode node, HashSet<int> visited, Stack<int> stack)
        {
            visited.Add(node.val);
            if (node.children != null)//5.check naighbours
                foreach (GraphNode child in node.children)
                {
                    topologicalSortUtil(child, visited, stack);
                }
            //6.push stack
            stack.Push(node.val);
        }
    }
}
