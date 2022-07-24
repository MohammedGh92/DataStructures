using System;
using DataStructures.Graphs;
using DataStructures.Graphs.TopSort;

namespace DataStructures
{
    class Program
    {
        public static void Main(String[] args)
        {
            MinimumNumberOfOperations minimumNumberOfOperations = new MinimumNumberOfOperations();
            Console.WriteLine("Sol:" + minimumNumberOfOperations.solution());
        }
    }
}