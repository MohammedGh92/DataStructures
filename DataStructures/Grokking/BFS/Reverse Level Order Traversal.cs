using System;
using System.Collections.Generic;
using DataStructures.Tree;
using DataStructures.Utils;

namespace DataStructures.Grokking.BFS
{
    public class Reverse_Level_Order_Traversal
    {
        TreeNode n1;
        public Reverse_Level_Order_Traversal()
        {
            n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n3.left = n6;
            n3.right = n7;
        }

        public void reverseTraversal()
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            Queue<TreeNode> p = new Queue<TreeNode>();
            List<List<int>> lists = new List<List<int>>();
            q.Enqueue(n1);
            List<int> cList = new List<int>();
            while (q.Count() > 0)
            {
                TreeNode front = q.Dequeue();
                cList.Add(front.val);
                if (front.left != null)
                    p.Enqueue(front.left);
                if (front.right != null)
                    p.Enqueue(front.right);

                if (q.Count() == 0)
                {
                    q = p;
                    p = new Queue<TreeNode>();
                    lists.Insert(0, cList);
                    cList = new List<int>();
                }
            }

            for (int i = 0; i < lists.Count; i++)
                Print.PrintList(lists[i]);
        }

        public void reverseTraversalOpt()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<List<int>> lists = new List<List<int>>();
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                int levelSize = queue.Count();
                List<int> cList = new List<int>(levelSize);
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode cNode = queue.Dequeue();
                    cList.Add(cNode.val);
                    if (cNode.left != null)
                        queue.Enqueue(cNode.left);
                    if (cNode.right != null)
                        queue.Enqueue(cNode.right);
                }
                lists.Insert(0, cList);
            }

            for (int i = 0; i < lists.Count; i++)
                Print.PrintList(lists[i]);
        }
    }
}

