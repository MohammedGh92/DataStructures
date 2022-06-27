using System;
namespace DataStructures.SortingAlgorithms
{
    public class CountingSort
    {

        public static int[] Sort(int[] arr)
        {
            int[] array = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };
            int[] sortedArray = new int[array.Length];
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }
            int[] counts = new int[maxVal - minVal + 1];
            for (int i = 0; i < array.Length; i++)
                counts[array[i] - minVal]++;
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
                counts[i] = counts[i] + counts[i - 1];
            for (int i = array.Length - 1; i >= 0; i--)
                sortedArray[counts[array[i] - minVal]--] = array[i];
            return sortedArray;
        }
    }
}
