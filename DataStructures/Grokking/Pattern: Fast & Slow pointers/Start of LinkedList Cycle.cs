using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Start_of_LinkedList_Cycle
    {
        Node<int> n1;
        public Start_of_LinkedList_Cycle()
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

        public Node<int> startOfLinkedList()
        {

            Node<int> sp = n1;
            Node<int> fp = n1.next;

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

            Node<int> slowSavedP = new Node<int>(0);
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

        public Node<int> startOfLinkedListUsingHash()
        {

            HashSet<Node<int>> hash = new HashSet<Node<int>>();

            Node<int> cp = n1;

            while (cp != null)
            {
                if (hash.Contains(cp))
                    return cp;
                else
                    hash.Add(cp);
                cp = cp.next;
            }

            return new Node<int>(0);
        }
    }
}
