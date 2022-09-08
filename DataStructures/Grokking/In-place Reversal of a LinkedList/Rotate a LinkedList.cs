using System;
using DataStructures.LinkedList;
using DataStructures.Utils;

namespace DataStructures.Grokking.PatternInplaceReversalofaLinkedList
{
    public class Rotate_a_LinkedList
    {
        ListNode n1;
        int k;
        public Rotate_a_LinkedList()
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
            k = 2;
        }

        public ListNode rotate()
        {
            ListNode cn = n1;
            ListNode prev = null;
            while (k > 0)
            {
                prev = cn;
                cn = cn.next;
                k--;
                if (cn == null)
                    cn = n1;
            }
            ListNode dummyNode = new ListNode(0);
            dummyNode.next = cn;
            prev.next = null;
            while (cn.next != null)
                cn = cn.next;
            cn.next = n1;
            Print.printLinkedList(dummyNode.next);
            return dummyNode.next;
        }
    }
}
