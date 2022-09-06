using System;
namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Palindrome_LinkedList
    {
        Node<int> n1;
        public Palindrome_LinkedList()
        {
            n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            Node<int> n22 = new Node<int>(2);
            Node<int> n11 = new Node<int>(1);
            n1.next = n2;
            n2.next = n3;
            n3.next = n22;
            n22.next = n11;
        }

        public bool isPalindrome()
        {
            //1.Find middle
            Node<int> sp = n1;
            Node<int> fp = n1.next;
            while (fp != null && fp.next != null)
            {
                sp = sp.next;
                fp = fp.next.next;
            }

            //2.Reverse from middle
            Node<int> reveresedNode = reverse(sp);

            //3.Check palindrome
            Node<int> cp = n1;
            while (cp != null && reveresedNode != null)
            {
                Console.WriteLine(reveresedNode.val + "," + cp.val);
                if (reveresedNode.val != cp.val)
                    return false;
                reveresedNode = reveresedNode.next;
                cp = cp.next;
            }

            //4.Reverse middle again



            //5.Return the result

            return false;
        }

        private Node<int> reverse(Node<int> head)
        {
            Node<int> prev = null;
            while (head != null)
            {
                Node<int> next = head.next;
                head.next = prev;
                prev = head;
                head = next;
            }
            return prev;
        }
    }
}
