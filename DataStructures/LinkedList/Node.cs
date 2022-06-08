using System;
namespace DataStructures
{
    public class Node<T>
    {
        public T val;
        public Node<T> next;
        public Node(T val)
        {
            this.val = val;
        }
    }
}
