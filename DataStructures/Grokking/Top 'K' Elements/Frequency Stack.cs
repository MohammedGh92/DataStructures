using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.TopKElements
{
    public class Frequency_Stack
    {

        Dictionary<int, int> dict;

        public Frequency_Stack()
        {
            dict = new Dictionary<int, int>();
        }

        internal void checkSol()
        {
            //push(1), push(2), push(3), push(2), push(1), push(2), push(5)
            Push(1);
            Push(2);
            Push(3);
            Push(2);
            Push(1);
            Push(2);
            Push(5);

            for (int i = 0; i < 3; i++)
                Console.WriteLine(Pop());
        }

        private void Push(int nu)
        {
            if (!dict.ContainsKey(nu))
                dict.Add(nu, 0);
            dict[nu]++;
        }

        private int Pop()
        {

            int maxOccNu = 0;
            int resNu = 0;
            foreach (var item in dict)
            {
                if (item.Value > maxOccNu)
                {
                    resNu = item.Key;
                    maxOccNu = item.Value;
                }
            }

            dict[resNu]--;
            return resNu;

        }
    }
}
