using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class Permutation_in_a_String
    {
        //String="oidbcaf", Pattern="abc"
        string str;
        string Pattern;
        public Permutation_in_a_String()
        {
            str = "oidbcaf";
            Pattern = "abc";
        }

        public bool findPermutation()
        {

            Dictionary<char, int> patternDict = new Dictionary<char, int>();

            for (int i = 0; i < Pattern.Length; i++)
            {
                char cc = Pattern[i];
                if (!patternDict.ContainsKey(cc))
                    patternDict.Add(cc, 0);
                patternDict[cc]++;
            }

            int startWin = 0;
            int matched = 0;
            for (int endWin = 0; endWin < str.Length; endWin++)
            {
                char cc = str[endWin];
                if (patternDict.ContainsKey(cc))
                {
                    patternDict[cc]--;
                    if (patternDict[cc] == 0)
                        matched++;
                }



                if (matched == patternDict.Count)
                    return true;

                if (endWin >= Pattern.Length - 1)
                {

                    char leftC = str[startWin];
                    if (patternDict.ContainsKey(leftC))
                    {

                        if (patternDict[leftC] == 0)
                            matched--;
                        patternDict[leftC]++;

                    }

                }

            }

            return false;
        }
    }
}
