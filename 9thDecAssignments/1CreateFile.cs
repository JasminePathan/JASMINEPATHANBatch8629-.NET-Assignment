// Write a program in C# Sharp to create a blank file in the disk newly

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Classes._9thDecAssignments
{
    class _1CreateFile
    {
        public static void Main(string[] args)
        {
            string fileName = @"mytest.txt";
            try
            {
                using (FileStream fs = File.Create(fileName))
                {
                    Console.WriteLine(" A file created with name " + fileName);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(" Exception: " + ex.Message);
            }
        }
    }
}
