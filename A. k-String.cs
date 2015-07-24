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
            int[] init1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = init1[0];
            int k = init1[1];

            String[] init = Console.ReadLine().Split(' ').ToArray();

            var ans = 0;

            for (int i = 0; i < init.Length; i++)
            {
                ans += init[i].Count(x => x == '7' || x == '4') > k ? 0 : 1;
            }

            Console.WriteLine(ans);
                Console.ReadLine();
        }
    }
}
