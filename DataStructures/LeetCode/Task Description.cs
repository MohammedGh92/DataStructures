using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Utils;

namespace DataStructures.LeetCode
{
    public class Task_Description
    {
        /*
         
        Task Description
        A precedence rule is given as "P>E", which means that letter "P" is followed directly by the letter "E".
                Write a function, given an array of precedence rules, that finds the word represented by the given rules.

        Note: Each represented word contains a set of unique characters, i.e. the word does not contain duplicate letters.

        Examples:
        findWord(["P>E","E>R","R>U"]) // PERU
        findWord(["I>N","A>I","P>A","S>P"]) // SPAIN


        findWord(["U>N", "G>A", "R>Y", "H>U", "N>G", "A>R"]) // HUNGARY
        findWord(["I>F", "W>I", "S>W", "F>T"]) // SWIFT
        findWord(["R>T", "A>L", "P>O", "O>R", "G>A", "T>U", "U>G"]) // PORTUGAL
        findWord(["W>I", "R>L", "T>Z", "Z>E", "S>W", "E>R", "L>A", "A>N", "N>D", "I>T"]) // SWITZERLAND
         
         */
        string[] arr;
        public Task_Description()
        {
            arr = new string[] { "U>N", "G>A", "R>Y", "H>U", "N>G", "A>R" };
        }

        public string findWord()
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            HashSet<char> hash = new HashSet<char>();

            for (int i = 0; i < arr.Length; i++)
            {
                hash.Add(arr[i][0]);
                hash.Add(arr[i][2]);
                dict.Add(arr[i][0], arr[i][2]);
            }

            foreach (var item in dict)
                hash.Remove(item.Value);

            StringBuilder stringBuilder = new StringBuilder();
            char cc = new char();
            foreach (char chara in hash)
            {
                cc = chara;
                break;
            }
            buildStr(stringBuilder, dict, cc);
            return stringBuilder.ToString();
        }

        private void buildStr(StringBuilder stringBuilder, Dictionary<char, char> dict, char cc)
        {
            stringBuilder.Append(cc);
            if (dict.ContainsKey(cc))
                buildStr(stringBuilder, dict, dict[cc]);
        }
    }
}

