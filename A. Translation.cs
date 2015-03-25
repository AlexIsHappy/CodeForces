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
            var num = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxIndex = numbers.IndexOf(numbers.Max());
            int minIndex = numbers.LastIndexOf(numbers.Min());

            var time = 0;

            if (maxIndex > minIndex)
                time = maxIndex + (num - minIndex - 1) - 1;
            else
                time = maxIndex + (num - minIndex - 1);

            Console.WriteLine(time);
            Console.ReadLine();
        }
    }
}
