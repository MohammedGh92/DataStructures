using System;
using System.Collections.Generic;
using DataStructures.Grokking.P1SlidingWindow;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        public static void Main(String[] args)
        {
            Words_Concatenation words_Concatenation = new Words_Concatenation();
            Print.PrintList(words_Concatenation.findWordConcatenation());
        }
    }
}