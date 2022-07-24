using System;
using System.Collections.Generic;

namespace DataStructures.Graphs.TopSort
{
    public class network
    {
        int k;
        int n;
        int[][] times;
        public network()
        {
            //times = [[1,2,1]], n = 2, k = 1
            times = new int[1][];
            times[0] = new int[] { 1, 2, 1 };
            n = 2;
            k = 2;
        }

        public int solution()
        {
            Dictionary<int, List<Tuple<int, int>>> dict = new Dictionary<int, List<Tuple<int, int>>>();
            for (int i = 0; i < times.Length; i++)
            {
                int from = times[i][0];
                int to = times[i][1];
                int time = times[i][2];
                if (!dict.ContainsKey(from))
                    dict.Add(from, new List<Tuple<int, int>>());
                dict[from].Add(new Tuple<int, int>(to, time));
            }
            int[] timeReceivedAt = new int[n + 1];
            for (int i = 0; i < timeReceivedAt.Length; i++)
                timeReceivedAt[i] = int.MaxValue;
            BFS(k, timeReceivedAt, dict);
            int ans = int.MinValue;
            for (int i = 1; i < timeReceivedAt.Length; i++)
            {
                Console.WriteLine(timeReceivedAt[i]);
                ans = Math.Max(ans, timeReceivedAt[i]);
            }
            if (ans != int.MinValue && ans != int.MaxValue)
                return ans;
            return -1;
        }

        private void BFS(int k, int[] timeReceivedAt, Dictionary<int, List<Tuple<int, int>>> dict)
        {

            Queue<int> q = new Queue<int>();
            q.Enqueue(k);
            timeReceivedAt[k] = 0;
            while (q.Count() > 0)
            {
                //1.pop front
                int front = q.Dequeue();
                //2.check neighbours
                if (dict.ContainsKey(front))
                    foreach (var neighbour in dict[front])
                    {
                        int to = neighbour.Item1;//C->B
                        int time = neighbour.Item2;//1
                        int arrTime = timeReceivedAt[front] + time;// 1+1 = 2
                        if (timeReceivedAt[to] > arrTime)
                        {
                            timeReceivedAt[to] = arrTime;
                            q.Enqueue(to);
                        }

                    }
            }
        }
    }
}
