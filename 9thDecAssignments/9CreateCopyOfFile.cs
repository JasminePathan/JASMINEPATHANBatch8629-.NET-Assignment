// Write a program in C# Sharp to create and copy the file to another name and display the content. 

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _9CreateCopyOfFile
    {
        public static void Main(string[] args)
        {
            string sfileName = @"mytest.txt";
            string tfileName = @"mynewtest.txt";

            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }

            using (StreamWriter fileStr = File.CreateText(sfileName))
            {
                fileStr.WriteLine(" Hello and Welcome");

            }
            using (StreamReader sr = File.OpenText(sfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", sfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }

            File.Copy(sfileName, tfileName, true);
            Console.WriteLine(" The file {0} successfully copied to the name {1} in the same directory.", sfileName, tfileName);

            using (StreamReader sr = File.OpenText(tfileName))
            {
                string s = "";
                Console.WriteLine(" Here is the content of the file {0} : ", tfileName);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("");
            }
        }
    }
}