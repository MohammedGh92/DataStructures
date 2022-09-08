using System;
namespace DataStructures.Grokking.TwoHeaps
{
    public class medianSlidingWindow
    {
        //Java
        //int[] nums;
        //int k;
        //public medianSlidingWindow()
        //{
        //    nums = new int[] { 1, 2, -1, 3, 5 };
        //    k = 3;
        //}

        //private PriorityQueue<Interger> minHeap;
        //private PriorityQueue<Interger> maxHeap;
        //public double[] findSlidingWindowMedian()
        //{
        //    minHeap = new PriorityQueue<Interger>();
        //    maxHeap = new PriorityQueue<Interger>();
        //    double[] res = new double[nums.Length - k + 1];

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int num = nums[i];
        //        if (maxHeap.Empty() || maxHeap.Peek() >= num)
        //            maxHeap.add(num);
        //        else
        //            minHeap.add(num);
        //        balanceHeaps();
        //        int curResIndx = i - k + 1;
        //        if (curResIndx >= 0)
        //        {
        //            if (maxHeap.Size() == minHeap.Size())
        //                res[curResIndx] = maxHeap.Peek() / 2.0 + minHeap.Peek() / 2.0;
        //            else
        //                res[curResIndx] = maxHeap.Peek();
        //        }

        //        int removeElement = nums[curResIndx];
        //        if(removeElement<maxHeap.Peek())
        //            maxHeap.remove(removeElement);
        //        else
        //            minHeap.remove(removeElement);
        //        balanceHeaps();
        //    }
        //    return res;
        //}

        //private void balanceHeaps()
        //{
        //    if (maxHeap.Size() > minHeap.Size() + 1)
        //        minHeap.add(maxHeap.poll());
        //    else if (maxHeap.Size() < minHeap.Size())
        //        maxHeap.add(minHeap.poll());
        //}
    }
}

