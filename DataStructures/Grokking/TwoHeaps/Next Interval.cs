using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.TwoHeaps
{
    public class Next_Interval
    {
        //Java
        //int[][] Intervals;
        //public Next_Interval()
        //{
        //    Intervals = new int[3][];
        //    Intervals[0] = new int[] { 3, 4 };
        //    Intervals[1] = new int[] { 1, 5 };
        //    Intervals[2] = new int[] { 4, 6 };
        //}

        //public int[] findNextInterval()
        //{
        //    int n = intervals.length;
        //    PriorityQueue<Integer> maxStartHeap = new PriorityQueue<>(n, (i1, i2)->intervals[i2][0] - intervals[i1][0]);
        //    PriorityQueue<Integer> maxEndHeap = new PriorityQueue<>(n, (i1, i2)->intervals[i2][1] - intervals[i1][1]);
        //    int[] result = new int[n];
        //    for (int i = 0; i < intervals.length; i++)
        //    {
        //        maxStartHeap.offer(i);
        //        maxEndHeap.offer(i);
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        int topEnd = maxEndHeap.poll();
        //        result[topEnd] = -1; // defaults to -1
        //        if (intervals[maxStartHeap.peek()][0] >= intervals[topEnd][1])
        //        {
        //            int topStart = maxStartHeap.poll();
        //            while (!maxStartHeap.isEmpty() && intervals[maxStartHeap.peek()][0] >= intervals[topEnd][1])
        //            {
        //                topStart = maxStartHeap.poll();
        //            }
        //            result[topEnd] = topStart;
        //            maxStartHeap.add(topStart);
        //        }
        //    }
        //    return result;
        //}
    }
}

