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
            var k = init[1];

            var sb = new StringBuilder();
            var initN = 1;
            sb.Append(initN + " ");

            while (k > 1)
            {
                initN = initN + k;
                sb.Append(initN + " ");
                k--;
            }

            for (int i = 2; i <= n;i++)
            {
                if (!sb.ToString().Contains(i.ToString()))
                {
                    sb.Append(i + " ");
                }
            }


                Console.WriteLine(sb.ToString());
                Console.ReadLine();
        }

    }
}
