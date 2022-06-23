using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.SearchingAlgorithms;
using DataStructures.Utils;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            Print.PrintArr(intersectionOfTwoArrays(nums1, nums2));
        }

        private static int[] intersectionOfTwoArrays(int[] nums1, int[] nums2)
        {
            HashSet<int> nums1Hash = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++)
                nums1Hash.Add(nums1[i]);

            List<int> list = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums1Hash.Contains(nums2[i]))
                    list.Add(nums2[i]);
            }

            int[] resArr = new int[list.Count];

            for (int i = 0; i < list.Count; i++)
                resArr[i] = list[i];

            return resArr;
        }
    }
}
