using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.DFS
{
    public class Tree_Diameter
    {
        TreeNode n1;

        public Tree_Diameter()
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

        public void calculateHeight()
        {
            calculateHeight(n1);
            Console.WriteLine(treeDiameter);
        }

        private static int treeDiameter = 0;
        private int calculateHeight(TreeNode node)
        {
            if (node == null)
                return 0;
            int leftTreeHeight = calculateHeight(node.left);
            int rightTreeHeight = calculateHeight(node.right);
            if (leftTreeHeight != 0 && rightTreeHeight != 0)
            {
                int diameter = leftTreeHeight + rightTreeHeight + 1;
                treeDiameter = Math.Max(treeDiameter, diameter);
            }
            return Math.Max(leftTreeHeight, rightTreeHeight) + 1;
        }
    }
}