using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class RottingOranges
    {
        int[][] grid;
        public RottingOranges()
        {
            grid = new int[3][];
            grid[0] = new int[] { 2, 1, 1 };
            grid[1] = new int[] { 1, 1, 1 };
            grid[2] = new int[] { 0, 1, 2 };
        }

        public int OrangesRotting()
        {
            Queue<Node> q = new Queue<Node>();
            Queue<Node> p = new Queue<Node>();
            int level = 0;
            int numOfFreshs = 0;
            HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
            //0.loop over all the oranges,
            //add rotten to the queue, and count the number of fresh
            for (int r = 0; r < grid.Length; r++)
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == 1)
                        numOfFreshs++;
                    else if (grid[r][c] == 2)
                        q.Enqueue(new Node(r, c));
                }
            if (numOfFreshs == 0)
                return 0;
            while (q.Count() > 0)
            {
                //1.pop front
                Node cn = q.Dequeue();
                Console.WriteLine(level + "," + cn.r + "," + cn.c);
                grid[cn.r][cn.c] = 2;
                if (level > 0)
                    numOfFreshs--;
                //2.check goal, number of rotten == number of fresh
                if (numOfFreshs == 0)
                    return level;
                //3.check neighbours

                //3.1 up
                if (cn.r > 0 && grid[cn.r - 1][cn.c] == 1 && !visited.Contains(new Tuple<int, int>(cn.r - 1, cn.c)))
                {
                    p.Enqueue(new Node(cn.r - 1, cn.c));
                    visited.Add(new Tuple<int, int>(cn.r - 1, cn.c));
                }
                //3.2 down
                if (cn.r < grid.Length - 1 && grid[cn.r + 1][cn.c] == 1 && !visited.Contains(new Tuple<int, int>(cn.r + 1, cn.c)))
                {
                    p.Enqueue(new Node(cn.r + 1, cn.c));
                    visited.Add(new Tuple<int, int>(cn.r + 1, cn.c));
                }
                //3.3 left
                if (cn.c > 0 && grid[cn.r][cn.c - 1] == 1 && !visited.Contains(new Tuple<int, int>(cn.r, cn.c - 1)))
                {
                    p.Enqueue(new Node(cn.r, cn.c - 1));
                    visited.Add(new Tuple<int, int>(cn.r, cn.c - 1));
                }
                //3.4 right
                if (cn.c < grid[cn.r].Length - 1 && grid[cn.r][cn.c + 1] == 1 && !visited.Contains(new Tuple<int, int>(cn.r, cn.c + 1)))
                {
                    p.Enqueue(new Node(cn.r, cn.c + 1));
                    visited.Add(new Tuple<int, int>(cn.r, cn.c + 1));
                }

                //4.check level (swap)
                if (q.Count() == 0)
                {
                    level++;
                    q = p;
                    p = new Queue<Node>();
                }

            }

            return -1;
        }

        private class Node
        {
            public int r;
            public int c;
            public Node(int r, int c)
            {
                this.r = r;
                this.c = c;
            }
            public Node() { }
        }
    }
}
