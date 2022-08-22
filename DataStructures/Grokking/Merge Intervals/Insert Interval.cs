using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class Insert_Interval
    {
        List<Interval> intervals;
        Interval newInterval;
        public Insert_Interval()
        {
            intervals = new List<Interval>();
            intervals.Add(new Interval(1, 3));
            intervals.Add(new Interval(5, 7));
            intervals.Add(new Interval(8, 12));
            newInterval = new Interval(4, 6);
        }

        public List<Interval> insert()
        {
            List<Interval> mergedIntervals = new List<Interval>();


            for (int i = 0; i < intervals.Count; i++)
                if (newInterval.start < intervals[i].start)
                {
                    intervals.Insert(i, newInterval);
                    break;
                }

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
            return mergedIntervals;
        }
    }
}
