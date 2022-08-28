using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Utils;

namespace DataStructures.Grokking.Subsets
{
    public class Unique_Generalized_Abbreviations
    {
        string str;
        public Unique_Generalized_Abbreviations()
        {
            str = "BAT";
        }

        public List<string> generateGeneralizedAbbreviation()
        {
            List<string> resList = new List<string>();

            Queue<StringBuilder> q = new Queue<StringBuilder>();
            Queue<StringBuilder> p = new Queue<StringBuilder>();
            q.Enqueue(new StringBuilder());

            for (int i = 0; i < str.Length; i++)
            {
                while (q.Count() > 0)
                {
                    //1.pop front
                    StringBuilder front = q.Dequeue();
                    StringBuilder front2 = new StringBuilder(front.ToString());
                    //2.check next level
                    front.Append(1);
                    p.Enqueue(front);
                    front2.Append(str[i]);
                    p.Enqueue(front2);

                }//1,B => 11,1A,B1,BA => 111,1A1,B11,BA1,11T,1AT,B1T,BAT => 3,1A1,B2,BA1,2T,1AT,B1T,BAT
                q = p;
                p = new Queue<StringBuilder>();
            }

            while (q.Count() > 0)
                resList.Add(fixStr(q.Dequeue().ToString()));

            for (int i = 0; i < resList.Count; i++)
                Console.WriteLine(resList[i]);

            return resList;
        }

        private string fixStr(string str)
        {
            char[] strChar = str.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            int ccount = 0;
            for (int i = 0; i < strChar.Length; i++)
            {
                char cc = strChar[i];
                if (char.IsDigit(cc))
                    ccount++;
                else
                {
                    if (ccount > 0)
                    {
                        stringBuilder.Append(ccount);
                    }
                    stringBuilder.Append(cc);
                    ccount = 0;
                }
            }
            if (ccount > 0)
                stringBuilder.Append(ccount);
            return stringBuilder.ToString();
        }
    }
}
