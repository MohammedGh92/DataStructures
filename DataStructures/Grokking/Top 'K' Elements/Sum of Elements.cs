using System;
namespace DataStructures.Grokking.TopKElements
{
    public class Sum_of_Elements
    {
        int[] arr;
        int k1;
        int k2;
        public Sum_of_Elements()
        {
            arr = new int[] { 3, 5, 8, 7 };
            k1 = 1;
            k2 = 4;
        }

        public int findSumOfElements()
        {
            int sum = 0;

            Array.Sort(arr);

            int cn = k1;
            cn++;
            while (cn < k2)
            {
                sum += arr[cn - 1];
                cn++;
            }

            Console.WriteLine(sum);

            return sum;
        }
    }
}
