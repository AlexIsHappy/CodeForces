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
            var levels = int.Parse(Console.ReadLine());
            var pl1 = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).ToList();
            var pl2 = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).ToList();

            pl1.AddRange(pl2);

            Console.WriteLine(pl1.Distinct().Count() == levels ? "I become the guy." : "Oh, my keyboard!");
            Console.ReadLine();

        }
    }
}
