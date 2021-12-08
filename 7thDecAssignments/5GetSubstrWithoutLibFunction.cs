using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _5GetSubstrWithoutLibFunction
    {
        public static void Main(string[] args)
        {
            try
            {
                string str, substr="";
                Console.Write(" Enter a string: ");
                str = Console.ReadLine();
                Console.Write(" Enter the position to start extraction: ");
                int start_index = int.Parse(Console.ReadLine());
                Console.Write(" Enter the length of substring: ");
                int len = int.Parse(Console.ReadLine());

                for(int i = start_index; i< start_index + len; i++)
                {
                    if (i < str.Length) 
                        substr += str[i];
                }

                Console.WriteLine(" The substring retrieve from the string is: " + substr);

            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }

        }
    }
}