using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Grokking.TopKElements
{
    public class Scheduling_Tasks
    {
        char[] tasks;
        int k;
        public Scheduling_Tasks()
        {
            //tasks = new char[] { 'a', 'a', 'a', 'b', 'c', 'c' };
            //k = 2;
            tasks = new char[] { 'a', 'b', 'a' };
            k = 3;
        }

        public int scheduleTasks()
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < tasks.Length; i++)
            {
                if (!dict.ContainsKey(tasks[i]))
                    dict.Add(tasks[i], 0);
                dict[tasks[i]]++;
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            bool firstOne = true;
            int firstCharInterval = 0;
            char firstTaskChar = new char();
            int intervalCounter = 0;
            while (dict.Count > 0)
            {
                foreach (var item in dict)
                {
                    if (firstOne)
                    {
                        firstOne = false;
                        firstTaskChar = item.Key;
                    }
                    if (item.Key == firstTaskChar)
                    {
                        if (firstCharInterval > 0)
                        {
                            while (intervalCounter - firstCharInterval < k)
                                intervalCounter++;
                        }

                        firstCharInterval = intervalCounter;
                        firstCharInterval++;
                    }
                    dict[item.Key]--;
                    if (dict[item.Key] == 0)
                        dict.Remove(item.Key);
                    intervalCounter++;
                }
            }
            return intervalCounter;
        }
    }
}