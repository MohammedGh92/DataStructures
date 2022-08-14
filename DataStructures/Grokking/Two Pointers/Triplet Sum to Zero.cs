using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.TwoPointers
{
    public class Triplet_Sum_to_Zero
    {
        int[] arr;
        public Triplet_Sum_to_Zero()
        {
            arr = new int[] { -3, 0, 1, 2, -1, 1, -2 };
        }

        public List<List<int>> searchTriplets()
        {
            List<List<int>> resList = new List<List<int>>();
            Array.Sort(arr);
            //-3, 0, 1, 2, -1, 1, -2
            //-3,-2,-1,0,1,1,2
            int cp = 0;
            int left;
            int right;
            while (cp < arr.Length - 3)
            {
                int cn = arr[cp];
                if (cp > 0 && cn == arr[cp - 1])
                {
                    cp++;
                    continue;
                }
                left = cp + 1;
                right = arr.Length - 1;
                while (left < right)
                {
                    int sum = cn + arr[left] + arr[right];
                    if (sum == 0)
                    {
                        List<int> newSol = new List<int>();
                        newSol.Add(arr[cp]);
                        newSol.Add(arr[left]);
                        newSol.Add(arr[right]);
                        resList.Add(newSol);
                        Print.PrintList(newSol);
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;
                }
                cp++;
            }
            return resList;

        }
    }
}
