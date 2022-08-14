using System;
namespace DataStructures.Grokking.TwoPointers
{
    public class Remove_Duplicates
    {
        int[] arr;
        public Remove_Duplicates()
        {
            arr = new int[] { 2, 2, 2, 11 };
        }

        public int remove()
        {
            int res = 1;
            int left = 0;
            int right = 1;

            while (right < arr.Length)
            {
                if (arr[left] == arr[right])
                    right++;
                else
                {
                    left = right;
                    right += 1;
                    res++;
                }
            }

            return res;
        }
    }
}
