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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var b = init[0];
            var g = init[1];

            int max = Math.Max(b,g);
            int min = Math.Min(b,g);

            var sb = new StringBuilder();
            var count = 0;

            for (int i = 1; i <= min; i++)
            {
                for (int j = i; j <= max;j++)
                {
                    count++;
                    sb.Append(j + " " + i);
                }
            }
            Console.WriteLine(count);
            foreach(string s in sb)
            {
                Console.WriteLine(s);
            }
                Console.ReadLine();
        }
    }
}
