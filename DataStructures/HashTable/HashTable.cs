using System;
using DataStructures.List;

namespace DataStructures
{
    internal class HashTable<T>
    {
        private float loadFactor;
        private LinkedListWithKey<T>[] linkedListsArr;
        private int count;
        internal HashTable(int capacity, float loadFactor = 0.75f)
        {
            if (capacity < 0)
            {
                Console.WriteLine("Capacity should be over 0, setting capacity to 1");
                capacity = 1;
            }
            linkedListsArr = new LinkedListWithKey<T>[capacity];
            count = 0;
            for (int i = 0; i < linkedListsArr.Length; i++)
                linkedListsArr[i] = new LinkedListWithKey<T>();
            this.loadFactor = loadFactor;
        }

        private float getCurLoadFactor()
        {
            return (float)((float)count / (float)linkedListsArr.Length);
        }

        internal void put(int key, T value)
        {
            int newIndx = getHashedIndx(key);
            if (linkedListsArr[newIndx].AddNode(new NodeWithKey<T>(key, value)))
                count++;
            while (getCurLoadFactor() >= loadFactor)
                ReHash();
        }

        private void ReHash()
        {
            count = 0;
            LinkedListWithKey<T>[] newlinkedListsArr = new LinkedListWithKey<T>[linkedListsArr.Length * 2];
            for (int i = 0; i < newlinkedListsArr.Length; i++)
                newlinkedListsArr[i] = new LinkedListWithKey<T>();
            for (int i = 0; i < linkedListsArr.Length; i++)
            {
                NodeWithKey<T> cn = linkedListsArr[i].head;
                while (cn != null)
                {
                    NodeWithKey<T> newNode = new NodeWithKey<T>(cn.key, cn.val);
                    int newIndx = newNode.key % newlinkedListsArr.Length;
                    if (newlinkedListsArr[newIndx].AddNode(newNode))
                        count++;
                    cn = cn.next;
                }
            }
            linkedListsArr = newlinkedListsArr;
        }

        internal T get(int key)
        {
            int newIndx = getHashedIndx(key);
            return linkedListsArr[newIndx].GetNode(key);
        }

        internal void delete(int key)
        {
            int newIndx = getHashedIndx(key);
            if (linkedListsArr[newIndx].Remove(key))
                count--;
        }

        private int getHashedIndx(int key)
        {
            return key % linkedListsArr.Length;
        }

    }
}
