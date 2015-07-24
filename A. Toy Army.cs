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
            int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int walNum = line[0];
            int chips = line[1];

            int sum = Enumerable.Range(1, walNum).Sum();

                int res = Math.Abs((chips / sum) * sum - chips);

                for (int i = 1; i <= walNum; i++)
                {
                    if (res - i <= 0)
                    {
                        Console.WriteLine(res - i < 0 ? res : res - i);
                        return;
                    }
                    else
                    {
                        res -= i;
                    }
                }

            Console.WriteLine(res);
                Console.ReadLine();
        }
    }
}
