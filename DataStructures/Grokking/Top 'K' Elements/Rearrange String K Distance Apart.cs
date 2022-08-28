using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Grokking.TopKElements
{
    public class Rearrange_String_K_Distance_Apart
    {
        string str;
        int k;
        public Rearrange_String_K_Distance_Apart()
        {
            str = "Programming";
            k = 3;
        }

        public string reorganizeString()
        {

            StringBuilder stringBuilder = new StringBuilder();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 0);
                dict[str[i]]++;
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);//NLogn
            int curPos = 0;
            int counter = 0;
            bool firstOne = true;
            char firstChar = new char();
            while (dict.Count > 0)
            {
                foreach (var item in dict)
                {
                    if (firstOne)
                    {
                        firstOne = false;
                        firstChar = item.Key;
                    }
                    if (item.Key == firstChar)
                    {
                        if (curPos > 0)
                        {
                            if (counter - curPos < k)
                                return "";
                            else
                                curPos = counter;
                        }
                        else
                            curPos = counter;
                    }
                    stringBuilder.Append(item.Key);
                    dict[item.Key]--;
                    if (dict[item.Key] <= 0)
                        dict.Remove(item.Key);
                    counter++;
                }
            }

            return stringBuilder.ToString();

        }

    }
}
