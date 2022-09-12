using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.DFS
{
    public class Sum_of_Path_Numbers
    {
        TreeNode n1;
        public Sum_of_Path_Numbers()
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

        public void findSumOfPathNumbers()
        {
            int totalSum = 0;
            findSumOfPathNumbers(n1, 0, totalSum);
        }

        private void findSumOfPathNumbers(TreeNode node, int cSum, int totalSum)
        {
            if (node == null)
                return;
            cSum = (10 * cSum) + node.val;
            if (isLeaf(node))
            {
                Console.WriteLine("cSum:" + cSum);
                totalSum += cSum;
            }
            else
            {
                findSumOfPathNumbers(node.left, cSum, totalSum);
                findSumOfPathNumbers(node.right, cSum, totalSum);
            }
            cSum -= node.val;
        }

        private bool isLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }

    }
}

