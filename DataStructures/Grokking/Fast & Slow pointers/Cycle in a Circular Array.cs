using System;
using System.Collections.Generic;

namespace DataStructures.Grokking.PatternFastSlowpointers
{
    public class Cycle_in_a_Circular_Array
    {
        int[] arr;
        public Cycle_in_a_Circular_Array()
        {
            //arr = new int[] { 1, 2, -1, 2, 2 };
            //arr = new int[] { 2, 2, -1, 2 };
            //arr = new int[] { 2, 1, -1, -2 };
            //arr = new int[] { -1, -2, -3, -4, -5 };
            //arr = new int[] { 2, -1, 1, 2, 2 };
            //arr = new int[] { -2, 1, -1, -2, -2 };
            arr = new int[] { 3, 1, 2 };
        }

        public bool loopExists()
        {

            for (int i = 0; i < arr.Length; i++)
            {
                bool isForward = arr[i] >= 0; // if we are moving forward or not
                int slow = i, fast = i;

                // if slow or fast becomes '-1' this means we can't find cycle for this number
                do
                {
                    slow = findNextIndex(arr, isForward, slow); // move one step for slow pointer
                    fast = findNextIndex(arr, isForward, fast); // move one step for fast pointer
                    if (fast != -1)
                        fast = findNextIndex(arr, isForward, fast); // move another step for fast pointer
                } while (slow != -1 && fast != -1 && slow != fast);

                if (slow != -1 && slow == fast)
                    return true;
            }

            return false;
        }

        private static int findNextIndex(int[] arr, bool isForward, int currentIndex)
        {
            bool direction = arr[currentIndex] >= 0;
            if (isForward != direction)
                return -1; // change in direction, return -1

            int nextIndex = (currentIndex + arr[currentIndex]) % arr.Length;
            if (nextIndex < 0)
                nextIndex += arr.Length; // wrap around for negative numbers

            // one element cycle, return -1 
            if (nextIndex == currentIndex)
                nextIndex = -1;

            return nextIndex;
        }


        private int getCircularIndx(int curIndx, int[] arr)
        {
            while (curIndx >= arr.Length)
                curIndx = curIndx - arr.Length;
            while (curIndx < 0)
                curIndx = curIndx + arr.Length;
            return curIndx;
        }


        public bool loopExistsUsingHash()
        {
            HashSet<int> hash = new HashSet<int>();
            //1.loop throgh all nums
            for (int i = 0; i < arr.Length; i++)
            {
                hash = new HashSet<int>();
                int curDir = arr[i] > 0 ? 1 : 0;//1 is forward, 0 is back
                if (arr[i] == 0)
                    continue;
                int curIndx = i;
                hash.Add(curIndx);
                while (true)
                {

                    curIndx += arr[curIndx];
                    while (curIndx >= arr.Length)
                        curIndx = curIndx - arr.Length;
                    while (curIndx < 0)
                        curIndx = curIndx + arr.Length;
                    if (curDir == 1 && arr[curIndx] < 0)
                        break;
                    if (curDir == 0 && arr[curIndx] > 0)
                        break;
                    if (hash.Contains(curIndx))
                    {
                        if (hash.Count > 1 && curIndx == i)
                            return true;
                        else
                            break;

                    }
                    hash.Add(curIndx);
                }
            }
            return false;
        }
    }
}
