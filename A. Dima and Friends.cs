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

            var ans = 0;

            for (int i = 1; i <= 5; i++)
            {
                if ( (i + p.Sum() - 1)%(init + 1) == 0)
                {
                    ans++;
                }
            }

            Console.WriteLine(5 - ans);
                Console.ReadLine();
        }
    }
}
