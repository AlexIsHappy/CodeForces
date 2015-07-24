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
            var nums = int.Parse(Console.ReadLine());
            var ratings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            var sortedRat = ratings.OrderByDescending(x => x).ToList();
            
            var sb = new StringBuilder();
            for (int i = 0; i < ratings.Length; i++)
            {
                sb.Append(sortedRat.IndexOf(ratings[i]) + 1 + " ");
            }

            Console.WriteLine(sb.ToString());
           Console.ReadLine();

        }
    }
}
