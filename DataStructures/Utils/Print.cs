using System;
using System.Collections.Generic;

namespace DataStructures.Utils
{
    public class Print
    {
        public static void PrintArr(int[] arr)
        {
            Console.WriteLine("======");
            for (int i = 0; i < arr.Length; i++)
                if (i == arr.Length - 1)
                    Console.Write(arr[i]);
                else
                    Console.Write(arr[i] + ",");
            Console.WriteLine("\n======");
        }

        public static void PrintDict(dynamic dict)
        {
            Console.WriteLine("======");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }
            Console.WriteLine("\n======");
        }
    }
}
