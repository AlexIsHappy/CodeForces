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
            var gr = int.Parse(Console.ReadLine());
            var groups = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            List<int> index = new List<int>();

            groups.Sort();
           var taxi =  groups.GroupBy(i => i).Select(g => g.Count()).ToList();

           if (taxi[1] % 2 == 0)
               count += taxi[1] / 2;
           else
               count += taxi[1] / 2 + 1;

           if ((taxi[0] + taxi[2] * 3) % 4 == 0)
               count += (taxi[0] + taxi[2] * 3) / 4;
           else
               count += ((taxi[0] + taxi[2] * 3) / 4) + 1;

           count += taxi[3];

           Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
