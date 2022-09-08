using System;
using System.Collections.Generic;
using DataStructures.LinkedList;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Start_of_LinkedList_Cycle
    {
        ListNode n1;
        public Start_of_LinkedList_Cycle()
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
            n6.next = n3;
        }

        public ListNode startOfLinkedList()
        {

            ListNode sp = n1;
            ListNode fp = n1.next;

            //1.find cycle
            while (fp != null && fp.next != null)
            {
                if (sp == fp)
                    break;
                sp = sp.next;
                fp = fp.next.next;
            }

            if (fp == null || fp.next == null)
                return null;

            //2.get length of the cycle

            ListNode slowSavedP = new ListNode(0);
            slowSavedP.next = sp;
            sp = sp.next;
            int counter = 0;
            while (slowSavedP.next != sp)
            {
                sp = sp.next;
                counter++;
            }

            //3.Get start
            fp = n1.next;
            while (counter > 0)
            {
                fp = fp.next;
                counter--;
            }
            sp = n1;
            while (sp != fp)
            {
                sp = sp.next;
                fp = fp.next;
            }
            return sp;
        }

        public ListNode startOfLinkedListUsingHash()
        {

            HashSet<ListNode> hash = new HashSet<ListNode>();

            ListNode cp = n1;

            while (cp != null)
            {
                if (hash.Contains(cp))
                    return cp;
                else
                    hash.Add(cp);
                cp = cp.next;
            }

            return new ListNode(0);
        }
    }
}
