using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class Employee_Free_Time
    {
        //Hours=[[[1,3], [5,6]], [[2,3], [6,8]]]
        List<List<Interval>> EWO;
        public Employee_Free_Time()
        {
            EWO = new List<List<Interval>>();
            EWO.Add(new List<Interval>());
            EWO.Add(new List<Interval>());
            EWO[0].Add(new Interval(1, 3));
            EWO[0].Add(new Interval(5, 6));

            EWO[1].Add(new Interval(2, 3));
            EWO[1].Add(new Interval(6, 8));
        }

        public List<Interval> findEmployeeFreeTime()
        {
            List<Interval> resList = new List<Interval>();
            List<Interval> tempIntList = new List<Interval>();
            foreach (List<Interval> intervals in EWO)
                foreach (Interval interval in intervals)
                    tempIntList.Add(interval);
            tempIntList.Sort((i1, i2) => i1.start.CompareTo(i2.start));
            int cp = 0;
            Interval ci = tempIntList[0];
            Interval ni = tempIntList[0];
            int start = ci.start;
            int end = ci.end;
            List<Interval> overLapList = new List<Interval>();
            while (cp < tempIntList.Count - 1)
            {
                ni = tempIntList[cp + 1];
                if (ni.start <= end)
                    end = Math.Max(end, ni.end);
                else
                {
                    overLapList.Add(new Interval(start, end));
                    start = ni.start;
                    end = ni.end;
                }
                cp++;
            }
            overLapList.Add(new Interval(start, end));


            for (int i = 0; i < overLapList.Count - 1; i++)
                resList.Add(new Interval(overLapList[i].end, overLapList[i + 1].start));
            return resList;
        }
    }
}
