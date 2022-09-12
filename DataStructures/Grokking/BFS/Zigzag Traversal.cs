using System;
using System.Collections.Generic;
using DataStructures.Tree;
using DataStructures.Utils;

namespace DataStructures.Grokking.BFS
{
    public class Zigzag_Traversal
    {
        TreeNode n1;
        public Zigzag_Traversal()
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

        public void traverse()
        {

            Queue<TreeNode> queue = new Queue<TreeNode>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            queue.Enqueue(n1);

            while (queue.Count() > 0)
            {
                TreeNode back = queue.Dequeue();
                Console.WriteLine(back.val);
                if (back.right != null)
                {
                    Console.WriteLine(back.right.val);
                    stack.Push(back.right);
                }
                if (back.left != null)
                {
                    Console.WriteLine(back.left.val);
                    stack.Push(back.left);
                }
                if (queue.Count() == 0)
                {
                    while (stack.Count() > 0)
                    {
                        TreeNode front = stack.Pop();

                        if (front.left != null)
                            queue.Enqueue(front.left);
                        if (front.right != null)
                            queue.Enqueue(front.right);
                    }
                }
            }
        }

        public void traverseOpt()
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            List<List<int>> lists = new List<List<int>>();
            bool leftToRight = true;
            queue.Enqueue(n1);
            while (queue.Count() > 0)
            {
                int levelSize = queue.Count();
                List<int> cList = new List<int>(levelSize);
                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode cNode = queue.Dequeue();
                    cList.Add(cNode.val);
                    if (cNode.left != null)
                        queue.Enqueue(cNode.left);
                    if (cNode.right != null)
                        queue.Enqueue(cNode.right);
                }
                if (!leftToRight)
                    cList.Reverse();
                lists.Add(cList);
                leftToRight = !leftToRight;
            }

            for (int i = 0; i < lists.Count; i++)
                Print.PrintList(lists[i]);
        }

    }
}

