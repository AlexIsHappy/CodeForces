using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var num = init[0];
            var index = init[1];
            long ans = 0;

            if (num % 2 == 0)
            {
                ans = index > num / 2 ? (index - num / 2) * 2 : (index * 2) - 1;
            }
            else
            {
                ans = index > (num / 2) + 1 ? (index - ((num / 2) + 1)) * 2 : (index * 2) - 1;
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
