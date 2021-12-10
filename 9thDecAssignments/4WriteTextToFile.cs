// Write a program in C# Sharp to create a file and add some text

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _4WriteTextToFile
    {
        public static void Main(string[] args)
        {
            string filename = @"mytest.txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = File.CreateText(filename))
            {
                sw.WriteLine(" Hello and welcome...");
                sw.WriteLine(" This is new content in a file.");
            }
        }
    }
}