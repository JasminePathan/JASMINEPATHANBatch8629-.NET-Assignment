using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class _5CountNoOfDigitsUsingRecur
    {
        static int CountDigits(int n, int count)
        {
            if (n == 0)
                return count;
            return CountDigits(n / 10, ++count);
            
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.Write(" Enter a number: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine(" The number {0} contains number of digits: {1}", n, CountDigits(n,0));
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}