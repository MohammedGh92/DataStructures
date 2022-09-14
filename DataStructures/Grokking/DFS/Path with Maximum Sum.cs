using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.DFS
{
    public class Path_with_Maximum_Sum
    {
        TreeNode n1;
        public Path_with_Maximum_Sum()
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

        private int maxSum = 0;
        public void findMaximumPathSum()
        {
            findMaximumPathSum(n1);
            Console.WriteLine(maxSum);
        }

        private int findMaximumPathSum(TreeNode node)
        {
            if (node == null)
                return 0;
            int maxPathSumFromLeft = findMaximumPathSum(node.left);
            int maxPathSumFromRight = findMaximumPathSum(node.right);
            maxPathSumFromLeft = Math.Max(maxPathSumFromLeft, 0);
            maxPathSumFromRight = Math.Max(maxPathSumFromRight, 0);
            int localMaxSum = maxPathSumFromLeft + maxPathSumFromRight + node.val;
            maxSum = Math.Max(maxSum, localMaxSum);
            return Math.Max(maxPathSumFromLeft, maxPathSumFromRight) + node.val;
        }
    }
}