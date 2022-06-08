using System;
namespace DataStructures.LinkedList
{
    public class LinkedListWithKey<T>
    {
        public NodeWithKey<T> head;

        public bool AddNode(NodeWithKey<T> node)
        {
            if (head == null)
            {
                head = node;
                return true;
            }
            if (head.key == node.key)
            {
                head.val = node.val;
                return false;
            }
            NodeWithKey<T> cn = head;
            while (cn.next != null)
            {
                if (cn.key == node.key)
                {
                    cn.val = node.val;
                    return false;
                }
                cn = cn.next;
            }
            cn.next = node;
            return true;
        }

        public bool Remove(int key)
        {
            if (head == null)
                return false;
            if (head.key == key)
            {
                head = head.next;
                return head == null;
            }
            NodeWithKey<T> cn = head;
            while (cn.next != null)
            {
                if (cn.next.key == key)
                {
                    cn.next = cn.next.next;
                    return head == null;
                }
                cn = cn.next;
            }
            return head == null;
        }

        public T GetNode(int key)
        {
            NodeWithKey<T> cn = head;
            while (cn != null)
            {
                if (cn.key == key)
                    return cn.val;
                cn = cn.next;
            }
            throw new NullReferenceException();
        }
    }
}
