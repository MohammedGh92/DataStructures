using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    public class Queue<T>
    {
        private LinkedList<T> linkedList;

        public Queue()
        {
            linkedList = new LinkedList<T>();
        }

        public void Enqueue(T val)
        {
            linkedList.AddFirst(val);
        }

        public T Dequeue()
        {
            if (Count() <= 0)
                throw new NullReferenceException();
            return linkedList.Remove().val;
        }

        public T Peek()
        {
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
