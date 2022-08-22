using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Grokking.TopKElements
{
    public class Frequency_Sort
    {
        string str;
        public Frequency_Sort()
        {
            str = "Programming";
        }

        public String sortCharacterByFrequency()
        {


            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {

                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 0);
                dict[str[i]]++;

            }


            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var cc in dict)
            {
                for (int i = 0; i < cc.Value; i++)
                    stringBuilder.Append(cc.Key);
            }


            return stringBuilder.ToString();
        }
    }
}
