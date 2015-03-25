using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            String number = Console.ReadLine();
            int num = int.Parse (number);
            var arr = new[] { 4, 7, 44, 47, 74, 77, 444, 447, 474, 477, 744, 747, 774, 777 };
            Console.WriteLine(arr.Any(x => x % num == 0) ? "YES" : "NO");
        }
    }
}
