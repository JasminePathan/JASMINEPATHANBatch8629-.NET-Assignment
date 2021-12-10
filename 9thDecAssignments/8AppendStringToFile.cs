// Write a program in C# Sharp to append some text to an existing file. 

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _8AppendStringToFile
    {
        public static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" Hello and Welcome");

                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }
                using (StreamWriter file = new StreamWriter(@"mytest.txt", true))
                {
                    file.WriteLine(" This is the line appended at last line.");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.WriteLine(" Here is the content of the file after appending the text : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");
                }

            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}