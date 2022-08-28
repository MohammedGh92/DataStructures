using System;
namespace DataStructures.Grokking.Kwaymerge
{
    public class Kth_Smallest_Number_in_M_Sorted_Lists
    {
        int[][] arrays;
        int k;
        public Kth_Smallest_Number_in_M_Sorted_Lists()
        {
            arrays = new int[3][];
            for (int i = 0; i < arrays.Length; i++)
                arrays[i] = new int[3];
            arrays[0][0] = 2;
            arrays[0][1] = 6;
            arrays[0][2] = 8;

            arrays[1][0] = 3;
            arrays[1][1] = 6;
            arrays[1][2] = 7;

            arrays[2][0] = 1;
            arrays[2][1] = 3;
            arrays[2][2] = 4;

            k = 5;
        }

        public int findKthSmallest()
        {
            int[] pointers = new int[arrays.Length];
            int cc = 1;
            while (getLowestOne(pointers) != -1)
            {
                if (cc == k)
                    return arrays[arrayIndx][pointers[pointerIndx]];
                pointers[pointerIndx]++;
                cc++;
            }

            return -1;
        }

        private int pointerIndx;
        private int arrayIndx;
        private int getLowestOne(int[] pointers)
        {
            int res = -1;
            pointerIndx = -1;
            int minVal = int.MaxValue;
            for (int i = 0; i < pointers.Length; i++)
            {
                if (pointers[i] >= arrays[i].Length)
                    continue;
                if (res == -1)
                {
                    res = pointers[i];
                    arrayIndx = i;
                    pointerIndx = pointers[i];
                    minVal = arrays[i][pointers[i]];
                }
                else
                {
                    if (arrays[i][pointers[i]] < minVal)
                    {
                        res = i;
                        pointerIndx = pointers[res];
                        arrayIndx = i;
                        minVal = arrays[i][pointers[i]];
                    }
                }

            }
            pointerIndx = res;
            return res;

        }
    }
}
