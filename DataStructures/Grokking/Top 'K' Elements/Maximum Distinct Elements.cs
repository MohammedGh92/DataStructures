using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Grokking.TopKElements
{
    public class Maximum_Distinct_Elements
    {
        int[] arr;
        int k;
        public Maximum_Distinct_Elements()
        {
            arr = new int[] { 7, 3, 5, 8, 5, 3, 3 };
            k = 2;
        }

        public int findMaximumDistinctElements()
        {
            int res = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 0);
                dict[arr[i]]++;
            }
            dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                if (k == 0)
                    break;

                while (k > 0 && dict[item.Key] > 1)
                {
                    dict[item.Key]--;
                    k--;
                }
            }


            foreach (var item in dict)
            {
                if (k == 0)
                    break;
                dict.Remove(item.Key);
                k--;
            }


            foreach (var item in dict)
            {
                if (item.Value == 1)
                    res++;
                else
                    break;
            }

            return res;
        }
    }
}
