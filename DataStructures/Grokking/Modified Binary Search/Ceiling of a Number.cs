namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Ceiling_of_a_Number
    {
        int[] nums;
        int key;
        public Ceiling_of_a_Number()
        {
            nums = new int[] { 1, 3, 8, 10, 15 };
            //nums = new int[] { 4, 6, 10 };
            key = 12;
        }

        public int searchCeilingOfANumber()
        {

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = (right + left) / 2;
                if (nums[mid] == key)
                    return mid;
                else if (nums[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return left;
        }
    }
}
