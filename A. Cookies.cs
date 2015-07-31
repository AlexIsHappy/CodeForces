using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace ConsoleApplication25
{
    class Solution
    {
        static void Main(string[] args)
        {
            var init = int.Parse(Console.ReadLine());

            var p = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int g = p[0];
            for (int i = 1; i < init; i++)
            {
                g = gcd(g, p[i]);
            }

            Console.WriteLine(g * init);
            Console.ReadLine();
        }

        private static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }
    }
}
