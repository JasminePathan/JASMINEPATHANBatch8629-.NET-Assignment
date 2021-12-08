using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _4StrArrBubbleSort
    {
        public static void Main(string[] args)
        {
            try
            {
                string temp;
                Console.Write(" Enter number of strings: ");
                int n = int.Parse(Console.ReadLine());
                string[] str = new string[n];
                Console.WriteLine(" Enter {0} strings below: ",n);
                for(int i = 0; i<n; i++)
                {
                    Console.Write(" ");
                    str[i] = Console.ReadLine();
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (str[j].CompareTo(str[j + 1]) > 0)
                        {
                            temp = str[j];
                            str[j] = str[j + 1];
                            str[j + 1] = temp;
                        }
                    }
                }
                Console.WriteLine(" After sorting the array appears like: ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(" " + str[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}