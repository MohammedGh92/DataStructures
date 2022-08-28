using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Misc
{
    public class DecodeMessage
    {

        string key;
        string MSG;

        public DecodeMessage()
        {
            key = "the quick brown fox jumps over the lazy dog";
            MSG = "vkbs bs t suepuv";
        }

        public string DecodeMsg()
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            int alphaBetLetterCount = 97;
            for (int i = 0; i < key.Length; i++)
            {
                if (key[i] == ' ')
                    continue;
                if (!dict.ContainsKey(key[i]))
                {
                    dict.Add(key[i], (char)alphaBetLetterCount);
                    alphaBetLetterCount++;
                }
            }
            dict.Add(' ', ' ');
            StringBuilder stringBuilder = new StringBuilder();
             

            for (int i = 0; i < MSG.Length; i++)
                stringBuilder.Append(dict[MSG[i]]);
            return stringBuilder.ToString();
        }
    }
}
