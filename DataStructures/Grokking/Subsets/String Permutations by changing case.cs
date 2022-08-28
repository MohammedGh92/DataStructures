using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.Subsets
{
    public class String_Permutations_by_changing_case
    {
        string str;
        public String_Permutations_by_changing_case()
        {
            //str = "ab52";
            str = "C";
        }

        public List<string> findLetterCaseStringPermutations()
        {
            Console.WriteLine("======2======");
            List<string> strList = new List<string>();
            char[] strChar = str.ToCharArray();
            strList.Add(new string(strChar));
            for (int i = 0; i < strChar.Length; i++)
            {
                char cc = strChar[i];
                if (!char.IsLetter(cc))
                    continue;
                int cs = strList.Count;
                for (int y = 0; y < cs; y++)
                {
                    char[] newRes = strList[y].ToCharArray();
                    if (Char.IsLower(cc))
                        newRes[i] = char.ToUpper(newRes[i]);
                    else
                        newRes[i] = char.ToLower(newRes[i]);
                    strList.Add(new string(newRes));
                }
            }
            return strList;
        }
    }
}