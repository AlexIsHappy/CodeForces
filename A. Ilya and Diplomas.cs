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
            var init = int.Parse(Console.ReadLine());
            var line1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var line2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var line3 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var max1 = line1[1];
            var max2 = line2[1];
            var max3 = line3[1];

            var min1 = line1[0];
            var min2 = line2[0];
            var min3 = line3[0];

            var dip1 = Math.Min(init - min2 - min3,max1);
            var dip2 = Math.Min(init - dip1 - min3, max2);
            var dip3 = Math.Min(init - dip1 - dip2, max3);

            Console.WriteLine(dip1 + " " + dip2 + " " + dip3);

            Console.ReadLine();
        }
    }
}
