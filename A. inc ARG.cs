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

            var ans = 0;
            var sb = new StringBuilder();

            for (int i = 0; i < init; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var range = new int []{1,3};
                if (!line.Any(x => range.Contains(x)))
                {
                    ans++;
                    sb.Append(i + 1 + " ");
                }
            }

            Console.WriteLine(ans);
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
      
    }
}
