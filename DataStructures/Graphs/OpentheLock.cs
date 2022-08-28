using System;
using System.Collections.Generic;
using DataStructures.Utils;

namespace DataStructures.Graphs
{
    public class OpentheLock
    {
        string[] deadends;
        string target;
        public OpentheLock()
        {
            deadends = new string[] { "0201", "0101", "0102", "1212", "2002" };
            target = "0202";
        }

        public int OpenLock()
        {
            HashSet<string> deadEndsHash = setDeadends(deadends);
            HashSet<string> visited = new HashSet<string>();
            Queue<string> q = new Queue<string>();
            Queue<string> p = new Queue<string>();
            int level = 0;
            q.Enqueue("0000");
            if (deadEndsHash.Contains("0000"))
                return -1;
            while (q.Count() > 0)
            {
                //1.Pop Front
                string front = q.Dequeue();
                //2.check goal
                if (front == target)
                    return level;
                //3.check naighbours
                for (int i = 0; i < 4; i++)
                {
                    char[] strToCharArr = front.ToCharArray();
                    int charNu = int.Parse("" + strToCharArr[i]);
                    int PlusNu = charNu + 1;
                    if (PlusNu > 9)
                        PlusNu = 0;
                    int MinNu = charNu - 1;
                    if (MinNu < 0)
                        MinNu = 9;
                    string newNuStrPlused = "";
                    string newNuStMinus = "";
                    strToCharArr[i] = (char)(PlusNu + 48);
                    newNuStrPlused = new string(strToCharArr);
                    strToCharArr[i] = (char)(MinNu + 48);
                    newNuStMinus = new string(strToCharArr);

                    if (!visited.Contains(newNuStrPlused) && !deadEndsHash.Contains(newNuStrPlused))
                    {
                        visited.Add(newNuStrPlused);
                        p.Enqueue(newNuStrPlused);
                    }

                    if (!visited.Contains(newNuStMinus) && !deadEndsHash.Contains(newNuStMinus))
                    {
                        visited.Add(newNuStMinus);
                        p.Enqueue(newNuStMinus);
                    }

                }
                //4.check level
                if (q.Count() == 0)
                {
                    q = p;
                    p = new Queue<string>();
                    level++;
                }
            }
            return -1;
        }

        private HashSet<string> setDeadends(string[] deadends)
        {
            return new HashSet<string>(deadends);
        }
    }
}
