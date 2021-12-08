using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _3SortStrArrAsc
    {
        public static void Main(string[] args)
        {
            int i;
            char ch;
            Console.Write(" Enter a String: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();

            for (i = 1; i < arr.Length; i++) 
            {
                for (int j = 0; j < arr.Length - i; j++) 
                {
                    if (arr[j] > arr[j + 1])
                    {
                        ch = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = ch;
                    }
                }
            }
            Console.Write(" After sorting the string appears like:");
            foreach(char c in arr)
            {
                if(c !=' ')
                    Console.Write(" " + c);
            }
        }
    }
}