using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class Words_Concatenation
    {
        string str;
        string[] words;
        public Words_Concatenation()
        {
            str = "catfoxcat";
            words = new string[] { "cat", "fox" };
        }

        public List<int> findWordConcatenation()
        {
            List<int> resultIndices = new List<int>();
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();
            int wordLength = words[0].Length;
            int wordsCount = words.Length;
            int windowLength = wordsCount * wordLength;
            for (int i = 0; i < words.Length; i++)
            {
                string cw = words[i];
                if (!wordsDict.ContainsKey(cw))
                    wordsDict.Add(cw, 0);
                wordsDict[cw]++;
            }

            for (int i = 0; i <= str.Length - windowLength; i++)
            {
                Dictionary<string, int> seenWords = new Dictionary<string, int>();
                for (int j = 0; j < wordsCount; j++)
                {
                    int nextWordIndex = i + (j * wordLength);
                    string cword = str.Substring(nextWordIndex, wordLength);
                    if (!wordsDict.ContainsKey(cword))
                        break;
                    if (!seenWords.ContainsKey(cword))
                        seenWords.Add(cword, 0);
                    seenWords[cword]++;
                    if (seenWords[cword] > wordsDict[cword])
                        break;
                    if (j + 1 == wordsCount)
                        resultIndices.Add(i);
                }

            }
            return resultIndices;
        }
    }
}
