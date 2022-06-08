using System;
namespace DataStructures
{
    public class NodeWithKey<T>
    {
        public int key;
        public T val;
        public NodeWithKey<T> next;
        public NodeWithKey(int key, T val)
        {
            this.key = key;
            this.val = val;
        }
    }
}
