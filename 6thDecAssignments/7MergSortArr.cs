// Write a program in C# to merge two arrays of same size sorted in ascending order.

using System;
public class Class1
{
	public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Enter the number of elements to be stored in the first and second array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n*2];
            int[] arr2 = new int[n];
            Console.WriteLine(" Enter {0} elements in the first array: ",n);
            for (int i = 0; i < n; i++) 
            {
                Console.Write(" element-{0}: ", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" Enter {0} elements in the second array: ",n);
            for (int i = 0; i < n; i++) 
            {
                Console.Write(" element-{0}: ", i + 1);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for(int i= 0; i < arr2.Length; i++)
            {
                arr1[n++] = arr2[i];
            }

            System.Array.Sort(arr1);

            Console.Write(" The merged array in ascending order is:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(" " + arr1[i]);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}