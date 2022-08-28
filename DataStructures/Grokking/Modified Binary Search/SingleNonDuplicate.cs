using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class SingleNonDuplicate
    {
        int[] nums;
        public SingleNonDuplicate()
        {
            nums = new int[] { 3, 3, 7, 7, 10, 11, 11 };
        }

        public int findSingleDupNum()
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if ((mid + 1) < nums.Length && nums[mid] == nums[mid + 1])
                {
                    if ((nums.Length - mid + 1) % 2 != 0)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else if ((mid - 1) >= 0 && nums[mid] == nums[mid - 1])
                {
                    if ((mid + 1) % 2 != 0)
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                else
                {
                    Console.WriteLine("Here 1");
                    return nums[mid];
                }
            }
            Console.WriteLine("Here 2");
            return nums[left];
        }
    }
}
