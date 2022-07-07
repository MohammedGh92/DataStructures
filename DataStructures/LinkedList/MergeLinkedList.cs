using System;
namespace DataStructures.LinkedList
{
    public class MergeLinkedList
    {
        public static Node<int> mergeTwoSortedLinkedLists(Node<int> l1n, Node<int> l2n)
        {

            if (l1n == null && l2n == null)
                return null;
            if (l1n == null)
                return l2n;
            if (l2n == null)
                return l1n;

            Node<int> head = new Node<int>(0);
            Node<int> cn = head;

            while (l1n != null && l2n != null)
            {

                if (l1n.val < l2n.val)
                {
                    cn.next = l1n;
                    l1n = l1n.next;
                }
                else
                {
                    cn.next = l2n;
                    l2n = l2n.next;
                }
                cn = cn.next;
            }

            while (l1n != null)
            {
                cn.next = l1n;
                l1n = l1n.next;
                cn = cn.next;
            }

            while (l2n != null)
            {
                cn.next = l2n;
                l2n = l2n.next;
                cn = cn.next;
            }
            return head.next;
        }

        static int lowestNode;
        static Node<int> mergeTwoSortedLinkedLists(LinkedList<int>[] linkedLists)
        {

            if (linkedLists == null || linkedLists.Length == 0)
                return null;

            Node<int>[] pointers = new Node<int>[linkedLists.Length];

            for (int i = 0; i < linkedLists.Length; i++)
                pointers[i] = linkedLists[i].head;
            Node<int> head = new Node<int>(0);
            Node<int> cn = head;
            while (getLowestNode(pointers) != -1)
            {
                cn.next = pointers[lowestNode];
                pointers[lowestNode] = pointers[lowestNode].next;
                cn = cn.next;
            }
            return head.next;
        }

        static int getLowestNode(Node<int>[] linkedLists)
        {
            int res = -1;
            for (int i = 0; i < linkedLists.Length; i++)
            {
                if ((res == -1 || linkedLists[res] == null) && linkedLists[i] != null)
                    res = i;
                if (linkedLists[i] != null && linkedLists[i].val < linkedLists[res].val)
                    res = i;
            }
            lowestNode = res;
            return res;
        }
    }
}
