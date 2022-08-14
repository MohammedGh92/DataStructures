using System;
using DataStructures.Grokking.TwoPointers;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Triplet_Sum_Close_to_Target triplet_Sum_Close_to_Target = new Triplet_Sum_Close_to_Target();
            Console.WriteLine(triplet_Sum_Close_to_Target.searchTriplet());
        }
    }
}