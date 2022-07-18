using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class ShortestPathinBinaryMatrix
    {
        int[][] grid;
        public ShortestPathinBinaryMatrix()
        {
            //grid = [[0, 0, 0],[1,1,0],[1,1,0]]
            grid = new int[2][];
            grid[0] = new int[] { 0, 1 };
            grid[1] = new int[] { 1, 0 };
            //grid[2] = new int[] { 1, 1, 0 };
        }

        public int ShortestPathBinaryMatrix()
        {
            Queue<Node> q = new Queue<Node>();
            Queue<Node> p = new Queue<Node>();
            int level = 0;
            if (grid[0][0] != 0)
                return -1;
            q.Enqueue(new Node(0, 0));
            while (q.Count() > 0)
            {
                //1.pop front
                Node front = q.Dequeue();
                Console.WriteLine(level + "," + front.r + "," + front.c);
                //2.check goal, front == bottom right cell
                if (front.r == grid.Length - 1 && front.c == grid[0].Length - 1)
                    return level + 1;
                //3.check neighbours

                //3.1 up
                if (front.r > 0)
                {
                    if (grid[front.r - 1][front.c] == 0)
                    {
                        p.Enqueue(new Node(front.r - 1, front.c));
                        grid[front.r - 1][front.c] = 1;
                    }
                    //left
                    if (front.c > 0 && grid[front.r - 1][front.c - 1] == 0)
                    {
                        p.Enqueue(new Node(front.r - 1, front.c - 1));
                        grid[front.r - 1][front.c - 1] = 1;
                    }
                    //right
                    if (front.c < grid[0].Length - 1 && grid[front.r - 1][front.c + 1] == 0)
                    {
                        p.Enqueue(new Node(front.r - 1, front.c + 1));
                        grid[front.r - 1][front.c + 1] = 1;
                    }
                }
                //3.2 down
                if (front.r < grid.Length - 1)
                {
                    if (grid[front.r + 1][front.c] == 0)
                    {
                        p.Enqueue(new Node(front.r + 1, front.c));
                        grid[front.r + 1][front.c] = 1;
                    }
                    if (front.c > 0 && grid[front.r + 1][front.c - 1] == 0)
                    {
                        p.Enqueue(new Node(front.r + 1, front.c - 1));
                        grid[front.r + 1][front.c - 1] = 1;
                    }
                    //right
                    if (front.c < grid[0].Length - 1 && grid[front.r + 1][front.c + 1] == 0)
                    {
                        p.Enqueue(new Node(front.r + 1, front.c + 1));
                        grid[front.r + 1][front.c + 1] = 1;
                    }
                }
                //3.3 left
                if (front.c > 0 && grid[front.r][front.c - 1] == 0)
                {
                    p.Enqueue(new Node(front.r, front.c - 1));
                    grid[front.r][front.c - 1] = 1;
                }
                //3.4 right
                if (front.c < grid[front.r].Length - 1 && grid[front.r][front.c + 1] == 0)
                {
                    p.Enqueue(new Node(front.r, front.c + 1));
                    grid[front.r][front.c + 1] = 1;
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
