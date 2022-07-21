using System;
using System.Collections.Generic;
using DataStructures.Tree;

namespace DataStructures.Graphs
{
    public class DeepestLeavesSum2
    {
        TreeNode root;
        public DeepestLeavesSum2()
        {
            //root = [1, 2, 3, 4, 5, null, 6, 7, null, null, null, null, 8]
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);
            TreeNode n8 = new TreeNode(8);
            n1.left = n2;
            n1.right = n3;
            n2.left = n4;
            n2.right = n5;
            n4.left = n7;
            n3.right = n6;
            n6.right = n8;

            root = n1;
        }

        int maxSum;
        int maxLevel;
        public int DeepestLeavesSum()
        {
            DFS(root);
            return maxSum;
        }

        public void DFS(TreeNode root)
        {
            maxLevel = int.MinValue;
            //1.create visited
            HashSet<int> visited = new HashSet<int>();
            //2.loop through all root nodes
            DFSUtil(root, visited, 0);

        }

        public void DFSUtil(TreeNode node, HashSet<int> visited, int level)
        {
            if (node == null)
                return;
            //3.check visited
            if (visited.Contains(node.val))
                return;
            //4.check goal
            if (level > maxLevel)
            {
                maxLevel = level;
                maxSum = node.val;
            }
            else if (level == maxLevel)
            {
                maxSum += node.val;
            }
            //5.check naighours
            DFSUtil(node.left, visited, level + 1);
            DFSUtil(node.right, visited, level + 1);
        }
    }
}
