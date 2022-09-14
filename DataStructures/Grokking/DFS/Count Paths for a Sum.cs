using System;
using System.Collections.Generic;
using DataStructures.Tree;
using DataStructures.Utils;

namespace DataStructures.Grokking.DFS
{
    public class Count_Paths_for_a_Sum
    {
        TreeNode n1;
        int S;
        public Count_Paths_for_a_Sum()
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
            S = 10;
        }

        public void countPaths()
        {
            List<int> list = new List<int>();
            Console.WriteLine(countPaths(n1, list, S));
        }

        private int countPaths(TreeNode n1, List<int> list, int S)
        {
            if (n1 == null)
                return 0;
            list.Add(n1.val);
            int pathCount = 0;
            int pathSum = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                pathSum += list[i];
                if (pathSum == S)
                {
                    Print.PrintList(list);
                    pathCount++;
                }
            }
            pathCount += countPaths(n1.left, list, S);
            pathCount += countPaths(n1.right, list, S);
            list.RemoveAt(list.Count - 1);
            return pathCount;
        }
    }
}

