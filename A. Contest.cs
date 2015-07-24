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
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int chest = 0;
            int bicepc = 0;
            int back = 0;

            for (int i = 0; i < init; i++)
            {
                if (nums[i] % 3 == 0)
                {
                    chest += nums[i];
                }
                else if (nums[i] % 3 != 0 && nums[i] % 2 == 0)
                {
                    bicepc += nums[i];
                }
                else
                {
                    back += nums[i];
                }
            }


           if (chest > bicepc && chest > back)
           {
               Console.WriteLine("chest");
           }
           else if (bicepc > chest && bicepc > back)
           {
               Console.WriteLine("biceps");
           }
           else
           {
               Console.WriteLine("back");
           }
                Console.ReadLine();
        }
    }
}
