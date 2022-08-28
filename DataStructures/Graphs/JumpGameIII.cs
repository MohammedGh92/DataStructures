using System;
namespace DataStructures.Graphs
{
    public class JumpGameIII
    {
        int[] arr;
        int start;
        public JumpGameIII()
        {
            arr = new int[] { 4, 2, 3, 0, 3, 1, 2 };
            start = 5;
        }

        public bool CanReach()
        {
            bool res = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count() > 0)
            {
                int cn = queue.Dequeue();
                if (cn < 0 || cn >= arr.Length || arr[cn] == -1)
                    continue;
                if (arr[cn] == 0)
                    return true;
                if (cn < arr.Length)
                {
                    int cand1 = cn + arr[cn];
                    queue.Enqueue(cand1);
                }

                if (cn >= 0)
                {
                    int cand2 = cn - arr[cn];
                    queue.Enqueue(cand2);
                }
                arr[cn] = -1;

            }
            return res;
        }
    }
}
