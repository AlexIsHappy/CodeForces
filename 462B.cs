﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace MaxExtension
{
    public static class Max
    {
        public static int MaxIndex(this IEnumerable<int> sequence)
        {
            int maxindex = -1;
            int maxvalue = default(int);

            int index = 0;
            foreach (int value in sequence)
            {
                if (value.CompareTo(maxvalue) > 0 || maxindex == -1)
                {
                    maxindex = index;
                    maxvalue = value;
                }
                index++;
            }

            return maxindex;
        }
    }
}
namespace ConsoleApplication25
{
    using MaxExtension;
    class Solution
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var let = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var last = char.ToUpper(str[str.Length - 1]) - 64;

            int maxLett = let.MaxIndex();
            var l = char.ToLower((char)('A' + maxLett));

            var ans = str + new string(l, n);
            var intans = 0;
            for (int i = 0; i < ans.Length; i++)
            {
                intans += let[(char.ToUpper(ans[i]) - 64) - 1] * (i + 1);
            }

            Console.WriteLine(intans);
            Console.ReadLine();
        }
    }
}