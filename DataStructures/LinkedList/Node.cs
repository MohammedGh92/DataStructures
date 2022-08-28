using System;
namespace DataStructures
{
    internal class Node<T>
    {
        internal T val;
        internal Node<T> next;
        internal Node(T val)
        {
            this.val = val;
        }
    }
}
