using System;
using DataStructures.List;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Middle_of_the_LinkedList
    {
        ListNode n1;
        public Middle_of_the_LinkedList()
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

        public ListNode getMid()
        {

            ListNode sp = n1;
            ListNode fp = n1.next;

            while (fp != null && fp.next != null)
            {
                sp = sp.next;
                fp = fp.next.next;
            }

            return sp;
        }

    }
}
