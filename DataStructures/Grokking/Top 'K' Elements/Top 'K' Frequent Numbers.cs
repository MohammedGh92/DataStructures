using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Grokking.TopKElements
{
    public class Top__K__Frequent_Numbers
    {
        int[] arr;
        int k;
        public Top__K__Frequent_Numbers()
        {
            arr = new int[] { 1, 3, 5, 12, 11, 12, 11 };
            k = 2;
        }

        public List<int> findTopKFrequentNumbers()
        {
            List<int> resList = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 0);
                dict[arr[i]]++;
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int counter = 0;
            foreach (var item in dict)
            {
                resList.Add(item.Key);
                counter++;
                if (counter == k)
                    break;
            }
            return resList;
        }
    }
}
