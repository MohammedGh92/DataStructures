using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class LinkedList_Cycle
    {
        Node<int> n1;
        public LinkedList_Cycle()
        {
            n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            Node<int> n4 = new Node<int>(4);
            Node<int> n5 = new Node<int>(5);
            Node<int> n6 = new Node<int>(6);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;
            n5.next = n6;
            n6.next = n3;
        }

        public bool haveACylce()
        {
            Node<int> slow = n1;
            Node<int> fast = slow.next;
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

            HashSet<Node<int>> hash = new HashSet<Node<int>>();
            Node<int> cp = n1;

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
