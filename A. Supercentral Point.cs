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
            int [] init = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int r = init[0];
            int x = init[1];
            int y = init[2];
            int x1 = init[3];
            int y1 = init[4];

            double distance = Math.Sqrt((x - x1)*(x - x1) + (y - y1)*(y - y1));

            Console.WriteLine(Math.Ceiling(distance / (r*2)));
                Console.ReadLine();
        }
    }
}
