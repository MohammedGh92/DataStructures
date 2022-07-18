using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class SwiminRisingWater
    {
        int[][] grid;

        public SwiminRisingWater()
        {
            grid = new int[5][];
            grid[0] = new int[] { 0, 1, 2, 3, 4 };
            grid[1] = new int[] { 24, 23, 22, 21, 5 };
            grid[2] = new int[] { 12, 13, 14, 15, 16 };
            grid[3] = new int[] { 11, 17, 18, 19, 20 };
            grid[4] = new int[] { 10, 9, 8, 7, 6 };
        }

        public int SwimInWater()
        {
            int N = grid.Length;
            bool[][] b = new bool[N][];
            int time = -1;
            for (int i = 0; i < N; i++)
            {
                b[i] = new bool[N];
                for (int j = 0; j < N; j++)
                {
                    b[i][j] = false;
                }
            }
            while (!b[N - 1][N - 1])
            {
                time++;
                if (grid[0][0] > time)
                {
                    continue;
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        b[i][j] = false;
                    }
                }
                dfs(grid, 0, 0, time, b);
            }
            return time;
        }
        public void dfs(int[][] grid, int x, int y, int time, bool[][] havebeen)
        {
            havebeen[x][y] = true;
            if (havebeen[grid.Length - 1][grid.Length - 1])
            {
                return;
            }
            if (x != 0 && !havebeen[x - 1][y] && grid[x - 1][y] <= time)
            {
                dfs(grid, x - 1, y, time, havebeen);
            }
            if (y != 0 && !havebeen[x][y - 1] && grid[x][y - 1] <= time)
            {
                dfs(grid, x, y - 1, time, havebeen);
            }
            if (x != grid.Length - 1 && !havebeen[x + 1][y] && grid[x + 1][y] <= time)
            {
                dfs(grid, x + 1, y, time, havebeen);
            }
            if (y != grid.Length - 1 && !havebeen[x][y + 1] && grid[x][y + 1] <= time)
            {
                dfs(grid, x, y + 1, time, havebeen);
            }
        }


    }
}
