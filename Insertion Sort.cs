using System;

class InsertionSortExample
{
    //static void Main(string[] args)
    //{
    //    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

    //    Console.WriteLine("Original array:");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //    Console.WriteLine();

    //    InsertionSort(arr);

    //    Console.WriteLine("\nSorted array:");
    //    foreach (int i in arr)
    //    {
    //        Console.Write(i + " ");
    //    }
    //    Console.ReadKey();
    //}

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        Console.WriteLine($"Initial array: [{string.Join(", ", arr)}]");

        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            Console.WriteLine($"i={i}, key={key}, j={j}");

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
                Console.WriteLine($"  Shifting: [{string.Join(", ", arr)}]");
            }
            arr[j + 1] = key;
            Console.WriteLine($"After inserting key: [{string.Join(", ", arr)}]");
        }
        Console.WriteLine($"Final sorted array: [{string.Join(", ", arr)}]");
    }
}