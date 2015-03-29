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
            var init = Console.ReadLine().Split(' ');

            var n = int.Parse(init[0]);
            var m = int.Parse(init[1]);
            var a = int.Parse(init[2]);
            var b = int.Parse(init[3]);

            var cost = 0;

            cost = Math.Min(n * a, (n / m) * b + (n % (n / m)) * a);
            Console.WriteLine(cost);
            Console.ReadLine();

        }
    }
}
