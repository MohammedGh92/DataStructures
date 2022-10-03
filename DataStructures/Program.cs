
using System;
using System.Linq;
using DataStructures.LeetCode.TopInterviewQuestions;

namespace DataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(Environment.NewLine, Enumerable.Repeat(string.Empty, 100)));
            Remove_Duplicates_from_Sorted_Array remove_Duplicates_From_Sorted_Array = new Remove_Duplicates_from_Sorted_Array();
            remove_Duplicates_From_Sorted_Array.RemoveDuplicates();
        }
    }
}