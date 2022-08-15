using System;
namespace DataStructures.Grokking.TwoPointers
{
    public class Triplets_with_Smaller_Sum
    {
        int[] arr;
        int target;
        public Triplets_with_Smaller_Sum()
        {
            //arr = new int[] { -1, 0, 2, 3 };
            //target = 3;
            arr = new int[] { -1, 4, 2, 1, 3 };
            target = 5;
        }

        public int searchTriplets()
        {
            Console.WriteLine("=========");
            int resCount = 0;
            Array.Sort(arr);
            int cp = 0;

            //-1,1,2,3,4
            while (cp < arr.Length - 2)
            {
                int cn = arr[cp];
                int left = cp + 1;
                int right = left + 1;

                while (left < arr.Length - 1)
                {
                    int csum = cn + arr[left] + arr[right];
                    if (csum >= target)
                        break;
                    if (cn == arr[right] || arr[left] == arr[right])
                        right++;
                    else
                    {
                        Console.WriteLine(cn + "," + arr[left] + "," + arr[right]);
                        resCount++;
                        right++;
                    }
                    if (right >= arr.Length)
                    {
                        left++;
                        right = left + 1;
                    }
                }
                cp++;
            }
            return resCount;
        }
    }
}
