using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Grokking.TwoPointers
{
    public class Quadruple_Sum_to_Target
    {
        int[] arr;
        int target;
        public Quadruple_Sum_to_Target()
        {
            //arr = new int[] { 4, 1, 2, -1, 1, -3 };
            //target = 1;
            arr = new int[] { 2, 0, -1, 1, -2, 2 };
            target = 2;
        }

        public List<List<int>> searchQuadruplets()
        {
            List<List<int>> resList = new List<List<int>>();


            Array.Sort(arr);

            int cp = 0;

            while (cp < arr.Length - 3)
            {
                if (cp > 0 && arr[cp] == arr[cp - 1])
                {
                    cp++;
                    continue;
                }
                int cp2 = cp + 1;
                while (cp2 < arr.Length - 2)
                {
                    if (cp2 > 1 && arr[cp2] == arr[cp2 - 1])
                    {
                        cp2++;
                        continue;
                    }
                    int left = cp2 + 1;
                    int right = arr.Length - 1;
                    while (left < right)
                    {
                        int cpcp2Sum = arr[cp] + arr[cp2];
                        int leftRightSum = arr[left] + arr[right];
                        int totalSum = cpcp2Sum + leftRightSum;
                        if (totalSum == target)
                        {
                            List<int> newList = new List<int>();

                            newList.Add(arr[cp]);
                            newList.Add(arr[cp2]);
                            newList.Add(arr[left]);
                            newList.Add(arr[right]);
                            Print.PrintList(newList);
                            left++;
                            right--;
                        }
                        else if (totalSum > target)
                            right--;
                        else
                            left++;
                    }
                    cp2++;
                }
                cp++;
            }
            return resList;
        }

    }
}