using System;
using System.Linq;
using DataStructures.Grokking.ModifiedBinarySearch;
using DataStructures.LeetCode;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 100)));
            TwoSum twoSum = new TwoSum();
            twoSum.TwoSums();
        }
    }
}