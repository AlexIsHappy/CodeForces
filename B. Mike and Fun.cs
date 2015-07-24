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

            var a = init[0];
            var b = init[1];
            var c = init[2];
            var d = init[3];

            var res1 = Math.Max(3 * a / 10, a - (a / 250) * c);
            var res2 = Math.Max(3 * b / 10, b - b / 250 * d);

            if (res1 > res2)
                Console.WriteLine("Misha");
            else if (res1 < res2)
                Console.WriteLine("Vasya");
            else
                Console.WriteLine("Tie");

                Console.ReadLine();
        }
    }
}
