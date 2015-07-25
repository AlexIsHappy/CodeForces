using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Numerics;
namespace ConsoleApplication25
{
    class Solution
    {
        static void Main(string[] args)
        {
            var start = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var s = start[0];
            var p = start[1];

            var grades = new string[s];

            for (int i = 0; i < s; i++)
            {
                grades[i] = Console.ReadLine();
            }

            var max = new List<int>();

            for (int i = 0; i < p; i++)
            {
                var temp = new List<int>();
                for (int j = 0; j < s; j++)
                {
                    temp.Add(grades[j][i] - '0');
                }

                var maxi = temp.Max();
                for (int j = 0; j < s; j++)
                {
                    if ((grades[j][i] - '0') == maxi)
                        max.Add(j);
                }
            }

            Console.WriteLine(max.Distinct().Count());
                Console.ReadLine();
        }
    }
}
