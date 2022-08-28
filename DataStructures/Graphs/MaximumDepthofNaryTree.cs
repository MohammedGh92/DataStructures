using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class MaximumDepthofNaryTree
    {

        Node root;
        public MaximumDepthofNaryTree()
        {
            Node n2 = new Node(2);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n1 = new Node(1);
            Node n3 = new Node(3);
            n1.children = new List<Node>();
            n1.children.Add(n2);
            n1.children.Add(n3);
            n1.children.Add(n4);
            n3.children = new List<Node>();
            n3.children.Add(n5);
            n3.children.Add(n6);
            root = n1;
        }

        public int MaxDepth()
        {
            Queue<Node> q = new Queue<Node>();
            Queue<Node> p = new Queue<Node>();
            q.Enqueue(root);
            int level = 0;
            while (q.Count() > 0)
            {
                Node front = q.Dequeue();

                if (front.children != null)
                    foreach (Node child in front.children)
                        p.Enqueue(child);
                if (q.Count() == 0)
                {
                    q = p;
                    p = new Queue<Node>();
                    level++;
                }
            }

            return level;
        }

        class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
