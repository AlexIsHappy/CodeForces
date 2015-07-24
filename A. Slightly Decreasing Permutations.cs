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
            var t = init[1];
            var c = init[2];

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var cur = 0;
            var ans = 0;

            for (int i = 0; i < n;i++)
            {
                if (nums[i] > t)
                {
                    ans += (cur - c + 1) > 0 ? (cur - c + 1) : 0;
                    cur = 0;
                }
                else
                {
                    cur++;
                }
            }

            if (cur != 0)
            {
                ans += (cur - c + 1) > 0 ? (cur - c + 1) : 0;
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
