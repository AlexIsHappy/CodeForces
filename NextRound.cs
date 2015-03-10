using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            String[] words = new String[n];
            int[] wordLength = new int [n];

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
                wordLength[i] = words[i].Length;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (wordLength[i] <= 10)
                    Console.WriteLine(words[i]);
                else
                    Console.WriteLine(words[i][0] + (words[i].Length - 2).ToString() + words[i][words.Length -1]);
            }

                Console.ReadLine();
        }
    }
}
