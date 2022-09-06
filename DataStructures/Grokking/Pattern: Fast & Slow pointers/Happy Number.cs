using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Happy_Number
    {

        public bool isAHappyNum(int num)
        {
            int sp = num;
            int fp = GetSum(num);
            while (sp != 1 && fp != 1)
            {
                sp = GetSum(sp);
                fp = GetSum(GetSum(fp));
                if (fp == sp)
                    return false;
            }
            return true;
        }

        public bool isAHappyNumUsingHash(int num)
        {

            HashSet<int> hash = new HashSet<int>();

            int cn = num;

            while (cn != 1)
            {
                if (hash.Contains(cn))
                    return false;
                hash.Add(cn);
                cn = GetSum(cn);
            }

            return true;
        }

        private int GetSum(int num)
        {
            string numStr = num.ToString();
            int sum = 0;

            for (int i = 0; i < numStr.Length; i++)
                sum += int.Parse("" + numStr[i]) * int.Parse("" + numStr[i]);
            return sum;
        }
    }
}
