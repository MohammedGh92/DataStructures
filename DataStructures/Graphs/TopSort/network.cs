using System;
using System.Collections.Generic;

namespace DataStructures.Graphs.TopSort
{
    public class network
    {
        int K;
        int N;
        int[][] times;
        public network()
        {
            times = new int[3][];
            times[0] = new int[] { 2, 1, 1 };
            times[1] = new int[] { 2, 3, 1 };
            times[2] = new int[] { 3, 4, 1 };
            N = 4;
            K = 2;
        }

        public int solution()
        {
            int res = 0;

            //0.build graph
            //1.pop front
            //2.check goal
            //3.check neighbours
            //4.check level

            Dictionary<int, List<Tuple<int, int>>> dict = new Dictionary<int, List<Tuple<int, int>>>();

            for (int i = 0; i < times.Length; i++)
            {
                int from = times[i][0];
                int to = times[i][1];
                int time = times[i][2];
                //if (!dict.ContainsKey(from))
                //    dict.Add();
            }

            return res;
        }
    }
}
