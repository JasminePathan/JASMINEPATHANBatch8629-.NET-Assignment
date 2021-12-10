//Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series using recursion

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class A10FibonacciUsingRecursion
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write(" Input number of terms for the Fibonacci series : ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n The Fibonacci series of {0} terms is : ", n1);
                for (int i = 0; i < n1; i++)
                {
                    Console.Write("{0} ", FindFibonacci(i));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }

        public static int FindFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int c = a;
                a = b;
                b = a + c;
            }
            return b;
        }
    }
}

