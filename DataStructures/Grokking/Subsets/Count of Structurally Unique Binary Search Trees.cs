using System;
namespace DataStructures.Grokking.Subsets
{
    public class Count_of_Structurally_Unique_Binary_Search_Trees
    {
        public Count_of_Structurally_Unique_Binary_Search_Trees()
        {
        }

        int[] memo;
        public int countTrees(int n)
        {
            if (n <= 1)
                return 1;
            if (memo == null)
            {
                memo = new int[n + 1];
                memo[0] = 1;
                memo[1] = 1;
            }
            if (memo[n] != 0)
            {
                Console.WriteLine("Here");
                return memo[n];
            }
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int countOfLeftSub = countTrees(i - 1);
                int countOfRightSub = countTrees(n - i);
                count += countOfLeftSub * countOfRightSub;
            }
            memo[n] = count;
            return count;
        }
    }
}