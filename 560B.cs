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
            var a1 = init[0];
            var b1 = init[1];

            init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a2 = init[0];
            var b2 = init[1];

            init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a3 = init[0];
            var b3 = init[1];

            bool ok = Check(a1, b1, a2, b2, a3, b3);
            if (!ok)
                ok = Check(a1, b1, b2, a2, a3, b3);
            if (!ok)
                ok = Check(a1, b1, b2, a2, b3, a3);
            if (!ok)
                ok = Check(a1, b1, a2, b2, b3, a3);

            if (!ok)
                ok = Check(b1, a1, a2, b2, a3, b3);
            if (!ok)
                ok = Check(b1, a1, b2, a2, a3, b3);
            if (!ok)
                ok = Check(b1, a1, b2, a2, b3, a3);
            if (!ok)
                ok = Check(b1, a1, a2, b2, b3, a3);

            Console.WriteLine(ok ? "YES" : "NO");
            Console.ReadLine();

        }

        private static bool Check(int a1, int b1, int a2, int b2, int a3, int b3)
        {
            return
                (a1 >= a2 + a3 && b1 >= b2 && b1 >= b3)
                || (a1 >= a2 && a1 >= a3 && b1 >= b2 + b3);
        }
    }
}