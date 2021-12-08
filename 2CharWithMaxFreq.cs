using System;
using System.Collections.Generic;
using System.Text;

namespace Classes._7thDecAssignments
{
    class _2CharWithMaxFreq
    {
        public static void Main(string[] args)
        {
            int max, length, i, ascii;
            Console.Write(" Enter a string: ");
            string str = Console.ReadLine();
            length = str.Length;

            int[] char_freq = new int[255];
            i = 0;
            while (i < length)
            {
                ascii = (int)str[i];
                char_freq[ascii] += 1;
                i++;
            }
            max = 0;
            for (i = 0; i < 255; i++)
            {
                if(i!=32)
                {
                    if (char_freq[i] > char_freq[max])
                        max = i;
                }
            }
            Console.WriteLine(" The highest frequency of character '{0}' appears number of times: {1}", (char)max, char_freq[max]);
        }
    }
}