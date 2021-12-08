// Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _7ChangeCase
    {
        public static void Main(string[] args)
        {
            Console.Write(" Enter a string: ");
            string str = Console.ReadLine();
            char[] charArr = str.ToCharArray();

            Console.Write(" After conversion, the string is: ");
            for(int i = 0; i<charArr.Length; i++)
            {
                if (char.IsLower(charArr[i]))
                    Console.Write(char.ToUpper(charArr[i]));
                else
                    Console.Write(char.ToLower(charArr[i]));
            }

            Console.WriteLine();
        }
    }
}