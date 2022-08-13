using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class LongestSubstringwithDistinctCharacters
    {
        string str;
        public LongestSubstringwithDistinctCharacters()
        {
            str = "abccde";
        }

        public int findLength()
        {

            int startWindow = 0;
            int maxLength = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int endWindow = 0; endWindow < str.Length; endWindow++)
            {

                char cc = str[endWindow];

                if (!dict.ContainsKey(cc))
                    dict.Add(cc, 0);
                dict[cc]++;

                while (dict[cc] > 1)
                {

                    char startC = str[startWindow];
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
