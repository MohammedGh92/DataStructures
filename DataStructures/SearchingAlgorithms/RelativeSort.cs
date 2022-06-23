using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.SearchingAlgorithms
{
    public class RelativeSort
    {
        private static int[] sortRelative(int[] arr1, int[] arr2)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (dict.ContainsKey(arr1[i]))
                    dict[arr1[i]]++;
                else
                    dict[arr1[i]] = 1;
            }

            int cp = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                while (dict[arr2[i]] > 0)
                {
                    arr1[cp] = arr2[i];
                    cp++;
                    dict[arr2[i]]--;
                }
            }
            foreach (var num in dict.OrderBy(key => key.Key))
            {
                while (dict[num.Key] > 0)
                {
                    arr1[cp] = num.Key;
                    dict[num.Key]--;
                    cp++;
                }
            }

            return arr1;

        }
    }
}
