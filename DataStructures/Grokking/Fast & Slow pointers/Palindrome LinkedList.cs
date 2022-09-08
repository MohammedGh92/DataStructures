using System;
using DataStructures.LinkedList;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Palindrome_LinkedList
    {
        ListNode n1;
        public Palindrome_LinkedList()
        {
            n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n22 = new ListNode(2);
            ListNode n11 = new ListNode(1);
            n1.next = n2;
            n2.next = n3;
            n3.next = n22;
            n22.next = n11;
        }

        public bool isPalindrome()
        {
            //1.Find middle
            ListNode sp = n1;
            ListNode fp = n1.next;
            while (fp != null && fp.next != null)
            {
                sp = sp.next;
                fp = fp.next.next;
            }
            //2.Reverse from middle
            ListNode reveresedNode = reverse(sp);
            ListNode savedNode = new ListNode(0);
            savedNode.next = reveresedNode;
            //3.Check palindrome
            ListNode cp = n1;
            while (cp != null && reveresedNode != null)
            {
                if (reveresedNode.val != cp.val)
                    return false;
                reveresedNode = reveresedNode.next;
                cp = cp.next;
            }

            reveresedNode = reverse(savedNode.next.next);
            //4.Reverse middle again
            while (reveresedNode != null)
            {
                Console.WriteLine(reveresedNode.val);
                reveresedNode = reveresedNode.next;
            }
            sp.next = reveresedNode;
            //5.Return the result

            while (n1 != null)
            {
                Console.WriteLine(n1.val);
                n1 = n1.next;
            }

            return false;
        }

        private ListNode reverse(ListNode head)
        {
            ListNode prev = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }
}
