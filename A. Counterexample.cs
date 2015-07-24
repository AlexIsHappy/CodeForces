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
            var m = init[1];

            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var ans = 0;
            var cur = 0;
            for (int i = 0; i < n; i++)
            {
                if (cur + a[i] < m)
                {
                    cur += a[i];
                }
                else
                {
                    ans++;
                    cur = a[i];
                }
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }

    }
}
