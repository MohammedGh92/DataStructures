using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.CyclicSort
{
    public class Find_the_First_K_Missing_Positive_Numbers
    {
        int[] arr;
        int k;
        public Find_the_First_K_Missing_Positive_Numbers()
        {
            arr = new int[] { 3, -1, 4, 5, 5 };
            k = 3;
        }

        public List<int> findNumbers()
        {
            Sort(arr);
            List<int> missingNumbers = new List<int>();
            HashSet<int> extraNumbers = new HashSet<int>();
            for (int i = 0; i < arr.Length && missingNumbers.Count < k; i++)
            {
                if (arr[i] != i + 1)
                {
                    missingNumbers.Add(i + 1);
                    extraNumbers.Add(arr[i]);
                }
            }
            // add the remaining missing numbers
            for (int i = 1; missingNumbers.Count < k; i++)
            {
                int candidateNumber = i + arr.Length;
                // ignore if the array contains the candidate number
                if (!extraNumbers.Contains(candidateNumber))
                    missingNumbers.Add(candidateNumber);
            }
            Print.PrintList(missingNumbers);
            return missingNumbers;
        }

        private void Sort(int[] arr)
        {
            int i = 0;

            while (i < arr.Length)
            {
                if (arr[i] <= 0)
                    i++;
                if (arr[i] > arr.Length)
                    i++;
                if (arr[i] != arr[arr[i] - 1])
                    swap(arr, i, arr[i] - 1);
                else
                    i++;
            }
        }

        private void swap(int[] arr, int i, int v)
        {
            int temp = arr[i];
            arr[i] = arr[v];
            arr[v] = temp;
        }
    }
}
