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
            var word = (Console.ReadLine() + Console.ReadLine()).ToCharArray();

            var v2 = Console.ReadLine().ToCharArray();

            Console.WriteLine(v2.OrderBy(c => c).SequenceEqual(v2.OrderBy(c => c)) ? "YES" : "NO");

            Console.ReadLine();
        }
    }
}
