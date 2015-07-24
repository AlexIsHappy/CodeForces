using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main(string[] args)
        {
            var init1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var init2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var nd = init1[0];
            var bowls = init1[1];
            var plates = init1[2];

            var ans = 0;

            ans += bowls - init2.Count(x => x == 1) < 0 ? Math.Abs(bowls - init2.Count(x => x == 1)) : 0;

            if (bowls - init2.Count(x => x == 1) < 0)
            {
                ans += plates - init2.Count(x => x == 2) < 0 ? Math.Abs(plates - init2.Count(x => x == 2)) : 0;
            }
            else
            {
                bowls = bowls - init2.Count(x => x == 1);
                ans += (plates + bowls) - init2.Count(x => x == 2) < 0 ? Math.Abs(plates - init2.Count(x => x == 2)) : 0;
            }



            Console.WriteLine(ans);
            Console.ReadLine();

        }

    }
}
