using System;
using DataStructures.List;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Palindrome_LinkedList
    {
        ListNode head;
        public Palindrome_LinkedList()
        {
            ListNode n11 = new ListNode(1);
            ListNode n22 = new ListNode(2, n11);
            ListNode n2 = new ListNode(2, n22);
            head = new ListNode(1, n2);
        }

        public bool isPalindrome()
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null;

            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }
            Console.WriteLine(head.val + "," + prev.val);
            while (head != null && prev != null)
            {
                if (head.val != prev.val)
                    return false;
                head = head.next;
                prev = prev.next;
            }
            return true;
        }
    }
}
