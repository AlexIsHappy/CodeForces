﻿using System;
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
            double [] init = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double r = init[0];
            double x = init[1];
            double y = init[2];
            double x1 = init[3];
            double y1 = init[4];

            double distance = Math.Sqrt((x - x1)*(x - x1) + (y - y1)*(y - y1));

            Console.WriteLine(Math.Ceiling(distance / (r*2)));
                Console.ReadLine();
        }
    }
}
