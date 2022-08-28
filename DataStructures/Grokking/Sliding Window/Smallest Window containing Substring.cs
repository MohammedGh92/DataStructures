using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class Smallest_Window_containing_Substring
    {
        string str;
        string Pattern;
        public Smallest_Window_containing_Substring()
        {
            str = "abdbca";
            Pattern = "abc";
        }

        public string findSubstring()
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
            int smallestLength = int.MaxValue;
            int matched = 0;

            int startChar = 0;
            int endChar = 0;
            for (int endWin = 0; endWin < str.Length; endWin++)
            {

                char cc = str[endWin];

                if (patternDict.ContainsKey(cc))
                {
                    patternDict[cc]--;
                    if (patternDict[cc] == 0)
                        matched++;
                }

                while (matched == patternDict.Count)
                {
                    if (endWin - startWin < smallestLength)
                    {
                        smallestLength = endWin - startWin;
                        startChar = startWin;
                        endChar = endWin;
                    }
                    char startC = str[startWin];
                    if (patternDict.ContainsKey(startC))
                    {

                        if (patternDict[startC] == 0)
                            matched--;

                        patternDict[startC]++;

                    }
                    startWin++;
                }


            }
            if (smallestLength != int.MaxValue)
                return str.Substring(startWin - 1, endChar - startWin + 2);
            return "";
        }

    }
}
