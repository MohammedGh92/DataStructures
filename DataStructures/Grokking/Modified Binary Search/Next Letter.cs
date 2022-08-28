using System;
namespace DataStructures.Grokking.ModifiedBinarySearch
{
    public class Next_Letter
    {
        char[] letters;
        char key;
        public Next_Letter()
        {
            letters = new char[] { 'a', 'c', 'f', 'h' };
            key = 'g';
        }

        public char searchNextLetter()
        {

            int left = 0;
            int right = letters.Length - 1;

            while (left < right)
            {

                int mid = (left + right) / 2;

                if (letters[mid] == key)
                    return letters[mid];
                else if (letters[mid] < key)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return letters[left];
        }
    }
}
