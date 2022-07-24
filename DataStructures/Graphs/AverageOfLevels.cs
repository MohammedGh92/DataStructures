using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class AverageOfLevels
    {
        TreeNode root;
        public AverageOfLevels()
        {
            TreeNode n7 = new TreeNode(7);
            TreeNode n15 = new TreeNode(15);
            TreeNode n20 = new TreeNode(20, n15, n7);
            TreeNode n9 = new TreeNode(9);
            TreeNode n3 = new TreeNode(3, n9, n20);
            root = n3;
        }

        public IList<double> GetAverageOfLevels()
        {
            IList<double> resList = new List<double>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            Queue<TreeNode> p = new Queue<TreeNode>();
            q.Enqueue(root);
            double cCount = 0;
            int levelNodesCounter = 0;
            while (q.Count() > 0)
            {
                //1.pop front
                TreeNode front = q.Dequeue();
                Console.WriteLine("front:" + front);
                //2.node
                cCount += front.val;
                levelNodesCounter++;
                //3.check neighbours
                if (front.left != null)
                    p.Enqueue(front.left);
                if (front.right != null)
                    p.Enqueue(front.right);
                //4.check level
                if (q.Count() == 0)
                {
                    q = p;
                    p = new Queue<TreeNode>();
                    resList.Add(cCount / levelNodesCounter);
                    cCount = 0;
                    levelNodesCounter = 0;
                }
            }
            for (int i = 0; i < resList.Count; i++)
                Console.WriteLine(resList[i]);
            return resList;
        }

        class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
