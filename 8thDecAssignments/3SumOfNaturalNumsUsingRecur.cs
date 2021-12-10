// Write a program in C# Sharp to find the sum of first n natural numbers using recursion. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class _3SumOfNaturalNumsUsingRecur
    {
        static int PrintSum(int first, int n)
        {
            if (n == first)
                return n;
            return n + PrintSum(first, n - 1);
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.Write(" How many numbers to sum: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(" sum of first {0} natural number is: {1}", n, PrintSum(1,n));
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}