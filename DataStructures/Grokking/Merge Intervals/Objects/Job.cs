﻿using System;
namespace DataStructures.Grokking.P3MergeIntervals.Objects
{
    public class Job
    {
        public int start;
        public int end;
        public int cpuLoad;

        public Job(int start, int end, int cpuLoad)
        {
            this.start = start;
            this.end = end;
            this.cpuLoad = cpuLoad;
        }
    }
}
