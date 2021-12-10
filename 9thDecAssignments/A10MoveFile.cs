// Write a program in C# Sharp to create a file and move the file into the same directory to another name. 

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class A10MoveFile
    {
        public static void Main(string[] arg)
        {
            string sfileName = @"mytest.txt";
            string tfileName = @"mynewtest.txt";

            if (File.Exists(sfileName))
            {
                File.Delete(sfileName);
            }
            if (File.Exists(tfileName))
            {
                File.Delete(tfileName);
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
            System.IO.File.Move(sfileName, tfileName);
            Console.WriteLine(" The file {0} successfully moved to the name {1} in the same directory.", sfileName, tfileName);

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