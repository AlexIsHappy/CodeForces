using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int16.Parse(Console.ReadLine());
            int b = Int16.Parse(Console.ReadLine());
            int c = Int16.Parse(Console.ReadLine());

            int ans = a + b + c;
            ans = Math.Max(ans, (a + b) * c);
            ans = Math.Max(ans, a * (b + c));
            ans = Math.Max(ans, a * b * c);

            Console.WriteLine(ans);

            Console.WriteLine();
        }
    }
}
