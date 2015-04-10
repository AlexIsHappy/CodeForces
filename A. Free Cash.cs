using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = int.Parse(Console.ReadLine());
            int count = 1;

            var e = Enumerable.Range(0, init).Select(i => Console.ReadLine().Split(' ').Select(int.Parse).Aggregate(0, (ac, x) => x + ac * 100))
                .GroupBy(x => x)
                .Select(g => g.Count())
                .Max();

            Console.Write(e);
        }
    }
}
