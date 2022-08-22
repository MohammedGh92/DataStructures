using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Grokking.Kwaymerge
{
    public class K_Pairs_with_Largest_Sums
    {
        int[] arr1;
        int[] arr2;
        int k;
        public K_Pairs_with_Largest_Sums()
        {
            arr1 = new int[] { 9, 8, 2 };
            arr2 = new int[] { 6, 3, 1 };
            k = 3;
        }

        public List<int[]> findKLargestPairs()
        {
            List<int[]> resList = new List<int[]>();
            Dictionary<int[], int> dict = new Dictionary<int[], int>();
            for (int i = 0; i < arr1.Length; i++)
                for (int y = 0; y < arr2.Length; y++)
                    dict.Add(new int[] { arr1[i], arr2[y] }, arr1[i] + arr2[y]);

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