using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures.Utils;

namespace DataStructures.Grokking.TopKElements
{
    public class Kth_Largest_Number_in_a_Stream
    {
        int[] arr;
        List<int> list;
        int k;
        public Kth_Largest_Number_in_a_Stream()
        {

            arr = new int[] { 3, 1, 5, 12, 2, 11 };
            k = 4;
            list = arr.ToList();
            list.Sort();
        }

        public int add(int num)
        {

            if (num < arr[0])
                list.Insert(0, num);
            else if (num >= arr[arr.Length - 1])
                list.Insert(arr.Length + 1, num);
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                    if (num >= arr[i] && num < arr[i + 1])
                    {
                        list.Insert(i + 2, num);
                        break;
                    }
            }

            int counter = k;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                counter--;
                if (counter == 0)
                {
                    return list[i];
                }
            }
            return -1;
        }
    }
}
