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
            var init = int.Parse(Console.ReadLine());
            var nom = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var ans = nom[0] == 1 ? -1 : nom[0] - 1;

            Console.WriteLine(ans);
            Console.ReadLine();
            
        }
    }
}
