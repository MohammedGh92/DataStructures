using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Heap
    {
        protected List<int> arr;
        protected bool isMinHeap;
        public Heap(List<int> arr, bool isMinHeap)
        {
            this.arr = arr;
            this.isMinHeap = isMinHeap;
        }

        internal void build()
        {
            for (int i = arr.Count / 2 - 1; i >= 0; i--)
                heapify(arr.Count, i);
        }

        private void heapify(int n, int i)
        {
            int nextNode = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            if (isMinHeap)
            {
                if (leftChild < n && arr[leftChild] > arr[nextNode])
                    nextNode = leftChild;
                if (rightChild < n && arr[rightChild] > arr[nextNode])
                    nextNode = rightChild;
            }
            else
            {
                if (leftChild < n && arr[leftChild] < arr[nextNode])
                    nextNode = leftChild;
                if (rightChild < n && arr[rightChild] < arr[nextNode])
                    nextNode = rightChild;
            }
            if (nextNode != i)
            {
                int temp = arr[i];
                arr[i] = arr[nextNode];
                arr[nextNode] = temp;
                heapify(n, nextNode);
            }
        }

        internal List<int> getSortedArr() { return arr; }

        internal void sort()
        {
            for (int i = arr.Count - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(i, 0);
            }
        }

        public void insert(int num)
        {
            arr.Add(num);
            build();
            sort();
        }

        internal void printArray()
        {
            Console.WriteLine("\n======");
            for (int i = 0; i < arr.Count; i++)
                Console.Write(arr[i]);
            Console.WriteLine("\n======");
        }

        public int peek()
        {
            return arr[0];
        }
    }
}