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

            var initNum = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var nums = new Dictionary<int, int>();
            var dist = initNum.Distinct().ToList();
            var disCount = dist.Count;

            for (int i = 0; i < disCount; i++)
            {
                nums.Add(dist[i], initNum.Count(x => x == dist[i]));
            }

            var maxAm = nums.Aggregate((l,k) => l.Value > k.Value ? l : k).Key;
            var start = initNum.FindIndex(x => x == maxAm) + 1;
            var end = initNum.FindLastIndex(x => x == maxAm) + 1;

            Console.WriteLine(start + " " + end);
            Console.ReadLine();

        }
    }
}
