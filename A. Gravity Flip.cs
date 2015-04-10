using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = int.Parse(Console.ReadLine());
            int count = 0;

            List<string> time = new List<string>();

            for (int i = 0; i < init; i++)
            {
                time.Add(string.Concat(Console.ReadLine().Split(' ')));
            }

            Console.Write(init - time.Distinct().Count());
        }
    }
}
