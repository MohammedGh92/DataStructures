using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.DFS
{
    public class Path_With_Given_Sequence
    {
        TreeNode n1;
        int[] sequence;
        public Path_With_Given_Sequence()
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
            sequence = new int[] { 1, 2, 5 };
        }

        public void findPath()
        {
            int curIndx = 0;
            Console.WriteLine(findPath(n1, curIndx, sequence));
        }

        private bool findPath(TreeNode node, int curIndx, int[] sequence)
        {
            if (node == null)
                return false;
            if (node.val != sequence[curIndx])
                return false;
            curIndx++;
            if (curIndx == sequence.Length)
                return true;
            return findPath(node.left, curIndx, sequence) || findPath(node.right, curIndx, sequence);
        }
    }
}

