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
            var init = Console.ReadLine();

            var sb = new StringBuilder();
            var count = 0;

            var nums = new string []{"1","41","441"};

            for (int i = init.Length - 1; i >= 0; i--)
            {
                sb.Append(init[i]);
                if (!nums.Any(x => x == sb.ToString()))
                {
                    if (count == 3)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                        count++;
                }
                else
                {
                    count = 0;
                    sb = new StringBuilder();
                }

                Console.WriteLine(sb.ToString());
            }

            Console.WriteLine("YES");
                Console.ReadLine();
        }

    }
}
