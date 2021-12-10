// Write a program in C# Sharp to display the individual digits of a given number using recursion. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class _4DisplayDigitsIndividually
    {
        static void displayDigits(int n)
        {
            if (n < 10)
            {
                Console.Write(" " + n);
                return;
            }
            displayDigits(n / 10);
            Console.Write(" " + n%10);
            return;

        }
        public static void Main(string[] args)
        {
            try
            {
                Console.Write(" Enter a number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write(" The digits in the number {0} are:",n);
                displayDigits(n);

            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }

        }
    }
}