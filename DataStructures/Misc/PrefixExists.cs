using System;
using System.Collections.Generic;

namespace DataStructures.Misc
{
    public class PrefixExists
    {
        Node trie;
        string[] words;
        string inputStr;
        public PrefixExists()
        {
            words = new string[] { "island", "boat" };
            inputStr = "isd";
        }

        internal void Solution()
        {

            trie = new Node('*');
            buildTrie(words);
            Node cn = trie;
            int cp = 0;
            while (cp < inputStr.Length)
            {
                if (!cn.next.ContainsKey(inputStr[cp]))
                {
                    Console.WriteLine("False");
                    return;
                }
                cn = cn.next[inputStr[cp]];
                cp++;
            }
            Console.WriteLine("True");
        }

        private void buildTrie(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string cWord = words[i];
                Node cn = trie;
                foreach (char cc in cWord)
                {
                    if (!cn.next.ContainsKey(cc))
                        cn.addLetter(cc);
                    cn = cn.next[cc];
                }
            }
        }

        class Node
        {

            public char value;
            public Dictionary<char, Node> next;
            public Node(char value = new char())
            {
                next = new Dictionary<char, Node>();
                this.value = value;
            }

            public void addLetter(char letter)
            {
                next.Add(letter, new Node(letter));
            }
        }
    }
}

