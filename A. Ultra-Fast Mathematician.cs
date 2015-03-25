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
            var n = int.Parse(Console.ReadLine());
            Console.Write(fn(n));
            Console.ReadLine();
        }

        public static double fn (int n)
        {
            double result = 0;

            while (n > 0)
            {
                result += Math.Pow(-1, n) * n;
                n--;
            }

            return result;

        }

    }
}
