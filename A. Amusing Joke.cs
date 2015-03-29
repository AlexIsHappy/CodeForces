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
            var group = Console.ReadLine().Split(' ').Select(int.Parse).ToList()[0];

            List<int> puzzles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            puzzles.Sort();

            Console.WriteLine(puzzles[group - 1] - puzzles[0]);
            Console.ReadLine();
        }
    }
}
