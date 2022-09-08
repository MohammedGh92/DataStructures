using System;
using System.Collections.Generic;
using DataStructures.LinkedList;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class LinkedList_Cycle
    {
        ListNode n1;
        public LinkedList_Cycle()
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

        public bool haveACylce()
        {
            ListNode slow = n1;
            ListNode fast = slow.next;
            while (fast != null && fast.next != null)
            {
                if (slow == fast)
                    return true;
                slow = slow.next;
                fast = fast.next.next;
            }

            return false;
        }

        public bool haveACylceUsingHash()
        {
            HashSet<ListNode> hash = new HashSet<ListNode>();
            ListNode cp = n1;

            while (cp != null)
            {
                Console.WriteLine(cp.val);
                if (hash.Contains(cp))
                    return true;
                else
                    hash.Add(cp);
                cp = cp.next;
            }

            return false;
        }
    }
}
