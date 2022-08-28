using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    internal class Stack<T>
    {
        private LinkedList<T> linkedList;

        internal Stack()
        {
            linkedList = new LinkedList<T>();
        }

        internal void Push(T val)
        {
            linkedList.Add(val);
        }

        internal T Pop()
        {
            if (Count() <= 0)
                throw new NullReferenceException();
            return linkedList.Remove().val;
        }

        internal T Peek()
        {
            if (Count() <= 0)
                throw new NullReferenceException();
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
