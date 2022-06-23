using System;
namespace DataStructures.SearchingAlgorithms
{
    public class BinarySearch
    {
        public static int search(int[] arr, int Nu, bool returnExpectedPos=false)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == Nu)
                    return mid;
                else if (arr[mid] < Nu)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            if (returnExpectedPos)
                return left;
            else
                return -1;//Not Found
        }

        public static int search(char[] arr, char c)
        {
            int left = 0;
            int right = arr.Length - 1;
            int mid = 0;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (arr[mid] <= c)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return mid;
        }
    }
}
