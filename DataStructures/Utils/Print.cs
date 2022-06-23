using System;
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
    }
}
