// Write a program in C# Sharp to create a file and write an array of strings to the file. 

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _6WriteArrOfStringToFile
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] arr;
                int n;
                string filename = @"mytest.txt";
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                Console.Write(" Enter number of lines to be write into a file: ");
                n = int.Parse(Console.ReadLine());
                arr = new string[n];
                Console.WriteLine(" Enter {0} strings: ", n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" String-{0}: ", i + 1);
                    arr[i] = Console.ReadLine();
                }
                File.WriteAllLines(filename, arr);

                Console.WriteLine("\n Content in a file is: ");
                using (StreamReader sr = File.OpenText(filename))
                {
                    string s = "";
                    while((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(" "+s);
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