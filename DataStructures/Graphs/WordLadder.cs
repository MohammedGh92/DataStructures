using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class WordLadder
    {
        string beginWord;
        string endWord;
        string[] wordList;
        public WordLadder(string beginWord, string endWord, string[] wordList)
        {
            this.beginWord = beginWord;
            this.endWord = endWord;
            this.wordList = wordList;
        }

        public WordLadder()
        {
            beginWord = "hit";
            endWord = "cog";
            wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
        }

        public int FindShortestPath()
        {
            Queue<node> queue = new Queue<node>();
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();
            foreach (var word in wordList)
                wordsDict[word] = 0;
            node firstNode = new node();
            firstNode.word = beginWord;
            firstNode.dist = 1;
            queue.Enqueue(firstNode);
            while (queue.Count() > 0)
            {
                node cWordNode = queue.Dequeue();
                if (cWordNode.word == endWord)
                    return cWordNode.dist;

                for (int i = 0; i < cWordNode.word.Length; i++)
                {
                    char[] _cWordNodeArr = cWordNode.word.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (c == _cWordNodeArr[i])
                            continue;
                        _cWordNodeArr[i] = c;
                        string cWord = new string(_cWordNodeArr);
                        if (wordsDict.ContainsKey(cWord) && wordsDict[cWord] == 0)
                        {
                            wordsDict[cWord] = 1;
                            node newWordNode = new node();
                            newWordNode.word = cWord;
                            newWordNode.dist = cWordNode.dist + 1;
                            queue.Enqueue(newWordNode);
                        }

                    }
                }
            }
            //No Path
            Console.WriteLine("No Path");
            return 0;

        }

        private class node
        {
            public string word;
            public int dist;
        }
    }

}
