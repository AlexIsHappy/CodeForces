using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int []reverse = new int [line.Length];

            for (int i = 0; i < reverse.Length; i++)
            {
                reverse[line[i] - 1] = i + 1; 
            }

            foreach (int i in reverse)
                Console.Write(i + " ");
            Console.ReadLine();

        }

    }
}
