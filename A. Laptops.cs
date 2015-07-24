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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var num = init[0];
            var money = init[1];


            int max = 0;
            for (int i = 0; i < init[0]; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (line[0] < money && line[1] != 0)
                {
                    if (100 - line[1] > max)
                        max = 100 - line[1];
                }
            }

                Console.WriteLine(max);
                Console.ReadLine();

        }
      
    }
}
