// Write a program in C# Sharp to find maximum and minimum element in an array.  

using System;
public class Class1
{
	public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Enter the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine(" Enter {0} elements in the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            System.Array.Sort(arr);

            Console.WriteLine(" Maximum element is: " + arr[n-1]);
            Console.WriteLine(" Minimum element is: " + arr[0]);
        }
        catch(Exception ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}