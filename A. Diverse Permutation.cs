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
            var init = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (int i = 0; i < n;i++)
            {
                if (isPrime(init[i]))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

                Console.ReadLine();
        }

        private static bool isPrime(long num)
        {
            long boundary = (long)Math.Ceiling(Math.Sqrt(num));
            Console.WriteLine(boundary);
            if (num == 1) return false;
            if (num == 2) return true;

            var ans = 0;

            for (int i = 1; i <= boundary; i++)
            {
                if (num % i == 0)
                {
                    ans++;

                    if (ans > 2)
                        return false;
                }
            }

            if (ans == 1)
                return false;

            return true;
        }

    }
}
