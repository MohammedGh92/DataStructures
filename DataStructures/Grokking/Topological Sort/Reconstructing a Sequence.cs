using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.TopologicalSort
{
    public class Reconstructing_a_Sequence
    {
        int[][] prerequisites;
        int[] originalSeq;
        public Reconstructing_a_Sequence()
        {
            originalSeq = new int[] { 1, 2, 3, 4 };
            //seqs: [[1, 2], [2, 3], [3, 4]]
            prerequisites = new int[3][];
            prerequisites[0] = new int[] { 1, 2 };
            prerequisites[1] = new int[] { 2, 3 };
            prerequisites[2] = new int[] { 3, 4 };
        }

        public bool canConstruct()
        {

            //Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            //for(int i=0;i<)

            return false;
        }
    }
}

