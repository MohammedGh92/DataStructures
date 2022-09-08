using System;
using System.Collections.Generic;
using System.Linq;
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
            Next_Interval next_Interval = new Next_Interval();
            next_Interval.findNextInterval();
        }
    }
}