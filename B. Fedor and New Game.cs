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

            var n = init[0];
            var m = init[1];
            var k = init[2];

            var ans = 0;
            var numbers = new int[m + 1];
            for (int i = 0; i <= m; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < m; i++)
            {
                int val = numbers[m] ^ numbers[i];
                int armyDif = 0;
                for (int j = 0; j < n; j++)
                {
                    if((val >> j & 1) == 1)
                    {
                        armyDif++;
                    }
                }
                if (armyDif <= k)
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
      
    }
}
