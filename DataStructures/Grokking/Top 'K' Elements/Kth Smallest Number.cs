using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.TopKElements
{
    public class Kth_Smallest_Number
    {
        int[] arr;
        int K;
        public Kth_Smallest_Number()
        {
            arr = new int[] { 3, 1, 5, 12, 2, 11 };
            K = 3;
        }

        public List<int> BruteForce()
        {
            List<int> res = new List<int>();

            Array.Sort(arr);
            int resIndx = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                res.Add(arr[i]);
                resIndx++;
                if (resIndx == K)
                    break;
            }
            return res;
        }

        public List<int> findKLargestNumbers()
        {
            List<int> res = new List<int>();

            Heap minHeap = new Heap(arr, true);
            minHeap.build();
            for (int i = 0; i < K; i++)
                res.Add(minHeap.getSortedArr()[i]);

            return res;
        }
    }
}
