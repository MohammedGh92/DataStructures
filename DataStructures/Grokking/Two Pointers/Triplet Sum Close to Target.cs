using System;
namespace DataStructures.Grokking.TwoPointers
{
    public class Triplet_Sum_Close_to_Target
    {
        int[] arr;
        int target;
        public Triplet_Sum_Close_to_Target()
        {
            //arr = new int[] { -3, -1, 1, 2 };
            //target = 1;
            //arr = new int[] { -2, 0, 1, 2 };
            //target = 2;
            arr = new int[] { 1, 0, 1, 1 };
            target = 100;
        }

        public int searchTriplet()
        {
            Array.Sort(arr);
            int cp = 0;
            int left;
            int right;
            int smallestDiff = int.MaxValue;
            while (cp < arr.Length - 2)
            {
                left = cp + 1;
                right = arr.Length - 1;
                while (left < right)
                {
                    int cDiff = target - arr[cp] - arr[left] - arr[right];
                    if (cDiff == 0)
                        return target;

                    if ((Math.Abs(cDiff) < Math.Abs(smallestDiff)) || (Math.Abs(cDiff) == Math.Abs(smallestDiff) &&
                            cDiff > smallestDiff))
                        smallestDiff = cDiff;
                    if (cDiff > 0)
                        left++;
                    else
                        right--;
                }
                cp++;
            }
            return target - smallestDiff;
        }
    }
}
