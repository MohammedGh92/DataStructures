using System;
namespace DataStructures
{
    internal class Heap
    {

        private int[] arr;

        internal Heap(int[] arr)
        {
            this.arr = arr;
        }

        internal void build()
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                heapify(arr.Length, i);
        }

        private void heapify(int n, int i)
        {
            int highestNode = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;
            if (leftChild < n && arr[leftChild] > arr[highestNode])
                highestNode = leftChild;
            if (rightChild < n && arr[rightChild] > arr[highestNode])
                highestNode = rightChild;
            if (highestNode != i)
            {
                int temp = arr[i];
                arr[i] = arr[highestNode];
                arr[highestNode] = temp;
                heapify(n, highestNode);
            }
        }

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
