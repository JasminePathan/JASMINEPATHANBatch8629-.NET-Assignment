//  Write a program in C# Sharp to remove a file from the disk

using System;
using System.Collections.Generic;
using System.IO;

namespace Classes._9thDecAssignments
{
    class _2RemoveFile
    {
        public static void Main(string[] args)
        {
            string filename = @"mytest.txt";

            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine(" File {0} deleted from the disk",filename);
            }
            else
                Console.WriteLine(" File {0} does not exists",filename);
        }
    }
}