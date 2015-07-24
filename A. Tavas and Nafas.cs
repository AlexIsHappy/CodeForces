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
            var init = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int p1 =0;
            int p2 = 0;

            for (int i = 0; i < init; i++)
            {
                int max = Math.Max(nums[0], nums[nums.Count - 1]);
                int maxIndex = nums[0] > nums[nums.Count - 1] ? 0 : nums.Count - 1;
                if (i % 2 == 0)
                {
                    p1 += max;
                }
                else
                {
                    p2 += max;
                }

                nums.RemoveAt(maxIndex);
            }
            
            Console.WriteLine(p1 + " " + p2);
            Console.ReadLine();
        }
      
    }
}
