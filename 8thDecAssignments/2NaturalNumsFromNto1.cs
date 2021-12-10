using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class _2NaturalNumsFromNto1
    {
        static int PrintNums(int start, int n)
        {
            if (n < 1)
            {
                return start;
            }

            Console.Write(" {0} ", n);
            n--;
            return PrintNums(start, n);
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.Write(" Enter how many natural numbers to print: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write(" Natural number from {0} to 1 are: ", n);
                PrintNums(1, n);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}