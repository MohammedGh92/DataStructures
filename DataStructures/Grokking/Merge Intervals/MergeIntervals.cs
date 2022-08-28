using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class MergeIntervals
    {
        List<Interval> intervals;
        public MergeIntervals()
        {
            intervals = new List<Interval>();
            intervals.Add(new Interval(1, 4));
            intervals.Add(new Interval(1, 5));
            intervals.Add(new Interval(1, 9));
            intervals.Add(new Interval(10, 12));

        }

        public List<Interval> merge()
        {
            List<Interval> mergedIntervals = new List<Interval>();
            intervals.Sort((p, q) => p.start.CompareTo(q.start));
            if (intervals.Count <= 1)
                return intervals;
            int cp = 0;
            Interval ci = intervals[cp];
            Interval ni = intervals[cp + 1];
            int start = ci.start;
            int end = ci.end;
            while (cp < intervals.Count - 1)
            {
                ni = intervals[cp + 1];
                if (ni.start <= end)
                    end = Math.Max(end, ni.end);
                else
                {
                    mergedIntervals.Add(new Interval(start, end));
                    start = ni.start;
                    end = ni.end;
                }
                cp++;
            }
            mergedIntervals.Add(new Interval(start, end));
            for (int i = 0; i < mergedIntervals.Count; i++)
                Console.WriteLine(mergedIntervals[i].start + "," + mergedIntervals[i].end);

            return mergedIntervals;
        }
    }
}