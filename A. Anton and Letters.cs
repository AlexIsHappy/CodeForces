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
            String line = Console.ReadLine();
            String remove = "{}, ";
            var l = String.Concat(line.Where(i => !remove.Contains(i))).Distinct().Count();

            Console.WriteLine(l);
            Console.ReadLine();
        }
    }
}
