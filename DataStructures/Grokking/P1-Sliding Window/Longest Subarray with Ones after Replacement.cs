using System;
namespace DataStructures.Grokking.P1SlidingWindow
{
    public class Longest_Subarray_with_Ones_after_Replacement
    {

        int[] arr;
        int k;
        public Longest_Subarray_with_Ones_after_Replacement()
        {
            arr = new int[] { 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1 };
            k = 3;
        }

        public int findLength()
        {

            int maxLength = 0;
            int startWin = 0;
            int zeros = 0;
            int ones = 0;
            for (int endWin = 0; endWin < arr.Length; endWin++)
            {

                if (arr[endWin] == 0)
                    zeros++;
                else
                    ones++;

                while (zeros > k)
                {

                    int startN = arr[startWin];
                    if (startN == 0)
                        zeros--;
                    else
                        ones--;
                    startWin++;
                }
                maxLength = Math.Max(maxLength, endWin - (startWin - 1));

            }

            return maxLength;
        }
    }
}
