using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class LongestSubstringwithSameLettersafterReplacement
    {
        string str;
        int k;
        public LongestSubstringwithSameLettersafterReplacement()
        {
            str = "abbcb";
            k = 1;
        }

        public int findLength()
        {
            int startWindow = 0;
            int maxLength = 0;
            int maxRepeatLetterCount = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int endWindow = 0; endWindow < str.Length; endWindow++)
            {

                char cc = str[endWindow];

                if (!dict.ContainsKey(cc))
                    dict.Add(cc, 0);
                dict[cc]++;
                maxRepeatLetterCount = Math.Max(maxRepeatLetterCount, dict[cc]);

                if (endWindow - startWindow + 1 - maxRepeatLetterCount > k)
                {
                    char startC = str[startWindow];
                    dict[startC]--;
                    startWindow++;
                }
                maxLength = Math.Max(maxLength, endWindow - startWindow + 1);
            }
            return maxLength;
        }
    }
}
