﻿using System;
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
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num.Sort();

            foreach (int n in num)
            {
                Console.Write(n + " ");
            }
                Console.ReadLine();
        }
    }
}
