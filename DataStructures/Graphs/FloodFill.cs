using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class FloodFill
    {
        int[][] image;
        int sr;
        int sc;
        int color;
        public FloodFill()
        {
            //image = [[1, 1, 1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
            image = new int[3][];
            image[0] = new int[3];
            image[1] = new int[3];
            image[2] = new int[3];
            image[0][0] = 1;
            image[0][1] = 1;
            image[0][2] = 1;

            image[1][0] = 1;
            image[1][1] = 1;

            image[2][0] = 1;
            image[2][2] = 1;

            sr = 1;
            sc = 1;
        }

        public void FillBFS()
        {
            //BFS
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            HashSet<Tuple<int, int>> hash = new HashSet<Tuple<int, int>>();
            Tuple<int, int> startPos = new Tuple<int, int>(sr, sc);
            queue.Enqueue(startPos);
            int sourceColor = image[startPos.Item1][startPos.Item2];
            while (queue.Count() > 0)
            {
                Tuple<int, int> cn = queue.Dequeue();
                Console.WriteLine(cn.Item1 + "," + cn.Item2);
                if (hash.Contains(cn))
                    continue;
                int cr = cn.Item1;
                int cc = cn.Item2;
                hash.Add(cn);
                image[cr][cc] = color;

                Tuple<int, int> upNode = new Tuple<int, int>(cr - 1, cc);
                Tuple<int, int> downNode = new Tuple<int, int>(cr + 1, cc);
                Tuple<int, int> leftNode = new Tuple<int, int>(cr, cc - 1);
                Tuple<int, int> rightNode = new Tuple<int, int>(cr, cc + 1);
                if (upNode.Item1 >= 0 && !hash.Contains(upNode) && image[upNode.Item1][upNode.Item2] == sourceColor)
                    queue.Enqueue(upNode);
                if (downNode.Item1 < image.Length && !hash.Contains(downNode) && image[downNode.Item1][downNode.Item2] == sourceColor)
                    queue.Enqueue(downNode);
                if (leftNode.Item2 >= 0 && !hash.Contains(leftNode) && image[leftNode.Item1][leftNode.Item2] == sourceColor)
                    queue.Enqueue(leftNode);
                if (rightNode.Item2 < image[rightNode.Item1].Length && !hash.Contains(rightNode) && image[rightNode.Item1][rightNode.Item2] == sourceColor)
                    queue.Enqueue(rightNode);

            }
        }

        public void FillDFS()
        {
            //DFS
            HashSet<Tuple<int, int>> hash = new HashSet<Tuple<int, int>>();
            Tuple<int, int> startPos = new Tuple<int, int>(sr, sc);
            int sourceColor = image[startPos.Item1][startPos.Item2];
            DFSSearch(hash, startPos.Item1, startPos.Item2, sourceColor);
            Print.Print2DArr(image);
        }

        private void DFSSearch(HashSet<Tuple<int, int>> hash, int row, int col, int sourceColor)
        {
            if (row >= image.Length || col >= image[0].Length || row < 0 || col < 0)
                return;
            if (image[row][col] != sourceColor)
                return;
            if (hash.Contains(new Tuple<int, int>(row, col)))
                return;
            image[row][col] = color;
            hash.Add(new Tuple<int, int>(row, col));
            //Up
            DFSSearch(hash, row - 1, col, sourceColor);
            //Down
            DFSSearch(hash, row + 1, col, sourceColor);
            //Left
            DFSSearch(hash, row, col - 1, sourceColor);
            //Right
            DFSSearch(hash, row, col + 1, sourceColor);
        }
    }
}
