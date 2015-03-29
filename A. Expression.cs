using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int16.Parse(Console.ReadLine());

            int[] p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int Max = p[0];
            int Min = p[0];
            int count = 0;

            foreach (int i in p)
            {
                if (i > Max)
                {
                    count++;
                    Max = i;
                }

                else if (i < Min)
                {
                    count++;
                    Min = i;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
