using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.Subsets
{
    public class Structurally_Unique_Binary_Search_Trees
    {
        int n;
        public Structurally_Unique_Binary_Search_Trees()
        {
            n = 4;
        }

        public List<TreeNode> findUniqueTrees(int n)
        {
            if (n <= 0)
                return new List<TreeNode>();

            return findList(1, n);
        }

        private List<TreeNode> findList(int start, int end)
        {
            List<TreeNode> result = new List<TreeNode>();
            if (start > end)
            {
                result.Add(null);
                return result;
            }

            for (int i = start; i <= end; i++)
            {

                List<TreeNode> leftSubTree = findList(start, i - 1);
                List<TreeNode> rightSubTree = findList(i + 1, end);
                foreach (TreeNode leftTree in leftSubTree)
                {
                    foreach (TreeNode rightTree in rightSubTree)
                    {
                        TreeNode root = new TreeNode(i);
                        root.left = leftTree;
                        root.right = rightTree;
                        result.Add(root);
                    }
                }

            }
            return result;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.val = val;
        }
    }
}
