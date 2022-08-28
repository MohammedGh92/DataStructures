using System;
using System.Collections.Generic;

namespace DataStructures.Utils
{
    internal class Print
    {
        internal static void PrintArr(int[] arr)
        {
            Console.WriteLine("======");
            for (int i = 0; i < arr.Length; i++)
                if (i == arr.Length - 1)
                    Console.Write(arr[i]);
                else
                    Console.Write(arr[i] + ",");
            Console.WriteLine("\n======");
        }

        internal static void PrintList(List<int> list)
        {
            Console.WriteLine("======");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.WriteLine("\n======");
        }


        internal static void Print2DArr(int[][] arr)
        {
            Console.WriteLine("======");
            for (int i = 0; i < arr.Length; i++)
                for (int y = 0; y < arr[i].Length; y++)
                    Console.WriteLine(arr[i][y]);
            Console.WriteLine("\n======");
        }

        internal static void Print2DArr(int[,] arr, bool withPos)
        {
            Console.WriteLine("======");
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int y = 0; y < arr.GetLength(1); y++)
                    if (withPos)
                        Console.WriteLine(i + "," + y + ":" + arr[i, y]);
                    else
                        Console.WriteLine(arr[i, y]);
            Console.WriteLine("\n======");
        }

        internal static void PrintDict(dynamic dict)
        {
            Console.WriteLine("======");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + "," + item.Value);
            }
            Console.WriteLine("\n======");
        }

        internal static void PrintHash(dynamic hash)
        {
            Console.WriteLine("======");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n======");
        }
    }
}
