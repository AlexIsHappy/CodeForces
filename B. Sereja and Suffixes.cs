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

            var p = init[0];
            var x = init[1];

            Dictionary<int, int> bask = new Dictionary<int, int>();

            for (int i = 0; i < p; i++)
            {
                bask.Add(i, 0);
            }

            for (int i = 0; i < x; i++)
            {
                int num = int.Parse(Console.ReadLine());
                bask[num % p]++;

                Console.WriteLine(num % p);
                if (bask[num % p] > 1)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
            Console.ReadLine();

        }
    }
}
