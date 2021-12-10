// Write a program in C# Sharp to create a file with text and read the file. 

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _5ReadContentFromFile
    {
        public static void Main(string[] args)
        {
            string filename = @"mytest.txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine(" File {0} does not exists...",filename);
            }
            else
            {
                using (StreamReader sr = File.OpenText(filename))
                {
                    string data = "";
                    Console.WriteLine(" Content of file " + filename+": ");
                    while ((data = sr.ReadLine()) != null)
                    {
                        Console.Write(data);
                    }
                }
            }
        }
    }
}