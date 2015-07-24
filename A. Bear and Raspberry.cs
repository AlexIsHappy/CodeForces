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

            var a = init[0];
            var b = init[1];

            int win1 = 0;
            int win2 = 0;
            int dwar = 0;

            for (int i = 1; i <= 6; i++)
            {
                if (Math.Abs(a - i) > Math.Abs(b - i))
                {
                    win1++;
                }
                else if (Math.Abs(a - i) < Math.Abs(b - i))
                {
                    win2++;
                }
                else
                {
                    dwar++;
                }
            }

            Console.WriteLine(win1 + " " + dwar + " " + win2);
            Console.ReadLine();
        }
      
    }
}
