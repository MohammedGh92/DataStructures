﻿using System;
using DataStructures.Tree;

namespace DataStructures
{
    public class TreeO
    {
        public TreeNode root;

        public void printAllData(Traversing traverseType = Traversing.InOrder)
        {
            Console.WriteLine(traverseType);
            traverseNodes(root, traverseType);
        }

        public void Insert(int data)
        {
            if (root == null)
                root = new TreeNode(data);
            else
                root.insert(data);
        }

        private void traverseNodes(TreeNode node, Traversing traverseType)
        {
            if (node == null)
                return;
            if (traverseType == Traversing.PreOrder)
            {
                Console.WriteLine(node.val);
                traverseNodes(node.left, traverseType);
                traverseNodes(node.right, traverseType);
            }
            else if (traverseType == Traversing.InOrder)
            {
                traverseNodes(node.left, traverseType);
                Console.WriteLine(node.val);
                traverseNodes(node.right, traverseType);
            }
            else
            {
                traverseNodes(node.left, traverseType);
                traverseNodes(node.right, traverseType);
                Console.WriteLine(node.val);
            }

        }
    }
}
