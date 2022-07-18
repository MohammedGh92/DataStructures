using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class CloneGraph
    {
        GraphNode startNode;
        public CloneGraph()
        {
            GraphNode n1 = new GraphNode(1);
            GraphNode n2 = new GraphNode(2);
            GraphNode n3 = new GraphNode(3);
            GraphNode n4 = new GraphNode(4);
            n1.children = new GraphNode[2];
            n2.children = new GraphNode[2];
            n3.children = new GraphNode[2];
            n4.children = new GraphNode[2];
            n1.children[0] = n2;
            n1.children[1] = n4;
            n2.children[0] = n1;
            n2.children[1] = n3;
            n3.children[0] = n2;
            n3.children[1] = n4;
            n4.children[0] = n1;
            n4.children[1] = n3;
            startNode = n1;
        }

        internal Node GetCloneTheGraph(Node node)
        {
            if (node == null) return null;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            Dictionary<int, Node> dict = new Dictionary<int, Node>();
            dict.Add(node.val, new Node(node.val));
            while (queue.Count() > 0)
            {
                Node cn = queue.Dequeue();
                for (int i = 0; i < cn.neighbors.Count; i++)
                {
                    Node cnNeighbour = cn.neighbors[i];
                    if (!dict.ContainsKey(cnNeighbour.val))
                    {
                        queue.Enqueue(cnNeighbour);
                        dict.Add(cnNeighbour.val, new Node(cnNeighbour.val));
                    }
                    dict[cn.val].neighbors.Add(dict[cnNeighbour.val]);
                }
            }
            return dict[node.val];
        }

        internal class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node()
            {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
    }

}
