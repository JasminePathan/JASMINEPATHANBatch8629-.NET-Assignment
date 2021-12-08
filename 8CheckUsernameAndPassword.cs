// 8.	Write a program in C# Sharp to check the username and password. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _8CheckUsernameAndPassword
    {
        public static void Main(string[] args)
        {
            int count=0;
            string username, password;
            do
            {
                Console.Write(" Enter username: ");
                username = Console.ReadLine();
                Console.Write(" Enter password: ");
                password = Console.ReadLine();

                if (username != "abcd" || password != "1234")
                {
                    Console.WriteLine("\n LOGIN FAILED....TRY AGAIN....\n");
                    count++;
                }
                else
                    count = 1;
            }
            while ((username != "abcd" || password != "1234") && count != 3);

            if (count == 3)
                Console.WriteLine(" Login failed 3 times.....Please try after some time\n");
            else
                Console.WriteLine(" Password Entered successfully!\n");
        }
    }
}