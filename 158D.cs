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
            var n = int.Parse(Console.ReadLine());
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxSum = init.Sum();

            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    for (int x = 0; x < i; x++)
                    {
                        int cursum = 0;
                        for (int y = x; y < n; y += i)
                        {
                            cursum += init[y];
                        }
                        maxSum = Math.Max(cursum, maxSum);
                    }
                }
            }

            Console.WriteLine(maxSum);
            Console.ReadLine();
        }
    }
}