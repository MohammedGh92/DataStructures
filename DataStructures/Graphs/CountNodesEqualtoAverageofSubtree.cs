using System;
using DataStructures.Tree;

namespace DataStructures.Graphs
{
    public class CountNodesEqualtoAverageofSubtree
    {
        TreeNode root;
        public CountNodesEqualtoAverageofSubtree()
        {
            TreeNode root = new TreeNode(4);
            TreeNode n8 = new TreeNode(8);
            TreeNode n0 = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            root.left = n8;
            root.right = n5;
            n8.left = n0;
            n8.right = n1;
            n5.right = n6;
        }

        int res;
        public int AverageOfSubtree()
        {

            DFS(root);

            return res;
        }

        private void DFS(TreeNode root)
        {
            //2.loop through all root nodes
            DFSUtil(root);


        }

        private int DFSUtil(TreeNode node)
        {
            if (node == null)
                return 0;
            //4.check goal
            //4.1 is leaf
            if (node.left == null && node.right == null)
            {
                res++;
                return node.val;
            }
            else
            {
                //4.2 return its value == average
                return node.val + DFSUtil(node.left) + DFSUtil(node.right);
            }
        }
    }
}
