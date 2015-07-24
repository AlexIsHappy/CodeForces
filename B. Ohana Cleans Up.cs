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
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var n = nums[0];
            var k = nums[1];

            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int f = line[0];
                int t = line[1];

                int locMax = t > k ? f - (t - k) : f;
                max = Math.Max(locMax, max);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
      
    }
}
