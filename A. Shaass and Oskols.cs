using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = Console.ReadLine().Split(' ');
            var numamount = int.Parse(init[0]);
            var queries = int.Parse(init[1]);

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var positive = numbers.Where(n => n > 0).ToArray();
            var negative = numbers.Where(n => n < 0).ToArray();

            int sum = 0;
            int[] results = new int[queries];

            for (int i = 0; i < queries; i++)
            {
                var q = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var n = q[1] - q[0] + 1;
                if (n % 2 == 0)
                {
                    if (positive.Count() >= (n / 2) && negative.Count() >= (n / 2))
                    {
                        results[i] = 1;
                    }
                    else
                        results[i] = 0;
                }
                else
                {
                    results[i] = 0;
                }
            }

            foreach (int i in results)
                Console.WriteLine(i);

                Console.ReadLine();
        }
    }
}
