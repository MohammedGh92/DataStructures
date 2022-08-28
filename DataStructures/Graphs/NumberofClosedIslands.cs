using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class NumberofClosedIslands
    {
        int[][] grid;
        private int rowCount, colCount;
        internal NumberofClosedIslands()
        {
            //grid = [[1, 1, 1, 1, 1, 1, 1, 0],[1,0,0,0,0,1,1,0],
            //[1,0,1,0,1,1,1,0],[1,0,0,0,0,1,0,1],[1,1,1,1,1,1,1,0]];
            grid = new int[5][];
            grid[0] = new int[] { 1, 1, 1, 1, 1, 1, 1, 0 };
            grid[1] = new int[] { 1, 0, 0, 0, 0, 1, 1, 0 };
            grid[2] = new int[] { 1, 0, 1, 0, 1, 1, 1, 0 };
            grid[3] = new int[] { 1, 0, 0, 0, 0, 1, 0, 1 };
            grid[4] = new int[] { 1, 1, 1, 1, 1, 1, 1, 0 };

        }

        internal int getNuOfClosedIslands()
        {
            int sum = 0;
            rowCount = grid.Length;
            colCount = grid[0].Length;
            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    if (grid[r][c] == 0 && IsEnclosed(r, c))
                        sum++;
                }
            }

            return sum;
        }

        private bool IsEnclosed(int r, int c)
        {

            if (r < 0 || r >= rowCount || c < 0 || c >= colCount)
                return false;

            if (grid[r][c] != 0)
                return true;

            grid[r][c] = 2;

            bool res = true;

            res &= IsEnclosed(r - 1, c);
            res &= IsEnclosed(r + 1, c);
            res &= IsEnclosed(r, c - 1);
            res &= IsEnclosed(r, c + 1);
            return res;

        }
    }
}
