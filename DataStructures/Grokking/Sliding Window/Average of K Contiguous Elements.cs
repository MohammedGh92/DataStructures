using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.P1SlidingWindow
{
    public class AverageOfKContiguousElements
    {

        int[] arr;
        int K;
        public AverageOfKContiguousElements()
        {
            arr = new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            K = 5;
        }

        public void findSol()
        {
            List<float> resList = new List<float>();
            int left = 0;
            int right = 1;
            int cSum = arr[left];
            while (right < arr.Length)
            {
                cSum += arr[right];
                if (right - left >= 4)
                {
                    resList.Add(((float)cSum / (float)5));
                    cSum -= arr[left];
                    left++;
                }
                right++;
            }
            for (int i = 0; i < resList.Count; i++)
                Console.WriteLine(resList[i]);
        }
    }
}