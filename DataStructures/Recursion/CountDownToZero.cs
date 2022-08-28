using System;
namespace DataStructures.Recursion
{
    public class CountDownToZero
    {

        public void CountToZero(int n)
        {
            Console.WriteLine(n);
            if (n == 0)
                return;
            CountToZero(n - 1);
        }

    }
}
