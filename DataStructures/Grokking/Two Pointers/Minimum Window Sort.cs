using System;
namespace DataStructures.Grokking.P2TwoPointers
{
    public class Minimum_Window_Sort
    {
        int[] arr;
        public Minimum_Window_Sort()
        {
            arr = new int[] { 1, 2, 4, 3 };
        }

        public int sort()
        {
            int min = int.MaxValue;//min unsorted num
            int max = int.MinValue;//max unsorted num
            int cp = 0;

            while (cp < arr.Length - 1)
            {
                if (arr[cp] > arr[cp + 1])
                {
                    if (arr[cp + 1] < min)
                        min = arr[cp + 1];
                    if (arr[cp + 1] > max)
                        max = arr[cp + 1];
                }
                cp++;
            }

            int leftIndx = 0;
            int rightIndx = 0;

            if (min != int.MaxValue)
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] >= min)
                    {
                        leftIndx = i;
                        break;
                    }

            if (max != int.MinValue)
                for (int i = arr.Length - 1; i >= 0; i--)
                    if (arr[i] <= max)
                    {
                        rightIndx = i;
                        break;
                    }
            return rightIndx - leftIndx + (leftIndx == 0 && rightIndx == 0 ? 0 : 1);
        }
    }
}
