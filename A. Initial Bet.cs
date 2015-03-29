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
            var init = int.Parse(Console.ReadLine());
            var sum = 0;

            for(int i = 0; i < init; i++)
            {
               sum += Console.ReadLine().Split(' ').Select(int.Parse).Sum();
            }

            if (sum == 0)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
