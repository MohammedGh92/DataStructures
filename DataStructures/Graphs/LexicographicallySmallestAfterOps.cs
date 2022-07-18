using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public class LexicographicallySmallestAfterOps
    {
        string s;
        int a;
        int b;
        public LexicographicallySmallestAfterOps()
        {
            s = "5525";
            a = 9;
            b = 2;

        }

        public string FindLexSmallestString()
        {
            string _s = s;
            //.bfs
            Queue<string> queue = new Queue<string>();
            HashSet<string> hash = new HashSet<string>();
            queue.Enqueue(_s);

            while (queue.Count() > 0)
            {
                string cs = queue.Dequeue();
                if (hash.Contains(cs))
                    continue;
                //.check each time if its lex smaller
                if (string.CompareOrdinal(cs, _s) < 0)
                    _s = cs;
                //.add each new case to a hash
                hash.Add(cs);

                //.add Method
                string addStr = AddMethod(cs);
                //.rotate Method
                string rotateStr = RotateMethod(cs);

                if (!hash.Contains(addStr))
                    queue.Enqueue(addStr);
                if (!hash.Contains(rotateStr))
                    queue.Enqueue(rotateStr);
            }
            //.its will end auto when hash contain all possible sols
            return _s;
        }

        private string RotateMethod(string cs)
        {
            return cs.Substring(b, cs.Length - b) + cs.Substring(0, b);
        }

        private string AddMethod(string cs)
        {
            char[] csArr = cs.ToCharArray();

            for (int i = 1; i < cs.Length; i += 2)
            {
                int cCharNu = int.Parse(csArr[i] + "");
                cCharNu += a;
                cCharNu %= 10;
                csArr[i] = char.Parse(cCharNu + "");
            }
            return new string(csArr);
        }

        private bool isLexSmaller(string cs, string s)
        {
            for (int i = 0; i < cs.Length; i++)
                if (cs[i] < s[i])
                    return true;
            return false;
        }
    }
}
