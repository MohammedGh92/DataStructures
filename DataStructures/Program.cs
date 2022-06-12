namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = new int[] { 5, 1, 2, 3, 4 };
            Heap heap = new Heap(newArr);
            heap.build();
            heap.sort();
            heap.printArray();
        }
    }
}
