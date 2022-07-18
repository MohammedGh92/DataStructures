using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class SnakesAndLadders
    {
        public void CreateGame()
        {
            int[][] snakes = new int[4][];
            snakes[0] = new int[] { 27, 1 };
            snakes[1] = new int[] { 21, 9 };
            snakes[2] = new int[] { 17, 4 };
            snakes[3] = new int[] { 19, 7 };

            int[][] ladders = new int[4][];
            ladders[0] = new int[] { 11, 26 };
            ladders[1] = new int[] { 3, 22 };
            ladders[2] = new int[] { 5, 8 };
            ladders[3] = new int[] { 20, 29 };
            createBoard(30, snakes, ladders);
        }

        public void CreateGame(int boardSize, int[][] snakes, int[][] ladders)
        {
            createBoard(boardSize, snakes, ladders);
        }

        public void createBoard(int boardSize, int[][] snakes, int[][] ladders)
        {

        }

        public void findShortestPath()
        {

            int boardSize = 36;
            int[][] snakes = new int[5][];
            snakes[0] = new int[] { 32, 30 };
            snakes[1] = new int[] { 20, 6 };
            snakes[2] = new int[] { 17, 4 };
            snakes[3] = new int[] { 24, 16 };
            snakes[4] = new int[] { 34, 12 };

            int[][] ladders = new int[5][];
            ladders[0] = new int[] { 25, 35 };
            ladders[1] = new int[] { 9, 27 };
            ladders[2] = new int[] { 18, 29 };
            ladders[3] = new int[] { 5, 7 };
            ladders[4] = new int[] { 2, 15 };

            Console.WriteLine("Min Dice throws required is "
                              + solution(boardSize, snakes, ladders));
        }

        Dictionary<int, int> snakesDict;
        Dictionary<int, int> laddersDict;
        private int solution(int boardSize, int[][] snakes, int[][] ladders)
        {

            setSnakesToDict(ref snakesDict, snakes);
            setLaddersToDict(ref laddersDict, ladders);
            int[] visited = new int[boardSize];
            Queue<node> queue = new Queue<node>();
            node cn = new node();
            cn.pos = 0;
            cn.nuOfDiceThrows = 0;
            cn.prevPath = "1";
            visited[0] = 1;
            queue.Enqueue(cn);
            while (queue.Count() != 0)
            {
                cn = queue.Dequeue();
                if (cn.pos >= boardSize - 1)
                    break;
                for (int i = cn.pos + 1; i <= (cn.pos + 6) && i < boardSize; i++)
                {
                    if (visited[i] == 0)
                    {
                        node nextNode = new node();
                        nextNode.nuOfDiceThrows = cn.nuOfDiceThrows + 1;
                        nextNode.pos = i;
                        visited[i] = 1;
                        nextNode.prevPath = cn.prevPath + "," + i;
                        addLaddersAndSnakes(ref visited, ref queue, nextNode);
                        queue.Enqueue(nextNode);
                    }
                }
            }
            return cn.nuOfDiceThrows;
        }

        private void addLaddersAndSnakes(ref int[] visited, ref Queue<node> queue, node curNode)
        {
            if (laddersDict.ContainsKey(curNode.pos))
            {
                curNode.pos = laddersDict[curNode.pos];
                queue.Enqueue(curNode);
                addLaddersAndSnakes(ref visited, ref queue, curNode);
            }
            if (snakesDict.ContainsKey(curNode.pos))
            {
                curNode.pos = snakesDict[curNode.pos];
                queue.Enqueue(curNode);
                addLaddersAndSnakes(ref visited, ref queue, curNode);
            }

        }

        private void setSnakesToDict(ref Dictionary<int, int> snakesDict, int[][] snakes)
        {
            snakesDict = new Dictionary<int, int>();
            for (int i = 0; i < snakes.Length; i++)
                snakesDict.Add(snakes[i][0], snakes[i][1]);

        }

        private void setLaddersToDict(ref Dictionary<int, int> laddersDict, int[][] ladders)
        {
            laddersDict = new Dictionary<int, int>();
            for (int i = 0; i < ladders.Length; i++)
                laddersDict.Add(ladders[i][0], ladders[i][1]);
        }


        private class node
        {
            public string prevPath;
            public int pos;
            public int nuOfDiceThrows;
        }

    }
}
