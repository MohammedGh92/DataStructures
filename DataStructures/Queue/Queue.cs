using System;
using DataStructures.List;

namespace DataStructures
{
    internal class Queue<T>
    {
        private LinkedList<T> linkedList;

        internal Queue()
        {
            linkedList = new LinkedList<T>();
        }

        internal void Enqueue(T val)
        {
            linkedList.AddFirst(val);
        }

        internal T Dequeue()
        {
            if (Count() <= 0)
                throw new NullReferenceException();
            return linkedList.Remove().val;
        }

        internal T Peek()
        {
            return linkedList.Peek().val;
        }

        internal int Count()
        {
            return linkedList.Count();
        }

        internal void PrintAllData()
        {
            linkedList.PrintAllNodes();
        }
    }
}
