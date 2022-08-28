using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class SnakesAndLadders2
    {

        public SnakesAndLadders2()
        {
            CreateGame();
        }

        int[][] snakes;
        int[][] ladders;
        int boardSize;
        public void CreateGame()
        {
            snakes = new int[4][];
            snakes[0] = new int[] { 27, 1 };
            snakes[1] = new int[] { 21, 9 };
            snakes[2] = new int[] { 17, 4 };
            snakes[3] = new int[] { 19, 7 };

            ladders = new int[4][];
            ladders[0] = new int[] { 11, 26 };
            ladders[1] = new int[] { 3, 22 };
            ladders[2] = new int[] { 5, 8 };
            ladders[3] = new int[] { 20, 29 };

            boardSize = 30;
        }

        public void findShortestPath()
        {
            Console.WriteLine(solution());
        }

        int solution()
        {
            Dictionary<int, int> snakesDict = GetSnakesDict();
            Dictionary<int, int> laddersDict = GetLaddersDict();
            HashSet<int> hash = new HashSet<int>();
            Queue<int> q, p;
            int level = 0;
            q = new Queue<int>();
            p = new Queue<int>();
            q.Enqueue(1);
            while (q.Count() > 0)
            {

                //1.Pop front
                int front = q.Dequeue();
                //2.Check if goal
                if (front == boardSize)
                    return level;

                //3.check neighbours
                for (int i = front + 1; i <= boardSize && i <= front + 6; i++)
                {
                    if (hash.Contains(i))
                        continue;
                    hash.Add(i);
                    if (!laddersDict.ContainsKey(i) && !snakesDict.ContainsKey(i))
                        p.Enqueue(i);//no ladder or snake
                    else
                    {
                        if (laddersDict.ContainsKey(i))
                            p.Enqueue(laddersDict[i]);
                        if (snakesDict.ContainsKey(i))
                            p.Enqueue(snakesDict[i]);
                    }
                }
                //4.check level
                if (q.Count() == 0)
                {
                    level++;
                    q = p;
                    p = new Queue<int>();
                }
            }
            return 0;
        }

        private Dictionary<int, int> GetSnakesDict()
        {
            Dictionary<int, int> dictRes = new Dictionary<int, int>();
            for (int i = 0; i < snakes.Length; i++)
                dictRes.Add(snakes[i][0], snakes[i][1]);
            return dictRes;
        }

        private Dictionary<int, int> GetLaddersDict()
        {
            Dictionary<int, int> dictRes = new Dictionary<int, int>();
            for (int i = 0; i < ladders.Length; i++)
                dictRes.Add(ladders[i][0], ladders[i][1]);
            return dictRes;
        }
    }
}
