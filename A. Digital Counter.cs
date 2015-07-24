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
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = init[0];
            var m = init[1];

            int[] posit = new int[n];

            for (int i = 0; i < m; i++)
            {
                posit[i] = int.Parse(Console.ReadLine());
            }

            List<int> seen = new List<int>();
            int[] ans = new int[m];

            int j = posit[posit.Length - 1];
            int tAns = 0;
            int k = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (!seen.Contains(nums[i]))
                {
                    tAns++;
                }

                seen.Add(nums[i]);

                if (i == j - 1)
                {
                    ans[j - 1] = tAns;
                    j--;
                }
            }

            foreach(int i in ans)
            {
                Console.WriteLine(i);
            }

                Console.ReadLine();
        }
    }
}
