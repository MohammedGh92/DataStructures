using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.TopKElements
{
    public class _K__Closest_Numbers
    {
        int[] arr;
        int k;
        int x;
        public _K__Closest_Numbers()
        {
            arr = new int[] { 1, 2, 8, 8, 9 };
            k = 3;
            x = 7;
        }

        public List<int> findClosestElements()
        {
            List<int> resList = new List<int>();
            //1.Find closestIndx by binary search
            int closestIndx = getClosesetIndxByBinarySearch();
            resList.Add(arr[closestIndx]);
            //2.set two pointer, one on the left and one on the right
            int left = closestIndx - 1;
            int right = closestIndx + 1;

            while (resList.Count < k)
            {
                if (left < 0)
                {
                    resList.Add(arr[right]);
                    right++;
                }
                else if (right > arr.Length - 1)
                {
                    resList.Add(arr[left]);
                    left--;
                }
                else
                {
                    int rightDiff = Math.Abs(x - arr[right]);
                    int leftDiff = Math.Abs(x - arr[left]);
                    if (rightDiff < leftDiff)
                    {
                        resList.Add(arr[right]);
                        right++;
                    }
                    else
                    {
                        resList.Add(arr[left]);
                        left--;
                    }
                }
            }

            return resList;
        }

        private int getClosesetIndxByBinarySearch()
        {
            int left = 0;
            int right = arr.Length - 1;
            if (x <= arr[0])
                return 0;
            if (x >= arr[arr.Length - 1])
                return arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                    return mid;
                else if (arr[mid] < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return left;
        }

    }
}
