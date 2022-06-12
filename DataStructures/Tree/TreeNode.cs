using System;
namespace DataStructures.Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public bool isLeaf() { return left == null && right == null; }

        public void insert(int val)
        {
            if (this.val > val)
            {
                if (left == null)
                    left = new TreeNode(val);
                else
                    left.insert(val);
            }
            else
            {
                if (right == null)
                    right = new TreeNode(val);
                else
                    right.insert(val);
            }
        }

    }
}
