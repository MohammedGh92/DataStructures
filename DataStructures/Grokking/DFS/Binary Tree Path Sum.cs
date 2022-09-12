using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.DFS
{
    public class Binary_Tree_Path_Sum
    {
        TreeNode n1;
        public Binary_Tree_Path_Sum()
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

        public void hasPath()
        {
            Console.WriteLine("hasPath(n1, 10):" + hasPath(n1, 10));
        }

        public bool hasPath(TreeNode node, int sum)
        {

            if (node == null)
                return false;

            sum -= node.val;

            if (sum == 0 && isLeaf(node))
                return true;

            if (sum >= 0)
                return hasPath(node.left, sum) || hasPath(node.right, sum);
            return false;
        }

        private bool isLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}

