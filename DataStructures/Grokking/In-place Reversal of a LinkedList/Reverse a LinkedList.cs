using System;
using DataStructures.LinkedList;

namespace DataStructures.Grokking.PatternInplaceReversalofaLinkedList
{
    public class Reverse_a_LinkedList
    {
        ListNode n1;
        public Reverse_a_LinkedList()
        {
            n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            ListNode n5 = new ListNode(5);
            ListNode n6 = new ListNode(6);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
        }

        public ListNode reverse()
        {

            ListNode prev = null;
            ListNode cn = n1;
            while (cn != null)
            {
                ListNode next = cn.next;
                cn.next = prev;
                prev = cn;
                cn = next;
            }

            return prev;
        }

    }
}
