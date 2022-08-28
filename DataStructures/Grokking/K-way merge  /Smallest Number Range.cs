using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.Kwaymerge
{
    public class Smallest_Number_Range
    {
        int[][] arrays;
        public Smallest_Number_Range()
        {
            arrays = new int[3][];
            arrays[0] = new int[3];
            arrays[1] = new int[2];
            arrays[2] = new int[3];
            arrays[0][0] = 1;
            arrays[0][1] = 5;
            arrays[0][2] = 8;

            arrays[1][0] = 4;
            arrays[1][1] = 12;

            arrays[2][0] = 7;
            arrays[2][1] = 8;
            arrays[2][2] = 10;
        }

        public int[] findSmallestRange()
        {

            int[] resArr = new int[2];

            int[] pointers = new int[arrays.Length];

            bool stillThereNums = true;
            int smallestDiff = int.MaxValue;
            while (stillThereNums)
            {
                int minPointerIndx = -1;
                int minVal = int.MaxValue;
                int minArrIndx = -1;

                int maxPointerIndx = -1;
                int maxVal = int.MinValue;

                for (int i = 0; i < pointers.Length; i++)
                {
                    if (minPointerIndx == -1 || arrays[i][pointers[i]] <= minVal)
                    {
                        minPointerIndx = i;
                        minArrIndx = i;
                        minVal = arrays[i][pointers[i]];
                    }

                    if (maxPointerIndx == -1 || arrays[i][pointers[i]] >= maxVal)
                    {
                        maxPointerIndx = i;
                        maxVal = arrays[i][pointers[i]];
                    }
                }
                int curDiff = Math.Abs(maxVal - minVal);
                //Console.WriteLine(curDiff + "," + smallestDiff);
                if (curDiff < smallestDiff)
                {
                    smallestDiff = curDiff;
                    resArr[0] = minVal;
                    resArr[1] = maxVal;
                }
                pointers[minPointerIndx]++;
                stillThereNums = pointers[minPointerIndx] < arrays[minArrIndx].Length;
            }

            return resArr;
        }

        public int[] findSmallestRangeOpimized()
        {
            int m = arrays.Length, n = arrays[0].Length;
            SortedSet<(int val, int i, int j)> heap = new SortedSet<(int val, int i, int j)>();
            for (int i = 0; i < m; i++)
                heap.Add((arrays[i][0], i, 0));
            int rangeMin = 0, rangeMax = int.MaxValue;
            while (heap.Count > 0)
            {
                var min = heap.Min;
                var max = heap.Max;
                if (rangeMax - rangeMin > max.val - min.val)
                {
                    rangeMin = min.val;
                    rangeMax = max.val;
                }
                heap.Remove(min);
                var nextI = min.i;
                var nextJ = min.j + 1;
                if (nextJ == arrays[nextI].Length)
                {
                    Console.WriteLine(rangeMin + "," + rangeMax);
                    return new int[] { rangeMin, rangeMax };
                }
                heap.Add((arrays[nextI][nextJ], nextI, nextJ));
            }
            return new int[0];
        }
    }
}