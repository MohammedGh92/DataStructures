using System;
namespace DataStructures
{
    internal class NodeWithKey<T>
    {
        internal int key;
        internal T val;
        internal NodeWithKey<T> next;
        internal NodeWithKey(int key, T val)
        {
            this.key = key;
            this.val = val;
        }
    }
}
