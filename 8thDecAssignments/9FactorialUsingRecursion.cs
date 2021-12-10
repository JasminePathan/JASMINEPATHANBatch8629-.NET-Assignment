// Write a program in C# Sharp to find the factorial of a given number using recursion

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class _9FactorialUsingRecursion
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write(" Input any positive number : ");
                int n = Convert.ToInt32(Console.ReadLine());

                int fact = Factorial(n);

                Console.WriteLine(" The factorial of {0} is : {1} ", n, fact);
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }

        private static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}