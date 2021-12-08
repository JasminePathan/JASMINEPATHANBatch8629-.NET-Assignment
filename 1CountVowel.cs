using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _1CountVowel
    {
        public static void Main(string[] args)
        {
            int vowel = 0;
            int consonant = 0;
            Console.Write(" Enter the String: ");
            string str = Console.ReadLine();
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if ("aeiou".Contains(str[i].ToString()))
                    vowel++;

                else if ("bcdfghjklmnpqrstvwxyz".Contains(str[i].ToString()))
                    consonant++;
            }
            Console.WriteLine(" The total number of vowel in the string is: " + vowel);
            Console.WriteLine(" The total number of consonant in the string is: " + consonant);
        }
    }
}