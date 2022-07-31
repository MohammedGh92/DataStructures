using System;
using DataStructures.Graphs;
using DataStructures.Graphs.TopSort;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        public static void Main(String[] args)
        {

            Heap heap = new Heap(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            heap.build();
            heap.sort();
            heap.printArray();
        }
    }
}