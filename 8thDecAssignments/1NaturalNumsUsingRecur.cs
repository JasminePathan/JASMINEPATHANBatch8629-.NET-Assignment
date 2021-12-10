using System;

public class NaturalNums
{
    public static int PrintNaturalNums(int first, int n)
    {
        if (n < 1)
        {
            return first;
        }
        n--;
        Console.Write(" {0} ", first);
        return PrintNaturalNums(first + 1, n);
    }
    public static void Main(string[] args)
    {
        try
        {
            Console.Write(" Enter how many natural numbers to print: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Natural number from 1 to {0} are: ", n);
            PrintNaturalNums(1, n);
            Console.WriteLine();

        }
        catch(Exception ex)
        {
            Console.WriteLine(" Exception: " + ex.Message);
        }
    }
}