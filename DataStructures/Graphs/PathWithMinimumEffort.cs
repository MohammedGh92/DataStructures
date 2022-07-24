using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class PathWithMinimumEffort
    {
        int[][] heights;
        public PathWithMinimumEffort()
        {
            //heights = [[1,10,6,7,9,10,4,9]]
            heights = new int[1][];
            heights[0] = new int[] { 1, 10, 6, 7, 9, 10, 4, 9 };
        }

        public int MinimumEffortPath()
        {
            int[][] maximumEffort = new int[heights.Length][];
            for (int i = 0; i < heights.Length; i++)
                maximumEffort[i] = new int[heights[i].Length];
            for (int i = 0; i < maximumEffort.Length; i++)
                Array.Fill(maximumEffort[i], int.MaxValue);
            BFS(maximumEffort, heights);
            return maximumEffort[maximumEffort.Length - 1][maximumEffort[maximumEffort.Length - 1].Length - 1];
        }

        private void BFS(int[][] maximumEffort, int[][] heights)
        {
            Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
            q.Enqueue(new Tuple<int, int>(0, 0));
            maximumEffort[0][0] = 0;
            while (q.Count() > 0)
            {
                //1.pop front
                Tuple<int, int> front = q.Dequeue();
                Console.WriteLine(front.Item1 + "," + front.Item2);
                //2.check neighbours
                int cDiff = 0;
                int prevVal = 0;
                //Up
                if (front.Item1 - 1 >= 0)
                {
                    cDiff = Math.Abs(heights[front.Item1 - 1][front.Item2] - heights[front.Item1][front.Item2]);
                    int cMaxDif = (int)MathF.Max(maximumEffort[front.Item1][front.Item2], cDiff);
                    prevVal = maximumEffort[front.Item1 - 1][front.Item2];
                    maximumEffort[front.Item1 - 1][front.Item2] = (int)MathF.Min(
                          maximumEffort[front.Item1 - 1][front.Item2],
                          cMaxDif
                          );
                    if (prevVal != maximumEffort[front.Item1 - 1][front.Item2])
                        q.Enqueue(new Tuple<int, int>(front.Item1 - 1, front.Item2));
                }

                //Down
                if (front.Item1 + 1 < heights.Length)
                {
                    cDiff = Math.Abs(heights[front.Item1 + 1][front.Item2] - heights[front.Item1][front.Item2]);
                    int cMaxDif = (int)MathF.Max(maximumEffort[front.Item1][front.Item2], cDiff);
                    prevVal = maximumEffort[front.Item1 + 1][front.Item2];
                    maximumEffort[front.Item1 + 1][front.Item2] = (int)MathF.Min(
                        maximumEffort[front.Item1 + 1][front.Item2],
                        cMaxDif
                        );
                    if (prevVal != maximumEffort[front.Item1 + 1][front.Item2])
                        q.Enqueue(new Tuple<int, int>(front.Item1 + 1, front.Item2));
                }

                //Left
                if (front.Item2 - 1 >= 0)
                {
                    cDiff = Math.Abs(heights[front.Item1][front.Item2 - 1] - heights[front.Item1][front.Item2]);
                    int cMaxDif = (int)MathF.Max(maximumEffort[front.Item1][front.Item2], cDiff);
                    prevVal = maximumEffort[front.Item1][front.Item2 - 1];
                    maximumEffort[front.Item1][front.Item2 - 1] = (int)MathF.Min(
                        maximumEffort[front.Item1][front.Item2 - 1],
                        cMaxDif
                        );
                    if (prevVal != maximumEffort[front.Item1][front.Item2 - 1])
                        q.Enqueue(new Tuple<int, int>(front.Item1, front.Item2 - 1));
                }
                //Right
                if (front.Item2 + 1 < heights[front.Item1].Length)
                {
                    cDiff = Math.Abs(heights[front.Item1][front.Item2 + 1] - heights[front.Item1][front.Item2]);
                    int cMaxDif = (int)MathF.Max(maximumEffort[front.Item1][front.Item2], cDiff);
                    prevVal = maximumEffort[front.Item1][front.Item2 + 1];
                    maximumEffort[front.Item1][front.Item2 + 1] = (int)MathF.Min(
                        maximumEffort[front.Item1][front.Item2 + 1],
                        cMaxDif
                        );
                    if (prevVal != maximumEffort[front.Item1][front.Item2 + 1])
                        q.Enqueue(new Tuple<int, int>(front.Item1, front.Item2 + 1));
                }
            }
        }
    }
}