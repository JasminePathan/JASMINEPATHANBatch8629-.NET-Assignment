using System;

public class Class1
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Enter the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] first_arr = new int[n];
            int[] second_arr = new int[n];
            Console.WriteLine(" Enter {0} elements in the array: ",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ", i + 1);
                first_arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(" The elements stored in the first array are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + first_arr[i]);
            }

            //System.Array.Copy(first_arr, second_arr, n);

            for (int i = 0; i < n; i++) 
            {
                second_arr[i] = first_arr[i];
            }

            Console.Write("\n The elements stored in the second array are: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write(" " + second_arr[i]);
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}