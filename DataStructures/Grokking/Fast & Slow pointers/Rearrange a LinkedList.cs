using System;
using DataStructures.List;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Rearrange_a_LinkedList
    {
        ListNode n2;
        public Rearrange_a_LinkedList()
        {
            n2 = new ListNode(2);
            ListNode n4 = new ListNode(4);
            ListNode n6 = new ListNode(6);
            ListNode n8 = new ListNode(8);
            ListNode n10 = new ListNode(10);
            ListNode n12 = new ListNode(12);
            n2.next = n4;
            n4.next = n6;
            n6.next = n8;
            n8.next = n10;
            n10.next = n12;
        }

        public void reorder()
        {

            //1.reach middle
            ListNode slow = n2;
            ListNode fast = slow.next;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //2.reverse
            ListNode reversedNode = reverse(slow.next);

            //3.loop through first list
            ListNode sp = n2;

            while (sp != null && reversedNode != null)
            {
                //4.each time add node from list 2 as the next of the current node from the first one
                ListNode next = sp.next;
                sp.next = new ListNode(reversedNode.val);
                reversedNode = reversedNode.next;
                sp.next.next = next;
                sp = next;
            }
            ListNode sp1 = n2;
            while (sp1.next != null)
            {
                Console.WriteLine("sp1:" + sp1.val);
                sp1 = sp1.next;
            }

        }

        private ListNode reverse(ListNode slow)
        {
            ListNode prev = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }
            return prev;

        }
    }
}
