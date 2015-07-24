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
            var n = int.Parse(Console.ReadLine());

            var matr = new string[n];
            var let = new List<char>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                let.Add(line[i]);
                let.Add(line[n - 1 - i]);

                if (!let.All(x => x == let[0]) || line.Distinct().Count() > 2)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

                Console.WriteLine("YES");
                Console.ReadLine();
        }

    }
}
