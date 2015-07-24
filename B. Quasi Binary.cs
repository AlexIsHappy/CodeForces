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
            var n = long.Parse(Console.ReadLine());

            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            Array.Sort(nums);

            long sum = 0;
            var ans = n;

            for (long l = 0; l < n; l++)
            {
                Console.WriteLine(sum + " " + nums[l]);
                if (nums[l] < sum)
                {
                    ans--;
                }

                sum += nums[l];
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
