
using System;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class UniquePaths
    {
        int m;
        int n;
        public UniquePaths()
        {
            m = 3;
            n = 2;
        }

        int[,] memo;
        public int GetUniquePaths()
        {
            memo = new int[m, n];
            checkPath(0, 0);
            Print.Print2DArr(memo, true);
            return 0;
        }

        private int checkPath(int v1, int v2)
        {
            if (v1 == m - 1 && v2 == n - 1)
                return 1;
            if (memo[v1, v2] != 0)
                return memo[v1, v2];

            int res = 0;
            if (v1 < m - 1)
                res += checkPath(v1 + 1, v2);
            if (v2 < n - 1)
                res += checkPath(v1, v2 + 1);
            memo[v1, v2] = res;
            return res;
        }
    }
}