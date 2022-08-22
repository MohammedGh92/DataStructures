using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class FruitsintoBaskets
    {

        char[] arr;
        public FruitsintoBaskets()
        {
            arr = new char[] { 'A', 'B', 'C', 'A', 'C' };
        }

        public int findLength()
        {

            int startWindow = 0;
            int maxLength = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int endWindow = 0; endWindow < arr.Length; endWindow++)
            {

                char cc = arr[endWindow];

                if (!dict.ContainsKey(cc))
                    dict.Add(cc, 0);
                dict[cc]++;

                while (dict.Count > 2)
                {

                    char startC = arr[startWindow];
                    dict[startC]--;
                    if (dict[startC] == 0)
                        dict.Remove(startC);
                    startWindow++;  
                }
                maxLength = Math.Max(maxLength, endWindow - (startWindow - 1));
            }

            return maxLength;
        }
    }
}
