using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _6SubstrPresentOrNot
    {
        public static void Main(string[] args)
        {
            Console.Write(" Enter a string: ");
            string str = Console.ReadLine();
            Console.Write(" Enter the substring to search: ");
            string substr = Console.ReadLine();

            Console.WriteLine(" The substring {0} in the string", str.Contains(substr) ? "exists" : "is not exists");
        }
    }
}