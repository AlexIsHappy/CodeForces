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

            var n = init[0];
            var x = init[1];

            var c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(c);

            var ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans += c[i] * x;
                if (x != 1)
                {
                    x--;
                }
            }

            Console.WriteLine(ans);
            Console.ReadLine();


        }

    }
}
