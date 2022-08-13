using System;
using System.Collections.Generic;

namespace DataStructures.DynamicProgramming
{
    public class Fibonacci
    {
        public int fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int[] memo = new int[n];

            memo[0] = 0;
            memo[1] = 1;

            for (int i = 2; i < n; i++)
                memo[i] = memo[i - 1] + memo[i - 2];

            return memo[n - 1] + memo[n - 2];

        }

        int[] memo;
        public int fibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            if (memo == null)
                memo = new int[n + 1];
            if (memo[n] != 0)
                return memo[n];
            return memo[n] = fibonacciRecursive(n - 1) + fibonacciRecursive(n - 2);
        }
    }
}
