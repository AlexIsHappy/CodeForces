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
            int um = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr1 = new List<int>();
            var arr2 = new List<int>();
            var arr3 = new List<int>();

            var negative = numbers.Where(n => n < 0).ToList().GetRange(0,2);

            foreach (int n in negative)
            {
                Console.WriteLine(n);
            }


          Console.ReadLine();
        }

    }

    public class Pair
    {
        public int Number { get; set; }
        public int Count  { get; set; }

        public Pair (int number, int count)
        {
            this.Number = number;
            this.Count = count;
        }
    }
}
