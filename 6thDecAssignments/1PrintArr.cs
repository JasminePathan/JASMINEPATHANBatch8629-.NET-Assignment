using System;

public class Class1
{
	public static void Main(string[] args)
	{
		try
		{
			int[] arr = new int[10];
			Console.WriteLine(" Input 10 Elements in the array: ");
			for (int i = 0; i < 10; i++)
			{
				Console.Write(" element-{0}: ", i);
				arr[i] = int.Parse(Console.ReadLine());
			}

			Console.Write(" Elements in array are:");
			for (int i = 0; i < 10; i++)
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