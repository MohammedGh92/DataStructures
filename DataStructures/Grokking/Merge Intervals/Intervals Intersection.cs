using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class Intervals_Intersection
    {
        List<Interval> intervals1;
        List<Interval> intervals2;
        public Intervals_Intersection()
        {
            intervals1 = new List<Interval>();
            intervals2 = new List<Interval>();
            intervals1.Add(new Interval(1, 3));
            intervals1.Add(new Interval(5, 6));
            intervals1.Add(new Interval(7, 9));
            intervals2.Add(new Interval(2, 3));
            intervals2.Add(new Interval(5, 7));
        }

        public List<Interval> merge()
        {
            List<Interval> intervalsIntersection = new List<Interval>();
            int i = 0;
            int j = 0;
            while (i < intervals1.Count && j < intervals2.Count)
            {
                Interval i1 = intervals1[i];
                Interval i2 = intervals2[j];
                if (areOverlaped(i1, i2))
                    intervalsIntersection.Add(new Interval(Math.Max(i1.start, i2.start), Math.Min(i1.end, i2.end)));
                if (i1.end < i2.end)
                    i++;
                else
                    j++;
            }

            for (int z = 0; z < intervalsIntersection.Count; z++)
                Console.WriteLine(intervalsIntersection[z].start + "," + intervalsIntersection[z].end);

            return intervalsIntersection;
        }

        private bool areOverlaped(Interval i1, Interval i2)
        {
            return (i1.start >= i2.start && i1.start <= i2.end) || (i2.start >= i1.start && i2.start <= i1.end);
        }
    }
}