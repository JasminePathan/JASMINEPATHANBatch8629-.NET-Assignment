// Write a program in C# Sharp to search the position of a substring within a string. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _9IndexOfSubstr
    {
        public static void Main(string[] args)
        {
            Console.Write(" Enter a string: ");
            string str = Console.ReadLine();
            Console.Write(" Enter a substring to be found in the string: ");
            string substr = Console.ReadLine();

            int ind = str.IndexOf(substr);
            if (ind < 0)
                Console.WriteLine(" '{0}' is not found in '{1}'", substr, str);
            else
                Console.WriteLine("Found '{0}' in '{1}' at position {2}", substr, str, ind);
        }
    }
}