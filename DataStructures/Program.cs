using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using DataStructures.Graphs;
using DataStructures.Grokking.BFS;
using DataStructures.Grokking.DFS;
using DataStructures.Grokking.P3MergeIntervals;
using DataStructures.Grokking.PatternInplaceReversalofaLinkedList;
using DataStructures.Grokking.SlidingWindow;
using DataStructures.Grokking.TopologicalSort;
using DataStructures.Grokking.TwoHeaps;
using DataStructures.LeetCode;
using DataStructures.Test;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 100)));
            Maximum_Sum_Subarray_of_Size_K maximum_Sum_Subarray_Of_Size_K = new Maximum_Sum_Subarray_of_Size_K();
            Console.WriteLine(maximum_Sum_Subarray_Of_Size_K.findMaxSumSubArray());
        }
    }
}