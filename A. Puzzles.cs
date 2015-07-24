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
            var c = Console.ReadLine().Split(' ').Select(int.Parse).Sum();
            var m = Console.ReadLine().Split(' ').Select(int.Parse).Sum();

            var s = int.Parse(Console.ReadLine());

            s = s - c / 5;
            if (c % 5 != 0)
                s--;

            s = s - m / 10;
            if (m % 10 != 0)
                s--;
            Console.WriteLine(s >= 0 ? "YES" : "NO");

          Console.ReadLine();
        }
    }
}
