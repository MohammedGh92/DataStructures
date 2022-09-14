using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataStructures.Grokking.TopologicalSort
{
    public class Alien_Dictionary
    {
        string[] words;
        public Alien_Dictionary()
        {
            words = new string[] { "ba", "bc", "ac", "cab" };
        }

        public string findOrder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            HashSet<char> visited = new HashSet<char>();
            for (int i = 0; i < words.Length - 1; i++)
            {
                string word1 = words[i];
                string word2 = words[i + 1];
                getLetter(0, word1, word2, stringBuilder, visited);
            }

            return stringBuilder.ToString();
        }

        private void getLetter(int indx, string word1, string word2, StringBuilder stringBuilder, HashSet<char> visited)
        {
            if (indx >= word1.Length || indx >= word2.Length)
                return;
            if (!visited.Contains(word1[indx]))
            {
                visited.Add(word1[indx]);
                stringBuilder.Append(word1[indx]);
                if (!visited.Contains(word2[indx]))
                {
                    visited.Add(word2[indx]);
                    stringBuilder.Append(word2[indx]);
                }
            }
            else if (!visited.Contains(word2[indx]))
            {
                visited.Add(word2[indx]);
                stringBuilder.Append(word2[indx]);
            }
            else
            {
                indx += 1;
                getLetter(indx, word1, word2, stringBuilder, visited);
            }
        }
    }
}

