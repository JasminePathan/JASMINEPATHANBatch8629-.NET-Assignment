// Write a program in C# Sharp to create a blank file in the disk if the same file already exists.

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _3CreateExistedFile
    {
        public static void Main(string[] args)
        {
            string filename = @"mytest.txt";
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = File.Create(filename))
            {
                Console.WriteLine(" A file created with name " + filename);
            }
        }
    }
}