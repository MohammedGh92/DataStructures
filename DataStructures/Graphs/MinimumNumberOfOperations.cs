using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataStructures.Graphs
{
    public class MinimumNumberOfOperations
    {

        int N;
        int M;
        public MinimumNumberOfOperations()
        {
            N = 10;
            M = 15;
        }

        public int solution()
        {
            int level = 0;
            Queue<int> q = new Queue<int>();
            Queue<int> p = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            q.Enqueue(N);
            while (q.Count() > 0)
            {
                //1.pop front
                int front = q.Dequeue();
                //2.check goal
                if (front == M)
                    return level;
                //3.check naighbours
                for (int i = 1; i <= 6; i++)
                {
                    int cand = Oper(front, i);
                    if (!visited.Contains(cand))
                    {
                        p.Enqueue(cand);
                        visited.Add(cand);
                    }
                }
                //4.check level
                if (q.Count() == 0)
                {
                    q = p;
                    p = new Queue<int>();
                    level++;
                }

            }
            return level;
        }

        private int Oper(int n, int operationNu)    
        {
            switch (operationNu)
            {
                case 1: return n * 2;
                case 2: return n * 3;
                case 3: return n / 2;
                case 4: return n / 3;
                case 5: return n + 7;
                case 6: return n - 7;
            }
            throw new NotImplementedException();
        }
    }
}
