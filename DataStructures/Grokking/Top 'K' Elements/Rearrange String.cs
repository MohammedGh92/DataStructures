using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Grokking.TopKElements
{
    public class Rearrange_String
    {
        string str;
        public Rearrange_String()
        {
            str = "Programming";
        }

        public string rearrangeString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)//O(n)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 0);
                dict[str[i]]++;
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);//NLogn
            while (dict.Count > 0)
            {
                foreach (var item in dict)
                {
                    stringBuilder.Append(item.Key);
                    dict[item.Key]--;
                    if (dict[item.Key] <= 0)
                        dict.Remove(item.Key);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
