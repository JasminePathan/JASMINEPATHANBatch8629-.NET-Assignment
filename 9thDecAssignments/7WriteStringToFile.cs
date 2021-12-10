// Write a program in C# Sharp to create and write some line of text into a file which does not contain a given string in a line.

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _7WriteStringToFile
    {
        public static void Main(string[] args)
        {
            try
            {
                string filename = @"mytest.txt";
                Console.Write(" Enter the string to ignore the line: ");
                string str = Console.ReadLine();
                Console.Write(" Enter number of lines to write in the file: ");
                int n = int.Parse(Console.ReadLine());
                string[] arr = new string[n];
                Console.WriteLine(" Enter {0} strings below: ",n);
                for(int i = 0; i<n; i++)
                {
                    Console.Write(" Enter line {0}: ", i + 1);
                    string temp = Console.ReadLine();
                    if (!temp.Contains(str))
                        arr[i] = temp;
                }
                File.WriteAllLines(filename, arr);

                Console.WriteLine(" The line have ignored which contain the string '{0}'", str);
                Console.WriteLine(" The content of the file is: ");
                using (StreamReader sr = File.OpenText(filename))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(" " + s);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}