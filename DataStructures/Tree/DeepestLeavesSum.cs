using System;
namespace DataStructures.Tree
{
    public class DeepestLeavesSum
    {
        TreeNode root;
        public DeepestLeavesSum()
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

        int deepestLevel, fSum;
        public int deeDeepestLeavesSum()
        {
            deepestLevel = -1;
            fSum = 0;
            dfs(root, 0);
            return fSum;
        }

        private void dfs(TreeNode node, int level)
        {
            if (node == null)
                return;
            if (level > deepestLevel)
            {
                deepestLevel = level;
                fSum = node.val;
            }
            else if (level == deepestLevel)
            {
                fSum += node.val;
            }
            dfs(node.left, level + 1);
            dfs(node.right, level + 1);
        }
    }
}
