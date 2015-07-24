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
            var init = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var a = init[0];
            var b = init[1];
            var c = init[2];

            double ans = 0;

            var sb = new StringBuilder();
            for (double i = 0; i <= 81; i++)
            {
                ans = b * Math.Pow(i, a) + c;

                if (ans >= 0)
                {
                    var count = ans.ToString().ToCharArray().Select(x => x - '0').ToArray().Sum();

                    if (count == i)
                    {
                        Console.WriteLine(count);
                        sb.Append(ans + " ");
                    }
                }
            }

            if (sb.Length == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(sb.ToString());

                Console.ReadLine();
        }
    }
}
