using System;

public class Class1
{
	public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Enter the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());
            int j = 0, K = 0;
            int[] arr = new int[n];
            int[] Even_arr = new int[n];
            int[] Odd_arr = new int[n];

            Console.WriteLine(" Enter {0} elements in the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                    Even_arr[j++] = arr[i];
                else
                    Odd_arr[K++] = arr[i];
            }

            Console.WriteLine(" The Even elements are:");
            for (int i = 0; i < j; i++)
            {
                Console.Write(" " + Even_arr[i]);
            }
            
            Console.WriteLine("\n The Odd elements are:");
            for (int i = 0; i < K; i++)
            {
                Console.Write(" " + Odd_arr[i]);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}