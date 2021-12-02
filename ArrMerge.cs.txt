using System;

public class ArrayMergeAndSort
{
    public static void Main(string[] args)
    {
        Console.Write(" Enter size of first array: ");
        int m = int.Parse(Console.ReadLine());
        int[] arr1 = new int[m];

        Console.WriteLine(" Enter {0} array elements: ", m);
        for (int i = 0; i < m; i++)
        {
            Console.Write(" Element - {0}: ", i + 1);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\n Enter size of second array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr2 = new int[n];

        Console.WriteLine(" Enter {0} array elements: ", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(" Element- {0}: ", i + 1);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        // Merging of two arrays starts

        int[] SortedArray = new int[m + n];
        for (int i = 0; i < m; i++)
        {
            SortedArray[i] = arr1[i];
        }

        for (int i = 0; i < n; i++)
        {
            SortedArray[i + m] = arr2[i];
        }
        //Merging completed.

        //Sorting starts
        int count = 0;
        int swapCount = 0;
        for (int i = 0; i < m + n; i++)
        {
            for (int j = 0; j < m + n - 1; j++)
            {
                if (SortedArray[j] >= SortedArray[j + 1])
                {
                    int temp = SortedArray[j];
                    SortedArray[j] = SortedArray[j + 1];
                    SortedArray[j + 1] = temp;
                    swapCount++;
                }
                count++;
            }
        }
        //Sorting completed: bubble sort
        //Printing sorted array.
        Console.Write(" Elements after sort: ");
        for (int i = 0; i < m + n; i++)
        {
            Console.Write(SortedArray[i] + " ");
        }
        Console.WriteLine(" count: {0}, swapCount: {1}.", count, swapCount);
    }
}