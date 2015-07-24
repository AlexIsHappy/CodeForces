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
            var n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();

            if (n % 2 != 0)
            {
                Console.WriteLine(-1);
                return;
            }

            for (int i = 1; i <= n; i += 2)
            {
                sb.Append(i + 1);
                sb.Append(" ");
                sb.Append(i);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
                Console.ReadLine();
        }

    }
}
