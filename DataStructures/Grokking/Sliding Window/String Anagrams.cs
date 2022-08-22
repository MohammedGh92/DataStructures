using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class String_Anagrams
    {
        string str;
        string Pattern;
        public String_Anagrams()
        {
            str = "abbcabc";
            Pattern = "abc";
        }

        public List<int> findStringAnagrams()
        {
            List<int> resList = new List<int>();

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

                if (endWin >= Pattern.Length)
                {
                    char leftC = str[startWin];

                    if (patternDict.ContainsKey(leftC))
                    {
                        if (patternDict[leftC] == 0)
                            matched--;
                        patternDict[leftC]++;
                    }
                    startWin++;
                    if (matched == patternDict.Count)
                        resList.Add(startWin);
                }

                Console.WriteLine(matched + "," + startWin + "," + endWin);

            }


            return resList;
        }
    }
}
