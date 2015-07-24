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
            var sides = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var c1 = sides[0];
            var c2 = sides[1];
            var c3 = sides[2];
            var c4 = sides[3];
            var c5 = sides[4];
            var c6 = sides[5];
            var sqtr = Math.Sqrt(3) / 4; // Const square of triangle

            //Two figures
            var x = 0.5 * c6 + 0.5 * c2 + c1;

            var sq1 = Math.Sqrt(3) / 4 * (c1 + x) * c2;
            var sq2 = Math.Sqrt(3) / 4 * (c4 + x) * c3;

            var ans = (sq1 + sq2) / sqtr;

            Console.WriteLine(ans);
            Console.ReadLine();

        }
    }
}
