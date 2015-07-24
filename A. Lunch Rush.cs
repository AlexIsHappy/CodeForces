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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var n = init[0];
            var c = init[1];

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int max = 0;

            for (int i = 1; i < n; i++)
            {
                int loc = (nums[i - 1] - nums[i] - c);
                max = Math.Max(loc, max);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
      
    }
}
