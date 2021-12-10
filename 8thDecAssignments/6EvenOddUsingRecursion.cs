// Write a program in C to print even or odd numbers in a given range using recursion.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionAssignments
{
    class RecursionEvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write(" Input the range to print starting from 1 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n All even numbers from 1 to {0} are : ", n);
            EvenAndOdd(2, n);

            Console.WriteLine("\n\n All odd numbers from 1 to {0} are : ", n);
            EvenAndOdd(1, n);
            Console.ReadLine();
        }

        static void EvenAndOdd(int Val, int n)
        {
            if (Val > n)
                return;
            Console.Write(" {0}  ", Val);
            EvenAndOdd(Val + 2, n);
        }
    }
}