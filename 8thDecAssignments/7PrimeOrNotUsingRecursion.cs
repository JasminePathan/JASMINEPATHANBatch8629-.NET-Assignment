// Write a program in C# Sharp to check whether a number is prime or not using recursion.  

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class _7PrimeOrNotUsingRecursion
    {
        static void Main(string[] args)
        {
            try
            {
                int n1, primeNo;

                Console.Write(" Input any positive number : ");
                n1 = Convert.ToInt32(Console.ReadLine());

                primeNo = checkForPrime(n1, n1 / 2);

                Console.WriteLine(" The number{0} {1} a prime number", n1, primeNo == 1 ? "is" : "is NOT");
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
        static int checkForPrime(int n1, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n1 % i == 0)
                    return 0;
                else
                    return checkForPrime(n1, i - 1);

            }
        }
    }
}