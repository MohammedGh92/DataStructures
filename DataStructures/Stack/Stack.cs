using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    public class Stack<T>
    {
        private LinkedList<T> linkedList;

        public Stack()
        {
            linkedList = new LinkedList<T>();
        }

        public void Push(T val)
        {
            linkedList.Add(val);
        }

        public T Pop()
        {
            if (Count() <= 0)
                throw new NullReferenceException();
            return linkedList.Remove().val;
        }

        public T Peek()
        {
            if (Count() <= 0)
                throw new NullReferenceException();
            return linkedList.Peek().val;
        }

        public int Count()
        {
            return linkedList.Count();
        }

        public void PrintAllData()
        {
            linkedList.PrintAllNodes();
        }
    }
}
