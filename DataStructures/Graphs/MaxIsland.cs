using System;
namespace DataStructures.Graphs
{
    public class MaxIsland
    {
        int[][] matrix;
        public MaxIsland(int[][] matrix)
        {

        }

        public MaxIsland()
        {
            //[0, 0, 0, 0, 1, 1, 1],
            //[0, 0, 0, 0, 1, 1, 0],
            //[0, 1, 1, 1, 1, 1, 1],
            //[1, 1, 1, 0, 0, 1, 1],
            //[1, 1, 1, 1, 0, 1, 1],
            matrix = new int[5][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new int[7];
            matrix[0][4] = matrix[0][5] = matrix[0][6] = 1;
            matrix[1][4] = matrix[1][5] = 1;
            matrix[2][1] = matrix[2][2] = matrix[2][3] = matrix[2][4] = matrix[2][5] = matrix[2][6] = 1;
            matrix[3][0] = matrix[3][1] = matrix[3][2] = matrix[3][5] = matrix[3][6] = 1;
            matrix[4][0] = matrix[4][1] = matrix[4][2] = matrix[4][3] = matrix[4][5] = matrix[4][6] = 1;
        }

        public int findMaxIsland()
        {
            int res = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int y = 0; y < matrix[i].Length; y++)
                {
                    res = Math.Max(getMaxIsland(i, y), res);
                }
            }

            return res;
        }

        private int getMaxIsland(int row, int col)
        {
            if (row >= matrix.Length || col >= matrix[0].Length || row < 0 || col < 0)
                return 0;
            if (matrix[row][col] == 1)
                return 0;
            matrix[row][col] = 1;
            return 1 + getMaxIsland(row, col - 1) + getMaxIsland(row, col + 1) + getMaxIsland(row + 1, col) + getMaxIsland(row + 1, col);
        }
    }
}
