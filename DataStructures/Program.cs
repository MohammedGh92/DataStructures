using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using DataStructures.Grokking.BFS;
using DataStructures.Grokking.DFS;
using DataStructures.Grokking.P3MergeIntervals;
using DataStructures.Grokking.PatternInplaceReversalofaLinkedList;
using DataStructures.Grokking.TwoHeaps;
using DataStructures.Test;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 100)));
            Count_Paths_for_a_Sum count_Paths_For_A_Sum = new Count_Paths_for_a_Sum();
            count_Paths_For_A_Sum.countPaths();

        }
    }
}