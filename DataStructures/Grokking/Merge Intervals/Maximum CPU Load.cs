using System;
using System.Collections.Generic;
using DataStructures.Grokking.P3MergeIntervals.Objects;

namespace DataStructures.Grokking.P3MergeIntervals
{
    public class Maximum_CPU_Load
    {
        List<Job> jobs;
        public Maximum_CPU_Load()
        {
            jobs = new List<Job>();
            jobs.Add(new Job(1, 4, 2));
            jobs.Add(new Job(2, 4, 1));
            jobs.Add(new Job(3, 6, 5));
        }

        public int findMaxCPULoad()
        {

            int maxLoad = int.MinValue;

            jobs.Sort((i1, i2) => i1.start.CompareTo(i2.start));

            if (jobs.Count == 1)
                return jobs[0].cpuLoad;
            if (jobs.Count == 0)
                return -1;

            int p1 = 0;
            int p2 = 1;

            int cMaxLoad = 0;
            int newlyMovedOne = 0;
            while (p1 < jobs.Count && p2 < jobs.Count)
            {
                Job p1J = jobs[p1];
                Job p2J = jobs[p2];
                if (!areIntersected(p1J, p2J))
                {
                    maxLoad = Math.Max(cMaxLoad, maxLoad);
                    int newMaxLoad = Math.Max(p1J.cpuLoad, p2J.cpuLoad);
                    maxLoad = Math.Max(newMaxLoad, maxLoad);
                    newlyMovedOne = 0;
                }
                else
                {
                    if (newlyMovedOne == 0)
                        cMaxLoad += p1J.cpuLoad + p2J.cpuLoad;
                    else if (newlyMovedOne == 1)
                        cMaxLoad += p1J.cpuLoad;
                    else
                        cMaxLoad += p2J.cpuLoad;
                }

                if (p1J.end < p2J.end)
                {
                    newlyMovedOne = 1;
                    if (p1 < p2)
                        p1 = p2 + 1;
                    else
                        p1++;
                }
                else
                {
                    newlyMovedOne = 2;
                    if (p2 < p1)
                        p2 = p1 + 1;
                    else
                        p2++;
                }
            }
            maxLoad = Math.Max(cMaxLoad, maxLoad);
            return maxLoad;
        }

        private bool areIntersected(Job i1, Job i2)
        {
            return (i1.start >= i2.start && i1.start <= i2.end) || (i2.start >= i1.start && i2.start <= i1.end);
        }
    }
}
