﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using DataStructures.Graphs;
using DataStructures.Grokking.BFS;
using DataStructures.Grokking.DFS;
using DataStructures.Grokking.P3MergeIntervals;
using DataStructures.Grokking.PatternInplaceReversalofaLinkedList;
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
            Tasks_Scheduling tasks_Scheduling = new Tasks_Scheduling();
            Console.WriteLine("isSchedulingPossible:" + tasks_Scheduling.isSchedulingPossible());
        }
    }
}