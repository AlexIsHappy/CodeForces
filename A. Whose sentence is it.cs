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
            var gr = Console.ReadLine();

            if (long.Parse(gr) > 0)
            {
                Console.WriteLine(gr);
                return;
            }
            else
            {
                var c1 = long.Parse(gr.Remove(gr.Count() - 1));
                var c2 = long.Parse(gr.Remove(gr.Count() - 2,1));
                var balance = Math.Max(c1, c2);
                Console.WriteLine(balance);
            }

            Console.ReadLine();
        }
    }
}
