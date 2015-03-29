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
            var pages = int.Parse(Console.ReadLine());
            var init = Console.ReadLine().Split(' ');
            Dictionary<int, int> week = new Dictionary<int, int>();
            int day = 1;

            for (int i = 0; i < init.Length; i++)
            {
                week.Add(day, int.Parse(init[i]));
                day++;
            }

            while (pages > 0)
            {
                if (day == 8)
                    day = 1;
                pages -= week[day];
                day++;
            }

            Console.WriteLine(day - 1);
            Console.ReadLine();

        }
    }
}
