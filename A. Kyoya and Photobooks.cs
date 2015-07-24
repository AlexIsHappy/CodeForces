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
            var init = int .Parse(Console.ReadLine());

            int compl = 0;
            int half = 0;

            int max = 0;
            var lines = new List<String>();
            for (int i = 0; i < init; i++)
            {
                var line = Console.ReadLine();
                lines.Add(line);
                max = Math.Max(lines.Count(x => x == line), max);
            }

            Console.WriteLine(max);
            Console.ReadLine();
        }
      
    }
}
