using System;
using DataStructures.Utils;

namespace DataStructures.Grokking.TwoHeaps
{
    public class Sliding_Window_Median
    {
        int[] nums;
        int k;
        public Sliding_Window_Median()
        {
            //nums = new int[] { 1, 2, -1, 3, 5 };
            //k = 2;
            nums = new int[] { 1, 2, -1, 3, 5 };
            k = 3;
        }

        public double[] findSlidingWindowMedian()
        {
            double[] res = new double[nums.Length - k + 1];
            Queue<int> q = new Queue<int>();
            double csum = 0;
            int resIndx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                q.Enqueue(nums[i]);
                csum += nums[i];
                if (q.Count() >= k)
                {
                    if (q.Count() > k)
                        csum -= q.Dequeue();
                    res[resIndx] = (double)(csum / k);
                    resIndx++;
                }
            }

            for (int i = 0; i < res.Length; i++)
                Console.WriteLine(res[i]);

            return res;
        }
    }
}

