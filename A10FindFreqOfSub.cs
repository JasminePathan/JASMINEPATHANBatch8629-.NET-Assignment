/ Write a program in C# Sharp to find the number of times a substring appears in a given string.

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class A10FindFreqOfSub
    {
        public static void Main(string[] args)
        {
            Console.Write(" Enter a String: ");
            string str = Console.ReadLine();
            Console.Write(" Enter the string to be searched for: ");
            string substr = Console.ReadLine();

            int start = 0, count = -1, index = -1;

            while (start != -1)
            {
                start = str.IndexOf(substr, index + 1);
                count += 1;
                index = start;
            }

            Console.WriteLine(" The string {0} occurs {1} times.", substr, count);
        }
    }
}