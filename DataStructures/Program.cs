using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinWindow("ADOBECODEBANC", "ABC"));

        }

        private static string MinWindow(string s, string t)
        {
            Dictionary<char, int> tDict = new Dictionary<char, int>();
            Dictionary<char, int> windowDict = new Dictionary<char, int>();
            //1-put t in a dict
            //2-start a loop for s and keep adding characters
            //3-each character we add we increase its occ in windowDict
            //4-each time we increase windowDict, we check if all its occ are equal or higher that
            //tDict, if yes we consider as sol and we safe left and right, if its lower, we keep
            //adding, if its higher, then start poping out characters from our window
            //5-when we finish, we return the res left and res right


            //Implementaion:
            //1-put t in a dict, Checked.
            for (int i = 0; i < t.Length; i++)
            {
                char cc = t[i];
                if (tDict.ContainsKey(cc))
                    tDict[cc]++;
                else
                    tDict[cc] = 1;
            }

            int left = 0;
            int resLeft = -1;
            int resRight = -1;
            //2-start a loop for s and keep adding characters,Checked
            for (int i = 0; i < s.Length; i++)
            {
                char newChar = s[i];
                //3-each character we add we increase its occ in windowDict,Checked
                if (windowDict.ContainsKey(newChar))
                    windowDict[newChar]++;
                else
                    windowDict[newChar] = 1;

                //4-each time we increase windowDict, we check if all its occ are equal or higher than
                //tDict,Checked.
                while (isSol(windowDict, tDict))
                {
                    //4.1:if found a sol, we store left and right if they are lower than prev sol,Checked.
                    if (resLeft == -1)
                    {
                        resLeft = left;
                        resRight = i;
                    }
                    else
                    {
                        if (i - left < resRight - resLeft)
                        {
                            resLeft = left;
                            resRight = i;
                        }
                    }
                    //4.2:if its sol, we keep increasing left pointer to find smaller sol,Checked.
                    char leftChar = s[left];
                    if (windowDict.ContainsKey(leftChar))
                        windowDict[leftChar]--;
                    left++;
                }
            }

            //5:return substring, checking
            if (resLeft == -1)
                return "";
            else
                return s.Substring(resLeft, resRight + 1 - resLeft);
        }

        private static bool isSol(Dictionary<char, int> windowDict, Dictionary<char, int> tDict)
        {
            foreach (var c in tDict)
            {

                if (!windowDict.ContainsKey(c.Key))
                    return false;
                if (windowDict[c.Key] < c.Value)
                    return false;

            }
            return true;
        }
    }
}