using System;

namespace dataAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Test");
            int[] array = { 4, 1, 5, 3, 9, 7, 10, 15, 11 };
            Sorting sorting = new Sorting();
            sorting.BubbleSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}