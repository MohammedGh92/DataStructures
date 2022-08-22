using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.Kwaymerge
{
    public class Merge_K_Sorted_Lists
    {
        Node<int>[] linkedLists;
        public Merge_K_Sorted_Lists()
        {
            linkedLists = new Node<int>[3];

            Node<int> n1 = new Node<int>(2);
            n1.next = new Node<int>(6);
            n1.next.next = new Node<int>(8);

            Node<int> n2 = new Node<int>(3);
            n2.next = new Node<int>(6);
            n2.next.next = new Node<int>(7);

            Node<int> n3 = new Node<int>(1);
            n3.next = new Node<int>(3);
            n3.next.next = new Node<int>(4);

            linkedLists[0] = n1;
            linkedLists[1] = n2;
            linkedLists[2] = n3;
        }

        internal Node<int> merge()
        {
            Console.WriteLine("merge");
            Node<int>[] pointers = new Node<int>[linkedLists.Length];
            for (int i = 0; i < linkedLists.Length; i++)
                pointers[i] = linkedLists[i];
            Node<int> head = new Node<int>(0);
            Node<int> cn = head;
            while (getLowestNode(pointers) != -1)
            {
                cn.next = pointers[lowestNode];
                pointers[lowestNode] = pointers[lowestNode].next;
                cn = cn.next;
            }
            return head.next;
        }

        private int lowestNode = -1;
        private int getLowestNode(Node<int>[] pointers)
        {
            int res = -1;
            lowestNode = -1;
            for (int i = 0; i < pointers.Length; i++)
            {
                if (pointers[i] == null)
                    continue;
                if (res == -1)
                    res = i;
                else
                {
                    if (pointers[i].val < pointers[res].val)
                        res = i;
                }
            }
            lowestNode = res;
            return res;
        }
    }
}