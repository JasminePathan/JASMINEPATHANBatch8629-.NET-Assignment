//Write a program in C# Sharp to count the frequency of each element of an array. 

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
            int count;

            Console.WriteLine(" Enter {0} elements in the array: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = -1;
            }

            for (int i = 0; i < n; i++)
            {
                count = 1;
                for (int j = i+1; j < n; j++) 
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        arr2[j] = 0;
                    }
                }

                if (arr2[i] != 0)
                    arr2[i] = count;
            }
            Console.WriteLine(" Frequency of all elements of array: ");
            for (int i = 0; i < n; i++)
            {
                if (arr2[i] != 0)
                    Console.WriteLine(" {0} occurs {1} times", arr1[i], arr2[i]);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}