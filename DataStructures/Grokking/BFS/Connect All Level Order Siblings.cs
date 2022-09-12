using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.BFS
{
    public class Connect_All_Level_Order_Siblings
    {
        TreeNode n1;
        public Connect_All_Level_Order_Siblings()
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

        public void connect()
        {

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                TreeNode front = queue.Dequeue();
                if (front.left != null)
                    queue.Enqueue(front.left);
                if (front.right != null)
                    queue.Enqueue(front.right);
                if (queue.Count() > 0)
                {
                    Console.WriteLine(front.val + "," + queue.Peek().val);
                    front.next = queue.Peek();
                }
            }
        }

    }
}