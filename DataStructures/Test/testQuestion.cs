using System;
using System.Collections.Generic;

namespace DataStructures.Test
{
    public class testQuestion
    {
        public List<int[]> list;
        private Dictionary<int, int> dict;
        public testQuestion()
        {
            /**
            Given a long row/line of spots, we will have N operations in which we install solar panels in each of the spots within a given range.
            However, we only install new panels in spots where no panels have been previously installed.
            The requirement is to output the number of panel installations for each operation/line of input.
            Example:
            [1:40]
            [11, 14]
             1.discuss input
             2.discuss soltuion or approach
             3.writing sol
             4.validtion + explain time and space
                1. A:1-5 - B:1-2
                2. A:1-2 - B:1-5
                3. A:1-5 - B:3-6
                4. A:2-5 - B:1-3
             */
            list = new List<int[]>();
            list.Add(new int[] { 4, 10 });
            list.Add(new int[] { 7, 13 });
            list.Add(new int[] { 20, 30 });
            list.Add(new int[] { 1, 40 });
            dict = new Dictionary<int, int>();
        }


        public int AddCommand(int[] command)
        {
            int sum = 0;


            foreach (var interval in dict)
            {
                if (commadBiggerThanIntersection(command, interval))
                {
                    if (sum == 0)
                        sum = command[1] - command[0];
                    sum -= diffOfBigger(command, interval);
                    Console.WriteLine("sum:" + diffOfBigger(command, interval));
                    dict.Remove(interval.Key);
                }
                else if (thereIsIntersection(command, interval))//There is intersection
                {
                    Console.WriteLine("Here");
                    return sum + comparer(command, interval);
                }
            }
            if (sum != 0)
            {
                dict.Add(command[0], command[1]);
                return Math.Abs(sum) + 1;
            }
            sum = command[1] - command[0];
            dict.Add(command[0], command[1]);
            return sum + 1;
        }

        private int diffOfBigger(int[] command, KeyValuePair<int, int> interval)
        {
            int sum = 0;
            int start = command[0];
            int end = command[1];

            sum += interval.Key - start;
            sum += end - interval.Value;

            return sum;
        }

        private bool commadBiggerThanIntersection(int[] command, KeyValuePair<int, int> interval)
        {
            int start = command[0];
            int end = command[1];
            return start <= interval.Key && end >= interval.Value;
        }

        private int comparer(int[] command, KeyValuePair<int, int> interval)
        {
            int sum = 0;

            int start = command[0];
            int end = command[1];

            //1.A:1 - 5 | B:1 - 2
            //2.A:1 - 2 | B:1 - 5
            //3.A:1 - 5 | B:3 - 6
            //4.A:2 - 5 | B:1 - 3


            if (start < interval.Key)
                sum += interval.Key - start;
            if (end > interval.Value)
                sum += end - interval.Value;

            int min = Math.Min(start, interval.Key);
            int max = Math.Max(end, interval.Value);

            dict.Remove(interval.Key);
            dict.Add(min, max);

            return sum;
        }

        private bool thereIsIntersection(int[] command, KeyValuePair<int, int> interval)
        {
            //Intersection on start
            int start = command[0];
            int end = command[1];
            if (start >= interval.Key && start <= interval.Value)
                return true;
            //Intersection on start
            if (end >= interval.Key && end <= interval.Value)
                return true;
            return false;
        }
    }
}
