using System;
using System.Text;

namespace DataStructures.Grokking.P2TwoPointers
{
    public class Comparing_Strings_containing_Backspaces
    {
        string str1;
        string str2;
        public Comparing_Strings_containing_Backspaces()
        {
            str1 = "xywrrmp";
            str2 = "xywrrmu#p";
        }

        public bool compare()
        {

            int p1 = str1.Length - 1;
            int p2 = str2.Length - 1;
            int p1RemoveCounter = 0;
            int p2RemoveCounter = 0;

            while (p1 >= 0 && p2 >= 0)
            {

                if (str1[p1] == '#')
                {
                    p1RemoveCounter++;
                    p1--;
                    continue;
                }

                if (str2[p2] == '#')
                {
                    p2RemoveCounter++;
                    p2--;
                    continue;
                }

                if (p1RemoveCounter > 0)
                {
                    p1--;
                    p1RemoveCounter--;
                    continue;
                }

                if (p2RemoveCounter > 0)
                {
                    p2--;
                    p2RemoveCounter--;
                    continue;
                }

                if (str1[p1] != str2[p2])
                    return false;
                p1--;
                p2--;
            }

            return true;

        }
    }
}
