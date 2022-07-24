using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class PathwithMaximumProbability
    {

        int n;
        int[][] edges;
        double[] succProb;
        int start;
        int end;
        public PathwithMaximumProbability()
        {
            //n = 3, edges = [[0, 1],[1,2],[0,2]], succProb = [0.5, 0.5, 0.2], start = 0, end = 2
            n = 3;
            edges = new int[3][];
            edges[0] = new int[] { 0, 1 };
            edges[1] = new int[] { 1, 2 };
            edges[2] = new int[] { 0, 2 };
            succProb = new double[] { 0.5f, 0.5f, 0.2f };
            start = 0;
            end = 2;
        }

        public double MaxProbability()
        {
            //1.build graph
            Dictionary<int, List<Tuple<int, double>>> dict = new Dictionary<int, List<Tuple<int, double>>>();

            for (int i = 0; i < edges.Length; i++)
            {

                int from = edges[i][0];
                int to = edges[i][1];
                double succProbVal = succProb[i];

                if (!dict.ContainsKey(from))
                    dict.Add(from, new List<Tuple<int, double>>());
                dict[from].Add(new Tuple<int, double>(to, succProbVal));

                if (!dict.ContainsKey(to))
                    dict.Add(to, new List<Tuple<int, double>>());
                dict[to].Add(new Tuple<int, double>(from, succProbVal));
            }

            //2.create prob arr min values
            double[] probArr = new double[n];
            for (int i = 0; i < probArr.Length; i++)
                probArr[i] = double.MinValue;

            //3.BFS start => end
            BFS(start, dict, probArr);
            //4. check probArrEnd, if min return 0 or return arr[end]
            if (probArr[end] == double.MinValue)
                return 0;
            return probArr[end];
        }

        private void BFS(int start, Dictionary<int, List<Tuple<int, double>>> dict, double[] probArr)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(start);
            probArr[start] = 1;

            while (q.Count() > 0)
            {
                //1.pop front
                int front = q.Dequeue();
                //2.check neighbours
                if (dict.ContainsKey(front))
                {
                    foreach (var neighbour in dict[front])
                    {
                        int neighbourVal = neighbour.Item1;
                        double neighbourProb = neighbour.Item2;
                        double curProb = probArr[front] * neighbourProb;
                        if (curProb > probArr[neighbourVal])
                        {
                            probArr[neighbourVal] = curProb;
                            q.Enqueue(neighbourVal);
                        }
                    }
                }
            }
        }
    }
}
