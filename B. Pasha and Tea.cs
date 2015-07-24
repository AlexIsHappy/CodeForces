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
            NumberFormatInfo nfi_e = new CultureInfo("en-US", false).NumberFormat;

            var num = int.Parse(Console.ReadLine());
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(init);
            int ans = 0;

            for (int i = 1; i < num; i++)
            {
                if (init[i] == init[i - 1])
                {
                    init[i]++;
                    ans++;
                }
            }
            Console.WriteLine(ans);
                Console.ReadLine();
        }
    }
}
