using System;
namespace DataStructures.Utils
{
    public class Swap
    {
        public static void swap(ref int[] arr, int indx1, int indx2)
        {
            int temp = arr[indx1];
            arr[indx1] = arr[indx2];
            arr[indx2] = temp;
        }
    }
}
