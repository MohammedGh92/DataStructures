using System;
namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Middle_of_the_LinkedList
    {
        Node<int> n1;
        public Middle_of_the_LinkedList()
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
        }

        public Node<int> getMid()
        {

            Node<int> sp = n1;
            Node<int> fp = n1.next;

            while (fp != null && fp.next != null)
            {
                sp = sp.next;
                fp = fp.next.next;
            }

            return sp;
        }

    }
}
