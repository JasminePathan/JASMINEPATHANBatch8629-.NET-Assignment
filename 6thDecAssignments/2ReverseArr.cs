using System;

public class Class1
{
	public static void Main(string[] args)
	{
        try
        {
            Console.Write(" Enter the number of elements to store in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine(" Enter {0} array elements: ",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(" element-{0}: ",i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\n Entered array elements: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" "+arr[i]);
            }
            Console.Write("\n Array elements in Reverse order:");
            for(int i = arr.Length-1; i>=0; i--)
            {
                Console.Write(" " + arr[i]);
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
	}
}