using System;
using System.Collections.Generic;
using DataStructures.Tree;
using DataStructures.Utils;

namespace DataStructures.Grokking.DFS
{
    public class All_Paths_for_a_Sum
    {
        TreeNode n1;
        public All_Paths_for_a_Sum()
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


        public void findPaths()
        {
            List<List<int>> lists = new List<List<int>>();
            List<int> list = new List<int>();
            findPaths(n1, 10, list, lists);
            //Console.WriteLine(lists.Count);
        }

        public void findPaths(TreeNode node, int sum, List<int> cPath, List<List<int>> lists)
        {
            if (node == null)
                return;
            cPath.Add(node.val);
            if (sum == node.val && isLeaf(node))
                lists.Add(new List<int>(cPath));
            else
            {
                findPaths(node.left, sum - node.val, cPath, lists);
                findPaths(node.right, sum - node.val, cPath, lists);
            }
            cPath.RemoveAt(cPath.Count - 1);
        }

        private bool isLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}

