// Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._8thDecAssignments
{
    class _8PalindromeOrNotUsingRecursion
    {
        public static void Main(string[] args)
        {
            string str1;
            bool palindrome;

            Console.Write(" Input a string : ");
            str1 = Console.ReadLine();
            palindrome = IsPalindrome(str1);
            Console.WriteLine(" The string {0} a palindrome", palindrome == true ? "is" : "is NOT");
        }
        public static bool IsPalindrome(string str)
        {
            if (str.Length <= 1)
                return true;
            else
            {
                if (str[0] != str[str.Length - 1])
                    return false;
                else
                    return IsPalindrome(str.Substring(1, str.Length - 2));
            }
        }
    }
}