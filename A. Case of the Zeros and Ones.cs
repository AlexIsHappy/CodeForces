using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var clockWise = new int[num];
            var counter = new int[num];


            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 1)
                {
                   if (number[i] > i)
                       clockWise[i] = (num - 1 - number[i]) + i + 1;
                   else
                       clockWise[i] = i - number[i];
                }
                else
                {
                    if (number[i] > i)
                        clockWise[i] = number[i] - i;
                    else
                        clockWise[i] = num - i + number[i];

                }
            }

            if (clockWise.All(x => x == clockWise[0]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }
      
    }
}
