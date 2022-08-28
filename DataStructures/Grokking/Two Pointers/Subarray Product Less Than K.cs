using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.TwoPointers
{
    public class Subarray_Product_Less_Than_K
    {
        int[] arr;
        int target;
        public Subarray_Product_Less_Than_K()
        {
            arr = new int[] { 2, 5, 3, 10 };
            target = 30;
        }

        public List<List<int>> findSubarrays()
        {
            Console.WriteLine("===========================");
            List<List<int>> resList = new List<List<int>>();
            for (int i = 0; i < arr.Length; i++)
            {
                int csum = arr[i];
                List<int> ccList = new List<int>();
                ccList.Add(arr[i]);
                int cp = i + 1;
                if (csum < target)
                {
                    Print.PrintList(ccList);
                    resList.Add(ccList);
                }
                while (cp < arr.Length)
                {
                    csum *= arr[cp];
                    if (csum < target)
                    {

                        ccList.Add(arr[cp]);
                        resList.Add(ccList);
                        Print.PrintList(ccList);
                        cp++;
                    }
                    else
                        break;
                }
            }

            return resList;

        }
    }
}
