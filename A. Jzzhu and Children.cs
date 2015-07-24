using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int amount = init[0];
            int diff = init[1];

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var pair = numbers.Select((value, index) => new { value, index }).Last(x => x.value == numbers.Max()).index;

            Console.WriteLine(pair + 1);
            Console.ReadLine();
        }
    }
}
