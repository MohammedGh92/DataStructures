using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.BFS
{
    public class Minimum_Depth_of_a_Binary_Tree
    {
        TreeNode n1;
        public Minimum_Depth_of_a_Binary_Tree()
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

        public int findDepth()
        {
            int res = -1;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                res++;
                int clevelSize = queue.Count();
                for (int i = 0; i < clevelSize; i++)
                {
                    TreeNode cn = queue.Dequeue();
                    if (isLeaf(cn))
                        return res;
                    if (cn.left != null)
                        queue.Enqueue(cn.left);
                    if (cn.right != null)
                        queue.Enqueue(cn.right);
                }
            }
            Console.WriteLine(res);
            return res;
        }

        private bool isLeaf(TreeNode treeNode)
        {
            return treeNode.left == null && treeNode.right == null;
        }

    }
}