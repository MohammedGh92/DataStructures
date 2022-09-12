using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.BFS
{
    public class Level_Order_Successor
    {
        TreeNode n1;
        int key;
        public Level_Order_Successor()
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
            key = 3;
        }

        public TreeNode findSuccessor()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                TreeNode treeNode = queue.Dequeue();
                if (treeNode.val == key)
                    break;
                if (treeNode.left != null)
                    queue.Enqueue(treeNode.left);
                if (treeNode.right != null)
                    queue.Enqueue(treeNode.right);
            }
            return queue.Peek();
        }
    }
}