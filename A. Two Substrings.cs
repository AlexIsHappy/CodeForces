using System;
using System.Collections;
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
            var init = int.Parse(Console.ReadLine());

            var pos = new Dictionary<int, int>();
            var neg = new Dictionary<int, int>();

            for (int i = 0; i < init; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var x = line[0];
                var a = line[1];

                if (x < 0)
                    neg.Add(x, a);
                else
                    pos.Add(x, a);
            }

            var negK = neg.Keys.ToList();
            negK = negK.OrderByDescending(x => x).ToList();

            var posK = pos.Keys.ToList();
            posK.Sort();

            var min = negK.Count == posK.Count ? negK.Count : Math.Min(negK.Count, posK.Count);

            var ans = 0;
            if (min == negK.Count)
            {
                negK = negK.GetRange(0, min);
                posK = posK.GetRange(0, min + 1);
            }
            else
            {
                negK = negK.GetRange(0, min + 1);
                posK = posK.GetRange(0, min);
            }

            foreach (int key in negK)
            {
                ans += neg[key];
            }

            foreach (int key in posK)
            {
                ans += pos[key];
            }

            Console.WriteLine(ans);
            Console.ReadKey();

        }
    }
}
