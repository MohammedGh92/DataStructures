using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.Subsets
{
    public class Balanced_Parentheses
    {
        int N;
        public Balanced_Parentheses()
        {
            N = 3;
        }

        public List<string> generateValidParentheses()
        {
            List<string> resList = new List<string>();

            Queue<parenthes> q = new Queue<parenthes>();
            Queue<parenthes> p = new Queue<parenthes>();
            q.Enqueue(new parenthes());
            while (q.Count() > 0)
            {
                //1.pop front
                parenthes front = q.Dequeue();
                //2.check goal
                if (front.opened == N && front.closed == N)
                    resList.Add(front.s);
                else
                {
                    //3.check naighbours
                    string str;
                    if (front.opened < N)
                    {
                        str = front.s;
                        str += "(";
                        parenthes newPar = new parenthes();
                        newPar.s = str;
                        newPar.opened = front.opened + 1;
                        newPar.closed = front.closed;
                        p.Enqueue(newPar);
                    }
                    if (front.closed < N && front.closed < front.opened)
                    {
                        str = front.s;
                        str += ")";
                        parenthes newPar = new parenthes();
                        newPar.s = str;
                        newPar.opened = front.opened;
                        newPar.closed = front.closed + 1;
                        p.Enqueue(newPar);
                    }
                }
                //4.check level
                if (q.Count() == 0)
                {
                    q = p;
                    p = new Queue<parenthes>();
                }
            }

            for (int i = 0; i < resList.Count; i++)
                Console.WriteLine(resList[i]);

            return resList;
        }
    }

    public class parenthes
    {
        public string s;
        public int opened;
        public int closed;
    }
}
