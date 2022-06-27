using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.SearchingAlgorithms;
using DataStructures.SortingAlgorithms;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Print.PrintArr(CountingSort.Sort(new int[] { 5, 1, 2, 4, 0 }));
        }
    }
}
