using System;
using DataStructures.Tree;

namespace DataStructures.Grokking.BFS
{
    public class Connect_Level_Order_Siblings
    {
        TreeNode n1;
        public Connect_Level_Order_Siblings()
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

        public void ConnectLevelOrderSiblings()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                int cLevelSize = queue.Count();
                Console.WriteLine(cLevelSize);
                for (int i = 0; i < cLevelSize; i++)
                {
                    TreeNode cn = queue.Dequeue();
                    if (i < cLevelSize - 1)
                    {
                        Console.WriteLine(cn.val + "," + queue.Peek().val);
                        cn.next = queue.Peek();
                    }
                    if (cn.left != null)
                        queue.Enqueue(cn.left);
                    if (cn.right != null)
                        queue.Enqueue(cn.right);
                }
            }
        }
    }
}