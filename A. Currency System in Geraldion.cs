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
            var rec = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = rec[0];
            var b = rec[1];

            var rec1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a1 = rec1[0];
            var b1 = rec1[1];

            var rec2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a2 = rec2[0];
            var b2 = rec2[1];

            // Check all the possible combinations
            if (Math.Max(a1, a2) <= a && b1 + b2 <= b ||
                Math.Max(a1, a2) <= b && b1 + b2 <= a ||

                Math.Max(a1, b1) <= a && a2 + b2 <= b ||
                Math.Max(a1, b1) <= b && a2 + b2 <= a ||

                Math.Max(a1, b2) <= a && a2 + b1 <= b ||
                Math.Max(a1, b2) <= b && b1 + a2 <= a ||

                Math.Max(b1, a2) <= a && a1 + b2 <= b ||
                Math.Max(b1, a2) <= b && a1 + b2 <= a ||

                Math.Max(b2, a2) <= a && b1 + a1 <= b ||
                Math.Max(b2, a2) <= b && b1 + a1 <= a ||

                Math.Max(a1, b2) <= a && a1 + b2 <= b ||
                Math.Max(a1, b2) <= b && a1 + b2 <= a)
                Console.WriteLine("YES");
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();

        }
    }
}
