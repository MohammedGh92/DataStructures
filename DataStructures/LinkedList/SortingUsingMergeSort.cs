using System;
namespace DataStructures.LinkedList
{
    internal class SortingUsingMergeSort
    {
        internal static Node<int> getSorted(Node<int> head)
        {
            if (head == null || head.next == null)
                return head;
            Node<int> mid = getMid(head);
            Node<int> left = getSorted(head);
            Node<int> right = getSorted(mid);
            return merge(left, right);
        }

        private static Node<int> merge(Node<int> left, Node<int> right)
        {
            Node<int> dummyHead = new Node<int>(0);
            Node<int> cn = dummyHead;
            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    cn.next = left;
                    left = left.next;
                }
                else
                {
                    cn.next = right;
                    right = right.next;
                }
                cn = cn.next;
            }
            if (left == null)
                cn.next = right;
            else
                cn.next = left;
            return dummyHead.next;

        }

        private static Node<int> getMid(Node<int> head)
        {
            Node<int> midPrev = null;
            while (head != null && head.next != null)
            {
                if (midPrev == null)
                    midPrev = head;
                else
                    midPrev = midPrev.next;
                head = head.next.next;
            }
            Node<int> mid = midPrev.next;
            midPrev.next = null;
            return mid;
        }
    }
}
