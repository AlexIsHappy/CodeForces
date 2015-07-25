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
            var start = int.Parse(Console.ReadLine());

            var ans = 0;

            for (int i = 1; i <= 16; i++)
            {
                if ((start + i).ToString().Contains('8'))
                {
                    Console.WriteLine(i);
                    return;
                }
            }

        }
    }
}
