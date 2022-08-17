using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class Minimum_Meeting_Rooms
    {
        List<Interval> intervals;
        public Minimum_Meeting_Rooms()
        {
            intervals = new List<Interval>();
            intervals.Add(new Interval(1, 2));
            intervals.Add(new Interval(2, 5));
            intervals.Add(new Interval(7, 9));
        }

        public int findMinimumMeetingRooms()
        {
            int roomsRequired = 1;

            intervals.Sort((i1, i2) => i1.start.CompareTo(i2.start));

            if (intervals.Count <= 1)
                return roomsRequired;

            int p1 = 0;
            int p2 = 1;

            while (p1 < intervals.Count && p2 < intervals.Count)
            {
                Interval p1I = intervals[p1];
                Interval p2I = intervals[p2];

                if (areIntersected(p1I, p2I))
                    roomsRequired++;

                if (p1I.end < p2I.end)
                {
                    if (p1 < p2)
                        p1 = p2 + 1;
                    else
                        p1++;
                }
                else
                {
                    if (p2 < p1)
                        p2 = p1 + 1;
                    else
                        p2++;
                }

            }

            return roomsRequired;
        }

        private bool areIntersected(Interval i1, Interval i2)
        {
            return (i1.start >= i2.start && i1.start <= i2.end) || (i2.start >= i1.start && i2.start <= i1.end);
        }
    }
}
