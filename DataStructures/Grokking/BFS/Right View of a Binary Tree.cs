using System;
using System.Collections.Generic;
using DataStructures.Tree;

namespace DataStructures.Grokking.BFS
{
    public class Right_View_of_a_Binary_Tree
    {
        TreeNode n1;
        public Right_View_of_a_Binary_Tree()
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

        public List<TreeNode> traverse()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<TreeNode> list = new List<TreeNode>();
            if (n1 == null)
                return list;
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                int cLevelSize = queue.Count();
                for (int i = 0; i < cLevelSize; i++)
                {
                    TreeNode front = queue.Dequeue();
                    if (i == cLevelSize - 1)
                        list.Add(front);
                    if (front.left != null)
                        queue.Enqueue(front.left);
                    if (front.right != null)
                        queue.Enqueue(front.right);
                }
            }

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i].val);

            return list;
        }

    }
}

