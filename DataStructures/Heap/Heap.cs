using System;

namespace DataStructures
{
    public class Heap
    {
        protected int[] arr;
        protected bool isMaxHeap;
        public Heap(int[] arr, bool isMaxHeap)
        {
            this.arr = arr;
            this.isMaxHeap = isMaxHeap;
        }

        internal void build()
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                heapify(arr.Length, i);
        }

        private void heapify(int n, int i)
        {
            int nextNode = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            if (isMaxHeap)
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

        internal int[] getSortedArr() { return arr; }

        internal void sort()
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(i, 0);
            }
        }

        internal void printArray()
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i] + " ");
        }
    }
}