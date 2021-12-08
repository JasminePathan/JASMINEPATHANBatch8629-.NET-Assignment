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
            int ctr;
            Console.WriteLine(" Enter {0} elements in the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(" The unique elements found in the array are:");
            for (int i = 0; i < n; i++)
            {
                ctr = 0;
                for (int j = 0; j < i-1; j++)
                {
                    if (arr[i] == arr[j])
                        ctr++;
                }
                for (int k = i + 1; k < n; k++) 
                {
                    if (arr[i] == arr[k])
                        ctr++;

                    if (arr[i] == arr[i + 1])
                        i++;
                }
                if (ctr == 0)
                {
                    Console.Write(" " + arr[i]);
                }
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}