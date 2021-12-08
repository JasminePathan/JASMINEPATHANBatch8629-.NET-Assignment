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
            int sum = 0;

            Console.WriteLine(" Enter {0} elements in the array: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write(" element-{0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine(" Sum of all elements stored in the array is: " + sum);            
        }
        catch(FormatException ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}