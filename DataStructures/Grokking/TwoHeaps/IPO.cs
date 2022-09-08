using System;
namespace DataStructures.Grokking.TwoHeaps
{
    public class IPO
    {
        //Java
        //int numberOfProjects;
        //int initialCapital;
        //int[] profits;
        //int[] capital;
        //public IPO()
        //{
        //    profits = new int[] { 1, 2, 3 };
        //    capital = new int[] { 0, 1, 1 };
        //    numberOfProjects = 3;
        //    initialCapital = 0;
        //}

        //public int findMaximizedCapital(int numberOfProjects, int initialCapital, int[] profits, int[] capital)
        //{
        //    int n = profits.length;
        //    PriorityQueue<Integer> minCapitalHeap = new PriorityQueue<>(n, (i1, i2)->capital[i1] - capital[i2]);
        //    PriorityQueue<Integer> maxProfitHeap = new PriorityQueue<>(n, (i1, i2)->profits[i2] - profits[i1]);
        //    for (int i = 0; i < n; i++)
        //        minCapitalHeap.offer(i);
        //    int availableCapital = initialCapital;
        //    for (int i = 0; i < numberOfProjects; i++)
        //    {
        //        while (!minCapitalHeap.isEmpty() && capital[minCapitalHeap.peek()] <= availableCapital)
        //            maxProfitHeap.add(minCapitalHeap.poll());
        //        if (maxProfitHeap.isEmpty())
        //            break;
        //        availableCapital += profits[maxProfitHeap.poll()];
        //    }
        //    return availableCapital;
        //}
    }
}

