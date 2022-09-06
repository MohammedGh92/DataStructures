using System;
using System.Linq;
using DataStructures.Grokking.PatternFastSlowpointers;
using DataStructures.Test;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 100)));
            testQuestion test = new testQuestion();
            for (int i = 0; i < test.list.Count; i++)
                Console.WriteLine(test.AddCommand(test.list[i]));
        }
    }
}