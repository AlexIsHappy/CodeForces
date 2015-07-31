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

            var sum = p.Sum();

            var ans = 0;
            
            for (int i = 0; i < init; i++)
            {
                if ((sum - p[i]) % 2 == 0)
                    ans++;
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
