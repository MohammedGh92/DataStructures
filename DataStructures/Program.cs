using System;
using System.Linq;
using DataStructures.Grokking.ModifiedBinarySearch;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 100)));
            Rotation_Count rotation_Count = new Rotation_Count();
            Console.WriteLine(rotation_Count.countRotations());
        }
    }
}