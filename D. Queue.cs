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
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var sb = new List<string>();
            var ans = 0;

            for (int i = 0; i < n; i++)
            {
                var min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }

                var temp = a[min];
                a[min] = a[i];
                a[i] = temp;

                if (i != min)
                {
                    sb.Add(i + " " + min);
                    ans++;
                }
            }

            Console.WriteLine(ans);

            foreach(string s in sb)
            {
                Console.WriteLine(s);
            }
                Console.ReadLine();
        }
    }
}
