﻿using System;
using System.Collections.Generic;

namespace DataStructures
{
    internal class Graph
    {
        internal GraphNode[] nodes;
        internal Graph() { }
        internal void CreateSampleConnectedGraph(int nuOfNodes = 4)
        {
            nodes = new GraphNode[nuOfNodes];
            for (int i = 0; i < nodes.Length; i++)
                nodes[i] = new GraphNode((dynamic)i);

            nodes[0].children = new GraphNode[2];
            nodes[0].children[0] = nodes[1];
            nodes[0].children[1] = nodes[3];

            nodes[1].children = new GraphNode[2];
            nodes[1].children[0] = nodes[0];
            nodes[1].children[1] = nodes[2];

            nodes[2].children = new GraphNode[2];
            nodes[2].children[0] = nodes[1];
            nodes[2].children[1] = nodes[3];

            nodes[3].children = new GraphNode[2];
            nodes[3].children[0] = nodes[0];
            nodes[3].children[1] = nodes[2];
        }

        internal void SampleTree()
        {
            nodes = new GraphNode[7];
            for (int i = 0; i < nodes.Length; i++)
                nodes[i] = new GraphNode((dynamic)i);

            /*  
             *      0
             *     1 2
             *   3 4 5 6
             */
            nodes[0].children = new GraphNode[2];
            nodes[1].children = new GraphNode[2];
            nodes[2].children = new GraphNode[2];

            nodes[0].children[0] = nodes[1];
            nodes[0].children[1] = nodes[2];
            nodes[1].children[0] = nodes[3];
            nodes[1].children[1] = nodes[4];
            nodes[2].children[0] = nodes[5];
            nodes[2].children[1] = nodes[6];


        }

        internal void BFSSearchTwoQueues()
        {
            int level = 0;
            Queue<GraphNode> q, p;
            q = new Queue<GraphNode>();
            p = new Queue<GraphNode>();
            q.Enqueue(nodes[0]);
            while (q.Count() > 0)
            {
                //1.pop front
                GraphNode front = q.Dequeue();
                //2.check if goal
                Console.WriteLine(front.val);
                if (front.val == 6)
                {
                    Console.WriteLine(level);
                    return;
                }
                //3.push childrens
                if (front.children != null)
                    foreach (GraphNode child in front.children)
                        p.Enqueue(child);
                //4.check level is over
                if (q.Count() == 0)
                {
                    level++;
                    q = p;
                    p = new Queue<GraphNode>();
                }
            }
        }

        internal void printAllMainNodes()
        {
            Console.WriteLine("==============");
            for (int i = 0; i < nodes.Length; i++)
                Console.WriteLine(nodes[i].val);
            Console.WriteLine("==============");
        }

        internal void DFS()
        {
            Console.WriteLine("==============");
            foreach (var node in nodes)
            {
                if (!node.visited)
                    DFSearch(node);
            }
            Console.WriteLine("==============");
        }

        private void DFSearch(GraphNode node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.val);
            node.visited = true;
            if (node.children == null)
                return;
            foreach (var child in node.children)
            {
                if (!child.visited)
                    DFSearch(child);
            }
        }

        internal void BFSearch()
        {
            Console.WriteLine("==============");
            Queue<GraphNode> queue = new Queue<GraphNode>();
            queue.Enqueue(nodes[0]);
            while (queue.Count() > 0)
            {
                GraphNode cn = queue.Dequeue();
                Console.WriteLine(cn.val);
                cn.visited = true;
                if (cn.children != null)
                {
                    foreach (var child in cn.children)
                    {
                        if (!child.visited)
                            queue.Enqueue(child);
                    }
                }
            }
            Console.WriteLine("==============");
        }

        internal void DFS(GraphNode[] nodes)
        {
            if (nodes == null)
                return;
            //1.create visited
            HashSet<int> visited = new HashSet<int>();

            //2.loop through all root nodes
            //for (int i = 0; i < nodes.Length; i++)
            //    DFSUtil(nodes[i], visited);
        }

        bool isFounded;
        internal bool DFS(GraphNode[] nodes, int value)
        {
            if (nodes == null)
                return false;
            //1.create visited
            HashSet<int> visited = new HashSet<int>();

            //2.loop through all root nodes
            for (int i = 0; i < nodes.Length; i++)
            {
                if (!isFounded)
                    DFSUtil(nodes[i], visited, value);
            }
            return isFounded;
        }

        private void DFSUtil(GraphNode graphNode, HashSet<int> visited, int value)
        {
            //3.check visited
            if (visited.Contains(graphNode.val))
                return;
            //4.check goal
            visited.Add(graphNode.val);
            if (graphNode.val == value)
            {
                isFounded = true;
                return;
            }
            Console.WriteLine(graphNode.val);
            //5.check naighbours
            foreach (GraphNode node in graphNode.children)
                DFSUtil(node, visited, value);

        }
    }
}