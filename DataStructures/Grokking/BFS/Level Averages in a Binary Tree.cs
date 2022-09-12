using System;
using System.Collections.Generic;
using DataStructures.Tree;
using DataStructures.Utils;

namespace DataStructures.Grokking.BFS
{
    public class Level_Averages_in_a_Binary_Tree
    {
        TreeNode n1;
        public Level_Averages_in_a_Binary_Tree()
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

        public void findLevelAverages()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<float> avgList = new List<float>();
            if (n1 == null)
                return;
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                int levelSize = queue.Count();
                float cSum = 0;
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode cn = queue.Dequeue();
                    cSum += cn.val;
                    if (cn.left != null)
                        queue.Enqueue(cn.left);
                    if (cn.right != null)
                        queue.Enqueue(cn.right);
                }
                avgList.Add(cSum / levelSize);
            }

            Print.PrintList(avgList);
        }
    }
}