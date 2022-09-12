using System;
using DataStructures.List;

namespace DataStructures.Grokking.PatternInplaceReversalofaLinkedList
{
    public class Reverse_a_Sub_list
    {

        ListNode n1;
        int p;
        int q;
        public Reverse_a_Sub_list()
        {
            n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            ListNode n5 = new ListNode(5);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            p = 2;
            q = 4;
        }

        public ListNode reverseOptimalSol()
        {
            if (p == q)
                return n1;
            ListNode current = n1;
            ListNode prev = null;
            for (int i = 0; current != null && i < p - 1; i++)
            {
                prev = current;
                current = current.next;
            }
            ListNode lastOfPartOne = prev;
            ListNode lastOfSubList = current;
            ListNode next;
            for (int i = 0; current != null && i < q - p + 1; i++)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            if (lastOfPartOne != null)
                lastOfPartOne.next = prev;
            else
                n1 = prev;
            lastOfSubList.next = current;
            while (n1 != null)
            {
                Console.WriteLine(n1.val);
                n1 = n1.next;
            }
            return n1;
        }

        public void reverse()
        {
            //1.find start of sub list
            int cc = 1;
            ListNode startP = n1;
            ListNode prev = n1;
            startP = startP.next;
            while (cc < p - 1)
            {
                cc++;
                prev = startP;
                startP = startP.next;
            }
            //2.preserve the head before the sub list and preserve the start node of sub list
            Tuple<ListNode, ListNode> reversedNode = Reversethis(startP, q - p);
            ListNode headSubList = reversedNode.Item1;
            prev.next = headSubList;
            while (headSubList.next != null)
            {
                headSubList = headSubList.next;
            }
            headSubList.next = reversedNode.Item2;
            //4.set the preserved head next to the head of reversed

            while (n1 != null)
            {
                Console.WriteLine(n1.val);
                n1 = n1.next;
            }
        }

        private Tuple<ListNode, ListNode> Reversethis(ListNode head, int endPoint)
        {
            ListNode prev = null;
            int cc = 0;
            while (head != null && cc <= endPoint)
            {
                ListNode next = head.next;
                head.next = prev;
                prev = head;
                head = next;
                cc++;
                if (cc > endPoint)
                    return new Tuple<ListNode, ListNode>(prev, head);
            }
            return null;
        }
    }
}
