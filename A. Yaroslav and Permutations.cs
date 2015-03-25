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

            List<int> negative = new List<int>();

            foreach (int n in numbers)
            {
                if (n == 0)
                    arr3.Add(n);
                else if (n > 0)
                    arr2.Add(n);
                else 
                    negative.Add(n);
            }

            arr1.Add(negative[0]);

            if (arr2.Count == 0)
            {
                arr2.Add(negative[1]);
                arr2.Add(negative[2]);

                for (var i = 3; i < negative.Count; i++)
                    arr3.Add(negative[i]);
            }
            else
            {
                for (var i = 1; i < negative.Count; i++)
                    arr3.Add(negative[i]);
            }

            Console.Write("{0} ", arr1.Count);
            Console.WriteLine(string.Join(" ", arr1.Select(l => l.ToString()).ToArray()));
            Console.Write("{0} ", arr2.Count);
            Console.WriteLine(string.Join(" ", arr2.Select(l => l.ToString()).ToArray()));
            Console.Write("{0} ", arr3.Count);
            Console.WriteLine(string.Join(" ", arr3.Select(l => l.ToString()).ToArray()));

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
