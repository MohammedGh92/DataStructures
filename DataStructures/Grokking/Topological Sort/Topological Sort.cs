using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.TopologicalSort
{
    public class Topological_Sort
    {
        Graph graph;
        /*  
        *      1
        *     2 3
        *   4 5 6 7
        */
        public Topological_Sort()
        {
            graph = new Graph();
            graph.SampleTree();
        }

        public void topologicalSort()
        {
            //1.stack
            Stack<GraphNode> stack = new Stack<GraphNode>();
            //2.visited
            HashSet<int> visited = new HashSet<int>();
            //3.check nodes loop
            for (int i = 0; i < graph.nodes.Length; i++)
            {
                if (!visited.Contains(graph.nodes[i].val))
                    topologicalSortUtil(graph.nodes[i], stack, visited);
            }
            //7.pop from stack
            while (stack.Count()>0)
                Console.WriteLine(stack.Pop().val);
        }

        private void topologicalSortUtil(GraphNode graphNode, Stack<GraphNode> stack, HashSet<int> visited)
        {
            //4.check visited
            visited.Add(graphNode.val);
            //5.check choldren
            if (graphNode.children != null)
                foreach (GraphNode childNode in graphNode.children)
                    topologicalSortUtil(childNode, stack, visited);
            //6.push to stack
            stack.Push(graphNode);
        }
    }
}

