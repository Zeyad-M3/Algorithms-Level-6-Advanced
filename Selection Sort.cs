using System;
class SelectionSortExample
{
    static void SelectionSortAsc(int[] arr)
    {
        int n = arr.Length;
        Console.WriteLine($"Initial array: [{string.Join(", ", arr)}]");

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }
            Console.WriteLine($"i={i}, minIndex={minIndex}, minValue={arr[minIndex]}");

            // Swap
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;

            // نحن نحدد مكان نقل العنصر والعنصر الآخر نحتفظ به في temp
            // ويتم نقله إلى العنصر الذي تم تعريفه في مكان العنصر الآخر.


            Console.WriteLine($"After swap: [{string.Join(", ", arr)}]");
        }
        Console.WriteLine($"Final sorted array: [{string.Join(", ", arr)}]");
    }

    static void SelectionSortDesc(int[] arr)
    {
        int n = arr.Length;

        // One by one move boundary of unsorted subarray
        for (int i = 0; i < n - 1; i++)
        {
            // Find the Maximum element in unsorted array
            int maxIndex = i;
            for (int j = i + 1; j < n; j++)
                if (arr[j] > arr[maxIndex])
                    maxIndex = j;

            // Swap the found minimum element with the first element
            int temp = arr[maxIndex];
            arr[maxIndex] = arr[i];
            arr[i] = temp;
        }
    }

    // Driver code
    //static void Main(string[] args)
    //{
    //    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };


    //    Console.WriteLine("Original array:");
    //    foreach (int value in arr)
    //    {
    //        Console.Write(value + " ");
    //    }
    //    Console.WriteLine();

    //    SelectionSortAsc(arr);

    //    Console.WriteLine("\nSorted array ASC:");
    //    foreach (int value in arr)
    //    {
    //        Console.Write(value + " ");
    //    }

    //    SelectionSortDesc(arr);

    //    Console.WriteLine("\n\nSorted array Desc:");
    //    foreach (int value in arr)
    //    {
    //        Console.Write(value + " ");
    //    }
    //    Console.ReadKey();

    //}
}