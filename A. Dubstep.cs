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
            var sum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (sum.Sum() % sum.Count() == 0)
                Console.WriteLine(sum.Sum() / sum.Count());
            else
                Console.WriteLine(-1);
            Console.ReadLine();
        }
    }
}
