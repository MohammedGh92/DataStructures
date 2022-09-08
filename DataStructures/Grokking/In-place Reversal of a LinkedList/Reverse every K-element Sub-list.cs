using System;
using DataStructures.LinkedList;
using DataStructures.Utils;

namespace DataStructures.Grokking.PatternInplaceReversalofaLinkedList
{
    public class Reverse_every_K_element_Sub_list
    {
        ListNode n1;
        int k;
        public Reverse_every_K_element_Sub_list()
        {
            n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            ListNode n5 = new ListNode(5);
            ListNode n6 = new ListNode(6);
            ListNode n7 = new ListNode(7);
            ListNode n8 = new ListNode(8);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n7;
            n7.next = n8;
            k = 3;
        }

        public ListNode reverse()
        {
            if (k <= 1 || n1 == null)
                return n1;
            ListNode current = n1;
            ListNode prev = null;
            while (true)
            {
                ListNode lastNodeOfPrevPart = prev;
                ListNode lastNodeOfSubList = current;
                ListNode next;
                ListNode cur = current;
                for (int i = 0; i < k; i++)
                {
                    cur = cur.next;
                    if (cur == null)
                    {
                        Print.printLinkedList(n1);
                        //lastNodeOfPrevPart.next = current;
                        return n1;
                    }
                }

                for (int i = 0; current != null && i < k; i++)
                {
                    next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }

                if (lastNodeOfPrevPart != null)
                    lastNodeOfPrevPart.next = prev;
                else
                    n1 = prev;

                lastNodeOfSubList.next = current;
                if (current == null)
                    break;
                prev = lastNodeOfSubList;

            }
            Print.printLinkedList(n1);
            return n1;
        }
    }
}