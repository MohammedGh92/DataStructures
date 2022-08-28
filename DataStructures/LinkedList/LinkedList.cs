using System;
namespace DataStructures.LinkedList
{
    public class LinkedList<T>
    {
        internal Node<T> head;
        internal Node<T> tail;
        private int count;

        internal void AddFirst(T val)
        {
            count++;
            Node<T> newNode = new Node<T>(val);
            if (head == null)
            {
                head = newNode;
                tail = null;
                head.next = tail;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        internal void Add(T val)
        {
            count++;
            Node<T> newNode = new Node<T>(val);
            if (head == null)
            {
                head = newNode;
                tail = null;
                head.next = tail;
            }
            else if (tail == null)
            {
                tail = newNode;
                head.next = tail;
            }
            else
            {
                tail.next = newNode;
                tail = tail.next;
            }
        }

        internal int Count() { return count; }

        internal Node<T> Remove()
        {
            if (head == null)
                return null;
            count--;
            Node<T> removedNode;
            if (head.next == null)
            {
                removedNode = new Node<T>(head.val);
                head = null;
                tail = null;
                return removedNode;
            }
            if (head.next.next == null)
            {
                removedNode = new Node<T>(head.next.val);
                head.next = null;
                tail = null;
                return removedNode;
            }

            Node<T> cn = head;
            while (cn.next.next != null)
                cn = cn.next;
            removedNode = new Node<T>(cn.next.val);
            cn.next = null;
            tail = cn;
            return removedNode;
        }

        internal Node<T> Peek()
        {
            if (head == null)
                return null;

            Node<T> cn = head;
            while (cn.next != null)
                cn = cn.next;
            return cn;
        }

        internal void PrintAllNodes()
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
                return;
            }

            Node<T> cn = head;
            Console.WriteLine(cn.val);
            while (cn.next != null)
            {
                cn = cn.next;
                Console.WriteLine(cn.val);
            }
        }
    }
}
