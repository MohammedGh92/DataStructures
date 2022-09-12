using System;
namespace DataStructures.Tree
{
    public class TreeNode
    {
        internal int val;
        internal TreeNode left, right,next;
        internal TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        internal bool isLeaf() { return left == null && right == null; }

        internal void insert(int val)
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
