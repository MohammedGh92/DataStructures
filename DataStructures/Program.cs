
using System;
using DataStructures.Graphs;
using DataStructures.Tree;

namespace DataStructures
{
    class Program
    {
        public static void Main(String[] args)
        {
            ShortestPathinBinaryMatrix shortestPathinBinaryMatrix = new ShortestPathinBinaryMatrix();
            Console.WriteLine("Sol:" + shortestPathinBinaryMatrix.ShortestPathBinaryMatrix());
        }
    }
}