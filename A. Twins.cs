using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int amount = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i < amount + 1; i++)
            {
                if (i % k == 0 ||
                    i % l == 0 ||
                    i % m == 0 ||
                    i % n == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
