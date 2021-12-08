using System;

public class Class1
{
	public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Enter the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int[] arr3 = new int[n];
            int i, j, count;

            Console.WriteLine(" Enter {0} elements in the array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
                arr3[i] = 0;
            }

            System.Array.Copy(arr1, arr2, n);

            for (i = 0; i < n; i++)
            {
                count = 0;
                for (j = 0; j < n; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        count++;
                        arr3[j] = count;
                    }
                }
            }
            count = 0;
            for (i = 0; i < n; i++)
            {
                if (arr3[i] >= 2)
                    count++;
            }
            Console.WriteLine(" Total number of duplicate elements found in the array is: " + count);
        }
        catch(FormatException ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}